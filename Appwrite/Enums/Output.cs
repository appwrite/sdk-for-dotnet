using System;

namespace Appwrite.Enums
{
    public class Output : IEnum
    {
        public string Value { get; private set; }

        public Output(string value)
        {
            Value = value;
        }

        public static Output Jpg => new Output("jpg");
        public static Output Jpeg => new Output("jpeg");
        public static Output Png => new Output("png");
        public static Output Webp => new Output("webp");
        public static Output Heic => new Output("heic");
        public static Output Avif => new Output("avif");
        public static Output Gif => new Output("gif");
    }
}
