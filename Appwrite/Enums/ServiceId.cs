using System;

namespace Appwrite.Enums
{
    public class ServiceId : IEnum
    {
        public string Value { get; private set; }

        public ServiceId(string value)
        {
            Value = value;
        }

        public static ServiceId Account => new ServiceId("account");
        public static ServiceId Avatars => new ServiceId("avatars");
        public static ServiceId Databases => new ServiceId("databases");
        public static ServiceId Tablesdb => new ServiceId("tablesdb");
        public static ServiceId Locale => new ServiceId("locale");
        public static ServiceId Health => new ServiceId("health");
        public static ServiceId Project => new ServiceId("project");
        public static ServiceId Storage => new ServiceId("storage");
        public static ServiceId Teams => new ServiceId("teams");
        public static ServiceId Users => new ServiceId("users");
        public static ServiceId Vcs => new ServiceId("vcs");
        public static ServiceId Sites => new ServiceId("sites");
        public static ServiceId Functions => new ServiceId("functions");
        public static ServiceId Proxy => new ServiceId("proxy");
        public static ServiceId Graphql => new ServiceId("graphql");
        public static ServiceId Migrations => new ServiceId("migrations");
        public static ServiceId Messaging => new ServiceId("messaging");
    }
}
