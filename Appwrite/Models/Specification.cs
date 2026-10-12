
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Specification
    {
        [JsonPropertyName("memory")]
        public long Memory { get; private set; }

        [JsonPropertyName("cpus")]
        public double Cpus { get; private set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; private set; }

        [JsonPropertyName("slug")]
        public string Slug { get; private set; }

        public Specification(
            long memory,
            double cpus,
            bool enabled,
            string slug
        )
        {
            Memory = memory;
            Cpus = cpus;
            Enabled = enabled;
            Slug = slug;
        }

        public static Specification From(Dictionary<string, object> map) => new Specification(
            memory: Convert.ToInt64((map.ContainsKey("memory") ? map["memory"] : 0)),
            cpus: Convert.ToDouble((map.ContainsKey("cpus") ? map["cpus"] : 0)),
            enabled: (bool)(map.ContainsKey("enabled") ? map["enabled"] : false),
            slug: (map.ContainsKey("slug") ? map["slug"] : "").ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "memory", Memory },
            { "cpus", Cpus },
            { "enabled", Enabled },
            { "slug", Slug }
        };
    }
}
