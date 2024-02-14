
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Session
    {
        [JsonProperty("$id")]
        public string Id { get; private set; }

        [JsonProperty("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonProperty("userId")]
        public string UserId { get; private set; }

        [JsonProperty("expire")]
        public string Expire { get; private set; }

        [JsonProperty("provider")]
        public string Provider { get; private set; }

        [JsonProperty("providerUid")]
        public string ProviderUid { get; private set; }

        [JsonProperty("providerAccessToken")]
        public string ProviderAccessToken { get; private set; }

        [JsonProperty("providerAccessTokenExpiry")]
        public string ProviderAccessTokenExpiry { get; private set; }

        [JsonProperty("providerRefreshToken")]
        public string ProviderRefreshToken { get; private set; }

        [JsonProperty("ip")]
        public string Ip { get; private set; }

        [JsonProperty("osCode")]
        public string OsCode { get; private set; }

        [JsonProperty("osName")]
        public string OsName { get; private set; }

        [JsonProperty("osVersion")]
        public string OsVersion { get; private set; }

        [JsonProperty("clientType")]
        public string ClientType { get; private set; }

        [JsonProperty("clientCode")]
        public string ClientCode { get; private set; }

        [JsonProperty("clientName")]
        public string ClientName { get; private set; }

        [JsonProperty("clientVersion")]
        public string ClientVersion { get; private set; }

        [JsonProperty("clientEngine")]
        public string ClientEngine { get; private set; }

        [JsonProperty("clientEngineVersion")]
        public string ClientEngineVersion { get; private set; }

        [JsonProperty("deviceName")]
        public string DeviceName { get; private set; }

        [JsonProperty("deviceBrand")]
        public string DeviceBrand { get; private set; }

        [JsonProperty("deviceModel")]
        public string DeviceModel { get; private set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; private set; }

        [JsonProperty("countryName")]
        public string CountryName { get; private set; }

        [JsonProperty("current")]
        public bool Current { get; private set; }

        public Session(
            string id,
            string createdAt,
            string userId,
            string expire,
            string provider,
            string providerUid,
            string providerAccessToken,
            string providerAccessTokenExpiry,
            string providerRefreshToken,
            string ip,
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
            string countryName,
            bool current
        ) {
            Id = id;
            CreatedAt = createdAt;
            UserId = userId;
            Expire = expire;
            Provider = provider;
            ProviderUid = providerUid;
            ProviderAccessToken = providerAccessToken;
            ProviderAccessTokenExpiry = providerAccessTokenExpiry;
            ProviderRefreshToken = providerRefreshToken;
            Ip = ip;
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
            Current = current;
        }

        public static Session From(Dictionary<string, object> map) => new Session(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            userId: map["userId"].ToString(),
            expire: map["expire"].ToString(),
            provider: map["provider"].ToString(),
            providerUid: map["providerUid"].ToString(),
            providerAccessToken: map["providerAccessToken"].ToString(),
            providerAccessTokenExpiry: map["providerAccessTokenExpiry"].ToString(),
            providerRefreshToken: map["providerRefreshToken"].ToString(),
            ip: map["ip"].ToString(),
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
            countryName: map["countryName"].ToString(),
            current: (bool)map["current"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "userId", UserId },
            { "expire", Expire },
            { "provider", Provider },
            { "providerUid", ProviderUid },
            { "providerAccessToken", ProviderAccessToken },
            { "providerAccessTokenExpiry", ProviderAccessTokenExpiry },
            { "providerRefreshToken", ProviderRefreshToken },
            { "ip", Ip },
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
            { "countryName", CountryName },
            { "current", Current }
        };
    }
}