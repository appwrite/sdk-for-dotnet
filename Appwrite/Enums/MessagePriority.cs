using System;

namespace Appwrite.Enums
{
    public class MessagePriority : IEnum
    {
        public string Value { get; private set; }

        public MessagePriority(string value)
        {
            Value = value;
        }

        public static MessagePriority Normal => new MessagePriority("normal");
        public static MessagePriority High => new MessagePriority("high");
    }
}
