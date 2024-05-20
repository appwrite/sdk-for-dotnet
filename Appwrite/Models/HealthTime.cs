
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class HealthTime
    {
        [JsonProperty("remoteTime")]
        public long RemoteTime { get; private set; }

        [JsonProperty("localTime")]
        public long LocalTime { get; private set; }

        [JsonProperty("diff")]
        public long Diff { get; private set; }

        public HealthTime(
            long remoteTime,
            long localTime,
            long diff
        ) {
            RemoteTime = remoteTime;
            LocalTime = localTime;
            Diff = diff;
        }

        public static HealthTime From(Dictionary<string, object> map) => new HealthTime(
            remoteTime: Convert.ToInt64(map["remoteTime"]),
            localTime: Convert.ToInt64(map["localTime"]),
            diff: Convert.ToInt64(map["diff"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "remoteTime", RemoteTime },
            { "localTime", LocalTime },
            { "diff", Diff }
        };
    }
}