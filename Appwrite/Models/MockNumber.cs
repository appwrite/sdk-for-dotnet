
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class MockNumber
    {
        [JsonPropertyName("number")]
        public string Number { get; private set; }

        [JsonPropertyName("otp")]
        public string Otp { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        public MockNumber(
            string number,
            string otp,
            string createdAt,
            string updatedAt
        )
        {
            Number = number;
            Otp = otp;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public static MockNumber From(Dictionary<string, object> map) => new MockNumber(
            number: map["number"].ToString(),
            otp: map["otp"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "number", Number },
            { "otp", Otp },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt }
        };
    }
}
