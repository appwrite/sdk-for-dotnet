using System;

namespace Appwrite.Enums
{
    public class SiteUsageRange : IEnum
    {
        public string Value { get; private set; }

        public SiteUsageRange(string value)
        {
            Value = value;
        }

        public static SiteUsageRange TwentyFourHours => new SiteUsageRange("24h");
        public static SiteUsageRange ThirtyDays => new SiteUsageRange("30d");
        public static SiteUsageRange NinetyDays => new SiteUsageRange("90d");
    }
}
