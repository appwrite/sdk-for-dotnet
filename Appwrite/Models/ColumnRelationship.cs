using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class ColumnRelationship
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
        public string createdAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string updatedAt { get; private set; }

        [JsonPropertyName("relatedTable")]
        public string RelatedTable { get; private set; }

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

        public ColumnRelationship(
            string key,
            string type,
            string status,
            string error,
            bool required,
            bool? array,
            string createdAt,
            string updatedAt,
            string relatedTable,
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
            createdAt = createdAt;
            updatedAt = updatedAt;
            RelatedTable = relatedTable;
            RelationType = relationType;
            TwoWay = twoWay;
            TwoWayKey = twoWayKey;
            OnDelete = onDelete;
            Side = side;
        }

        public static ColumnRelationship From(Dictionary<string, object> map) => new ColumnRelationship(
            key: map["key"].ToString(),
            type: map["type"].ToString(),
            status: map["status"].ToString(),
            error: map["error"].ToString(),
            required: (bool)map["required"],
            array: (bool?)map["array"],
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            relatedTable: map["relatedTable"].ToString(),
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
            { "$createdAt", createdAt },
            { "$updatedAt", updatedAt },
            { "relatedTable", RelatedTable },
            { "relationType", RelationType },
            { "twoWay", TwoWay },
            { "twoWayKey", TwoWayKey },
            { "onDelete", OnDelete },
            { "side", Side }
        };
    }
}
