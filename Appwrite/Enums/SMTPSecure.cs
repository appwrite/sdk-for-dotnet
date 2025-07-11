using System;

namespace Appwrite.Enums
{
    public class SMTPSecure : IEnum
    {
        public string Value { get; private set; }

        public SMTPSecure(string value)
        {
            Value = value;
        }

        public static SMTPSecure Tls => new SMTPSecure("tls");
        public static SMTPSecure Ssl => new SMTPSecure("ssl");
    }
}
