using System;

namespace Appwrite.Enums
{
    public class ProjectUsageRange : IEnum
    {
        public string Value { get; private set; }

        public ProjectUsageRange(string value)
        {
            Value = value;
        }

        public static ProjectUsageRange OneHour => new ProjectUsageRange("1h");
        public static ProjectUsageRange OneDay => new ProjectUsageRange("1d");
    }
}
