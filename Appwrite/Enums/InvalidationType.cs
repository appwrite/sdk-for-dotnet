using System;

namespace Appwrite.Enums
{
    public class InvalidationType : IEnum
    {
        public string Value { get; private set; }

        public InvalidationType(string value)
        {
            Value = value;
        }

        public static InvalidationType Tag => new InvalidationType("tag");
        public static InvalidationType Path => new InvalidationType("path");
        public static InvalidationType All => new InvalidationType("all");
    }
}
