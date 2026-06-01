using System;

namespace Appwrite.Enums
{
    public class BrowserTheme : IEnum
    {
        public string Value { get; private set; }

        public BrowserTheme(string value)
        {
            Value = value;
        }

        public static BrowserTheme Light => new BrowserTheme("light");
        public static BrowserTheme Dark => new BrowserTheme("dark");
    }
}
