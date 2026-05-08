
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class OAuth2Dropbox
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("appKey")]
        public string AppKey { get; private set; }

        [JsonPropertyName("appSecret")]
        public string AppSecret { get; private set; }

        public OAuth2Dropbox(
            string id,
            bool enabled,
            string appKey,
            string appSecret
        )
        {
            Id = id;
            Enabled = enabled;
            AppKey = appKey;
            AppSecret = appSecret;
        }

        public static OAuth2Dropbox From(Dictionary<string, object> map) => new OAuth2Dropbox(
            id: map["$id"].ToString(),
            enabled: (bool)map["enabled"],
            appKey: map["appKey"].ToString(),
            appSecret: map["appSecret"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "enabled", Enabled },
            { "appKey", AppKey },
            { "appSecret", AppSecret }
        };
    }
}
