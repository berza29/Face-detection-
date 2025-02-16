using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Emgu.CV.CvEnum;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Grpc.Net.Client;
using grpccDetectClient;
using Microsoft.VisualBasic.CompilerServices;
using Bgra = Emgu.CV.Structure.Bgra;
using Enum = Google.Protobuf.WellKnownTypes.Enum;
using Size = System.Drawing.Size;

namespace WPFClient
{
    public partial class MainWindow : Window
    {
        private static String name = "";
      //  private Image<Bgr, byte> detectedFaces;
        private static Mat detectedFaces=new Mat(new Size(640,480), DepthType.Default, 3);
        private CascadeClassifier _faceCasacdeClassifier = new CascadeClassifier("haarcascade_frontalface_default.xml");
        private GrpcChannel _channel = GrpcChannel.ForAddress(" http://localhost:5294");
        private Mat _currentFrame = new Mat();
        private DispatcherTimer _timer = new DispatcherTimer() { Interval = TimeSpan.FromMilliseconds(1000) };
        ConcurrentQueue<byte[]> byteQueue = new ConcurrentQueue<byte[]>();
        private DetectService.DetectServiceClient client;
        private VideoCapture  capture = new VideoCapture(0);
        private bool EnableSaveImage;    
        byte[] arr = new byte[detectedFaces.Rows* detectedFaces.Cols];
        public MainWindow()
        {
            InitializeComponent();
             client = new grpccDetectClient.DetectService.DetectServiceClient(_channel);
           // Client();
            CaptureStart();
            _timer.Tick += new EventHandler(Detect);
            _timer.Start();
        }
        
        public void CaptureStart()
        {
          
            capture.ImageGrabbed += (object s, EventArgs e) =>
            {
               
                capture.Retrieve(_currentFrame);
                Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(() => imgWebcam.Source = ToBitmapSource(_currentFrame.ToBitmap())));
            };
            capture.Start();
        }
        
        public void Detect(object sender, EventArgs e)
        {
           Image<Gray, Byte> grayFrame = _currentFrame.ToImage<Gray, Byte>(); 
            detectedFaces = _currentFrame;
           Rectangle[] faces = _faceCasacdeClassifier.DetectMultiScale(grayFrame, 1.2, 3, Size.Empty, Size.Empty);

            if (faces.Length > 0)
            {
                foreach (var face in faces)
                {
                 //   Image<Bgr, Byte> resultImage=_currentFrame.ToImage<Bgr, Byte>();
                  
                  imgWebcam.Source = _currentFrame.ToImage<Bgra, Byte>().ToBitmapSource();
                   CvInvoke.Rectangle(_currentFrame,face,new Bgr(Color.Green).MCvScalar, 2);
                   //resultImage.ROI = face;
                    Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(() => copy.Source = ToBitmapSource(detectedFaces.ToBitmap())));
                }
            }
        }
        public void Train()
        {
            Task.Run( () =>
            {
                while (true)
                {
                            try
                            {
                                var respone = client.TrainAsync(new Empty());
                                
                                
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                                throw;
                            }
                    Thread.Sleep(500);
                } 
            });
        }
        public BitmapImage ToBitmapSource(Bitmap b)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                b.Save(ms, ImageFormat.Bmp);
                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                bi.StreamSource = ms;
                bi.CacheOption = BitmapCacheOption.OnLoad;
                bi.EndInit();
                return bi;
            }
        }
        
        public  byte[] ImageToByte(Mat  matImage)
        {
            Marshal.Copy(matImage.DataPointer,arr,0, arr.Length);
            return arr;
        }

      
        private void Add_Name(object sender, RoutedEventArgs e)
        {
            
           // btnSave.IsEnabled = true;
            btnAddName.IsEnabled = true;
            EnableSaveImage = true;
            txtPersonName.Dispatcher.Invoke(DispatcherPriority.Normal,
                (ThreadStart)delegate { Name = txtPersonName.Text; });

        }
     
        private void Train_Image(object sender, RoutedEventArgs e)
        {
            Train();
        }


        private void BtnCapture_OnClick(object sender, RoutedEventArgs e)
        {
            btnAddName.IsEnabled = true;
            EnableSaveImage = true;
            byteQueue.Enqueue(ImageToByte(detectedFaces));
            Client();
        }
      
        
        private int i = 0;
        public void Client()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    if (byteQueue.Count > 0)
                    {
                        if (byteQueue.TryDequeue(out byte[] array) )
                        {
                            var request = new Images
                            {
                                Content  = Google.Protobuf.ByteString.CopyFrom(array),
                                Name = $"{" "}"
                            };
                          
                            var response = client.Predict();
                            response.RequestStream.WriteAsync(request);
                            Console.WriteLine(request.Name + "_" + request.Content.Length);
                            Console.WriteLine("File uploaded successfully!");
                            response.RequestStream.CompleteAsync();
                        }
                    }
                    Thread.Sleep(500);
                } 
            });
        }
    }
}