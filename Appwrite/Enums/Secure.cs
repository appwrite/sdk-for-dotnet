using System;

namespace Appwrite.Enums
{
    public class Secure : IEnum
    {
        public string Value { get; private set; }

        public Secure(string value)
        {
            Value = value;
        }

        public static Secure Tls => new Secure("tls");
        public static Secure Ssl => new Secure("ssl");
    }
}
