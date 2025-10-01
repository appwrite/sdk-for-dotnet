
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class MfaRecoveryCodes
    {
        [JsonPropertyName("recoveryCodes")]
        public List<string> RecoveryCodes { get; private set; }

        public MfaRecoveryCodes(
            List<string> recoveryCodes
        ) {
            RecoveryCodes = recoveryCodes;
        }

        public static MfaRecoveryCodes From(Dictionary<string, object> map) => new MfaRecoveryCodes(
            recoveryCodes: map["recoveryCodes"] is JsonElement jsonArrayProp1 ? jsonArrayProp1.Deserialize<List<string>>()! : (List<string>)map["recoveryCodes"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "recoveryCodes", RecoveryCodes }
        };
    }
}
