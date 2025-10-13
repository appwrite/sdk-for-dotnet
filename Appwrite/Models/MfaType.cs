
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class MfaType
    {
        [JsonPropertyName("secret")]
        public string Secret { get; private set; }

        [JsonPropertyName("uri")]
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
