// See https://aka.ms/new-console-template for more information

using System.Net;
using Google.Protobuf;
using Grpc.Net.Client;
using grpcFileTransportClient;


namespace grpcClient
{
    class Program
    {
        static  async Task Main(String[] args)
        {
            var channel = GrpcChannel.ForAddress(" http://localhost:5294");
            var client = new FileService.FileServiceClient(channel);
            

            string file = @"C:\\Users\\Berza\\Desktop\\video.mp4";

            using FileStream fileStream = new FileStream(file, FileMode.Open);

            var byteContent = new ByteContent()
            {
                FileSize = fileStream.Length,
                Info= new grpcFileTransportClient.FInfo { FileName =Path.GetFileNameWithoutExtension(fileStream.Name), FileExtension = Path.GetExtension(fileStream.Name) },
                ReadedByte = 0
            };

            
            var upload=  client.FileUpload();
            byte[] buffer = new byte[2048];
            while ((byteContent.ReadedByte = await fileStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                byteContent.Buffer = ByteString.CopyFrom(buffer);
                  upload.RequestStream.WriteAsync(byteContent);//yaz
            }
            await upload.RequestStream.CompleteAsync();//gönder
 
            fileStream.Close();
        }
        
        
        
    }
}
