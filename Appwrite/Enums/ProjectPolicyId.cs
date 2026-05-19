using System;

namespace Appwrite.Enums
{
    public class ProjectPolicyId : IEnum
    {
        public string Value { get; private set; }

        public ProjectPolicyId(string value)
        {
            Value = value;
        }

        public static ProjectPolicyId PasswordDictionary => new ProjectPolicyId("password-dictionary");
        public static ProjectPolicyId PasswordHistory => new ProjectPolicyId("password-history");
        public static ProjectPolicyId PasswordPersonalData => new ProjectPolicyId("password-personal-data");
        public static ProjectPolicyId SessionAlert => new ProjectPolicyId("session-alert");
        public static ProjectPolicyId SessionDuration => new ProjectPolicyId("session-duration");
        public static ProjectPolicyId SessionInvalidation => new ProjectPolicyId("session-invalidation");
        public static ProjectPolicyId SessionLimit => new ProjectPolicyId("session-limit");
        public static ProjectPolicyId UserLimit => new ProjectPolicyId("user-limit");
        public static ProjectPolicyId MembershipPrivacy => new ProjectPolicyId("membership-privacy");
    }
}
