using System;

namespace Appwrite.Enums
{
    public class ApiService : IEnum
    {
        public string Value { get; private set; }

        public ApiService(string value)
        {
            Value = value;
        }

        public static ApiService Account => new ApiService("account");
        public static ApiService Avatars => new ApiService("avatars");
        public static ApiService Databases => new ApiService("databases");
        public static ApiService Locale => new ApiService("locale");
        public static ApiService Health => new ApiService("health");
        public static ApiService Storage => new ApiService("storage");
        public static ApiService Teams => new ApiService("teams");
        public static ApiService Users => new ApiService("users");
        public static ApiService Sites => new ApiService("sites");
        public static ApiService Functions => new ApiService("functions");
        public static ApiService Graphql => new ApiService("graphql");
        public static ApiService Messaging => new ApiService("messaging");
    }
}
