using System;

namespace Appwrite.Enums
{
    public class PasswordHash : IEnum
    {
        public string Value { get; private set; }

        public PasswordHash(string value)
        {
            Value = value;
        }

        public static PasswordHash Sha1 => new PasswordHash("sha1");
        public static PasswordHash Sha224 => new PasswordHash("sha224");
        public static PasswordHash Sha256 => new PasswordHash("sha256");
        public static PasswordHash Sha384 => new PasswordHash("sha384");
        public static PasswordHash Sha512224 => new PasswordHash("sha512/224");
        public static PasswordHash Sha512256 => new PasswordHash("sha512/256");
        public static PasswordHash Sha512 => new PasswordHash("sha512");
        public static PasswordHash Sha3224 => new PasswordHash("sha3-224");
        public static PasswordHash Sha3256 => new PasswordHash("sha3-256");
        public static PasswordHash Sha3384 => new PasswordHash("sha3-384");
        public static PasswordHash Sha3512 => new PasswordHash("sha3-512");
    }
}
