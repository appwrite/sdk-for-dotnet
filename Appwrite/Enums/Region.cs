using System;

namespace Appwrite.Enums
{
    public class Region : IEnum
    {
        public string Value { get; private set; }

        public Region(string value)
        {
            Value = value;
        }

        public static Region Default => new Region("default");
    }
}
