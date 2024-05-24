using System;

namespace Appwrite.Enums
{
    public class Compression : IEnum
    {
        public string Value { get; private set; }

        public Compression(string value)
        {
            Value = value;
        }

        public static Compression None => new Compression("none");
        public static Compression Gzip => new Compression("gzip");
        public static Compression Zstd => new Compression("zstd");
    }
}
