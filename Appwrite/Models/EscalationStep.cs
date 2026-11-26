
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class EscalationStep
    {
        [JsonPropertyName("delay")]
        public long Delay { get; private set; }

        [JsonPropertyName("roles")]
        public List<string> Roles { get; private set; }

        [JsonPropertyName("userIds")]
        public List<string> UserIds { get; private set; }

        public EscalationStep(
            long delay,
            List<string> roles,
            List<string> userIds
        )
        {
            Delay = delay;
            Roles = roles;
            UserIds = userIds;
        }

        public static EscalationStep From(Dictionary<string, object> map) => new EscalationStep(
            delay: Convert.ToInt64((map.ContainsKey("delay") ? map["delay"] : 0)),
            roles: (map.ContainsKey("roles") ? map["roles"] : new List<object>()).ConvertToList<string>(),
            userIds: (map.ContainsKey("userIds") ? map["userIds"] : new List<object>()).ConvertToList<string>()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "delay", Delay },
            { "roles", Roles },
            { "userIds", UserIds }
        };
    }
}
