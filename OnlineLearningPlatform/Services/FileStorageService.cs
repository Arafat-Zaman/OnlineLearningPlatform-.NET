namespace OnlineLearningPlatform.Services
{
    public class FileStorageService
    {
        private readonly string _storagePath;

        public FileStorageService(IConfiguration configuration)
        {
            _storagePath = configuration["FileStoragePath"];
        }

        public async Task<string> UploadFile(IFormFile file)
        {
            if (file.Length > 0)
            {
                var filePath = Path.Combine(_storagePath, file.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                return filePath;
            }
            return null;
        }
    }

}
