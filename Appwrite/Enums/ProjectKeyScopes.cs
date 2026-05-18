using System;

namespace Appwrite.Enums
{
    public class ProjectKeyScopes : IEnum
    {
        public string Value { get; private set; }

        public ProjectKeyScopes(string value)
        {
            Value = value;
        }

        public static ProjectKeyScopes ProjectRead => new ProjectKeyScopes("project.read");
        public static ProjectKeyScopes ProjectWrite => new ProjectKeyScopes("project.write");
        public static ProjectKeyScopes KeysRead => new ProjectKeyScopes("keys.read");
        public static ProjectKeyScopes KeysWrite => new ProjectKeyScopes("keys.write");
        public static ProjectKeyScopes PlatformsRead => new ProjectKeyScopes("platforms.read");
        public static ProjectKeyScopes PlatformsWrite => new ProjectKeyScopes("platforms.write");
        public static ProjectKeyScopes MocksRead => new ProjectKeyScopes("mocks.read");
        public static ProjectKeyScopes MocksWrite => new ProjectKeyScopes("mocks.write");
        public static ProjectKeyScopes PoliciesRead => new ProjectKeyScopes("policies.read");
        public static ProjectKeyScopes PoliciesWrite => new ProjectKeyScopes("policies.write");
        public static ProjectKeyScopes ProjectPoliciesRead => new ProjectKeyScopes("project.policies.read");
        public static ProjectKeyScopes ProjectPoliciesWrite => new ProjectKeyScopes("project.policies.write");
        public static ProjectKeyScopes TemplatesRead => new ProjectKeyScopes("templates.read");
        public static ProjectKeyScopes TemplatesWrite => new ProjectKeyScopes("templates.write");
        public static ProjectKeyScopes Oauth2Read => new ProjectKeyScopes("oauth2.read");
        public static ProjectKeyScopes Oauth2Write => new ProjectKeyScopes("oauth2.write");
        public static ProjectKeyScopes UsersRead => new ProjectKeyScopes("users.read");
        public static ProjectKeyScopes UsersWrite => new ProjectKeyScopes("users.write");
        public static ProjectKeyScopes SessionsRead => new ProjectKeyScopes("sessions.read");
        public static ProjectKeyScopes SessionsWrite => new ProjectKeyScopes("sessions.write");
        public static ProjectKeyScopes TeamsRead => new ProjectKeyScopes("teams.read");
        public static ProjectKeyScopes TeamsWrite => new ProjectKeyScopes("teams.write");
        public static ProjectKeyScopes DatabasesRead => new ProjectKeyScopes("databases.read");
        public static ProjectKeyScopes DatabasesWrite => new ProjectKeyScopes("databases.write");
        public static ProjectKeyScopes TablesRead => new ProjectKeyScopes("tables.read");
        public static ProjectKeyScopes TablesWrite => new ProjectKeyScopes("tables.write");
        public static ProjectKeyScopes ColumnsRead => new ProjectKeyScopes("columns.read");
        public static ProjectKeyScopes ColumnsWrite => new ProjectKeyScopes("columns.write");
        public static ProjectKeyScopes IndexesRead => new ProjectKeyScopes("indexes.read");
        public static ProjectKeyScopes IndexesWrite => new ProjectKeyScopes("indexes.write");
        public static ProjectKeyScopes RowsRead => new ProjectKeyScopes("rows.read");
        public static ProjectKeyScopes RowsWrite => new ProjectKeyScopes("rows.write");
        public static ProjectKeyScopes CollectionsRead => new ProjectKeyScopes("collections.read");
        public static ProjectKeyScopes CollectionsWrite => new ProjectKeyScopes("collections.write");
        public static ProjectKeyScopes AttributesRead => new ProjectKeyScopes("attributes.read");
        public static ProjectKeyScopes AttributesWrite => new ProjectKeyScopes("attributes.write");
        public static ProjectKeyScopes DocumentsRead => new ProjectKeyScopes("documents.read");
        public static ProjectKeyScopes DocumentsWrite => new ProjectKeyScopes("documents.write");
        public static ProjectKeyScopes BucketsRead => new ProjectKeyScopes("buckets.read");
        public static ProjectKeyScopes BucketsWrite => new ProjectKeyScopes("buckets.write");
        public static ProjectKeyScopes FilesRead => new ProjectKeyScopes("files.read");
        public static ProjectKeyScopes FilesWrite => new ProjectKeyScopes("files.write");
        public static ProjectKeyScopes TokensRead => new ProjectKeyScopes("tokens.read");
        public static ProjectKeyScopes TokensWrite => new ProjectKeyScopes("tokens.write");
        public static ProjectKeyScopes FunctionsRead => new ProjectKeyScopes("functions.read");
        public static ProjectKeyScopes FunctionsWrite => new ProjectKeyScopes("functions.write");
        public static ProjectKeyScopes ExecutionsRead => new ProjectKeyScopes("executions.read");
        public static ProjectKeyScopes ExecutionsWrite => new ProjectKeyScopes("executions.write");
        public static ProjectKeyScopes ExecutionRead => new ProjectKeyScopes("execution.read");
        public static ProjectKeyScopes ExecutionWrite => new ProjectKeyScopes("execution.write");
        public static ProjectKeyScopes SitesRead => new ProjectKeyScopes("sites.read");
        public static ProjectKeyScopes SitesWrite => new ProjectKeyScopes("sites.write");
        public static ProjectKeyScopes LogRead => new ProjectKeyScopes("log.read");
        public static ProjectKeyScopes LogWrite => new ProjectKeyScopes("log.write");
        public static ProjectKeyScopes ProvidersRead => new ProjectKeyScopes("providers.read");
        public static ProjectKeyScopes ProvidersWrite => new ProjectKeyScopes("providers.write");
        public static ProjectKeyScopes TopicsRead => new ProjectKeyScopes("topics.read");
        public static ProjectKeyScopes TopicsWrite => new ProjectKeyScopes("topics.write");
        public static ProjectKeyScopes SubscribersRead => new ProjectKeyScopes("subscribers.read");
        public static ProjectKeyScopes SubscribersWrite => new ProjectKeyScopes("subscribers.write");
        public static ProjectKeyScopes TargetsRead => new ProjectKeyScopes("targets.read");
        public static ProjectKeyScopes TargetsWrite => new ProjectKeyScopes("targets.write");
        public static ProjectKeyScopes MessagesRead => new ProjectKeyScopes("messages.read");
        public static ProjectKeyScopes MessagesWrite => new ProjectKeyScopes("messages.write");
        public static ProjectKeyScopes RulesRead => new ProjectKeyScopes("rules.read");
        public static ProjectKeyScopes RulesWrite => new ProjectKeyScopes("rules.write");
        public static ProjectKeyScopes WebhooksRead => new ProjectKeyScopes("webhooks.read");
        public static ProjectKeyScopes WebhooksWrite => new ProjectKeyScopes("webhooks.write");
        public static ProjectKeyScopes LocaleRead => new ProjectKeyScopes("locale.read");
        public static ProjectKeyScopes AvatarsRead => new ProjectKeyScopes("avatars.read");
        public static ProjectKeyScopes HealthRead => new ProjectKeyScopes("health.read");
        public static ProjectKeyScopes AssistantRead => new ProjectKeyScopes("assistant.read");
        public static ProjectKeyScopes MigrationsRead => new ProjectKeyScopes("migrations.read");
        public static ProjectKeyScopes MigrationsWrite => new ProjectKeyScopes("migrations.write");
        public static ProjectKeyScopes SchedulesRead => new ProjectKeyScopes("schedules.read");
        public static ProjectKeyScopes SchedulesWrite => new ProjectKeyScopes("schedules.write");
        public static ProjectKeyScopes VcsRead => new ProjectKeyScopes("vcs.read");
        public static ProjectKeyScopes VcsWrite => new ProjectKeyScopes("vcs.write");
        public static ProjectKeyScopes InsightsRead => new ProjectKeyScopes("insights.read");
        public static ProjectKeyScopes InsightsWrite => new ProjectKeyScopes("insights.write");
        public static ProjectKeyScopes ReportsRead => new ProjectKeyScopes("reports.read");
        public static ProjectKeyScopes ReportsWrite => new ProjectKeyScopes("reports.write");
        public static ProjectKeyScopes PresencesRead => new ProjectKeyScopes("presences.read");
        public static ProjectKeyScopes PresencesWrite => new ProjectKeyScopes("presences.write");
        public static ProjectKeyScopes BackupsPoliciesRead => new ProjectKeyScopes("backups.policies.read");
        public static ProjectKeyScopes BackupsPoliciesWrite => new ProjectKeyScopes("backups.policies.write");
        public static ProjectKeyScopes ArchivesRead => new ProjectKeyScopes("archives.read");
        public static ProjectKeyScopes ArchivesWrite => new ProjectKeyScopes("archives.write");
        public static ProjectKeyScopes RestorationsRead => new ProjectKeyScopes("restorations.read");
        public static ProjectKeyScopes RestorationsWrite => new ProjectKeyScopes("restorations.write");
        public static ProjectKeyScopes DomainsRead => new ProjectKeyScopes("domains.read");
        public static ProjectKeyScopes DomainsWrite => new ProjectKeyScopes("domains.write");
        public static ProjectKeyScopes EventsRead => new ProjectKeyScopes("events.read");
        public static ProjectKeyScopes UsageRead => new ProjectKeyScopes("usage.read");
    }
}
