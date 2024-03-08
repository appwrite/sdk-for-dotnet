using System;

namespace Appwrite.Enums
{
    public class AuthenticationFactor : IEnum
    {
        public string Value { get; private set; }

        public AuthenticationFactor(string value)
        {
            Value = value;
        }

        public static AuthenticationFactor Email => new AuthenticationFactor("email");
        public static AuthenticationFactor Phone => new AuthenticationFactor("phone");
        public static AuthenticationFactor Totp => new AuthenticationFactor("totp");
        public static AuthenticationFactor Recoverycode => new AuthenticationFactor("recoverycode");
    }
}
