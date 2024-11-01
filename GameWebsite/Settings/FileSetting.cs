﻿using static System.Net.Mime.MediaTypeNames;

namespace GameWebsite.Settings
{
    public static class FileSetting
    {
        public const string ImagesPath = "/assests/images/games";
        public const string AllowedExtensions = ".jpg,.jpeg,.png";
        public const int MaxFileSizeInMB = 1;
        public const int MaxFileSizeInBytes = MaxFileSizeInMB * 1024 * 1024;
    }
}
