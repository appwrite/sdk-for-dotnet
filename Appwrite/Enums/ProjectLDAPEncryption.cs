using System;

namespace Appwrite.Enums
{
    public class ProjectLDAPEncryption : IEnum
    {
        public string Value { get; private set; }

        public ProjectLDAPEncryption(string value)
        {
            Value = value;
        }

        public static ProjectLDAPEncryption None => new ProjectLDAPEncryption("none");
        public static ProjectLDAPEncryption Ldaps => new ProjectLDAPEncryption("ldaps");
        public static ProjectLDAPEncryption Starttls => new ProjectLDAPEncryption("starttls");
    }
}
