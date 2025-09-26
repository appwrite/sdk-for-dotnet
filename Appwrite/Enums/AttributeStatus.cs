using System;

namespace Appwrite.Enums
{
    public class AttributeStatus : IEnum
    {
        public string Value { get; private set; }

        public AttributeStatus(string value)
        {
            Value = value;
        }

        public static AttributeStatus Available => new AttributeStatus("available");
        public static AttributeStatus Processing => new AttributeStatus("processing");
        public static AttributeStatus Deleting => new AttributeStatus("deleting");
        public static AttributeStatus Stuck => new AttributeStatus("stuck");
        public static AttributeStatus Failed => new AttributeStatus("failed");
    }
}
