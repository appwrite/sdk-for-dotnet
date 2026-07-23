
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Oauth2Reject
    {
        [JsonPropertyName("redirectUrl")]
        public string RedirectUrl { get; private set; }

        public Oauth2Reject(
            string redirectUrl
        )
        {
            RedirectUrl = redirectUrl;
        }

        public static Oauth2Reject From(Dictionary<string, object> map) => new Oauth2Reject(
            redirectUrl: map["redirectUrl"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "redirectUrl", RedirectUrl }
        };
    }
}
