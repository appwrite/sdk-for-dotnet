using System;

namespace Appwrite.Enums
{
    public class Region : IEnum
    {
        public string Value { get; private set; }

        public Region(string value)
        {
            Value = value;
        }

        public static Region Fra => new Region("fra");
        public static Region Nyc => new Region("nyc");
        public static Region Syd => new Region("syd");
        public static Region Sfo => new Region("sfo");
        public static Region Sgp => new Region("sgp");
        public static Region Tor => new Region("tor");
    }
}
