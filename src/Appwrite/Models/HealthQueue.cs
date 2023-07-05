
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class HealthQueue
    {
        [JsonProperty("size")]
        public long Size { get; private set; }

        public HealthQueue(
            long size
        ) {
            Size = size;
        }

        public static HealthQueue From(Dictionary<string, object> map) => new HealthQueue(
            size: Convert.ToInt64(map["size"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "size", Size }
        };
    }
}