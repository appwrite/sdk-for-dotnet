using System;

namespace Appwrite.Enums
{
    public class SmtpEncryption : IEnum
    {
        public string Value { get; private set; }

        public SmtpEncryption(string value)
        {
            Value = value;
        }

        public static SmtpEncryption None => new SmtpEncryption("none");
        public static SmtpEncryption Ssl => new SmtpEncryption("ssl");
        public static SmtpEncryption Tls => new SmtpEncryption("tls");
    }
}
