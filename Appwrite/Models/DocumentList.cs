
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class DocumentList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("documents")]
        public List<Document> Documents { get; private set; }

        public DocumentList(
            long total,
            List<Document> documents
        ) {
            Total = total;
            Documents = documents;
        }

        public static DocumentList From(Dictionary<string, object> map) => new DocumentList(
            total: Convert.ToInt64(map["total"]),
            documents: map["documents"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Document.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["documents"]).Select(it => Document.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "documents", Documents.Select(it => it.ToMap()) }
        };

        public T ConvertTo<T>(Func<Dictionary<string, object>, T> fromJson) =>
            (T)Documents.Select(it => it.ConvertTo(fromJson));

    }
}
