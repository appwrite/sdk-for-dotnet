using System;

namespace Appwrite.Enums
{
    public class UserUsageRange : IEnum
    {
        public string Value { get; private set; }

        public UserUsageRange(string value)
        {
            Value = value;
        }

        public static UserUsageRange TwentyFourHours => new UserUsageRange("24h");
        public static UserUsageRange ThirtyDays => new UserUsageRange("30d");
        public static UserUsageRange NinetyDays => new UserUsageRange("90d");
    }
}
