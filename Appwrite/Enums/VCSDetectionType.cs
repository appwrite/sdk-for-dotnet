using System;

namespace Appwrite.Enums
{
    public class VCSDetectionType : IEnum
    {
        public string Value { get; private set; }

        public VCSDetectionType(string value)
        {
            Value = value;
        }

        public static VCSDetectionType Runtime => new VCSDetectionType("runtime");
        public static VCSDetectionType Framework => new VCSDetectionType("framework");
    }
}
