using System;

namespace Appwrite.Enums
{
    public class ImageFormat : IEnum
    {
        public string Value { get; private set; }

        public ImageFormat(string value)
        {
            Value = value;
        }

        public static ImageFormat Jpg => new ImageFormat("jpg");
        public static ImageFormat Jpeg => new ImageFormat("jpeg");
        public static ImageFormat Gif => new ImageFormat("gif");
        public static ImageFormat Png => new ImageFormat("png");
        public static ImageFormat Webp => new ImageFormat("webp");
    }
}
