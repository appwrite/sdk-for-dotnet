using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class Topic
    {
        [JsonPropertyName("$id")]
        public string id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string createdAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string updatedAt { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("emailTotal")]
        public long EmailTotal { get; private set; }

        [JsonPropertyName("smsTotal")]
        public long SmsTotal { get; private set; }

        [JsonPropertyName("pushTotal")]
        public long PushTotal { get; private set; }

        [JsonPropertyName("subscribe")]
        public List&lt;string&gt; Subscribe { get; private set; }

        public Topic(
            string id,
            string createdAt,
            string updatedAt,
            string name,
            long emailTotal,
            long smsTotal,
            long pushTotal,
            List&lt;string&gt; subscribe
        ) {
            id = id;
            createdAt = createdAt;
            updatedAt = updatedAt;
            Name = name;
            EmailTotal = emailTotal;
            SmsTotal = smsTotal;
            PushTotal = pushTotal;
            Subscribe = subscribe;
        }

        public static Topic From(Dictionary<string, object> map) => new Topic(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            name: map["name"].ToString(),
            emailTotal: Convert.ToInt64(map["emailTotal"]),
            smsTotal: Convert.ToInt64(map["smsTotal"]),
            pushTotal: Convert.ToInt64(map["pushTotal"]),
            subscribe: map["subscribe"] is JsonElement jsonArrayProp8 ? jsonArrayProp8.Deserialize<List<string>>()! : (List<string>)map["subscribe"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", id },
            { "$createdAt", createdAt },
            { "$updatedAt", updatedAt },
            { "name", Name },
            { "emailTotal", EmailTotal },
            { "smsTotal", SmsTotal },
            { "pushTotal", PushTotal },
            { "subscribe", Subscribe }
        };
    }
}
