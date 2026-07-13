
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class BillingPlanSupportedAddons
    {
        [JsonPropertyName("baa")]
        public bool Baa { get; private set; }

        [JsonPropertyName("premiumGeoDB")]
        public bool PremiumGeoDB { get; private set; }

        [JsonPropertyName("premiumGeoDBOrg")]
        public bool PremiumGeoDBOrg { get; private set; }

        public BillingPlanSupportedAddons(
            bool baa,
            bool premiumGeoDB,
            bool premiumGeoDBOrg
        )
        {
            Baa = baa;
            PremiumGeoDB = premiumGeoDB;
            PremiumGeoDBOrg = premiumGeoDBOrg;
        }

        public static BillingPlanSupportedAddons From(Dictionary<string, object> map) => new BillingPlanSupportedAddons(
            baa: (bool)map["baa"],
            premiumGeoDB: (bool)map["premiumGeoDB"],
            premiumGeoDBOrg: (bool)map["premiumGeoDBOrg"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "baa", Baa },
            { "premiumGeoDB", PremiumGeoDB },
            { "premiumGeoDBOrg", PremiumGeoDBOrg }
        };
    }
}
