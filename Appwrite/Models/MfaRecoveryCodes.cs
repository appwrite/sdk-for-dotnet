
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class MfaRecoveryCodes
    {
        [JsonProperty("recoveryCodes")]
        public List<object> RecoveryCodes { get; private set; }

        public MfaRecoveryCodes(
            List<object> recoveryCodes
        ) {
            RecoveryCodes = recoveryCodes;
        }

        public static MfaRecoveryCodes From(Dictionary<string, object> map) => new MfaRecoveryCodes(
            recoveryCodes: ((JArray)map["recoveryCodes"]).ToObject<List<object>>()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "recoveryCodes", RecoveryCodes }
        };
    }
}
