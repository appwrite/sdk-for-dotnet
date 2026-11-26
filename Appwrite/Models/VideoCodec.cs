
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class VideoCodec
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("outputs")]
        public List<Appwrite.Enums.VideoOutput> Outputs { get; private set; }

        public VideoCodec(
            string id,
            string name,
            List<Appwrite.Enums.VideoOutput> outputs
        )
        {
            Id = id;
            Name = name;
            Outputs = outputs;
        }

        public static VideoCodec From(Dictionary<string, object> map) => new VideoCodec(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            name: (map.ContainsKey("name") ? map["name"] : "").ToString(),
            outputs: (map.ContainsKey("outputs") ? map["outputs"] : new List<object>()).ConvertToList<Appwrite.Enums.VideoOutput>()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "name", Name },
            { "outputs", Outputs.Select(it => it.Value).ToList() }
        };
    }
}
