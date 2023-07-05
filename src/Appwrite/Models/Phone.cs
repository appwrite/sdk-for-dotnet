
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Phone
    {
        [JsonProperty("code")]
        public string Code { get; private set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; private set; }

        [JsonProperty("countryName")]
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