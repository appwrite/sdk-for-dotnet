using System;

namespace Appwrite.Enums
{
    public class TablesDBIndexType : IEnum
    {
        public string Value { get; private set; }

        public TablesDBIndexType(string value)
        {
            Value = value;
        }

        public static TablesDBIndexType Key => new TablesDBIndexType("key");
        public static TablesDBIndexType Fulltext => new TablesDBIndexType("fulltext");
        public static TablesDBIndexType Unique => new TablesDBIndexType("unique");
        public static TablesDBIndexType Spatial => new TablesDBIndexType("spatial");
    }
}
