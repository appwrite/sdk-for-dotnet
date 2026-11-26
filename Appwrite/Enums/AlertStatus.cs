using System;

namespace Appwrite.Enums
{
    public class AlertStatus : IEnum
    {
        public string Value { get; private set; }

        public AlertStatus(string value)
        {
            Value = value;
        }

        public static AlertStatus Firing => new AlertStatus("firing");
        public static AlertStatus Resolved => new AlertStatus("resolved");
    }
}
