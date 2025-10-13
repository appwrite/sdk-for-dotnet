
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Phone
    {
        [JsonPropertyName("code")]
        public string Code { get; private set; }

        [JsonPropertyName("countryCode")]
        public string CountryCode { get; private set; }

        [JsonPropertyName("countryName")]
        public string CountryName { get; private set; }

        public Phone(
            string code,
            string countryCode,
            string countryName
        ) {
            Code = code;
            CountryCode = countryCode;
            CountryName = countryName;
        }

        public static Phone From(Dictionary<string, object> map) => new Phone(
            code: map["code"].ToString(),
            countryCode: map["countryCode"].ToString(),
            countryName: map["countryName"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "code", Code },
            { "countryCode", CountryCode },
            { "countryName", CountryName }
        };
    }
}
