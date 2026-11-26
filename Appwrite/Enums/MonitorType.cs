using System;

namespace Appwrite.Enums
{
    public class MonitorType : IEnum
    {
        public string Value { get; private set; }

        public MonitorType(string value)
        {
            Value = value;
        }

        public static MonitorType Usage => new MonitorType("usage");
        public static MonitorType Http => new MonitorType("http");
        public static MonitorType Dns => new MonitorType("dns");
        public static MonitorType Tcp => new MonitorType("tcp");
        public static MonitorType Smtp => new MonitorType("smtp");
        public static MonitorType Budget => new MonitorType("budget");
    }
}
