using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class AlgoScryptModified
    {
        [JsonPropertyName("type")]
        public string Type { get; private set; }

        [JsonPropertyName("salt")]
        public string Salt { get; private set; }

        [JsonPropertyName("saltSeparator")]
        public string SaltSeparator { get; private set; }

        [JsonPropertyName("signerKey")]
        public string SignerKey { get; private set; }

        public AlgoScryptModified(
            string type,
            string salt,
            string saltSeparator,
            string signerKey
        ) {
            Type = type;
            Salt = salt;
            SaltSeparator = saltSeparator;
            SignerKey = signerKey;
        }

        public static AlgoScryptModified From(Dictionary<string, object> map) => new AlgoScryptModified(
            type: map["type"].ToString(),
            salt: map["salt"].ToString(),
            saltSeparator: map["saltSeparator"].ToString(),
            signerKey: map["signerKey"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "type", Type },
            { "salt", Salt },
            { "saltSeparator", SaltSeparator },
            { "signerKey", SignerKey }
        };
    }
}
