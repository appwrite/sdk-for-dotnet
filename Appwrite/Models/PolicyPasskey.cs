
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class PolicyPasskey
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("rpId")]
        public string RpId { get; private set; }

        [JsonPropertyName("origins")]
        public List<string> Origins { get; private set; }

        public PolicyPasskey(
            string id,
            string rpId,
            List<string> origins
        )
        {
            Id = id;
            RpId = rpId;
            Origins = origins;
        }

        public static PolicyPasskey From(Dictionary<string, object> map) => new PolicyPasskey(
            id: map["$id"].ToString(),
            rpId: map["rpId"].ToString(),
            origins: map["origins"].ConvertToList<string>()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "rpId", RpId },
            { "origins", Origins }
        };
    }
}
