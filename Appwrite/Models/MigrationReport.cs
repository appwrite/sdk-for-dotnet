
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class MigrationReport
    {
        [JsonPropertyName("user")]
        public long User { get; private set; }

        [JsonPropertyName("team")]
        public long Team { get; private set; }

        [JsonPropertyName("database")]
        public long Database { get; private set; }

        [JsonPropertyName("row")]
        public long Row { get; private set; }

        [JsonPropertyName("file")]
        public long File { get; private set; }

        [JsonPropertyName("bucket")]
        public long Bucket { get; private set; }

        [JsonPropertyName("function")]
        public long Function { get; private set; }

        [JsonPropertyName("platform")]
        public long Platform { get; private set; }

        [JsonPropertyName("api-key")]
        public long ApiKey { get; private set; }

        [JsonPropertyName("project-variable")]
        public long ProjectVariable { get; private set; }

        [JsonPropertyName("webhook")]
        public long Webhook { get; private set; }

        [JsonPropertyName("auth-methods")]
        public long AuthMethods { get; private set; }

        [JsonPropertyName("project-protocols")]
        public long ProjectProtocols { get; private set; }

        [JsonPropertyName("project-labels")]
        public long ProjectLabels { get; private set; }

        [JsonPropertyName("project-services")]
        public long ProjectServices { get; private set; }

        [JsonPropertyName("policies")]
        public long Policies { get; private set; }

        [JsonPropertyName("smtp")]
        public long Smtp { get; private set; }

        [JsonPropertyName("rule")]
        public long Rule { get; private set; }

        [JsonPropertyName("project-email-template")]
        public long ProjectEmailTemplate { get; private set; }

        [JsonPropertyName("project-environment")]
        public long ProjectEnvironment { get; private set; }

        [JsonPropertyName("site")]
        public long Site { get; private set; }

        [JsonPropertyName("provider")]
        public long Provider { get; private set; }

        [JsonPropertyName("topic")]
        public long Topic { get; private set; }

        [JsonPropertyName("subscriber")]
        public long Subscriber { get; private set; }

        [JsonPropertyName("message")]
        public long Message { get; private set; }

        [JsonPropertyName("size")]
        public long Size { get; private set; }

        [JsonPropertyName("version")]
        public string Version { get; private set; }

        [JsonPropertyName("oauth2-provider")]
        public long Oauth2Provider { get; private set; }

        [JsonPropertyName("backup-policy")]
        public long BackupPolicy { get; private set; }

        public MigrationReport(
            long user,
            long team,
            long database,
            long row,
            long file,
            long bucket,
            long function,
            long platform,
            long apiKey,
            long projectVariable,
            long webhook,
            long authMethods,
            long projectProtocols,
            long projectLabels,
            long projectServices,
            long policies,
            long smtp,
            long rule,
            long projectEmailTemplate,
            long projectEnvironment,
            long site,
            long provider,
            long topic,
            long subscriber,
            long message,
            long size,
            string version,
            long oauth2Provider,
            long backupPolicy
        )
        {
            User = user;
            Team = team;
            Database = database;
            Row = row;
            File = file;
            Bucket = bucket;
            Function = function;
            Platform = platform;
            ApiKey = apiKey;
            ProjectVariable = projectVariable;
            Webhook = webhook;
            AuthMethods = authMethods;
            ProjectProtocols = projectProtocols;
            ProjectLabels = projectLabels;
            ProjectServices = projectServices;
            Policies = policies;
            Smtp = smtp;
            Rule = rule;
            ProjectEmailTemplate = projectEmailTemplate;
            ProjectEnvironment = projectEnvironment;
            Site = site;
            Provider = provider;
            Topic = topic;
            Subscriber = subscriber;
            Message = message;
            Size = size;
            Version = version;
            Oauth2Provider = oauth2Provider;
            BackupPolicy = backupPolicy;
        }

        public static MigrationReport From(Dictionary<string, object> map) => new MigrationReport(
            user: Convert.ToInt64((map.ContainsKey("user") ? map["user"] : 0)),
            team: Convert.ToInt64((map.ContainsKey("team") ? map["team"] : 0)),
            database: Convert.ToInt64((map.ContainsKey("database") ? map["database"] : 0)),
            row: Convert.ToInt64((map.ContainsKey("row") ? map["row"] : 0)),
            file: Convert.ToInt64((map.ContainsKey("file") ? map["file"] : 0)),
            bucket: Convert.ToInt64((map.ContainsKey("bucket") ? map["bucket"] : 0)),
            function: Convert.ToInt64((map.ContainsKey("function") ? map["function"] : 0)),
            platform: Convert.ToInt64((map.ContainsKey("platform") ? map["platform"] : 0)),
            apiKey: Convert.ToInt64((map.ContainsKey("api-key") ? map["api-key"] : 0)),
            projectVariable: Convert.ToInt64((map.ContainsKey("project-variable") ? map["project-variable"] : 0)),
            webhook: Convert.ToInt64((map.ContainsKey("webhook") ? map["webhook"] : 0)),
            authMethods: Convert.ToInt64((map.ContainsKey("auth-methods") ? map["auth-methods"] : 0)),
            projectProtocols: Convert.ToInt64((map.ContainsKey("project-protocols") ? map["project-protocols"] : 0)),
            projectLabels: Convert.ToInt64((map.ContainsKey("project-labels") ? map["project-labels"] : 0)),
            projectServices: Convert.ToInt64((map.ContainsKey("project-services") ? map["project-services"] : 0)),
            policies: Convert.ToInt64((map.ContainsKey("policies") ? map["policies"] : 0)),
            smtp: Convert.ToInt64((map.ContainsKey("smtp") ? map["smtp"] : 0)),
            rule: Convert.ToInt64((map.ContainsKey("rule") ? map["rule"] : 0)),
            projectEmailTemplate: Convert.ToInt64((map.ContainsKey("project-email-template") ? map["project-email-template"] : 0)),
            projectEnvironment: Convert.ToInt64((map.ContainsKey("project-environment") ? map["project-environment"] : 0)),
            site: Convert.ToInt64((map.ContainsKey("site") ? map["site"] : 0)),
            provider: Convert.ToInt64((map.ContainsKey("provider") ? map["provider"] : 0)),
            topic: Convert.ToInt64((map.ContainsKey("topic") ? map["topic"] : 0)),
            subscriber: Convert.ToInt64((map.ContainsKey("subscriber") ? map["subscriber"] : 0)),
            message: Convert.ToInt64((map.ContainsKey("message") ? map["message"] : 0)),
            size: Convert.ToInt64((map.ContainsKey("size") ? map["size"] : 0)),
            version: (map.ContainsKey("version") ? map["version"] : "").ToString(),
            oauth2Provider: Convert.ToInt64((map.ContainsKey("oauth2-provider") ? map["oauth2-provider"] : 0)),
            backupPolicy: Convert.ToInt64((map.ContainsKey("backup-policy") ? map["backup-policy"] : 0))
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "user", User },
            { "team", Team },
            { "database", Database },
            { "row", Row },
            { "file", File },
            { "bucket", Bucket },
            { "function", Function },
            { "platform", Platform },
            { "api-key", ApiKey },
            { "project-variable", ProjectVariable },
            { "webhook", Webhook },
            { "auth-methods", AuthMethods },
            { "project-protocols", ProjectProtocols },
            { "project-labels", ProjectLabels },
            { "project-services", ProjectServices },
            { "policies", Policies },
            { "smtp", Smtp },
            { "rule", Rule },
            { "project-email-template", ProjectEmailTemplate },
            { "project-environment", ProjectEnvironment },
            { "site", Site },
            { "provider", Provider },
            { "topic", Topic },
            { "subscriber", Subscriber },
            { "message", Message },
            { "size", Size },
            { "version", Version },
            { "oauth2-provider", Oauth2Provider },
            { "backup-policy", BackupPolicy }
        };
    }
}
