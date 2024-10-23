

namespace GameWebsite.ViewModels
{
    public class CreateGameFormViewModel : GameFormViewModel
    {
        [AllowedExtensions(FileSetting.AllowedExtensions),
            MaxFileSize(FileSetting.MaxFileSizeInBytes)]
        public IFormFile Cover { get; set; } = default!;
    }
}
