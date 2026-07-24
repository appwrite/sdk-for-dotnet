
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Oauth2Project
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("region")]
        public string Region { get; private set; }

        [JsonPropertyName("endpoint")]
        public string Endpoint { get; private set; }

        public Oauth2Project(
            string id,
            string region,
            string endpoint
        )
        {
            Id = id;
            Region = region;
            Endpoint = endpoint;
        }

        public static Oauth2Project From(Dictionary<string, object> map) => new Oauth2Project(
            id: map["$id"].ToString(),
            region: map["region"].ToString(),
            endpoint: map["endpoint"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "region", Region },
            { "endpoint", Endpoint }
        };
    }
}
