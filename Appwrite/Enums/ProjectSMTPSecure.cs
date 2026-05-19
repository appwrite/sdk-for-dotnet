using System;

namespace Appwrite.Enums
{
    public class ProjectSMTPSecure : IEnum
    {
        public string Value { get; private set; }

        public ProjectSMTPSecure(string value)
        {
            Value = value;
        }

        public static ProjectSMTPSecure Tls => new ProjectSMTPSecure("tls");
        public static ProjectSMTPSecure Ssl => new ProjectSMTPSecure("ssl");
    }
}
