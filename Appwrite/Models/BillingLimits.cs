
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class BillingLimits
    {
        [JsonPropertyName("bandwidth")]
        public long? Bandwidth { get; private set; }

        [JsonPropertyName("storage")]
        public long? Storage { get; private set; }

        [JsonPropertyName("users")]
        public long? Users { get; private set; }

        [JsonPropertyName("executions")]
        public long? Executions { get; private set; }

        [JsonPropertyName("GBHours")]
        public long? GBHours { get; private set; }

        [JsonPropertyName("imageTransformations")]
        public long? ImageTransformations { get; private set; }

        [JsonPropertyName("authPhone")]
        public long? AuthPhone { get; private set; }

        [JsonPropertyName("budgetLimit")]
        public long? BudgetLimit { get; private set; }

        public BillingLimits(
            long? bandwidth,
            long? storage,
            long? users,
            long? executions,
            long? gBHours,
            long? imageTransformations,
            long? authPhone,
            long? budgetLimit
        )
        {
            Bandwidth = bandwidth;
            Storage = storage;
            Users = users;
            Executions = executions;
            GBHours = gBHours;
            ImageTransformations = imageTransformations;
            AuthPhone = authPhone;
            BudgetLimit = budgetLimit;
        }

        public static BillingLimits From(Dictionary<string, object> map) => new BillingLimits(
            bandwidth: map.TryGetValue("bandwidth", out var numberRaw1) && numberRaw1 != null
                                    ? Convert.ToInt64(numberRaw1)
                                    : null,
            storage: map.TryGetValue("storage", out var numberRaw2) && numberRaw2 != null
                                    ? Convert.ToInt64(numberRaw2)
                                    : null,
            users: map.TryGetValue("users", out var numberRaw3) && numberRaw3 != null
                                    ? Convert.ToInt64(numberRaw3)
                                    : null,
            executions: map.TryGetValue("executions", out var numberRaw4) && numberRaw4 != null
                                    ? Convert.ToInt64(numberRaw4)
                                    : null,
            gBHours: map.TryGetValue("GBHours", out var numberRaw5) && numberRaw5 != null
                                    ? Convert.ToInt64(numberRaw5)
                                    : null,
            imageTransformations: map.TryGetValue("imageTransformations", out var numberRaw6) && numberRaw6 != null
                                    ? Convert.ToInt64(numberRaw6)
                                    : null,
            authPhone: map.TryGetValue("authPhone", out var numberRaw7) && numberRaw7 != null
                                    ? Convert.ToInt64(numberRaw7)
                                    : null,
            budgetLimit: map.TryGetValue("budgetLimit", out var numberRaw8) && numberRaw8 != null
                                    ? Convert.ToInt64(numberRaw8)
                                    : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "bandwidth", Bandwidth },
            { "storage", Storage },
            { "users", Users },
            { "executions", Executions },
            { "GBHours", GBHours },
            { "imageTransformations", ImageTransformations },
            { "authPhone", AuthPhone },
            { "budgetLimit", BudgetLimit }
        };
    }
}
