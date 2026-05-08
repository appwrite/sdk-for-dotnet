
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
        public long Bandwidth { get; private set; }

        [JsonPropertyName("storage")]
        public long Storage { get; private set; }

        [JsonPropertyName("users")]
        public long Users { get; private set; }

        [JsonPropertyName("executions")]
        public long Executions { get; private set; }

        [JsonPropertyName("GBHours")]
        public long GBHours { get; private set; }

        [JsonPropertyName("imageTransformations")]
        public long ImageTransformations { get; private set; }

        [JsonPropertyName("authPhone")]
        public long AuthPhone { get; private set; }

        [JsonPropertyName("budgetLimit")]
        public long BudgetLimit { get; private set; }

        public BillingLimits(
            long bandwidth,
            long storage,
            long users,
            long executions,
            long gBHours,
            long imageTransformations,
            long authPhone,
            long budgetLimit
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
            bandwidth: Convert.ToInt64(map["bandwidth"]),
            storage: Convert.ToInt64(map["storage"]),
            users: Convert.ToInt64(map["users"]),
            executions: Convert.ToInt64(map["executions"]),
            gBHours: Convert.ToInt64(map["GBHours"]),
            imageTransformations: Convert.ToInt64(map["imageTransformations"]),
            authPhone: Convert.ToInt64(map["authPhone"]),
            budgetLimit: Convert.ToInt64(map["budgetLimit"])
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
