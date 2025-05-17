using System;

namespace Appwrite.Enums
{
    public class Adapter : IEnum
    {
        public string Value { get; private set; }

        public Adapter(string value)
        {
            Value = value;
        }

        public static Adapter Static => new Adapter("static");
        public static Adapter Ssr => new Adapter("ssr");
    }
}
