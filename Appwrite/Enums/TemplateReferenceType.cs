using System;

namespace Appwrite.Enums
{
    public class TemplateReferenceType : IEnum
    {
        public string Value { get; private set; }

        public TemplateReferenceType(string value)
        {
            Value = value;
        }

        public static TemplateReferenceType Branch => new TemplateReferenceType("branch");
        public static TemplateReferenceType Commit => new TemplateReferenceType("commit");
        public static TemplateReferenceType Tag => new TemplateReferenceType("tag");
    }
}
