using System;

namespace Appwrite.Enums
{
    public class MonitorSeverity : IEnum
    {
        public string Value { get; private set; }

        public MonitorSeverity(string value)
        {
            Value = value;
        }

        public static MonitorSeverity Info => new MonitorSeverity("info");
        public static MonitorSeverity Warning => new MonitorSeverity("warning");
        public static MonitorSeverity Error => new MonitorSeverity("error");
        public static MonitorSeverity Critical => new MonitorSeverity("critical");
    }
}
