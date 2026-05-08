using System;

namespace Appwrite.Enums
{
    public class ProjectPolicy : IEnum
    {
        public string Value { get; private set; }

        public ProjectPolicy(string value)
        {
            Value = value;
        }

        public static ProjectPolicy PasswordDictionary => new ProjectPolicy("password-dictionary");
        public static ProjectPolicy PasswordHistory => new ProjectPolicy("password-history");
        public static ProjectPolicy PasswordPersonalData => new ProjectPolicy("password-personal-data");
        public static ProjectPolicy SessionAlert => new ProjectPolicy("session-alert");
        public static ProjectPolicy SessionDuration => new ProjectPolicy("session-duration");
        public static ProjectPolicy SessionInvalidation => new ProjectPolicy("session-invalidation");
        public static ProjectPolicy SessionLimit => new ProjectPolicy("session-limit");
        public static ProjectPolicy UserLimit => new ProjectPolicy("user-limit");
        public static ProjectPolicy MembershipPrivacy => new ProjectPolicy("membership-privacy");
    }
}
