using System;

namespace Appwrite.Enums
{
    public class SMTPEncryption : IEnum
    {
        public string Value { get; private set; }

        public SMTPEncryption(string value)
        {
            Value = value;
        }

        public static SMTPEncryption None => new SMTPEncryption("none");
        public static SMTPEncryption Ssl => new SMTPEncryption("ssl");
        public static SMTPEncryption Tls => new SMTPEncryption("tls");
    }
}
