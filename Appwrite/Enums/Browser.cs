using System;

namespace Appwrite.Enums
{
    public class Browser : IEnum
    {
        public string Value { get; private set; }

        public Browser(string value)
        {
            Value = value;
        }

        public static Browser AvantBrowser => new Browser("aa");
        public static Browser AndroidWebViewBeta => new Browser("an");
        public static Browser GoogleChrome => new Browser("ch");
        public static Browser GoogleChromeIOS => new Browser("ci");
        public static Browser GoogleChromeMobile => new Browser("cm");
        public static Browser Chromium => new Browser("cr");
        public static Browser MozillaFirefox => new Browser("ff");
        public static Browser Safari => new Browser("sf");
        public static Browser MobileSafari => new Browser("mf");
        public static Browser MicrosoftEdge => new Browser("ps");
        public static Browser MicrosoftEdgeIOS => new Browser("oi");
        public static Browser OperaMini => new Browser("om");
        public static Browser Opera => new Browser("op");
        public static Browser OperaNext => new Browser("on");
    }
}
