
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class PolicyPasswordPersonalData
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("denyList")]
        public List<string> DenyList { get; private set; }

        public PolicyPasswordPersonalData(
            string id,
            bool enabled,
            List<string> denyList
        )
        {
            Id = id;
            Enabled = enabled;
            DenyList = denyList;
        }

        public static PolicyPasswordPersonalData From(Dictionary<string, object> map) => new PolicyPasswordPersonalData(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            enabled: (bool)(map.ContainsKey("enabled") ? map["enabled"] : false),
            denyList: (map.ContainsKey("denyList") ? map["denyList"] : new List<object>()).ConvertToList<string>()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "enabled", Enabled },
            { "denyList", DenyList }
        };
    }
}
