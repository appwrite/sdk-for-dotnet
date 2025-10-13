
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class FileList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("files")]
        public List<File> Files { get; private set; }

        public FileList(
            long total,
            List<File> files
        ) {
            Total = total;
            Files = files;
        }

        public static FileList From(Dictionary<string, object> map) => new FileList(
            total: Convert.ToInt64(map["total"]),
            files: map["files"].ConvertToList<Dictionary<string, object>>().Select(it => File.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "files", Files.Select(it => it.ToMap()) }
        };
    }
}
