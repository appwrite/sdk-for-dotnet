using System;

namespace Appwrite.Enums
{
    public class Model : IEnum
    {
        public string Value { get; private set; }

        public Model(string value)
        {
            Value = value;
        }

        public static Model Embeddinggemma => new Model("embeddinggemma");
    }
}
