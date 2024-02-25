namespace Messanger.API.Services.Interfaces
{
    public interface IFileService
    {
        Task<string> UploadFile(string filePath); 
    }
}
