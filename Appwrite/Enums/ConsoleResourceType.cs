using System;

namespace Appwrite.Enums
{
    public class ConsoleResourceType : IEnum
    {
        public string Value { get; private set; }

        public ConsoleResourceType(string value)
        {
            Value = value;
        }

        public static ConsoleResourceType Rules => new ConsoleResourceType("rules");
    }
}
