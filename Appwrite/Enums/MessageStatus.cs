using System;

namespace Appwrite.Enums
{
    public class MessageStatus : IEnum
    {
        public string Value { get; private set; }

        public MessageStatus(string value)
        {
            Value = value;
        }

        public static MessageStatus Draft => new MessageStatus("draft");
        public static MessageStatus Processing => new MessageStatus("processing");
        public static MessageStatus Scheduled => new MessageStatus("scheduled");
        public static MessageStatus Sent => new MessageStatus("sent");
        public static MessageStatus Failed => new MessageStatus("failed");
    }
}
