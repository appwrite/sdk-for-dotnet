using System;

namespace Appwrite.Enums
{
    public class VectorsDBIndexType : IEnum
    {
        public string Value { get; private set; }

        public VectorsDBIndexType(string value)
        {
            Value = value;
        }

        public static VectorsDBIndexType HnswEuclidean => new VectorsDBIndexType("hnsw_euclidean");
        public static VectorsDBIndexType HnswDot => new VectorsDBIndexType("hnsw_dot");
        public static VectorsDBIndexType HnswCosine => new VectorsDBIndexType("hnsw_cosine");
        public static VectorsDBIndexType Object => new VectorsDBIndexType("object");
        public static VectorsDBIndexType Key => new VectorsDBIndexType("key");
        public static VectorsDBIndexType Unique => new VectorsDBIndexType("unique");
    }
}
