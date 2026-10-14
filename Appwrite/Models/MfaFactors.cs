
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class MfaFactors
    {
        [JsonPropertyName("totp")]
        public bool Totp { get; private set; }

        [JsonPropertyName("phone")]
        public bool Phone { get; private set; }

        [JsonPropertyName("email")]
        public bool Email { get; private set; }

        [JsonPropertyName("recoveryCode")]
        public bool RecoveryCode { get; private set; }

        [JsonPropertyName("custom")]
        public bool Custom { get; private set; }

        public MfaFactors(
            bool totp,
            bool phone,
            bool email,
            bool recoveryCode,
            bool custom
        )
        {
            Totp = totp;
            Phone = phone;
            Email = email;
            RecoveryCode = recoveryCode;
            Custom = custom;
        }

        public static MfaFactors From(Dictionary<string, object> map) => new MfaFactors(
            totp: (bool)(map.ContainsKey("totp") ? map["totp"] : false),
            phone: (bool)(map.ContainsKey("phone") ? map["phone"] : false),
            email: (bool)(map.ContainsKey("email") ? map["email"] : false),
            recoveryCode: (bool)(map.ContainsKey("recoveryCode") ? map["recoveryCode"] : false),
            custom: (bool)(map.ContainsKey("custom") ? map["custom"] : false)
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "totp", Totp },
            { "phone", Phone },
            { "email", Email },
            { "recoveryCode", RecoveryCode },
            { "custom", Custom }
        };
    }
}
