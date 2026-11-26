using System;

namespace Appwrite.Enums
{
    public class MonitorMethod : IEnum
    {
        public string Value { get; private set; }

        public MonitorMethod(string value)
        {
            Value = value;
        }

        public static MonitorMethod GET => new MonitorMethod("GET");
        public static MonitorMethod HEAD => new MonitorMethod("HEAD");
        public static MonitorMethod POST => new MonitorMethod("POST");
        public static MonitorMethod PUT => new MonitorMethod("PUT");
        public static MonitorMethod PATCH => new MonitorMethod("PATCH");
        public static MonitorMethod DELETE => new MonitorMethod("DELETE");
        public static MonitorMethod OPTIONS => new MonitorMethod("OPTIONS");
    }
}
