using System;

namespace Appwrite.Enums
{
    public class Encryption : IEnum
    {
        public string Value { get; private set; }

        public Encryption(string value)
        {
            Value = value;
        }

        public static Encryption None => new Encryption("none");
        public static Encryption Ssl => new Encryption("ssl");
        public static Encryption Tls => new Encryption("tls");
    }
}
