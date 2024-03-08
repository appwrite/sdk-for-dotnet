using System;

namespace Appwrite.Enums
{
    public class AuthenticatorType : IEnum
    {
        public string Value { get; private set; }

        public AuthenticatorType(string value)
        {
            Value = value;
        }

        public static AuthenticatorType Totp => new AuthenticatorType("totp");
    }
}
