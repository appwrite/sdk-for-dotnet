
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class FileList
    {
        [JsonProperty("sum")]
        public int Sum { get; set; }

        [JsonProperty("files")]
        public List<File> Files { get; set; }


        public FileList(
            int sum,
            List<File> files
        ) {
            Sum = sum;
            Files = files;
        }

        public static FileList From(Dictionary<string, object> map) => new FileList(
            sum: (int)map["sum"],
            files: ((JArray)map["files"]).ToObject<List<File>>()!
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "sum", Sum },
            { "files", Files.Select(it => it.ToMap()) }
        };
    }
}