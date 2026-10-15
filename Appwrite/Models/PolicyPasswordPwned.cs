
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class PolicyPasswordPwned
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("sessions")]
        public bool Sessions { get; private set; }

        [JsonPropertyName("users")]
        public bool Users { get; private set; }

        public PolicyPasswordPwned(
            string id,
            bool enabled,
            bool sessions,
            bool users
        )
        {
            Id = id;
            Enabled = enabled;
            Sessions = sessions;
            Users = users;
        }

        public static PolicyPasswordPwned From(Dictionary<string, object> map) => new PolicyPasswordPwned(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            enabled: (bool)(map.ContainsKey("enabled") ? map["enabled"] : true),
            sessions: (bool)(map.ContainsKey("sessions") ? map["sessions"] : false),
            users: (bool)(map.ContainsKey("users") ? map["users"] : false)
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "enabled", Enabled },
            { "sessions", Sessions },
            { "users", Users }
        };
    }
}
