using System;

namespace Appwrite.Enums
{
    public class ProxyRuleProtocol : IEnum
    {
        public string Value { get; private set; }

        public ProxyRuleProtocol(string value)
        {
            Value = value;
        }

        public static ProxyRuleProtocol Http => new ProxyRuleProtocol("http");
        public static ProxyRuleProtocol Smtp => new ProxyRuleProtocol("smtp");
    }
}
