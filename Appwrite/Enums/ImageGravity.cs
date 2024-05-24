using System;

namespace Appwrite.Enums
{
    public class ImageGravity : IEnum
    {
        public string Value { get; private set; }

        public ImageGravity(string value)
        {
            Value = value;
        }

        public static ImageGravity Center => new ImageGravity("center");
        public static ImageGravity TopLeft => new ImageGravity("top-left");
        public static ImageGravity Top => new ImageGravity("top");
        public static ImageGravity TopRight => new ImageGravity("top-right");
        public static ImageGravity Left => new ImageGravity("left");
        public static ImageGravity Right => new ImageGravity("right");
        public static ImageGravity BottomLeft => new ImageGravity("bottom-left");
        public static ImageGravity Bottom => new ImageGravity("bottom");
        public static ImageGravity BottomRight => new ImageGravity("bottom-right");
    }
}
