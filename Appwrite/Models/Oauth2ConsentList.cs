
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Oauth2ConsentList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("consents")]
        public List<Oauth2Consent> Consents { get; private set; }

        public Oauth2ConsentList(
            long total,
            List<Oauth2Consent> consents
        )
        {
            Total = total;
            Consents = consents;
        }

        public static Oauth2ConsentList From(Dictionary<string, object> map) => new Oauth2ConsentList(
            total: Convert.ToInt64(map["total"]),
            consents: map["consents"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.Oauth2Consent.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "consents", Consents?.Select(it => it.ToMap()).ToList() }
        };
    }
}
