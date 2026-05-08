using System;

namespace Appwrite.Enums
{
    public class AuthMethod : IEnum
    {
        public string Value { get; private set; }

        public AuthMethod(string value)
        {
            Value = value;
        }

        public static AuthMethod EmailPassword => new AuthMethod("email-password");
        public static AuthMethod MagicUrl => new AuthMethod("magic-url");
        public static AuthMethod EmailOtp => new AuthMethod("email-otp");
        public static AuthMethod Anonymous => new AuthMethod("anonymous");
        public static AuthMethod Invites => new AuthMethod("invites");
        public static AuthMethod Jwt => new AuthMethod("jwt");
        public static AuthMethod Phone => new AuthMethod("phone");
    }
}
