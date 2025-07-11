
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class Metric
    {
        [JsonPropertyName("value")]
        public long Value { get; private set; }

        [JsonPropertyName("date")]
        public string Date { get; private set; }

        public Metric(
            long xvalue,
            string date
        ) {
            Value = xvalue;
            Date = date;
        }

        public static Metric From(Dictionary<string, object> map) => new Metric(
            xvalue: Convert.ToInt64(map["value"]),
            date: map["date"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "value", Value },
            { "date", Date }
        };
    }
}
