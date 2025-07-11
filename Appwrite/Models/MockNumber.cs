
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class MockNumber
    {
        [JsonPropertyName("phone")]
        public string Phone { get; private set; }

        [JsonPropertyName("otp")]
        public string Otp { get; private set; }

        public MockNumber(
            string phone,
            string otp
        ) {
            Phone = phone;
            Otp = otp;
        }

        public static MockNumber From(Dictionary<string, object> map) => new MockNumber(
            phone: map["phone"].ToString(),
            otp: map["otp"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "phone", Phone },
            { "otp", Otp }
        };
    }
}
