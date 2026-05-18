using System;

namespace Appwrite.Enums
{
    public class ProjectEmailTemplateId : IEnum
    {
        public string Value { get; private set; }

        public ProjectEmailTemplateId(string value)
        {
            Value = value;
        }

        public static ProjectEmailTemplateId Verification => new ProjectEmailTemplateId("verification");
        public static ProjectEmailTemplateId MagicSession => new ProjectEmailTemplateId("magicSession");
        public static ProjectEmailTemplateId Recovery => new ProjectEmailTemplateId("recovery");
        public static ProjectEmailTemplateId Invitation => new ProjectEmailTemplateId("invitation");
        public static ProjectEmailTemplateId MfaChallenge => new ProjectEmailTemplateId("mfaChallenge");
        public static ProjectEmailTemplateId SessionAlert => new ProjectEmailTemplateId("sessionAlert");
        public static ProjectEmailTemplateId OtpSession => new ProjectEmailTemplateId("otpSession");
    }
}
