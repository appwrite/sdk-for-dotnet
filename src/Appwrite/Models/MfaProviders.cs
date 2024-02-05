
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class MfaProviders
    {
        [JsonProperty("totp")]
        public bool Totp { get; private set; }

        [JsonProperty("phone")]
        public bool Phone { get; private set; }

        [JsonProperty("email")]
        public bool Email { get; private set; }

        public MfaProviders(
            bool totp,
            bool phone,
            bool email
        ) {
            Totp = totp;
            Phone = phone;
            Email = email;
        }

        public static MfaProviders From(Dictionary<string, object> map) => new MfaProviders(
            totp: (bool)map["totp"],
            phone: (bool)map["phone"],
            email: (bool)map["email"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "totp", Totp },
            { "phone", Phone },
            { "email", Email }
        };
    }
}