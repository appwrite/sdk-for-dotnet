
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Session
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("userId")]
        public string UserId { get; private set; }

        [JsonPropertyName("expire")]
        public string Expire { get; private set; }

        [JsonPropertyName("provider")]
        public string Provider { get; private set; }

        [JsonPropertyName("providerUid")]
        public string ProviderUid { get; private set; }

        [JsonPropertyName("providerAccessToken")]
        public string ProviderAccessToken { get; private set; }

        [JsonPropertyName("providerAccessTokenExpiry")]
        public string ProviderAccessTokenExpiry { get; private set; }

        [JsonPropertyName("providerRefreshToken")]
        public string ProviderRefreshToken { get; private set; }

        [JsonPropertyName("ip")]
        public string Ip { get; private set; }

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

        [JsonPropertyName("current")]
        public bool Current { get; private set; }

        [JsonPropertyName("factors")]
        public List<string> Factors { get; private set; }

        [JsonPropertyName("secret")]
        public string Secret { get; private set; }

        [JsonPropertyName("mfaUpdatedAt")]
        public string MfaUpdatedAt { get; private set; }

        public Session(
            string id,
            string createdAt,
            string updatedAt,
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
            bool current,
            List<string> factors,
            string secret,
            string mfaUpdatedAt
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
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
            Factors = factors;
            Secret = secret;
            MfaUpdatedAt = mfaUpdatedAt;
        }

        public static Session From(Dictionary<string, object> map) => new Session(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
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
            current: (bool)map["current"],
            factors: map["factors"].ConvertToList<string>(),
            secret: map["secret"].ToString(),
            mfaUpdatedAt: map["mfaUpdatedAt"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
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
            { "current", Current },
            { "factors", Factors },
            { "secret", Secret },
            { "mfaUpdatedAt", MfaUpdatedAt }
        };
    }
}
