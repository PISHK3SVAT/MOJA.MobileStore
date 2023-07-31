using Microsoft.AspNetCore.Http;

using Newtonsoft.Json;

using RestSharp;

namespace MOJA.MobileStore.Infrastructure.Services.ImageServer
{
    public class ImageUploadService : IImageUploadService
    {
        public List<string> Upload(string parentDir, List<IFormFile> files)
        {
            var client = new RestClient($"https://localhost:7051/api/image?parentDir={parentDir}");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            foreach (var item in files)
            {
                byte[] bytes;
                using (var ms = new MemoryStream())
                {
                    item.CopyToAsync(ms);
                    bytes = ms.ToArray();
                }
                request.AddFile(item.FileName, bytes, item.FileName, item.ContentType);
            }


            IRestResponse response = client.Execute(request);
            UploadDto upload = JsonConvert.DeserializeObject<UploadDto>(response.Content)!;
            return upload.Pathes;

        }
    }
}
