
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

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

        [JsonPropertyName("resourceInternalId")]
        public string ResourceInternalId { get; private set; }

        [JsonPropertyName("resourceType")]
        public string ResourceType { get; private set; }

        [JsonPropertyName("parentResourceId")]
        public string ParentResourceId { get; private set; }

        [JsonPropertyName("parentResourceInternalId")]
        public string ParentResourceInternalId { get; private set; }

        [JsonPropertyName("parentResourceType")]
        public string ParentResourceType { get; private set; }

        [JsonPropertyName("destinationResourceId")]
        public string DestinationResourceId { get; private set; }

        [JsonPropertyName("destinationResourceInternalId")]
        public string DestinationResourceInternalId { get; private set; }

        [JsonPropertyName("destinationResourceType")]
        public string DestinationResourceType { get; private set; }

        [JsonPropertyName("statusCounters")]
        public object StatusCounters { get; private set; }

        [JsonPropertyName("resourceData")]
        public List<object> ResourceData { get; private set; }

        [JsonPropertyName("errors")]
        public List<string> Errors { get; private set; }

        [JsonPropertyName("options")]
        public object Options { get; private set; }

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
            string resourceInternalId,
            string resourceType,
            string parentResourceId,
            string parentResourceInternalId,
            string parentResourceType,
            string destinationResourceId,
            string destinationResourceInternalId,
            string destinationResourceType,
            object statusCounters,
            List<object> resourceData,
            List<string> errors,
            object options
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Status = status;
            Stage = stage;
            Source = source;
            Destination = destination;
            Resources = resources;
            ResourceId = resourceId;
            ResourceInternalId = resourceInternalId;
            ResourceType = resourceType;
            ParentResourceId = parentResourceId;
            ParentResourceInternalId = parentResourceInternalId;
            ParentResourceType = parentResourceType;
            DestinationResourceId = destinationResourceId;
            DestinationResourceInternalId = destinationResourceInternalId;
            DestinationResourceType = destinationResourceType;
            StatusCounters = statusCounters;
            ResourceData = resourceData;
            Errors = errors;
            Options = options;
        }

        public static Migration From(Dictionary<string, object> map) => new Migration(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            status: (map.ContainsKey("status") ? map["status"] : "").ToString(),
            stage: (map.ContainsKey("stage") ? map["stage"] : "").ToString(),
            source: (map.ContainsKey("source") ? map["source"] : "").ToString(),
            destination: (map.ContainsKey("destination") ? map["destination"] : "Appwrite").ToString(),
            resources: (map.ContainsKey("resources") ? map["resources"] : new List<object>()).ConvertToList<string>(),
            resourceId: (map.ContainsKey("resourceId") ? map["resourceId"] : "").ToString(),
            resourceInternalId: (map.ContainsKey("resourceInternalId") ? map["resourceInternalId"] : "").ToString(),
            resourceType: (map.ContainsKey("resourceType") ? map["resourceType"] : "").ToString(),
            parentResourceId: (map.ContainsKey("parentResourceId") ? map["parentResourceId"] : "").ToString(),
            parentResourceInternalId: (map.ContainsKey("parentResourceInternalId") ? map["parentResourceInternalId"] : "").ToString(),
            parentResourceType: (map.ContainsKey("parentResourceType") ? map["parentResourceType"] : "").ToString(),
            destinationResourceId: (map.ContainsKey("destinationResourceId") ? map["destinationResourceId"] : "").ToString(),
            destinationResourceInternalId: (map.ContainsKey("destinationResourceInternalId") ? map["destinationResourceInternalId"] : "").ToString(),
            destinationResourceType: (map.ContainsKey("destinationResourceType") ? map["destinationResourceType"] : "").ToString(),
            statusCounters: (map.ContainsKey("statusCounters") ? map["statusCounters"] : new Dictionary<string, object>()),
            resourceData: (map.ContainsKey("resourceData") ? map["resourceData"] : new List<object>()).ConvertToList<object>(),
            errors: (map.ContainsKey("errors") ? map["errors"] : new List<object>()).ConvertToList<string>(),
            options: (map.ContainsKey("options") ? map["options"] : new Dictionary<string, object>())
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
            { "resourceInternalId", ResourceInternalId },
            { "resourceType", ResourceType },
            { "parentResourceId", ParentResourceId },
            { "parentResourceInternalId", ParentResourceInternalId },
            { "parentResourceType", ParentResourceType },
            { "destinationResourceId", DestinationResourceId },
            { "destinationResourceInternalId", DestinationResourceInternalId },
            { "destinationResourceType", DestinationResourceType },
            { "statusCounters", StatusCounters },
            { "resourceData", ResourceData },
            { "errors", Errors },
            { "options", Options }
        };
    }
}
