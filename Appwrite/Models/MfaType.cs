
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class MfaType
    {
        [JsonProperty("secret")]
        public string Secret { get; private set; }

        [JsonProperty("uri")]
        public string Uri { get; private set; }

        public MfaType(
            string secret,
            string uri
        ) {
            Secret = secret;
            Uri = uri;
        }

        public static MfaType From(Dictionary<string, object> map) => new MfaType(
            secret: map["secret"].ToString(),
            uri: map["uri"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "secret", Secret },
            { "uri", Uri }
        };
    }
}
