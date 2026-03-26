using System;

namespace Appwrite.Enums
{
    public class DatabasesIndexType : IEnum
    {
        public string Value { get; private set; }

        public DatabasesIndexType(string value)
        {
            Value = value;
        }

        public static DatabasesIndexType Key => new DatabasesIndexType("key");
        public static DatabasesIndexType Fulltext => new DatabasesIndexType("fulltext");
        public static DatabasesIndexType Unique => new DatabasesIndexType("unique");
        public static DatabasesIndexType Spatial => new DatabasesIndexType("spatial");
    }
}
