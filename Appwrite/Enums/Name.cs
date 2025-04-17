using System;

namespace Appwrite.Enums
{
    public class Name : IEnum
    {
        public string Value { get; private set; }

        public Name(string value)
        {
            Value = value;
        }

        public static Name V1Database => new Name("v1-database");
        public static Name V1Deletes => new Name("v1-deletes");
        public static Name V1Audits => new Name("v1-audits");
        public static Name V1Mails => new Name("v1-mails");
        public static Name V1Functions => new Name("v1-functions");
        public static Name V1StatsResources => new Name("v1-stats-resources");
        public static Name V1StatsUsage => new Name("v1-stats-usage");
        public static Name V1Webhooks => new Name("v1-webhooks");
        public static Name V1Certificates => new Name("v1-certificates");
        public static Name V1Builds => new Name("v1-builds");
        public static Name V1Messaging => new Name("v1-messaging");
        public static Name V1Migrations => new Name("v1-migrations");
    }
}
