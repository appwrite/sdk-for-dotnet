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

        public static StatusCode MovedPermanently301 => new StatusCode("301");
        public static StatusCode Found302 => new StatusCode("302");
        public static StatusCode TemporaryRedirect307 => new StatusCode("307");
        public static StatusCode PermanentRedirect308 => new StatusCode("308");
    }
}
