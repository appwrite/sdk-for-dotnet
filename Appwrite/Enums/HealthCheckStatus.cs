using System;

namespace Appwrite.Enums
{
    public class HealthCheckStatus : IEnum
    {
        public string Value { get; private set; }

        public HealthCheckStatus(string value)
        {
            Value = value;
        }

        public static HealthCheckStatus Pass => new HealthCheckStatus("pass");
        public static HealthCheckStatus Fail => new HealthCheckStatus("fail");
    }
}
