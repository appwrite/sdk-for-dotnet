using System;

namespace Appwrite.Enums
{
    public class WafRuleAction : IEnum
    {
        public string Value { get; private set; }

        public WafRuleAction(string value)
        {
            Value = value;
        }

        public static WafRuleAction Bypass => new WafRuleAction("bypass");
        public static WafRuleAction Deny => new WafRuleAction("deny");
        public static WafRuleAction Challenge => new WafRuleAction("challenge");
        public static WafRuleAction RateLimit => new WafRuleAction("rateLimit");
        public static WafRuleAction Redirect => new WafRuleAction("redirect");
    }
}
