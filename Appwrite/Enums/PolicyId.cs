using System;

namespace Appwrite.Enums
{
    public class PolicyId : IEnum
    {
        public string Value { get; private set; }

        public PolicyId(string value)
        {
            Value = value;
        }

        public static PolicyId PasswordDictionary => new PolicyId("password-dictionary");
        public static PolicyId PasswordHistory => new PolicyId("password-history");
        public static PolicyId PasswordPersonalData => new PolicyId("password-personal-data");
        public static PolicyId SessionAlert => new PolicyId("session-alert");
        public static PolicyId SessionDuration => new PolicyId("session-duration");
        public static PolicyId SessionInvalidation => new PolicyId("session-invalidation");
        public static PolicyId SessionLimit => new PolicyId("session-limit");
        public static PolicyId UserLimit => new PolicyId("user-limit");
        public static PolicyId MembershipPrivacy => new PolicyId("membership-privacy");
    }
}
