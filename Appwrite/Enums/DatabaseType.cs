using System;

namespace Appwrite.Enums
{
    public class DatabaseType : IEnum
    {
        public string Value { get; private set; }

        public DatabaseType(string value)
        {
            Value = value;
        }

        public static DatabaseType Legacy => new DatabaseType("legacy");
        public static DatabaseType Tablesdb => new DatabaseType("tablesdb");
    }
}
