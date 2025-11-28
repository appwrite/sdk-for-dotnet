using System;

namespace Appwrite.Enums
{
    public class VCSReferenceType : IEnum
    {
        public string Value { get; private set; }

        public VCSReferenceType(string value)
        {
            Value = value;
        }

        public static VCSReferenceType Branch => new VCSReferenceType("branch");
        public static VCSReferenceType Commit => new VCSReferenceType("commit");
        public static VCSReferenceType Tag => new VCSReferenceType("tag");
    }
}
