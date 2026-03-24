using System;

namespace Appwrite.Enums
{
    public class DocumentsDBIndexType : IEnum
    {
        public string Value { get; private set; }

        public DocumentsDBIndexType(string value)
        {
            Value = value;
        }

        public static DocumentsDBIndexType Key => new DocumentsDBIndexType("key");
        public static DocumentsDBIndexType Fulltext => new DocumentsDBIndexType("fulltext");
        public static DocumentsDBIndexType Unique => new DocumentsDBIndexType("unique");
        public static DocumentsDBIndexType Spatial => new DocumentsDBIndexType("spatial");
    }
}
