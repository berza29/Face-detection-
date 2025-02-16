// using System.ComponentModel;
// using Google.Protobuf.WellKnownTypes;
// using Grpc.Core;
// using grpcFileTransportServer;
//
// using static grpcFileTransportServer.FileService;
//
// namespace GrpcServer.Services;
//
// public class FileTransportService : FileServiceBase
// {
//     
//     private readonly IWebHostEnvironment _webHostEnvironment;
//     public FileTransportService(IWebHostEnvironment webHostEnvironment)
//     {
//         _webHostEnvironment = webHostEnvironment;
//     }
//     public override async Task<Empty> FileUpload(IAsyncStreamReader<ByteContent> requestStream, ServerCallContext context)
//     {
//
//         try
//         {
//             string path = Path.Combine(_webHostEnvironment.WebRootPath, "files");
//             if (!Directory.Exists(path)) Directory.CreateDirectory(path);
//
//             FileStream fileStream = null;
//             try
//             {
//                 int count = 0;
//                 decimal chunkSize = 0;
//                 while (await requestStream.MoveNext())
//                 {
//                     if (count++ ==0)
//                     {
//                         fileStream = new FileStream($"{path}/{requestStream.Current.Info.FileName}{requestStream.Current.Info.FileExtension}",FileMode.OpenOrCreate, FileAccess.ReadWrite);
//                         fileStream.SetLength(requestStream.Current.FileSize);
//                     }
//
//                     var buffer = requestStream.Current.Buffer.ToByteArray();
//                     await fileStream.WriteAsync(buffer, 0, buffer.Length);
//
//                     System.Console.WriteLine($"{Math.Round((chunkSize += requestStream.Current.ReadedByte) * 100 / requestStream.Current.FileSize)}%");
//                 }
//             }
//             catch (Exception e)
//             {
//            
//             }
//
//             await fileStream.DisposeAsync();
//             fileStream.Close();
//             return new Empty();
//
//         }
//         catch (Exception e)
//         {
//             Console.WriteLine(e);
//             Console.WriteLine(e.StackTrace);
//             throw;
//         }
//   
//        
//     }
//  }