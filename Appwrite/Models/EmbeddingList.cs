
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class EmbeddingList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("embeddings")]
        public List<Embedding> Embeddings { get; private set; }

        public EmbeddingList(
            long total,
            List<Embedding> embeddings
        ) {
            Total = total;
            Embeddings = embeddings;
        }

        public static EmbeddingList From(Dictionary<string, object> map) => new EmbeddingList(
            total: Convert.ToInt64(map["total"]),
            embeddings: map["embeddings"].ConvertToList<Dictionary<string, object>>().Select(it => Embedding.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "embeddings", Embeddings.Select(it => it.ToMap()) }
        };
    }
}
