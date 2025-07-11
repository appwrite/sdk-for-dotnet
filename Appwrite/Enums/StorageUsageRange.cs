using System;

namespace Appwrite.Enums
{
    public class StorageUsageRange : IEnum
    {
        public string Value { get; private set; }

        public StorageUsageRange(string value)
        {
            Value = value;
        }

        public static StorageUsageRange TwentyFourHours => new StorageUsageRange("24h");
        public static StorageUsageRange ThirtyDays => new StorageUsageRange("30d");
        public static StorageUsageRange NinetyDays => new StorageUsageRange("90d");
    }
}
