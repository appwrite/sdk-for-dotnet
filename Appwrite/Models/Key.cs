
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Key
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("expire")]
        public string Expire { get; private set; }

        [JsonPropertyName("scopes")]
        public List<string> Scopes { get; private set; }

        [JsonPropertyName("secret")]
        public string Secret { get; private set; }

        [JsonPropertyName("accessedAt")]
        public string AccessedAt { get; private set; }

        [JsonPropertyName("sdks")]
        public List<string> Sdks { get; private set; }

        public Key(
            string id,
            string createdAt,
            string updatedAt,
            string name,
            string expire,
            List<string> scopes,
            string secret,
            string accessedAt,
            List<string> sdks
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Name = name;
            Expire = expire;
            Scopes = scopes;
            Secret = secret;
            AccessedAt = accessedAt;
            Sdks = sdks;
        }

        public static Key From(Dictionary<string, object> map) => new Key(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            name: map["name"].ToString(),
            expire: map["expire"].ToString(),
            scopes: map["scopes"].ConvertToList<string>(),
            secret: map["secret"].ToString(),
            accessedAt: map["accessedAt"].ToString(),
            sdks: map["sdks"].ConvertToList<string>()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "name", Name },
            { "expire", Expire },
            { "scopes", Scopes },
            { "secret", Secret },
            { "accessedAt", AccessedAt },
            { "sdks", Sdks }
        };
    }
}
