using System;

namespace Appwrite.Enums
{
    public class MonitorTlsMode : IEnum
    {
        public string Value { get; private set; }

        public MonitorTlsMode(string value)
        {
            Value = value;
        }

        public static MonitorTlsMode None => new MonitorTlsMode("none");
        public static MonitorTlsMode Starttls => new MonitorTlsMode("starttls");
        public static MonitorTlsMode Implicit => new MonitorTlsMode("implicit");
        public static MonitorTlsMode Auto => new MonitorTlsMode("auto");
    }
}
