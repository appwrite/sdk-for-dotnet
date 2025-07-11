
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class Migration
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("status")]
        public string Status { get; private set; }

        [JsonPropertyName("stage")]
        public string Stage { get; private set; }

        [JsonPropertyName("source")]
        public string Source { get; private set; }

        [JsonPropertyName("destination")]
        public string Destination { get; private set; }

        [JsonPropertyName("resources")]
        public List<string> Resources { get; private set; }

        [JsonPropertyName("resourceId")]
        public string ResourceId { get; private set; }

        [JsonPropertyName("statusCounters")]
        public object StatusCounters { get; private set; }

        [JsonPropertyName("resourceData")]
        public object ResourceData { get; private set; }

        [JsonPropertyName("errors")]
        public List<string> Errors { get; private set; }

        public Migration(
            string id,
            string createdAt,
            string updatedAt,
            string status,
            string stage,
            string source,
            string destination,
            List<string> resources,
            string resourceId,
            object statusCounters,
            object resourceData,
            List<string> errors
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Status = status;
            Stage = stage;
            Source = source;
            Destination = destination;
            Resources = resources;
            ResourceId = resourceId;
            StatusCounters = statusCounters;
            ResourceData = resourceData;
            Errors = errors;
        }

        public static Migration From(Dictionary<string, object> map) => new Migration(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            status: map["status"].ToString(),
            stage: map["stage"].ToString(),
            source: map["source"].ToString(),
            destination: map["destination"].ToString(),
            resources: map["resources"] is JsonElement jsonArrayProp8 ? jsonArrayProp8.Deserialize<List<string>>()! : (List<string>)map["resources"],
            resourceId: map["resourceId"].ToString(),
            statusCounters: map["statusCounters"].ToString(),
            resourceData: map["resourceData"].ToString(),
            errors: map["errors"] is JsonElement jsonArrayProp12 ? jsonArrayProp12.Deserialize<List<string>>()! : (List<string>)map["errors"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "status", Status },
            { "stage", Stage },
            { "source", Source },
            { "destination", Destination },
            { "resources", Resources },
            { "resourceId", ResourceId },
            { "statusCounters", StatusCounters },
            { "resourceData", ResourceData },
            { "errors", Errors }
        };
    }
}
