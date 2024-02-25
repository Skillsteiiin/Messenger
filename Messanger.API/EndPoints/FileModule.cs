using Messanger.API.Services.Interfaces;

namespace Messanger.API.EndPoints
{
    public static class FileModule
    {
        //"C:\Users\Татьяна\Desktop\Char.txt"
        public static void AddFileModule(this IEndpointRouteBuilder app)
        {
            app.MapPost("PathFile", async (string path, IFileService _fileService) =>
            {
                return await _fileService.UploadFile(path);
            });
        }
    }
}
