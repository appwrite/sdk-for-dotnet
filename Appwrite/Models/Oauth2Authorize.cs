
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Oauth2Authorize
    {
        [JsonPropertyName("grantId")]
        public string GrantId { get; private set; }

        [JsonPropertyName("redirectUrl")]
        public string RedirectUrl { get; private set; }

        public Oauth2Authorize(
            string grantId,
            string redirectUrl
        )
        {
            GrantId = grantId;
            RedirectUrl = redirectUrl;
        }

        public static Oauth2Authorize From(Dictionary<string, object> map) => new Oauth2Authorize(
            grantId: map["grantId"].ToString(),
            redirectUrl: map["redirectUrl"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "grantId", GrantId },
            { "redirectUrl", RedirectUrl }
        };
    }
}
