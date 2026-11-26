using System;

namespace Appwrite.Enums
{
    public class AlertMetric : IEnum
    {
        public string Value { get; private set; }

        public AlertMetric(string value)
        {
            Value = value;
        }

        public static AlertMetric NetworkRequests => new AlertMetric("network.requests");
        public static AlertMetric NetworkInbound => new AlertMetric("network.inbound");
        public static AlertMetric NetworkOutbound => new AlertMetric("network.outbound");
        public static AlertMetric Executions => new AlertMetric("executions");
        public static AlertMetric ExecutionsMbSeconds => new AlertMetric("executions.mbSeconds");
        public static AlertMetric RealtimeConnections => new AlertMetric("realtime.connections");
        public static AlertMetric WebhooksEventsSent => new AlertMetric("webhooks.events.sent");
        public static AlertMetric WebhooksEventsFailed => new AlertMetric("webhooks.events.failed");
        public static AlertMetric UsersMau => new AlertMetric("users.mau");
        public static AlertMetric AuthMethodPhone => new AlertMetric("auth.method.phone");
        public static AlertMetric Users => new AlertMetric("users");
        public static AlertMetric DatabasesOperationsReads => new AlertMetric("databases.operations.reads");
        public static AlertMetric DatabasesOperationsWrites => new AlertMetric("databases.operations.writes");
        public static AlertMetric DatabasesStorage => new AlertMetric("databases.storage");
        public static AlertMetric Storage => new AlertMetric("storage");
        public static AlertMetric FilesStorage => new AlertMetric("files.storage");
        public static AlertMetric MessagesSent => new AlertMetric("messages.sent");
        public static AlertMetric MessagesSmsSent => new AlertMetric("messages.sms.sent");
        public static AlertMetric MessagesFailed => new AlertMetric("messages.failed");
        public static AlertMetric AvatarsScreenshotsGenerated => new AlertMetric("avatars.screenshotsGenerated");
        public static AlertMetric DedicatedDatabasesCpu => new AlertMetric("dedicatedDatabases.cpu");
        public static AlertMetric DedicatedDatabasesMemory => new AlertMetric("dedicatedDatabases.memory");
        public static AlertMetric DedicatedDatabasesStorage => new AlertMetric("dedicatedDatabases.storage");
        public static AlertMetric DedicatedDatabasesConnections => new AlertMetric("dedicatedDatabases.connections");
        public static AlertMetric DedicatedDatabasesQps => new AlertMetric("dedicatedDatabases.qps");
        public static AlertMetric DedicatedDatabasesIopsRead => new AlertMetric("dedicatedDatabases.iopsRead");
        public static AlertMetric DedicatedDatabasesIopsWrite => new AlertMetric("dedicatedDatabases.iopsWrite");
        public static AlertMetric AnalyticsEvents => new AlertMetric("analytics.events");
        public static AlertMetric AnalyticsPageviews => new AlertMetric("analytics.pageviews");
        public static AlertMetric BillingBudgetUsed => new AlertMetric("billing.budgetUsed");
    }
}
