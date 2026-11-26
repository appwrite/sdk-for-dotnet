using System;

namespace Appwrite.Enums
{
    public class MonitorStatus : IEnum
    {
        public string Value { get; private set; }

        public MonitorStatus(string value)
        {
            Value = value;
        }

        public static MonitorStatus Ok => new MonitorStatus("ok");
        public static MonitorStatus Firing => new MonitorStatus("firing");
    }
}
