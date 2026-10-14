using System;

namespace Appwrite.Enums
{
    public class IdTokenProvider : IEnum
    {
        public string Value { get; private set; }

        public IdTokenProvider(string value)
        {
            Value = value;
        }

        public static IdTokenProvider Apple => new IdTokenProvider("apple");
        public static IdTokenProvider Google => new IdTokenProvider("google");
    }
}
