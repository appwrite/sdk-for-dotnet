
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class MfaProvider
    {
        [JsonProperty("backups")]
        public List<object> Backups { get; private set; }

        [JsonProperty("secret")]
        public string Secret { get; private set; }

        [JsonProperty("uri")]
        public string Uri { get; private set; }

        public MfaProvider(
            List<object> backups,
            string secret,
            string uri
        ) {
            Backups = backups;
            Secret = secret;
            Uri = uri;
        }

        public static MfaProvider From(Dictionary<string, object> map) => new MfaProvider(
            backups: ((JArray)map["backups"]).ToObject<List<object>>(),
            secret: map["secret"].ToString(),
            uri: map["uri"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "backups", Backups },
            { "secret", Secret },
            { "uri", Uri }
        };
    }
}