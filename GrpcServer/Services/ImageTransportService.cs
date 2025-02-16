using System.Collections.Concurrent;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using grpcImageTransportServer;
using Microsoft.VisualBasic.CompilerServices;


namespace GrpcServer.Services;

public class ImageTransportService : DetectService.DetectServiceBase
{
   

    private Image returnImage;
    private bool faceDetectionEnabled = true;
    private bool EnableSaveImage = false;
    private int intKey;
    FileStream fileStream = null;
    private int number;
    private string image;
    private static bool isTrained = false;
    Bitmap bitmap;
    private String name;
    Image<Bgr, byte> imageCV;
    List<Image<Gray, Byte>> TrainedFaces = new();
    private List<int> PersonsLabes = new();
    private List<string> Names = new();
    private ConcurrentDictionary<int, Mat> _concurrentDictionary = new();
    private byte[] key;
    private byte[] value;
    private Mat[] images;
    int ImageCount = 0;
    int ThresHold = -1;
    int num = 0;
    string path = @"C:\Users\Lenovo\OneDrive\Belgeler\RiderProjects\StringValue";
    private readonly IWebHostEnvironment _webHostEnvironment;

    public ImageTransportService(IWebHostEnvironment webHostEnvironment)
    {
        _webHostEnvironment = webHostEnvironment;
    }
   // private List<ResponseTrain> TrainList;
  
    //public ImageTransportService(){
        
  //  string contents =File.ReadAllText(path);
  //  
  //  for (int i = 0; i < _concurrentDictionary.Count; i++)
  //  {
  //      if (path.Length > 0)
  //      {
  //          Mat byteMat = new Mat(1, contents.Length, DepthType.Cv8U, number);
  //          _concurrentDictionary.TryAdd(number, byteMat);
  //          _concurrentDictionary.AddOrUpdate(number, byteMat, (key, oldValue) => byteMat);
  //      }
  //  }
        
            
     //   }
    

    public  async Task Train(IAsyncStreamReader<ResponseTrain> responseStream,
        ServerCallContext context)
    {
             try
            {
              //  this.TrainedFaces.Clear();
                //this.PersonsLabes.Clear();
                //this.Names.Clear();
                while (await responseStream.MoveNext())
                {
                    try
                    {
                        EigenFaceRecognizer recognizer = new EigenFaceRecognizer(ImageCount, ThresHold);
                        if (_concurrentDictionary.Values.Count > 0)
                        {
                            if (_concurrentDictionary.Keys.Count >0)
                            {
                                recognizer.Train(_concurrentDictionary.Values.ToArray(), _concurrentDictionary.Keys.ToArray());
                                Console.WriteLine("Train edildi");
                                 recognizer.Write(path);

                                isTrained = true;
                            }
                        }
                        else
                        {   
                            if (isTrained)
                            {
                                Mat FaceResult = new Mat(1, value.Length, DepthType.Cv8U, number);
                                Image<Gray, Byte> grayFaceResult =
                                    FaceResult.ToImage<Gray, Byte>().Resize(200, 200, Inter.Cubic);
                                CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                                var result = recognizer.Predict(grayFaceResult);
                         
                              Debug.WriteLine(result.Label + ". " + result.Distance);
                            }
                            isTrained = false;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                }
                }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        
    }
    public  override async Task<Empty> Predict(IAsyncStreamReader<Images> requestStream,
        ServerCallContext context)
    {
        try
        {
            while (await requestStream.MoveNext())
            {
                key = Encoding.ASCII.GetBytes(requestStream.Current.Name);
               intKey = BitConverter.ToInt32(key, 0);
                value = requestStream.Current.Content.ToByteArray();
                image = Convert.ToBase64String(value) + Environment.NewLine;

                //dosya kaydet
                
                Task.Run(() => { File.AppendAllText($"{path}/{key}", image); });
                number = BitConverter.ToInt32(value, 0);
                _concurrentDictionary.TryAdd(intKey, new Mat(1, value.Length, DepthType.Cv8U, number));
               Console.WriteLine("eklendi");
                // byte[] temp_backToBytes = Encoding.UTF8.GetBytes(image);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return new Empty();

    }

    public void Train()
    {
      
    }
}

