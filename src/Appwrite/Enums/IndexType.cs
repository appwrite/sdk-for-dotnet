using System;

namespace Appwrite.Enums
{
    public class IndexType : IEnum
    {
        public string Value { get; private set; }

        public IndexType(string value)
        {
            Value = value;
        }

        public static IndexType Key => new IndexType("key");
        public static IndexType Fulltext => new IndexType("fulltext");
        public static IndexType Unique => new IndexType("unique");
    }
}
