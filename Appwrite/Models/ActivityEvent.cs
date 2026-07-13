
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class ActivityEvent
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("actorType")]
        public string ActorType { get; private set; }

        [JsonPropertyName("actorId")]
        public string ActorId { get; private set; }

        [JsonPropertyName("actorEmail")]
        public string ActorEmail { get; private set; }

        [JsonPropertyName("actorName")]
        public string ActorName { get; private set; }

        [JsonPropertyName("resourceParent")]
        public string ResourceParent { get; private set; }

        [JsonPropertyName("resourceType")]
        public string ResourceType { get; private set; }

        [JsonPropertyName("resourceId")]
        public string ResourceId { get; private set; }

        [JsonPropertyName("resource")]
        public string Resource { get; private set; }

        [JsonPropertyName("event")]
        public string Event { get; private set; }

        [JsonPropertyName("userAgent")]
        public string UserAgent { get; private set; }

        [JsonPropertyName("ip")]
        public string Ip { get; private set; }

        [JsonPropertyName("mode")]
        public string Mode { get; private set; }

        [JsonPropertyName("country")]
        public string Country { get; private set; }

        [JsonPropertyName("time")]
        public string Time { get; private set; }

        [JsonPropertyName("projectId")]
        public string ProjectId { get; private set; }

        [JsonPropertyName("teamId")]
        public string TeamId { get; private set; }

        [JsonPropertyName("hostname")]
        public string Hostname { get; private set; }

        public ActivityEvent(
            string id,
            string actorType,
            string actorId,
            string actorEmail,
            string actorName,
            string resourceParent,
            string resourceType,
            string resourceId,
            string resource,
            string @event,
            string userAgent,
            string ip,
            string mode,
            string country,
            string time,
            string projectId,
            string teamId,
            string hostname
        )
        {
            Id = id;
            ActorType = actorType;
            ActorId = actorId;
            ActorEmail = actorEmail;
            ActorName = actorName;
            ResourceParent = resourceParent;
            ResourceType = resourceType;
            ResourceId = resourceId;
            Resource = resource;
            Event = @event;
            UserAgent = userAgent;
            Ip = ip;
            Mode = mode;
            Country = country;
            Time = time;
            ProjectId = projectId;
            TeamId = teamId;
            Hostname = hostname;
        }

        public static ActivityEvent From(Dictionary<string, object> map) => new ActivityEvent(
            id: map["$id"].ToString(),
            actorType: map["actorType"].ToString(),
            actorId: map["actorId"].ToString(),
            actorEmail: map["actorEmail"].ToString(),
            actorName: map["actorName"].ToString(),
            resourceParent: map["resourceParent"].ToString(),
            resourceType: map["resourceType"].ToString(),
            resourceId: map["resourceId"].ToString(),
            resource: map["resource"].ToString(),
            @event: map["event"].ToString(),
            userAgent: map["userAgent"].ToString(),
            ip: map["ip"].ToString(),
            mode: map["mode"].ToString(),
            country: map["country"].ToString(),
            time: map["time"].ToString(),
            projectId: map["projectId"].ToString(),
            teamId: map["teamId"].ToString(),
            hostname: map["hostname"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "actorType", ActorType },
            { "actorId", ActorId },
            { "actorEmail", ActorEmail },
            { "actorName", ActorName },
            { "resourceParent", ResourceParent },
            { "resourceType", ResourceType },
            { "resourceId", ResourceId },
            { "resource", Resource },
            { "event", Event },
            { "userAgent", UserAgent },
            { "ip", Ip },
            { "mode", Mode },
            { "country", Country },
            { "time", Time },
            { "projectId", ProjectId },
            { "teamId", TeamId },
            { "hostname", Hostname }
        };
    }
}
