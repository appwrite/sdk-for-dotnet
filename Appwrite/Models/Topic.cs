
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Topic
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("emailTotal")]
        public long EmailTotal { get; private set; }

        [JsonPropertyName("smsTotal")]
        public long SmsTotal { get; private set; }

        [JsonPropertyName("pushTotal")]
        public long PushTotal { get; private set; }

        [JsonPropertyName("subscribe")]
        public List<string> Subscribe { get; private set; }

        public Topic(
            string id,
            string createdAt,
            string updatedAt,
            string name,
            long emailTotal,
            long smsTotal,
            long pushTotal,
            List<string> subscribe
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
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
            subscribe: map["subscribe"].ConvertToList<string>()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "name", Name },
            { "emailTotal", EmailTotal },
            { "smsTotal", SmsTotal },
            { "pushTotal", PushTotal },
            { "subscribe", Subscribe }
        };
    }
}
