using System;

namespace Appwrite.Enums
{
    public class ProjectServiceId : IEnum
    {
        public string Value { get; private set; }

        public ProjectServiceId(string value)
        {
            Value = value;
        }

        public static ProjectServiceId Account => new ProjectServiceId("account");
        public static ProjectServiceId Avatars => new ProjectServiceId("avatars");
        public static ProjectServiceId Databases => new ProjectServiceId("databases");
        public static ProjectServiceId Tablesdb => new ProjectServiceId("tablesdb");
        public static ProjectServiceId Locale => new ProjectServiceId("locale");
        public static ProjectServiceId Health => new ProjectServiceId("health");
        public static ProjectServiceId Project => new ProjectServiceId("project");
        public static ProjectServiceId Storage => new ProjectServiceId("storage");
        public static ProjectServiceId Teams => new ProjectServiceId("teams");
        public static ProjectServiceId Users => new ProjectServiceId("users");
        public static ProjectServiceId Vcs => new ProjectServiceId("vcs");
        public static ProjectServiceId Sites => new ProjectServiceId("sites");
        public static ProjectServiceId Functions => new ProjectServiceId("functions");
        public static ProjectServiceId Proxy => new ProjectServiceId("proxy");
        public static ProjectServiceId Graphql => new ProjectServiceId("graphql");
        public static ProjectServiceId Migrations => new ProjectServiceId("migrations");
        public static ProjectServiceId Messaging => new ProjectServiceId("messaging");
        public static ProjectServiceId Advisor => new ProjectServiceId("advisor");
    }
}
