
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Escalation
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("steps")]
        public List<EscalationStep> Steps { get; private set; }

        [JsonPropertyName("repeat")]
        public long Repeat { get; private set; }

        public Escalation(
            string id,
            string createdAt,
            string updatedAt,
            string name,
            List<EscalationStep> steps,
            long repeat
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Name = name;
            Steps = steps;
            Repeat = repeat;
        }

        public static Escalation From(Dictionary<string, object> map) => new Escalation(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            name: (map.ContainsKey("name") ? map["name"] : "").ToString(),
            steps: (map.ContainsKey("steps") ? map["steps"] : new List<object>()).ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.EscalationStep.From(map: it)).ToList(),
            repeat: Convert.ToInt64((map.ContainsKey("repeat") ? map["repeat"] : 0))
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "name", Name },
            { "steps", Steps?.Select(it => it.ToMap()).ToList() },
            { "repeat", Repeat }
        };
    }
}
