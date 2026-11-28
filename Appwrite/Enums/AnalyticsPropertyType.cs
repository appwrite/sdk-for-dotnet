using System;

namespace Appwrite.Enums
{
    public class AnalyticsPropertyType : IEnum
    {
        public string Value { get; private set; }

        public AnalyticsPropertyType(string value)
        {
            Value = value;
        }

        public static AnalyticsPropertyType Web => new AnalyticsPropertyType("web");
        public static AnalyticsPropertyType Mobile => new AnalyticsPropertyType("mobile");
        public static AnalyticsPropertyType Agent => new AnalyticsPropertyType("agent");
    }
}
