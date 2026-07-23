
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Oauth2PAR
    {
        [JsonPropertyName("request_uri")]
        public string RequestUri { get; private set; }

        [JsonPropertyName("expires_in")]
        public long ExpiresIn { get; private set; }

        public Oauth2PAR(
            string requestUri,
            long expiresIn
        )
        {
            RequestUri = requestUri;
            ExpiresIn = expiresIn;
        }

        public static Oauth2PAR From(Dictionary<string, object> map) => new Oauth2PAR(
            requestUri: map["request_uri"].ToString(),
            expiresIn: Convert.ToInt64(map["expires_in"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "request_uri", RequestUri },
            { "expires_in", ExpiresIn }
        };
    }
}
