using Messanger.API.Services.Interfaces;

namespace Messanger.API.Services.Implementations
{
    public class FileService : IFileService
    {
        private readonly Storage _storage;
        public FileService(Storage storage) 
        {
            _storage = storage;
        }
        public async Task<string> UploadFile(string filePath)
        {
            try
            {
                await _storage.LoadMessages(new string[]
                {
                    "bddsf",
                    "trytry"
                });
                return "Good";
               
            } catch 
            {
                return "nothing";
            }
        }
    }
}
