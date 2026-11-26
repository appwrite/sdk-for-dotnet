using System;

namespace Appwrite.Enums
{
    public class AlertComparator : IEnum
    {
        public string Value { get; private set; }

        public AlertComparator(string value)
        {
            Value = value;
        }

        public static AlertComparator GreaterThan => new AlertComparator("greaterThan");
        public static AlertComparator GreaterThanEqual => new AlertComparator("greaterThanEqual");
        public static AlertComparator LessThan => new AlertComparator("lessThan");
        public static AlertComparator LessThanEqual => new AlertComparator("lessThanEqual");
    }
}
