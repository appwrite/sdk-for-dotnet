using System;

namespace Appwrite.Enums
{
    public class EmailTemplateType : IEnum
    {
        public string Value { get; private set; }

        public EmailTemplateType(string value)
        {
            Value = value;
        }

        public static EmailTemplateType Verification => new EmailTemplateType("verification");
        public static EmailTemplateType MagicSession => new EmailTemplateType("magicSession");
        public static EmailTemplateType Recovery => new EmailTemplateType("recovery");
        public static EmailTemplateType Invitation => new EmailTemplateType("invitation");
        public static EmailTemplateType MfaChallenge => new EmailTemplateType("mfaChallenge");
        public static EmailTemplateType SessionAlert => new EmailTemplateType("sessionAlert");
        public static EmailTemplateType OtpSession => new EmailTemplateType("otpSession");
    }
}
