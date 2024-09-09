
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Build
    {
        [JsonProperty("$id")]
        public string Id { get; private set; }

        [JsonProperty("deploymentId")]
        public string DeploymentId { get; private set; }

        [JsonProperty("status")]
        public string Status { get; private set; }

        [JsonProperty("stdout")]
        public string Stdout { get; private set; }

        [JsonProperty("stderr")]
        public string Stderr { get; private set; }

        [JsonProperty("startTime")]
        public string StartTime { get; private set; }

        [JsonProperty("endTime")]
        public string EndTime { get; private set; }

        [JsonProperty("duration")]
        public long Duration { get; private set; }

        [JsonProperty("size")]
        public long Size { get; private set; }

        public Build(
            string id,
            string deploymentId,
            string status,
            string stdout,
            string stderr,
            string startTime,
            string endTime,
            long duration,
            long size
        ) {
            Id = id;
            DeploymentId = deploymentId;
            Status = status;
            Stdout = stdout;
            Stderr = stderr;
            StartTime = startTime;
            EndTime = endTime;
            Duration = duration;
            Size = size;
        }

        public static Build From(Dictionary<string, object> map) => new Build(
            id: map["$id"].ToString(),
            deploymentId: map["deploymentId"].ToString(),
            status: map["status"].ToString(),
            stdout: map["stdout"].ToString(),
            stderr: map["stderr"].ToString(),
            startTime: map["startTime"].ToString(),
            endTime: map["endTime"].ToString(),
            duration: Convert.ToInt64(map["duration"]),
            size: Convert.ToInt64(map["size"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "deploymentId", DeploymentId },
            { "status", Status },
            { "stdout", Stdout },
            { "stderr", Stderr },
            { "startTime", StartTime },
            { "endTime", EndTime },
            { "duration", Duration },
            { "size", Size }
        };
    }
}