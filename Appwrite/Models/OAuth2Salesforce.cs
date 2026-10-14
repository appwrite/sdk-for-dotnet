
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class OAuth2Salesforce
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("customerKey")]
        public string CustomerKey { get; private set; }

        [JsonPropertyName("customerSecret")]
        public string CustomerSecret { get; private set; }

        [JsonPropertyName("prompt")]
        public List<Appwrite.Enums.OAuth2SalesforcePrompt>? Prompt { get; private set; }

        public OAuth2Salesforce(
            string id,
            bool enabled,
            string customerKey,
            string customerSecret,
            List<Appwrite.Enums.OAuth2SalesforcePrompt>? prompt = null
        )
        {
            Id = id;
            Enabled = enabled;
            CustomerKey = customerKey;
            CustomerSecret = customerSecret;
            Prompt = prompt;
        }

        public static OAuth2Salesforce From(Dictionary<string, object> map) => new OAuth2Salesforce(
            id: map["$id"].ToString(),
            enabled: (bool)map["enabled"],
            customerKey: map["customerKey"].ToString(),
            customerSecret: map["customerSecret"].ToString(),
            prompt: map.TryGetValue("prompt", out var arrayRaw5Added) && arrayRaw5Added != null
                                ? arrayRaw5Added.ConvertToList<Appwrite.Enums.OAuth2SalesforcePrompt>()
                                : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "enabled", Enabled },
            { "customerKey", CustomerKey },
            { "customerSecret", CustomerSecret },
            { "prompt", Prompt?.Select(it => it.Value).ToList() }
        };
    }
}
