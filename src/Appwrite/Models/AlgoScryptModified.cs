
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class AlgoScryptModified
    {
        [JsonProperty("type")]
        public string Type { get; private set; }

        [JsonProperty("salt")]
        public string Salt { get; private set; }

        [JsonProperty("saltSeparator")]
        public string SaltSeparator { get; private set; }

        [JsonProperty("signerKey")]
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