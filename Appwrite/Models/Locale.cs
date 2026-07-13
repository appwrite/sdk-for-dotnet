
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Locale
    {
        [JsonPropertyName("ip")]
        public string Ip { get; private set; }

        [JsonPropertyName("countryCode")]
        public string CountryCode { get; private set; }

        [JsonPropertyName("country")]
        public string Country { get; private set; }

        [JsonPropertyName("continentCode")]
        public string ContinentCode { get; private set; }

        [JsonPropertyName("continent")]
        public string Continent { get; private set; }

        [JsonPropertyName("eu")]
        public bool Eu { get; private set; }

        [JsonPropertyName("currency")]
        public string Currency { get; private set; }

        [JsonPropertyName("city")]
        public string? City { get; private set; }

        [JsonPropertyName("timeZone")]
        public string? TimeZone { get; private set; }

        [JsonPropertyName("postalCode")]
        public string? PostalCode { get; private set; }

        [JsonPropertyName("latitude")]
        public double? Latitude { get; private set; }

        [JsonPropertyName("longitude")]
        public double? Longitude { get; private set; }

        [JsonPropertyName("autonomousSystemNumber")]
        public string? AutonomousSystemNumber { get; private set; }

        [JsonPropertyName("autonomousSystemOrganization")]
        public string? AutonomousSystemOrganization { get; private set; }

        [JsonPropertyName("isp")]
        public string? Isp { get; private set; }

        [JsonPropertyName("connectionType")]
        public string? ConnectionType { get; private set; }

        [JsonPropertyName("connectionUsageType")]
        public string? ConnectionUsageType { get; private set; }

        [JsonPropertyName("connectionOrganization")]
        public string? ConnectionOrganization { get; private set; }

        public Locale(
            string ip,
            string countryCode,
            string country,
            string continentCode,
            string continent,
            bool eu,
            string currency,
            string? city,
            string? timeZone,
            string? postalCode,
            double? latitude,
            double? longitude,
            string? autonomousSystemNumber,
            string? autonomousSystemOrganization,
            string? isp,
            string? connectionType,
            string? connectionUsageType,
            string? connectionOrganization
        )
        {
            Ip = ip;
            CountryCode = countryCode;
            Country = country;
            ContinentCode = continentCode;
            Continent = continent;
            Eu = eu;
            Currency = currency;
            City = city;
            TimeZone = timeZone;
            PostalCode = postalCode;
            Latitude = latitude;
            Longitude = longitude;
            AutonomousSystemNumber = autonomousSystemNumber;
            AutonomousSystemOrganization = autonomousSystemOrganization;
            Isp = isp;
            ConnectionType = connectionType;
            ConnectionUsageType = connectionUsageType;
            ConnectionOrganization = connectionOrganization;
        }

        public static Locale From(Dictionary<string, object> map) => new Locale(
            ip: map["ip"].ToString(),
            countryCode: map["countryCode"].ToString(),
            country: map["country"].ToString(),
            continentCode: map["continentCode"].ToString(),
            continent: map["continent"].ToString(),
            eu: (bool)map["eu"],
            currency: map["currency"].ToString(),
            city: map.TryGetValue("city", out var city) ? city?.ToString() : null,
            timeZone: map.TryGetValue("timeZone", out var timeZone) ? timeZone?.ToString() : null,
            postalCode: map.TryGetValue("postalCode", out var postalCode) ? postalCode?.ToString() : null,
            latitude: map.TryGetValue("latitude", out var numberRaw11) && numberRaw11 != null
                                    ? Convert.ToDouble(numberRaw11)
                                    : null,
            longitude: map.TryGetValue("longitude", out var numberRaw12) && numberRaw12 != null
                                    ? Convert.ToDouble(numberRaw12)
                                    : null,
            autonomousSystemNumber: map.TryGetValue("autonomousSystemNumber", out var autonomousSystemNumber) ? autonomousSystemNumber?.ToString() : null,
            autonomousSystemOrganization: map.TryGetValue("autonomousSystemOrganization", out var autonomousSystemOrganization) ? autonomousSystemOrganization?.ToString() : null,
            isp: map.TryGetValue("isp", out var isp) ? isp?.ToString() : null,
            connectionType: map.TryGetValue("connectionType", out var connectionType) ? connectionType?.ToString() : null,
            connectionUsageType: map.TryGetValue("connectionUsageType", out var connectionUsageType) ? connectionUsageType?.ToString() : null,
            connectionOrganization: map.TryGetValue("connectionOrganization", out var connectionOrganization) ? connectionOrganization?.ToString() : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "ip", Ip },
            { "countryCode", CountryCode },
            { "country", Country },
            { "continentCode", ContinentCode },
            { "continent", Continent },
            { "eu", Eu },
            { "currency", Currency },
            { "city", City },
            { "timeZone", TimeZone },
            { "postalCode", PostalCode },
            { "latitude", Latitude },
            { "longitude", Longitude },
            { "autonomousSystemNumber", AutonomousSystemNumber },
            { "autonomousSystemOrganization", AutonomousSystemOrganization },
            { "isp", Isp },
            { "connectionType", ConnectionType },
            { "connectionUsageType", ConnectionUsageType },
            { "connectionOrganization", ConnectionOrganization }
        };
    }
}
