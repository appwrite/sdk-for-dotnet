
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class PolicySessionDuration
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("duration")]
        public long Duration { get; private set; }

        public PolicySessionDuration(
            string id,
            long duration
        )
        {
            Id = id;
            Duration = duration;
        }

        public static PolicySessionDuration From(Dictionary<string, object> map) => new PolicySessionDuration(
            id: map["$id"].ToString(),
            duration: Convert.ToInt64(map["duration"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "duration", Duration }
        };
    }
}
