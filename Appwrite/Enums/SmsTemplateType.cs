using System;

namespace Appwrite.Enums
{
    public class SmsTemplateType : IEnum
    {
        public string Value { get; private set; }

        public SmsTemplateType(string value)
        {
            Value = value;
        }

        public static SmsTemplateType Verification => new SmsTemplateType("verification");
        public static SmsTemplateType Login => new SmsTemplateType("login");
        public static SmsTemplateType Invitation => new SmsTemplateType("invitation");
        public static SmsTemplateType Mfachallenge => new SmsTemplateType("mfachallenge");
    }
}
