using System;

namespace Appwrite.Enums
{
    public class MonitorResourceType : IEnum
    {
        public string Value { get; private set; }

        public MonitorResourceType(string value)
        {
            Value = value;
        }

        public static MonitorResourceType Project => new MonitorResourceType("project");
        public static MonitorResourceType Database => new MonitorResourceType("database");
        public static MonitorResourceType Bucket => new MonitorResourceType("bucket");
        public static MonitorResourceType Function => new MonitorResourceType("function");
        public static MonitorResourceType Site => new MonitorResourceType("site");
        public static MonitorResourceType DedicatedDatabase => new MonitorResourceType("dedicatedDatabase");
        public static MonitorResourceType Organization => new MonitorResourceType("organization");
    }
}
