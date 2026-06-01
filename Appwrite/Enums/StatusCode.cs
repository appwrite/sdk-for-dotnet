using System;

namespace Appwrite.Enums
{
    public class StatusCode : IEnum
    {
        public string Value { get; private set; }

        public StatusCode(string value)
        {
            Value = value;
        }

        public static StatusCode MovedPermanently => new StatusCode("301");
        public static StatusCode Found => new StatusCode("302");
        public static StatusCode TemporaryRedirect => new StatusCode("307");
        public static StatusCode PermanentRedirect => new StatusCode("308");
    }
}
