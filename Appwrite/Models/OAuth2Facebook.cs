
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class OAuth2Facebook
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("appId")]
        public string AppId { get; private set; }

        [JsonPropertyName("appSecret")]
        public string AppSecret { get; private set; }

        public OAuth2Facebook(
            string id,
            bool enabled,
            string appId,
            string appSecret
        )
        {
            Id = id;
            Enabled = enabled;
            AppId = appId;
            AppSecret = appSecret;
        }

        public static OAuth2Facebook From(Dictionary<string, object> map) => new OAuth2Facebook(
            id: map["$id"].ToString(),
            enabled: (bool)map["enabled"],
            appId: map["appId"].ToString(),
            appSecret: map["appSecret"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "enabled", Enabled },
            { "appId", AppId },
            { "appSecret", AppSecret }
        };
    }
}
