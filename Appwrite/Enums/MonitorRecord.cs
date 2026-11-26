using System;

namespace Appwrite.Enums
{
    public class MonitorRecord : IEnum
    {
        public string Value { get; private set; }

        public MonitorRecord(string value)
        {
            Value = value;
        }

        public static MonitorRecord A => new MonitorRecord("A");
        public static MonitorRecord AAAA => new MonitorRecord("AAAA");
        public static MonitorRecord CNAME => new MonitorRecord("CNAME");
        public static MonitorRecord MX => new MonitorRecord("MX");
        public static MonitorRecord TXT => new MonitorRecord("TXT");
        public static MonitorRecord NS => new MonitorRecord("NS");
    }
}
