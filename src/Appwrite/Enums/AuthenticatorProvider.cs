using System;

namespace Appwrite.Enums
{
    public class AuthenticatorProvider : IEnum
    {
        public string Value { get; private set; }

        public AuthenticatorProvider(string value)
        {
            Value = value;
        }

        public static AuthenticatorProvider Totp => new AuthenticatorProvider("totp");
    }
}
