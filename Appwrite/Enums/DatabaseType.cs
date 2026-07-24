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
        public static DatabaseType Documentsdb => new DatabaseType("documentsdb");
        public static DatabaseType Vectorsdb => new DatabaseType("vectorsdb");
        public static DatabaseType Mysql => new DatabaseType("mysql");
        public static DatabaseType Postgresql => new DatabaseType("postgresql");
        public static DatabaseType Mongodb => new DatabaseType("mongodb");
    }
}
