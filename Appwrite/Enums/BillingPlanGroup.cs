using System;

namespace Appwrite.Enums
{
    public class BillingPlanGroup : IEnum
    {
        public string Value { get; private set; }

        public BillingPlanGroup(string value)
        {
            Value = value;
        }

        public static BillingPlanGroup Starter => new BillingPlanGroup("starter");
        public static BillingPlanGroup Pro => new BillingPlanGroup("pro");
        public static BillingPlanGroup Scale => new BillingPlanGroup("scale");
    }
}
