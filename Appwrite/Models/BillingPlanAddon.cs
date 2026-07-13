
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
        public BillingPlanAddonDetails Seats { get; private set; }

        [JsonPropertyName("projects")]
        public BillingPlanAddonDetails Projects { get; private set; }

        public BillingPlanAddon(
            BillingPlanAddonDetails seats,
            BillingPlanAddonDetails projects
        )
        {
            Seats = seats;
            Projects = projects;
        }

        public static BillingPlanAddon From(Dictionary<string, object> map) => new BillingPlanAddon(
            seats: Appwrite.Models.BillingPlanAddonDetails.From(map: map["seats"] is JsonElement jsonObj1 ? jsonObj1.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)map["seats"]),
            projects: Appwrite.Models.BillingPlanAddonDetails.From(map: map["projects"] is JsonElement jsonObj2 ? jsonObj2.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)map["projects"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "seats", Seats?.ToMap() },
            { "projects", Projects?.ToMap() }
        };
    }
}
