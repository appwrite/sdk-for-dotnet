using System;

namespace Appwrite.Enums
{
    public class Scopes : IEnum
    {
        public string Value { get; private set; }

        public Scopes(string value)
        {
            Value = value;
        }

        public static Scopes ProjectRead => new Scopes("project.read");
        public static Scopes ProjectWrite => new Scopes("project.write");
        public static Scopes KeysRead => new Scopes("keys.read");
        public static Scopes KeysWrite => new Scopes("keys.write");
        public static Scopes PlatformsRead => new Scopes("platforms.read");
        public static Scopes PlatformsWrite => new Scopes("platforms.write");
        public static Scopes MocksRead => new Scopes("mocks.read");
        public static Scopes MocksWrite => new Scopes("mocks.write");
        public static Scopes PoliciesRead => new Scopes("policies.read");
        public static Scopes PoliciesWrite => new Scopes("policies.write");
        public static Scopes ProjectPoliciesRead => new Scopes("project.policies.read");
        public static Scopes ProjectPoliciesWrite => new Scopes("project.policies.write");
        public static Scopes TemplatesRead => new Scopes("templates.read");
        public static Scopes TemplatesWrite => new Scopes("templates.write");
        public static Scopes Oauth2Read => new Scopes("oauth2.read");
        public static Scopes Oauth2Write => new Scopes("oauth2.write");
        public static Scopes UsersRead => new Scopes("users.read");
        public static Scopes UsersWrite => new Scopes("users.write");
        public static Scopes SessionsRead => new Scopes("sessions.read");
        public static Scopes SessionsWrite => new Scopes("sessions.write");
        public static Scopes TeamsRead => new Scopes("teams.read");
        public static Scopes TeamsWrite => new Scopes("teams.write");
        public static Scopes DatabasesRead => new Scopes("databases.read");
        public static Scopes DatabasesWrite => new Scopes("databases.write");
        public static Scopes TablesRead => new Scopes("tables.read");
        public static Scopes TablesWrite => new Scopes("tables.write");
        public static Scopes ColumnsRead => new Scopes("columns.read");
        public static Scopes ColumnsWrite => new Scopes("columns.write");
        public static Scopes IndexesRead => new Scopes("indexes.read");
        public static Scopes IndexesWrite => new Scopes("indexes.write");
        public static Scopes RowsRead => new Scopes("rows.read");
        public static Scopes RowsWrite => new Scopes("rows.write");
        public static Scopes CollectionsRead => new Scopes("collections.read");
        public static Scopes CollectionsWrite => new Scopes("collections.write");
        public static Scopes AttributesRead => new Scopes("attributes.read");
        public static Scopes AttributesWrite => new Scopes("attributes.write");
        public static Scopes DocumentsRead => new Scopes("documents.read");
        public static Scopes DocumentsWrite => new Scopes("documents.write");
        public static Scopes BucketsRead => new Scopes("buckets.read");
        public static Scopes BucketsWrite => new Scopes("buckets.write");
        public static Scopes FilesRead => new Scopes("files.read");
        public static Scopes FilesWrite => new Scopes("files.write");
        public static Scopes TokensRead => new Scopes("tokens.read");
        public static Scopes TokensWrite => new Scopes("tokens.write");
        public static Scopes FunctionsRead => new Scopes("functions.read");
        public static Scopes FunctionsWrite => new Scopes("functions.write");
        public static Scopes ExecutionsRead => new Scopes("executions.read");
        public static Scopes ExecutionsWrite => new Scopes("executions.write");
        public static Scopes ExecutionRead => new Scopes("execution.read");
        public static Scopes ExecutionWrite => new Scopes("execution.write");
        public static Scopes SitesRead => new Scopes("sites.read");
        public static Scopes SitesWrite => new Scopes("sites.write");
        public static Scopes LogRead => new Scopes("log.read");
        public static Scopes LogWrite => new Scopes("log.write");
        public static Scopes ProvidersRead => new Scopes("providers.read");
        public static Scopes ProvidersWrite => new Scopes("providers.write");
        public static Scopes TopicsRead => new Scopes("topics.read");
        public static Scopes TopicsWrite => new Scopes("topics.write");
        public static Scopes SubscribersRead => new Scopes("subscribers.read");
        public static Scopes SubscribersWrite => new Scopes("subscribers.write");
        public static Scopes TargetsRead => new Scopes("targets.read");
        public static Scopes TargetsWrite => new Scopes("targets.write");
        public static Scopes MessagesRead => new Scopes("messages.read");
        public static Scopes MessagesWrite => new Scopes("messages.write");
        public static Scopes RulesRead => new Scopes("rules.read");
        public static Scopes RulesWrite => new Scopes("rules.write");
        public static Scopes WebhooksRead => new Scopes("webhooks.read");
        public static Scopes WebhooksWrite => new Scopes("webhooks.write");
        public static Scopes LocaleRead => new Scopes("locale.read");
        public static Scopes AvatarsRead => new Scopes("avatars.read");
        public static Scopes HealthRead => new Scopes("health.read");
        public static Scopes AssistantRead => new Scopes("assistant.read");
        public static Scopes MigrationsRead => new Scopes("migrations.read");
        public static Scopes MigrationsWrite => new Scopes("migrations.write");
        public static Scopes SchedulesRead => new Scopes("schedules.read");
        public static Scopes SchedulesWrite => new Scopes("schedules.write");
        public static Scopes VcsRead => new Scopes("vcs.read");
        public static Scopes VcsWrite => new Scopes("vcs.write");
        public static Scopes BackupsPoliciesRead => new Scopes("backups.policies.read");
        public static Scopes BackupsPoliciesWrite => new Scopes("backups.policies.write");
        public static Scopes ArchivesRead => new Scopes("archives.read");
        public static Scopes ArchivesWrite => new Scopes("archives.write");
        public static Scopes RestorationsRead => new Scopes("restorations.read");
        public static Scopes RestorationsWrite => new Scopes("restorations.write");
        public static Scopes DomainsRead => new Scopes("domains.read");
        public static Scopes DomainsWrite => new Scopes("domains.write");
        public static Scopes EventsRead => new Scopes("events.read");
    }
}
