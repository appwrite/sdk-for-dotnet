
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Oauth2OrganizationList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("organizations")]
        public List<Oauth2Organization> Organizations { get; private set; }

        public Oauth2OrganizationList(
            long total,
            List<Oauth2Organization> organizations
        )
        {
            Total = total;
            Organizations = organizations;
        }

        public static Oauth2OrganizationList From(Dictionary<string, object> map) => new Oauth2OrganizationList(
            total: Convert.ToInt64(map["total"]),
            organizations: map["organizations"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.Oauth2Organization.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "organizations", Organizations?.Select(it => it.ToMap()).ToList() }
        };
    }
}
