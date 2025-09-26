using System;

namespace Appwrite.Enums
{
    public class IndexStatus : IEnum
    {
        public string Value { get; private set; }

        public IndexStatus(string value)
        {
            Value = value;
        }

        public static IndexStatus Available => new IndexStatus("available");
        public static IndexStatus Processing => new IndexStatus("processing");
        public static IndexStatus Deleting => new IndexStatus("deleting");
        public static IndexStatus Stuck => new IndexStatus("stuck");
        public static IndexStatus Failed => new IndexStatus("failed");
    }
}
