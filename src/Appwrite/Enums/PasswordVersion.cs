using System;

namespace Appwrite.Enums
{
    public class PasswordVersion : IEnum
    {
        public string Value { get; private set; }

        public PasswordVersion(string value)
        {
            Value = value;
        }

        public static PasswordVersion Sha1 => new PasswordVersion("sha1");
        public static PasswordVersion Sha224 => new PasswordVersion("sha224");
        public static PasswordVersion Sha256 => new PasswordVersion("sha256");
        public static PasswordVersion Sha384 => new PasswordVersion("sha384");
        public static PasswordVersion Sha512224 => new PasswordVersion("sha512/224");
        public static PasswordVersion Sha512256 => new PasswordVersion("sha512/256");
        public static PasswordVersion Sha512 => new PasswordVersion("sha512");
        public static PasswordVersion Sha3224 => new PasswordVersion("sha3-224");
        public static PasswordVersion Sha3256 => new PasswordVersion("sha3-256");
        public static PasswordVersion Sha3384 => new PasswordVersion("sha3-384");
        public static PasswordVersion Sha3512 => new PasswordVersion("sha3-512");
    }
}
