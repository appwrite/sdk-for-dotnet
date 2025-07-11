
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class DevKey
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

        [JsonPropertyName("secret")]
        public string Secret { get; private set; }

        [JsonPropertyName("accessedAt")]
        public string AccessedAt { get; private set; }

        [JsonPropertyName("sdks")]
        public List<string> Sdks { get; private set; }

        public DevKey(
            string id,
            string createdAt,
            string updatedAt,
            string name,
            string expire,
            string secret,
            string accessedAt,
            List<string> sdks
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Name = name;
            Expire = expire;
            Secret = secret;
            AccessedAt = accessedAt;
            Sdks = sdks;
        }

        public static DevKey From(Dictionary<string, object> map) => new DevKey(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            name: map["name"].ToString(),
            expire: map["expire"].ToString(),
            secret: map["secret"].ToString(),
            accessedAt: map["accessedAt"].ToString(),
            sdks: map["sdks"] is JsonElement jsonArrayProp8 ? jsonArrayProp8.Deserialize<List<string>>()! : (List<string>)map["sdks"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "name", Name },
            { "expire", Expire },
            { "secret", Secret },
            { "accessedAt", AccessedAt },
            { "sdks", Sdks }
        };
    }
}
