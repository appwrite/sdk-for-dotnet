using System;

namespace Appwrite.Enums
{
    public class DeploymentStatus : IEnum
    {
        public string Value { get; private set; }

        public DeploymentStatus(string value)
        {
            Value = value;
        }

        public static DeploymentStatus Waiting => new DeploymentStatus("waiting");
        public static DeploymentStatus Processing => new DeploymentStatus("processing");
        public static DeploymentStatus Building => new DeploymentStatus("building");
        public static DeploymentStatus Ready => new DeploymentStatus("ready");
        public static DeploymentStatus Canceled => new DeploymentStatus("canceled");
        public static DeploymentStatus Failed => new DeploymentStatus("failed");
    }
}
