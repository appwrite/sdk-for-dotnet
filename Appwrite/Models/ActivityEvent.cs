
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

        [JsonPropertyName("userType")]
        public string UserType { get; private set; }

        [JsonPropertyName("userId")]
        public string UserId { get; private set; }

        [JsonPropertyName("userEmail")]
        public string UserEmail { get; private set; }

        [JsonPropertyName("userName")]
        public string UserName { get; private set; }

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

        [JsonPropertyName("osCode")]
        public string OsCode { get; private set; }

        [JsonPropertyName("osName")]
        public string OsName { get; private set; }

        [JsonPropertyName("osVersion")]
        public string OsVersion { get; private set; }

        [JsonPropertyName("clientType")]
        public string ClientType { get; private set; }

        [JsonPropertyName("clientCode")]
        public string ClientCode { get; private set; }

        [JsonPropertyName("clientName")]
        public string ClientName { get; private set; }

        [JsonPropertyName("clientVersion")]
        public string ClientVersion { get; private set; }

        [JsonPropertyName("clientEngine")]
        public string ClientEngine { get; private set; }

        [JsonPropertyName("clientEngineVersion")]
        public string ClientEngineVersion { get; private set; }

        [JsonPropertyName("deviceName")]
        public string DeviceName { get; private set; }

        [JsonPropertyName("deviceBrand")]
        public string DeviceBrand { get; private set; }

        [JsonPropertyName("deviceModel")]
        public string DeviceModel { get; private set; }

        [JsonPropertyName("countryCode")]
        public string CountryCode { get; private set; }

        [JsonPropertyName("countryName")]
        public string CountryName { get; private set; }

        public ActivityEvent(
            string id,
            string userType,
            string userId,
            string userEmail,
            string userName,
            string resourceParent,
            string resourceType,
            string resourceId,
            string resource,
            string xevent,
            string userAgent,
            string ip,
            string mode,
            string country,
            string time,
            string projectId,
            string teamId,
            string hostname,
            string osCode,
            string osName,
            string osVersion,
            string clientType,
            string clientCode,
            string clientName,
            string clientVersion,
            string clientEngine,
            string clientEngineVersion,
            string deviceName,
            string deviceBrand,
            string deviceModel,
            string countryCode,
            string countryName
        ) {
            Id = id;
            UserType = userType;
            UserId = userId;
            UserEmail = userEmail;
            UserName = userName;
            ResourceParent = resourceParent;
            ResourceType = resourceType;
            ResourceId = resourceId;
            Resource = resource;
            Event = xevent;
            UserAgent = userAgent;
            Ip = ip;
            Mode = mode;
            Country = country;
            Time = time;
            ProjectId = projectId;
            TeamId = teamId;
            Hostname = hostname;
            OsCode = osCode;
            OsName = osName;
            OsVersion = osVersion;
            ClientType = clientType;
            ClientCode = clientCode;
            ClientName = clientName;
            ClientVersion = clientVersion;
            ClientEngine = clientEngine;
            ClientEngineVersion = clientEngineVersion;
            DeviceName = deviceName;
            DeviceBrand = deviceBrand;
            DeviceModel = deviceModel;
            CountryCode = countryCode;
            CountryName = countryName;
        }

        public static ActivityEvent From(Dictionary<string, object> map) => new ActivityEvent(
            id: map["$id"].ToString(),
            userType: map["userType"].ToString(),
            userId: map["userId"].ToString(),
            userEmail: map["userEmail"].ToString(),
            userName: map["userName"].ToString(),
            resourceParent: map["resourceParent"].ToString(),
            resourceType: map["resourceType"].ToString(),
            resourceId: map["resourceId"].ToString(),
            resource: map["resource"].ToString(),
            xevent: map["event"].ToString(),
            userAgent: map["userAgent"].ToString(),
            ip: map["ip"].ToString(),
            mode: map["mode"].ToString(),
            country: map["country"].ToString(),
            time: map["time"].ToString(),
            projectId: map["projectId"].ToString(),
            teamId: map["teamId"].ToString(),
            hostname: map["hostname"].ToString(),
            osCode: map["osCode"].ToString(),
            osName: map["osName"].ToString(),
            osVersion: map["osVersion"].ToString(),
            clientType: map["clientType"].ToString(),
            clientCode: map["clientCode"].ToString(),
            clientName: map["clientName"].ToString(),
            clientVersion: map["clientVersion"].ToString(),
            clientEngine: map["clientEngine"].ToString(),
            clientEngineVersion: map["clientEngineVersion"].ToString(),
            deviceName: map["deviceName"].ToString(),
            deviceBrand: map["deviceBrand"].ToString(),
            deviceModel: map["deviceModel"].ToString(),
            countryCode: map["countryCode"].ToString(),
            countryName: map["countryName"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "userType", UserType },
            { "userId", UserId },
            { "userEmail", UserEmail },
            { "userName", UserName },
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
            { "hostname", Hostname },
            { "osCode", OsCode },
            { "osName", OsName },
            { "osVersion", OsVersion },
            { "clientType", ClientType },
            { "clientCode", ClientCode },
            { "clientName", ClientName },
            { "clientVersion", ClientVersion },
            { "clientEngine", ClientEngine },
            { "clientEngineVersion", ClientEngineVersion },
            { "deviceName", DeviceName },
            { "deviceBrand", DeviceBrand },
            { "deviceModel", DeviceModel },
            { "countryCode", CountryCode },
            { "countryName", CountryName }
        };
    }
}
