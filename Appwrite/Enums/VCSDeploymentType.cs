using System;

namespace Appwrite.Enums
{
    public class VCSDeploymentType : IEnum
    {
        public string Value { get; private set; }

        public VCSDeploymentType(string value)
        {
            Value = value;
        }

        public static VCSDeploymentType Branch => new VCSDeploymentType("branch");
        public static VCSDeploymentType Commit => new VCSDeploymentType("commit");
        public static VCSDeploymentType Tag => new VCSDeploymentType("tag");
    }
}
