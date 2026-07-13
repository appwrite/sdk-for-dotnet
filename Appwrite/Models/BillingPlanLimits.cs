
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class BillingPlanLimits
    {
        [JsonPropertyName("credits")]
        public long? Credits { get; private set; }

        [JsonPropertyName("dailyCredits")]
        public long? DailyCredits { get; private set; }

        public BillingPlanLimits(
            long? credits,
            long? dailyCredits
        )
        {
            Credits = credits;
            DailyCredits = dailyCredits;
        }

        public static BillingPlanLimits From(Dictionary<string, object> map) => new BillingPlanLimits(
            credits: map.TryGetValue("credits", out var numberRaw1) && numberRaw1 != null
                                    ? Convert.ToInt64(numberRaw1)
                                    : null,
            dailyCredits: map.TryGetValue("dailyCredits", out var numberRaw2) && numberRaw2 != null
                                    ? Convert.ToInt64(numberRaw2)
                                    : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "credits", Credits },
            { "dailyCredits", DailyCredits }
        };
    }
}
