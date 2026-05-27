using System;

namespace Appwrite.Enums
{
    public class HealthQueueName : IEnum
    {
        public string Value { get; private set; }

        public HealthQueueName(string value)
        {
            Value = value;
        }

        public static HealthQueueName V1Database => new HealthQueueName("v1-database");
        public static HealthQueueName V1Deletes => new HealthQueueName("v1-deletes");
        public static HealthQueueName V1Audits => new HealthQueueName("v1-audits");
        public static HealthQueueName V1Mails => new HealthQueueName("v1-mails");
        public static HealthQueueName V1Functions => new HealthQueueName("v1-functions");
        public static HealthQueueName V1StatsResources => new HealthQueueName("v1-stats-resources");
        public static HealthQueueName V1StatsUsage => new HealthQueueName("v1-stats-usage");
        public static HealthQueueName V1Webhooks => new HealthQueueName("v1-webhooks");
        public static HealthQueueName V1Certificates => new HealthQueueName("v1-certificates");
        public static HealthQueueName V1Builds => new HealthQueueName("v1-builds");
        public static HealthQueueName V1Screenshots => new HealthQueueName("v1-screenshots");
        public static HealthQueueName V1Messaging => new HealthQueueName("v1-messaging");
        public static HealthQueueName V1Migrations => new HealthQueueName("v1-migrations");
    }
}
