
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class BillingPlanAddon
    {
        [JsonPropertyName("seats")]
        public BillingPlanAddonDetails? Seats { get; private set; }

        [JsonPropertyName("projects")]
        public BillingPlanAddonDetails? Projects { get; private set; }

        public BillingPlanAddon(
            BillingPlanAddonDetails? seats,
            BillingPlanAddonDetails? projects
        )
        {
            Seats = seats;
            Projects = projects;
        }

        public static BillingPlanAddon From(Dictionary<string, object> map) => new BillingPlanAddon(
            seats: map.TryGetValue("seats", out var objectRaw1) && objectRaw1 != null
                                    ? Appwrite.Models.BillingPlanAddonDetails.From(map: objectRaw1 is JsonElement jsonObj1 ? jsonObj1.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)objectRaw1)
                                    : null,
            projects: map.TryGetValue("projects", out var objectRaw2) && objectRaw2 != null
                                    ? Appwrite.Models.BillingPlanAddonDetails.From(map: objectRaw2 is JsonElement jsonObj2 ? jsonObj2.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)objectRaw2)
                                    : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "seats", Seats?.ToMap() },
            { "projects", Projects?.ToMap() }
        };
    }
}
