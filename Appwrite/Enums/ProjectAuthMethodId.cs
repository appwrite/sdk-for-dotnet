using System;

namespace Appwrite.Enums
{
    public class ProjectAuthMethodId : IEnum
    {
        public string Value { get; private set; }

        public ProjectAuthMethodId(string value)
        {
            Value = value;
        }

        public static ProjectAuthMethodId EmailPassword => new ProjectAuthMethodId("email-password");
        public static ProjectAuthMethodId MagicUrl => new ProjectAuthMethodId("magic-url");
        public static ProjectAuthMethodId EmailOtp => new ProjectAuthMethodId("email-otp");
        public static ProjectAuthMethodId Anonymous => new ProjectAuthMethodId("anonymous");
        public static ProjectAuthMethodId Invites => new ProjectAuthMethodId("invites");
        public static ProjectAuthMethodId Jwt => new ProjectAuthMethodId("jwt");
        public static ProjectAuthMethodId Phone => new ProjectAuthMethodId("phone");
    }
}
