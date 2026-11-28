using System;

namespace Appwrite.Enums
{
    public class AnalyticsInterval : IEnum
    {
        public string Value { get; private set; }

        public AnalyticsInterval(string value)
        {
            Value = value;
        }

        public static AnalyticsInterval OneHour => new AnalyticsInterval("1h");
        public static AnalyticsInterval OneDay => new AnalyticsInterval("1d");
        public static AnalyticsInterval OneWeek => new AnalyticsInterval("1w");
        public static AnalyticsInterval OneMonth => new AnalyticsInterval("1m");
    }
}
