using System;

namespace Appwrite.Enums
{
    public class PlatformType : IEnum
    {
        public string Value { get; private set; }

        public PlatformType(string value)
        {
            Value = value;
        }

        public static PlatformType Windows => new PlatformType("windows");
        public static PlatformType Apple => new PlatformType("apple");
        public static PlatformType Android => new PlatformType("android");
        public static PlatformType Linux => new PlatformType("linux");
        public static PlatformType Web => new PlatformType("web");
    }
}
