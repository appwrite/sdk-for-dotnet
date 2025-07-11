using System;

namespace Appwrite.Enums
{
    public class DatabaseUsageRange : IEnum
    {
        public string Value { get; private set; }

        public DatabaseUsageRange(string value)
        {
            Value = value;
        }

        public static DatabaseUsageRange TwentyFourHours => new DatabaseUsageRange("24h");
        public static DatabaseUsageRange ThirtyDays => new DatabaseUsageRange("30d");
        public static DatabaseUsageRange NinetyDays => new DatabaseUsageRange("90d");
    }
}
