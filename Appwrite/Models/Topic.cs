
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

        [JsonPropertyName("description")]
        public string Description { get; private set; }

        [JsonPropertyName("emailTotal")]
        public long EmailTotal { get; private set; }

        [JsonPropertyName("smsTotal")]
        public long SmsTotal { get; private set; }

        [JsonPropertyName("pushTotal")]
        public long PushTotal { get; private set; }

        [JsonPropertyName("subscribe")]
        public List<string> Subscribe { get; private set; }

        [JsonPropertyName("qos")]
        public long? Qos { get; private set; }

        [JsonPropertyName("expiry")]
        public long? Expiry { get; private set; }

        public Topic(
            string id,
            string createdAt,
            string updatedAt,
            string name,
            string description,
            long emailTotal,
            long smsTotal,
            long pushTotal,
            List<string> subscribe,
            long? qos,
            long? expiry
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Name = name;
            Description = description;
            EmailTotal = emailTotal;
            SmsTotal = smsTotal;
            PushTotal = pushTotal;
            Subscribe = subscribe;
            Qos = qos;
            Expiry = expiry;
        }

        public static Topic From(Dictionary<string, object> map) => new Topic(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            name: (map.ContainsKey("name") ? map["name"] : "").ToString(),
            description: (map.ContainsKey("description") ? map["description"] : "").ToString(),
            emailTotal: Convert.ToInt64((map.ContainsKey("emailTotal") ? map["emailTotal"] : 0)),
            smsTotal: Convert.ToInt64((map.ContainsKey("smsTotal") ? map["smsTotal"] : 0)),
            pushTotal: Convert.ToInt64((map.ContainsKey("pushTotal") ? map["pushTotal"] : 0)),
            subscribe: (map.ContainsKey("subscribe") ? map["subscribe"] : new List<object> { "users" }).ConvertToList<string>(),
            qos: map.TryGetValue("qos", out var numberRaw10) && numberRaw10 != null
                                    ? Convert.ToInt64(numberRaw10)
                                    : null,
            expiry: map.TryGetValue("expiry", out var numberRaw11) && numberRaw11 != null
                                    ? Convert.ToInt64(numberRaw11)
                                    : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "name", Name },
            { "description", Description },
            { "emailTotal", EmailTotal },
            { "smsTotal", SmsTotal },
            { "pushTotal", PushTotal },
            { "subscribe", Subscribe },
            { "qos", Qos },
            { "expiry", Expiry }
        };
    }
}
