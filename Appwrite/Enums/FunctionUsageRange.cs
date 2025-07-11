using System;

namespace Appwrite.Enums
{
    public class FunctionUsageRange : IEnum
    {
        public string Value { get; private set; }

        public FunctionUsageRange(string value)
        {
            Value = value;
        }

        public static FunctionUsageRange TwentyFourHours => new FunctionUsageRange("24h");
        public static FunctionUsageRange ThirtyDays => new FunctionUsageRange("30d");
        public static FunctionUsageRange NinetyDays => new FunctionUsageRange("90d");
    }
}
