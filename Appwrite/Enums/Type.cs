using System;

namespace Appwrite.Enums
{
    public class Type : IEnum
    {
        public string Value { get; private set; }

        public Type(string value)
        {
            Value = value;
        }

        public static Type Tablesdb => new Type("tablesdb");
        public static Type Legacy => new Type("legacy");
    }
}
