
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class PolicyMfaFactors
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("totp")]
        public bool Totp { get; private set; }

        [JsonPropertyName("email")]
        public bool Email { get; private set; }

        [JsonPropertyName("phone")]
        public bool Phone { get; private set; }

        [JsonPropertyName("custom")]
        public bool Custom { get; private set; }

        public PolicyMfaFactors(
            string id,
            bool totp,
            bool email,
            bool phone,
            bool custom
        )
        {
            Id = id;
            Totp = totp;
            Email = email;
            Phone = phone;
            Custom = custom;
        }

        public static PolicyMfaFactors From(Dictionary<string, object> map) => new PolicyMfaFactors(
            id: map["$id"].ToString(),
            totp: (bool)map["totp"],
            email: (bool)map["email"],
            phone: (bool)map["phone"],
            custom: (bool)map["custom"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "totp", Totp },
            { "email", Email },
            { "phone", Phone },
            { "custom", Custom }
        };
    }
}
