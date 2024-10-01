
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class JWT
    {
        [JsonProperty("jwt")]
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
