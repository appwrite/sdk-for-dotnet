using System;

namespace Appwrite.Enums
{
    public class EnvironmentResource : IEnum
    {
        public string Value { get; private set; }

        public EnvironmentResource(string value)
        {
            Value = value;
        }

        public static EnvironmentResource User => new EnvironmentResource("user");
        public static EnvironmentResource Team => new EnvironmentResource("team");
        public static EnvironmentResource Membership => new EnvironmentResource("membership");
        public static EnvironmentResource AuthMethods => new EnvironmentResource("auth-methods");
        public static EnvironmentResource Policies => new EnvironmentResource("policies");
        public static EnvironmentResource Oauth2Provider => new EnvironmentResource("oauth2-provider");
        public static EnvironmentResource Database => new EnvironmentResource("database");
        public static EnvironmentResource Documentsdb => new EnvironmentResource("documentsdb");
        public static EnvironmentResource Vectorsdb => new EnvironmentResource("vectorsdb");
        public static EnvironmentResource Table => new EnvironmentResource("table");
        public static EnvironmentResource Collection => new EnvironmentResource("collection");
        public static EnvironmentResource Column => new EnvironmentResource("column");
        public static EnvironmentResource Attribute => new EnvironmentResource("attribute");
        public static EnvironmentResource Index => new EnvironmentResource("index");
        public static EnvironmentResource Row => new EnvironmentResource("row");
        public static EnvironmentResource Document => new EnvironmentResource("document");
        public static EnvironmentResource Bucket => new EnvironmentResource("bucket");
        public static EnvironmentResource File => new EnvironmentResource("file");
        public static EnvironmentResource Function => new EnvironmentResource("function");
        public static EnvironmentResource EnvironmentVariable => new EnvironmentResource("environment-variable");
        public static EnvironmentResource Deployment => new EnvironmentResource("deployment");
        public static EnvironmentResource Site => new EnvironmentResource("site");
        public static EnvironmentResource SiteVariable => new EnvironmentResource("site-variable");
        public static EnvironmentResource SiteDeployment => new EnvironmentResource("site-deployment");
        public static EnvironmentResource Provider => new EnvironmentResource("provider");
        public static EnvironmentResource Topic => new EnvironmentResource("topic");
        public static EnvironmentResource Subscriber => new EnvironmentResource("subscriber");
        public static EnvironmentResource Platform => new EnvironmentResource("platform");
        public static EnvironmentResource Smtp => new EnvironmentResource("smtp");
        public static EnvironmentResource ProjectVariable => new EnvironmentResource("project-variable");
        public static EnvironmentResource ProjectProtocols => new EnvironmentResource("project-protocols");
        public static EnvironmentResource ProjectLabels => new EnvironmentResource("project-labels");
        public static EnvironmentResource ProjectServices => new EnvironmentResource("project-services");
        public static EnvironmentResource ProjectEmailTemplate => new EnvironmentResource("project-email-template");
    }
}
