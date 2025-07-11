
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class SmsTemplate
    {
        [JsonPropertyName("type")]
        public string Type { get; private set; }

        [JsonPropertyName("locale")]
        public string Locale { get; private set; }

        [JsonPropertyName("message")]
        public string Message { get; private set; }

        public SmsTemplate(
            string type,
            string locale,
            string message
        ) {
            Type = type;
            Locale = locale;
            Message = message;
        }

        public static SmsTemplate From(Dictionary<string, object> map) => new SmsTemplate(
            type: map["type"].ToString(),
            locale: map["locale"].ToString(),
            message: map["message"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "type", Type },
            { "locale", Locale },
            { "message", Message }
        };
    }
}
