using System;

namespace Appwrite.Enums
{
    public class OrganizationKeyScopes : IEnum
    {
        public string Value { get; private set; }

        public OrganizationKeyScopes(string value)
        {
            Value = value;
        }

        public static OrganizationKeyScopes ProjectsRead => new OrganizationKeyScopes("projects.read");
        public static OrganizationKeyScopes ProjectsWrite => new OrganizationKeyScopes("projects.write");
        public static OrganizationKeyScopes DevKeysRead => new OrganizationKeyScopes("devKeys.read");
        public static OrganizationKeyScopes DevKeysWrite => new OrganizationKeyScopes("devKeys.write");
        public static OrganizationKeyScopes OrganizationKeysRead => new OrganizationKeyScopes("organization.keys.read");
        public static OrganizationKeyScopes OrganizationKeysWrite => new OrganizationKeyScopes("organization.keys.write");
        public static OrganizationKeyScopes OrganizationMembershipsRead => new OrganizationKeyScopes("organization.memberships.read");
        public static OrganizationKeyScopes OrganizationMembershipsWrite => new OrganizationKeyScopes("organization.memberships.write");
        public static OrganizationKeyScopes OrganizationRead => new OrganizationKeyScopes("organization.read");
        public static OrganizationKeyScopes OrganizationWrite => new OrganizationKeyScopes("organization.write");
        public static OrganizationKeyScopes DomainsRead => new OrganizationKeyScopes("domains.read");
        public static OrganizationKeyScopes DomainsWrite => new OrganizationKeyScopes("domains.write");
        public static OrganizationKeyScopes KeysRead => new OrganizationKeyScopes("keys.read");
        public static OrganizationKeyScopes KeysWrite => new OrganizationKeyScopes("keys.write");
    }
}
