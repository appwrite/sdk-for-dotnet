
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Topic
    {
        [JsonProperty("$id")]
        public string Id { get; private set; }

        [JsonProperty("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonProperty("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("emailTotal")]
        public long EmailTotal { get; private set; }

        [JsonProperty("smsTotal")]
        public long SmsTotal { get; private set; }

        [JsonProperty("pushTotal")]
        public long PushTotal { get; private set; }

        [JsonProperty("subscribe")]
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
            subscribe: ((JArray)map["subscribe"]).ToObject<List<string>>()
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