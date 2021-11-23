
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Tag
    {
        [JsonProperty("$id")]
        public string Id { get; set; }

        [JsonProperty("functionId")]
        public string FunctionId { get; set; }

        [JsonProperty("dateCreated")]
        public int DateCreated { get; set; }

        [JsonProperty("command")]
        public string Command { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }


        public Tag(
            string id,
            string functionId,
            int dateCreated,
            string command,
            string size
        ) {
            Id = id;
            FunctionId = functionId;
            DateCreated = dateCreated;
            Command = command;
            Size = size;
        }

        public static Tag From(Dictionary<string, object> map) => new Tag(
            id: (string)map["$id"],
            functionId: (string)map["functionId"],
            dateCreated: (int)map["dateCreated"],
            command: (string)map["command"],
            size: (string)map["size"]
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "$id", Id },
            { "functionId", FunctionId },
            { "dateCreated", DateCreated },
            { "command", Command },
            { "size", Size }
        };
    }
}