using System;

namespace Appwrite.Enums
{
    public class HealthAntivirusStatus : IEnum
    {
        public string Value { get; private set; }

        public HealthAntivirusStatus(string value)
        {
            Value = value;
        }

        public static HealthAntivirusStatus Disabled => new HealthAntivirusStatus("disabled");
        public static HealthAntivirusStatus Offline => new HealthAntivirusStatus("offline");
        public static HealthAntivirusStatus Online => new HealthAntivirusStatus("online");
    }
}
