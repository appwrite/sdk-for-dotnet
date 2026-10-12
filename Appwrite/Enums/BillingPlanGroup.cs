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

        public static BillingPlanGroup Free => new BillingPlanGroup("free");
        public static BillingPlanGroup Start => new BillingPlanGroup("start");
        public static BillingPlanGroup Pro => new BillingPlanGroup("pro");
        public static BillingPlanGroup Scale => new BillingPlanGroup("scale");
    }
}
