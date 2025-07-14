
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class AttributeRelationship
    {
        [JsonPropertyName("key")]
        public string Key { get; private set; }

        [JsonPropertyName("type")]
        public string Type { get; private set; }

        [JsonPropertyName("status")]
        public string Status { get; private set; }

        [JsonPropertyName("error")]
        public string Error { get; private set; }

        [JsonPropertyName("required")]
        public bool Required { get; private set; }

        [JsonPropertyName("array")]
        public bool? Array { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("relatedCollection")]
        public string RelatedCollection { get; private set; }

        [JsonPropertyName("relationType")]
        public string RelationType { get; private set; }

        [JsonPropertyName("twoWay")]
        public bool TwoWay { get; private set; }

        [JsonPropertyName("twoWayKey")]
        public string TwoWayKey { get; private set; }

        [JsonPropertyName("onDelete")]
        public string OnDelete { get; private set; }

        [JsonPropertyName("side")]
        public string Side { get; private set; }

        public AttributeRelationship(
            string key,
            string type,
            string status,
            string error,
            bool required,
            bool? array,
            string createdAt,
            string updatedAt,
            string relatedCollection,
            string relationType,
            bool twoWay,
            string twoWayKey,
            string onDelete,
            string side
        ) {
            Key = key;
            Type = type;
            Status = status;
            Error = error;
            Required = required;
            Array = array;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            RelatedCollection = relatedCollection;
            RelationType = relationType;
            TwoWay = twoWay;
            TwoWayKey = twoWayKey;
            OnDelete = onDelete;
            Side = side;
        }

        public static AttributeRelationship From(Dictionary<string, object> map) => new AttributeRelationship(
            key: map["key"].ToString(),
            type: map["type"].ToString(),
            status: map["status"].ToString(),
            error: map["error"].ToString(),
            required: (bool)map["required"],
            array: (bool?)map["array"],
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            relatedCollection: map["relatedCollection"].ToString(),
            relationType: map["relationType"].ToString(),
            twoWay: (bool)map["twoWay"],
            twoWayKey: map["twoWayKey"].ToString(),
            onDelete: map["onDelete"].ToString(),
            side: map["side"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "key", Key },
            { "type", Type },
            { "status", Status },
            { "error", Error },
            { "required", Required },
            { "array", Array },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "relatedCollection", RelatedCollection },
            { "relationType", RelationType },
            { "twoWay", TwoWay },
            { "twoWayKey", TwoWayKey },
            { "onDelete", OnDelete },
            { "side", Side }
        };
    }
}
