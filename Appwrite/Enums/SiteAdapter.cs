using System;

namespace Appwrite.Enums
{
    public class SiteAdapter : IEnum
    {
        public string Value { get; private set; }

        public SiteAdapter(string value)
        {
            Value = value;
        }

        public static SiteAdapter Static => new SiteAdapter("static");
        public static SiteAdapter Ssr => new SiteAdapter("ssr");
    }
}
