using System;

namespace Appwrite.Enums
{
    public class ProxyRuleDeploymentResourceType : IEnum
    {
        public string Value { get; private set; }

        public ProxyRuleDeploymentResourceType(string value)
        {
            Value = value;
        }

        public static ProxyRuleDeploymentResourceType Function => new ProxyRuleDeploymentResourceType("function");
        public static ProxyRuleDeploymentResourceType Site => new ProxyRuleDeploymentResourceType("site");
    }
}
