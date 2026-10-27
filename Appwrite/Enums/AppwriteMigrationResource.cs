using System;

namespace Appwrite.Enums
{
    public class AppwriteMigrationResource : IEnum
    {
        public string Value { get; private set; }

        public AppwriteMigrationResource(string value)
        {
            Value = value;
        }

        public static AppwriteMigrationResource User => new AppwriteMigrationResource("user");
        public static AppwriteMigrationResource Team => new AppwriteMigrationResource("team");
        public static AppwriteMigrationResource Membership => new AppwriteMigrationResource("membership");
        public static AppwriteMigrationResource AuthMethods => new AppwriteMigrationResource("auth-methods");
        public static AppwriteMigrationResource Policies => new AppwriteMigrationResource("policies");
        public static AppwriteMigrationResource Oauth2Provider => new AppwriteMigrationResource("oauth2-provider");
        public static AppwriteMigrationResource Database => new AppwriteMigrationResource("database");
        public static AppwriteMigrationResource Table => new AppwriteMigrationResource("table");
        public static AppwriteMigrationResource Column => new AppwriteMigrationResource("column");
        public static AppwriteMigrationResource Index => new AppwriteMigrationResource("index");
        public static AppwriteMigrationResource Row => new AppwriteMigrationResource("row");
        public static AppwriteMigrationResource Document => new AppwriteMigrationResource("document");
        public static AppwriteMigrationResource Attribute => new AppwriteMigrationResource("attribute");
        public static AppwriteMigrationResource Collection => new AppwriteMigrationResource("collection");
        public static AppwriteMigrationResource Documentsdb => new AppwriteMigrationResource("documentsdb");
        public static AppwriteMigrationResource Vectorsdb => new AppwriteMigrationResource("vectorsdb");
        public static AppwriteMigrationResource Bucket => new AppwriteMigrationResource("bucket");
        public static AppwriteMigrationResource File => new AppwriteMigrationResource("file");
        public static AppwriteMigrationResource Function => new AppwriteMigrationResource("function");
        public static AppwriteMigrationResource Deployment => new AppwriteMigrationResource("deployment");
        public static AppwriteMigrationResource EnvironmentVariable => new AppwriteMigrationResource("environment-variable");
        public static AppwriteMigrationResource Provider => new AppwriteMigrationResource("provider");
        public static AppwriteMigrationResource Topic => new AppwriteMigrationResource("topic");
        public static AppwriteMigrationResource Subscriber => new AppwriteMigrationResource("subscriber");
        public static AppwriteMigrationResource Message => new AppwriteMigrationResource("message");
        public static AppwriteMigrationResource Site => new AppwriteMigrationResource("site");
        public static AppwriteMigrationResource SiteDeployment => new AppwriteMigrationResource("site-deployment");
        public static AppwriteMigrationResource SiteVariable => new AppwriteMigrationResource("site-variable");
        public static AppwriteMigrationResource Platform => new AppwriteMigrationResource("platform");
        public static AppwriteMigrationResource ApiKey => new AppwriteMigrationResource("api-key");
        public static AppwriteMigrationResource Webhook => new AppwriteMigrationResource("webhook");
        public static AppwriteMigrationResource Smtp => new AppwriteMigrationResource("smtp");
        public static AppwriteMigrationResource BackupPolicy => new AppwriteMigrationResource("backup-policy");
        public static AppwriteMigrationResource ProjectVariable => new AppwriteMigrationResource("project-variable");
        public static AppwriteMigrationResource ProjectProtocols => new AppwriteMigrationResource("project-protocols");
        public static AppwriteMigrationResource ProjectLabels => new AppwriteMigrationResource("project-labels");
        public static AppwriteMigrationResource ProjectServices => new AppwriteMigrationResource("project-services");
        public static AppwriteMigrationResource ProjectEmailTemplate => new AppwriteMigrationResource("project-email-template");
        public static AppwriteMigrationResource ProjectEnvironment => new AppwriteMigrationResource("project-environment");
        public static AppwriteMigrationResource Rule => new AppwriteMigrationResource("rule");
    }
}
