
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class VcsContent
    {
        [JsonPropertyName("size")]
        public long? Size { get; private set; }

        [JsonPropertyName("isDirectory")]
        public bool? IsDirectory { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        public VcsContent(
            long? size,
            bool? isDirectory,
            string name
        ) {
            Size = size;
            IsDirectory = isDirectory;
            Name = name;
        }

        public static VcsContent From(Dictionary<string, object> map) => new VcsContent(
            size: map["size"] == null ? null :Convert.ToInt64(map["size"]),
            isDirectory: (bool?)map["isDirectory"],
            name: map["name"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "size", Size },
            { "isDirectory", IsDirectory },
            { "name", Name }
        };
    }
}
