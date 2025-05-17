using System;

namespace Appwrite.Enums
{
    public class DeploymentDownloadType : IEnum
    {
        public string Value { get; private set; }

        public DeploymentDownloadType(string value)
        {
            Value = value;
        }

        public static DeploymentDownloadType Source => new DeploymentDownloadType("source");
        public static DeploymentDownloadType Output => new DeploymentDownloadType("output");
    }
}
