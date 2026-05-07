using System;

namespace Appwrite.Enums
{
    public class MethodId : IEnum
    {
        public string Value { get; private set; }

        public MethodId(string value)
        {
            Value = value;
        }

        public static MethodId EmailPassword => new MethodId("email-password");
        public static MethodId MagicUrl => new MethodId("magic-url");
        public static MethodId EmailOtp => new MethodId("email-otp");
        public static MethodId Anonymous => new MethodId("anonymous");
        public static MethodId Invites => new MethodId("invites");
        public static MethodId Jwt => new MethodId("jwt");
        public static MethodId Phone => new MethodId("phone");
    }
}
