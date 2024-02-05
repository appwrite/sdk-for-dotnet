using System;

namespace Appwrite.Enums
{
    public class MessageType : IEnum
    {
        public string Value { get; private set; }

        public MessageType(string value)
        {
            Value = value;
        }

        public static MessageType Draft => new MessageType("draft");
        public static MessageType Cancelled => new MessageType("cancelled");
        public static MessageType Processing => new MessageType("processing");
    }
}
