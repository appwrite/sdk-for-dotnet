using System;

namespace Appwrite.Enums
{
    public class ProxyResourceType : IEnum
    {
        public string Value { get; private set; }

        public ProxyResourceType(string value)
        {
            Value = value;
        }

        public static ProxyResourceType Site => new ProxyResourceType("site");
        public static ProxyResourceType Function => new ProxyResourceType("function");
    }
}
