using System;

namespace Appwrite.Enums
{
    public class MessagingProviderType : IEnum
    {
        public string Value { get; private set; }

        public MessagingProviderType(string value)
        {
            Value = value;
        }

        public static MessagingProviderType Email => new MessagingProviderType("email");
        public static MessagingProviderType Sms => new MessagingProviderType("sms");
        public static MessagingProviderType Push => new MessagingProviderType("push");
    }
}
