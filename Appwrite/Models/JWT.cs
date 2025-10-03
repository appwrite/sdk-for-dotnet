using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class JWT
    {
        [JsonPropertyName("jwt")]
        public string Jwt { get; private set; }

        public JWT(
            string jwt
        ) {
            Jwt = jwt;
        }

        public static JWT From(Dictionary<string, object> map) => new JWT(
            jwt: map["jwt"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "jwt", Jwt }
        };
    }
}
