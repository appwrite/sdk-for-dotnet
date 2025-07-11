
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class VcsContentList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("contents")]
        public List<VcsContent> Contents { get; private set; }

        public VcsContentList(
            long total,
            List<VcsContent> contents
        ) {
            Total = total;
            Contents = contents;
        }

        public static VcsContentList From(Dictionary<string, object> map) => new VcsContentList(
            total: Convert.ToInt64(map["total"]),
            contents: map["contents"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => VcsContent.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["contents"]).Select(it => VcsContent.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "contents", Contents.Select(it => it.ToMap()) }
        };
    }
}
