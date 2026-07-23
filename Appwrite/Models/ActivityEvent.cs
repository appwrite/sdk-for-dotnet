
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

        [JsonPropertyName("continentCode")]
        public string ContinentCode { get; private set; }

        [JsonPropertyName("city")]
        public string City { get; private set; }

        [JsonPropertyName("subdivisions")]
        public string Subdivisions { get; private set; }

        [JsonPropertyName("isp")]
        public string Isp { get; private set; }

        [JsonPropertyName("autonomousSystemNumber")]
        public string AutonomousSystemNumber { get; private set; }

        [JsonPropertyName("autonomousSystemOrganization")]
        public string AutonomousSystemOrganization { get; private set; }

        [JsonPropertyName("connectionType")]
        public string ConnectionType { get; private set; }

        [JsonPropertyName("connectionUsageType")]
        public string ConnectionUsageType { get; private set; }

        [JsonPropertyName("connectionOrganization")]
        public string ConnectionOrganization { get; private set; }

        [JsonPropertyName("time")]
        public string Time { get; private set; }

        [JsonPropertyName("projectId")]
        public string ProjectId { get; private set; }

        [JsonPropertyName("teamId")]
        public string TeamId { get; private set; }

        [JsonPropertyName("hostname")]
        public string Hostname { get; private set; }

        [JsonPropertyName("sdk")]
        public string Sdk { get; private set; }

        [JsonPropertyName("sdkVersion")]
        public string SdkVersion { get; private set; }

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
            string continentCode,
            string city,
            string subdivisions,
            string isp,
            string autonomousSystemNumber,
            string autonomousSystemOrganization,
            string connectionType,
            string connectionUsageType,
            string connectionOrganization,
            string time,
            string projectId,
            string teamId,
            string hostname,
            string sdk,
            string sdkVersion
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
            ContinentCode = continentCode;
            City = city;
            Subdivisions = subdivisions;
            Isp = isp;
            AutonomousSystemNumber = autonomousSystemNumber;
            AutonomousSystemOrganization = autonomousSystemOrganization;
            ConnectionType = connectionType;
            ConnectionUsageType = connectionUsageType;
            ConnectionOrganization = connectionOrganization;
            Time = time;
            ProjectId = projectId;
            TeamId = teamId;
            Hostname = hostname;
            Sdk = sdk;
            SdkVersion = sdkVersion;
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
            continentCode: map["continentCode"].ToString(),
            city: map["city"].ToString(),
            subdivisions: map["subdivisions"].ToString(),
            isp: map["isp"].ToString(),
            autonomousSystemNumber: map["autonomousSystemNumber"].ToString(),
            autonomousSystemOrganization: map["autonomousSystemOrganization"].ToString(),
            connectionType: map["connectionType"].ToString(),
            connectionUsageType: map["connectionUsageType"].ToString(),
            connectionOrganization: map["connectionOrganization"].ToString(),
            time: map["time"].ToString(),
            projectId: map["projectId"].ToString(),
            teamId: map["teamId"].ToString(),
            hostname: map["hostname"].ToString(),
            sdk: map["sdk"].ToString(),
            sdkVersion: map["sdkVersion"].ToString()
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
            { "continentCode", ContinentCode },
            { "city", City },
            { "subdivisions", Subdivisions },
            { "isp", Isp },
            { "autonomousSystemNumber", AutonomousSystemNumber },
            { "autonomousSystemOrganization", AutonomousSystemOrganization },
            { "connectionType", ConnectionType },
            { "connectionUsageType", ConnectionUsageType },
            { "connectionOrganization", ConnectionOrganization },
            { "time", Time },
            { "projectId", ProjectId },
            { "teamId", TeamId },
            { "hostname", Hostname },
            { "sdk", Sdk },
            { "sdkVersion", SdkVersion }
        };
    }
}
