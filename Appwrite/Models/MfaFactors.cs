
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

        public MfaFactors(
            bool totp,
            bool phone,
            bool email,
            bool recoveryCode
        ) {
            Totp = totp;
            Phone = phone;
            Email = email;
            RecoveryCode = recoveryCode;
        }

        public static MfaFactors From(Dictionary<string, object> map) => new MfaFactors(
            totp: (bool)map["totp"],
            phone: (bool)map["phone"],
            email: (bool)map["email"],
            recoveryCode: (bool)map["recoveryCode"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "totp", Totp },
            { "phone", Phone },
            { "email", Email },
            { "recoveryCode", RecoveryCode }
        };
    }
}
