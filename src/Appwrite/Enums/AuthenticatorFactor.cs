using System;

namespace Appwrite.Enums
{
    public class AuthenticatorFactor : IEnum
    {
        public string Value { get; private set; }

        public AuthenticatorFactor(string value)
        {
            Value = value;
        }

        public static AuthenticatorFactor Totp => new AuthenticatorFactor("totp");
    }
}
