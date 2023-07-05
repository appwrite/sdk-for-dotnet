
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class DocumentList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("documents")]
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
            documents: ((JArray)map["documents"]).ToObject<List<Dictionary<string, object>>>().Select(it => Document.From(map: it)).ToList()
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