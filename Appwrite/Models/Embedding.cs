
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Embedding
    {
        [JsonPropertyName("model")]
        public string Model { get; private set; }

        [JsonPropertyName("dimension")]
        public long Dimension { get; private set; }

        [JsonPropertyName("embedding")]
        public List<double> Embedding { get; private set; }

        [JsonPropertyName("error")]
        public string Error { get; private set; }

        public Embedding(
            string model,
            long dimension,
            List<double> embedding,
            string error
        ) {
            Model = model;
            Dimension = dimension;
            Embedding = embedding;
            Error = error;
        }

        public static Embedding From(Dictionary<string, object> map) => new Embedding(
            model: map["model"].ToString(),
            dimension: Convert.ToInt64(map["dimension"]),
            embedding: map["embedding"].ConvertToList<double>(),
            error: map["error"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "model", Model },
            { "dimension", Dimension },
            { "embedding", Embedding },
            { "error", Error }
        };
    }
}
