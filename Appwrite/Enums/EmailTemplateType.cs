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
        public static EmailTemplateType Magicsession => new EmailTemplateType("magicsession");
        public static EmailTemplateType Recovery => new EmailTemplateType("recovery");
        public static EmailTemplateType Invitation => new EmailTemplateType("invitation");
        public static EmailTemplateType Mfachallenge => new EmailTemplateType("mfachallenge");
        public static EmailTemplateType Sessionalert => new EmailTemplateType("sessionalert");
        public static EmailTemplateType Otpsession => new EmailTemplateType("otpsession");
    }
}
