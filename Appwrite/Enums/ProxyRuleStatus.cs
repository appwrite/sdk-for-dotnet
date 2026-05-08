using System;

namespace Appwrite.Enums
{
    public class ProxyRuleStatus : IEnum
    {
        public string Value { get; private set; }

        public ProxyRuleStatus(string value)
        {
            Value = value;
        }

        public static ProxyRuleStatus Unverified => new ProxyRuleStatus("unverified");
        public static ProxyRuleStatus Verifying => new ProxyRuleStatus("verifying");
        public static ProxyRuleStatus Verified => new ProxyRuleStatus("verified");
    }
}
