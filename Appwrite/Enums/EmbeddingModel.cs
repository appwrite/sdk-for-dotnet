using System;

namespace Appwrite.Enums
{
    public class EmbeddingModel : IEnum
    {
        public string Value { get; private set; }

        public EmbeddingModel(string value)
        {
            Value = value;
        }

        public static EmbeddingModel NomicEmbedText => new EmbeddingModel("nomic-embed-text");
        public static EmbeddingModel EmbeddingGemma => new EmbeddingModel("embedding-gemma");
        public static EmbeddingModel AllMinilm => new EmbeddingModel("all-minilm");
        public static EmbeddingModel BgeSmall => new EmbeddingModel("bge-small");
    }
}
