
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class DocumentList
    {
        [JsonProperty("sum")]
        public int Sum { get; set; }

        [JsonProperty("documents")]
        public List<Document> Documents { get; set; }


        public DocumentList(
            int sum,
            List<Document> documents
        ) {
            Sum = sum;
            Documents = documents;
        }

        public static DocumentList From(Dictionary<string, object> map) => new DocumentList(
            sum: (int)map["sum"],
            documents: ((JArray)map["documents"]).ToObject<List<Document>>()!
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "sum", Sum },
            { "documents", Documents.Select(it => it.ToMap()) }
        };

        public T ConvertTo<T>(Func<Dictionary<string, object>, T> fromJson) =>
            (T)Documents.Select(it => it.ConvertTo(fromJson));

    }
}