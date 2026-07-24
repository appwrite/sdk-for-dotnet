
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Oauth2DeviceAuthorization
    {
        [JsonPropertyName("device_code")]
        public string DeviceCode { get; private set; }

        [JsonPropertyName("user_code")]
        public string UserCode { get; private set; }

        [JsonPropertyName("verification_uri")]
        public string VerificationUri { get; private set; }

        [JsonPropertyName("verification_uri_complete")]
        public string VerificationUriComplete { get; private set; }

        [JsonPropertyName("expires_in")]
        public long ExpiresIn { get; private set; }

        [JsonPropertyName("interval")]
        public long Interval { get; private set; }

        public Oauth2DeviceAuthorization(
            string deviceCode,
            string userCode,
            string verificationUri,
            string verificationUriComplete,
            long expiresIn,
            long interval
        )
        {
            DeviceCode = deviceCode;
            UserCode = userCode;
            VerificationUri = verificationUri;
            VerificationUriComplete = verificationUriComplete;
            ExpiresIn = expiresIn;
            Interval = interval;
        }

        public static Oauth2DeviceAuthorization From(Dictionary<string, object> map) => new Oauth2DeviceAuthorization(
            deviceCode: map["device_code"].ToString(),
            userCode: map["user_code"].ToString(),
            verificationUri: map["verification_uri"].ToString(),
            verificationUriComplete: map["verification_uri_complete"].ToString(),
            expiresIn: Convert.ToInt64(map["expires_in"]),
            interval: Convert.ToInt64(map["interval"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "device_code", DeviceCode },
            { "user_code", UserCode },
            { "verification_uri", VerificationUri },
            { "verification_uri_complete", VerificationUriComplete },
            { "expires_in", ExpiresIn },
            { "interval", Interval }
        };
    }
}
