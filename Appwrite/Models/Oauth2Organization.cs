
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Oauth2Organization
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        public Oauth2Organization(
            string id
        )
        {
            Id = id;
        }

        public static Oauth2Organization From(Dictionary<string, object> map) => new Oauth2Organization(
            id: map["$id"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id }
        };
    }
}
