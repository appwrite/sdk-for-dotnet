using System;

namespace Appwrite.Enums
{
    public class AnalyticsDimension : IEnum
    {
        public string Value { get; private set; }

        public AnalyticsDimension(string value)
        {
            Value = value;
        }

        public static AnalyticsDimension Country => new AnalyticsDimension("country");
        public static AnalyticsDimension Region => new AnalyticsDimension("region");
        public static AnalyticsDimension City => new AnalyticsDimension("city");
        public static AnalyticsDimension Browser => new AnalyticsDimension("browser");
        public static AnalyticsDimension BrowserVersion => new AnalyticsDimension("browserVersion");
        public static AnalyticsDimension OperatingSystem => new AnalyticsDimension("operatingSystem");
        public static AnalyticsDimension OperatingSystemVersion => new AnalyticsDimension("operatingSystemVersion");
        public static AnalyticsDimension Device => new AnalyticsDimension("device");
        public static AnalyticsDimension ScreenSize => new AnalyticsDimension("screenSize");
        public static AnalyticsDimension ReferrerSource => new AnalyticsDimension("referrerSource");
        public static AnalyticsDimension Channel => new AnalyticsDimension("channel");
        public static AnalyticsDimension UtmSource => new AnalyticsDimension("utmSource");
        public static AnalyticsDimension UtmMedium => new AnalyticsDimension("utmMedium");
        public static AnalyticsDimension UtmCampaign => new AnalyticsDimension("utmCampaign");
        public static AnalyticsDimension UtmContent => new AnalyticsDimension("utmContent");
        public static AnalyticsDimension UtmTerm => new AnalyticsDimension("utmTerm");
        public static AnalyticsDimension Page => new AnalyticsDimension("page");
        public static AnalyticsDimension Hostname => new AnalyticsDimension("hostname");
        public static AnalyticsDimension EntryPage => new AnalyticsDimension("entryPage");
        public static AnalyticsDimension ExitPage => new AnalyticsDimension("exitPage");
        public static AnalyticsDimension TrafficType => new AnalyticsDimension("trafficType");
        public static AnalyticsDimension BotName => new AnalyticsDimension("botName");
        public static AnalyticsDimension BotCategory => new AnalyticsDimension("botCategory");
        public static AnalyticsDimension UserId => new AnalyticsDimension("userId");
        public static AnalyticsDimension EventName => new AnalyticsDimension("eventName");
        public static AnalyticsDimension Props => new AnalyticsDimension("props");
    }
}
