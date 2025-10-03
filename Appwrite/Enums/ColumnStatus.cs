using System;

namespace Appwrite.Enums
{
    public class ColumnStatus : IEnum
    {
        public string Value { get; private set; }

        public ColumnStatus(string value)
        {
            Value = value;
        }

        public static ColumnStatus Available => new ColumnStatus("available");
        public static ColumnStatus Processing => new ColumnStatus("processing");
        public static ColumnStatus Deleting => new ColumnStatus("deleting");
        public static ColumnStatus Stuck => new ColumnStatus("stuck");
        public static ColumnStatus Failed => new ColumnStatus("failed");
    }
}
