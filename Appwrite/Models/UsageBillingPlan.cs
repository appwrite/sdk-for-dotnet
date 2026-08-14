
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class UsageBillingPlan
    {
        [JsonPropertyName("bandwidth")]
        public AdditionalResource Bandwidth { get; private set; }

        [JsonPropertyName("executions")]
        public AdditionalResource Executions { get; private set; }

        [JsonPropertyName("member")]
        public AdditionalResource? Member { get; private set; }

        [JsonPropertyName("realtime")]
        public AdditionalResource Realtime { get; private set; }

        [JsonPropertyName("realtimeMessages")]
        public AdditionalResource RealtimeMessages { get; private set; }

        [JsonPropertyName("realtimeBandwidth")]
        public AdditionalResource? RealtimeBandwidth { get; private set; }

        [JsonPropertyName("storage")]
        public AdditionalResource Storage { get; private set; }

        [JsonPropertyName("users")]
        public AdditionalResource Users { get; private set; }

        [JsonPropertyName("GBHours")]
        public AdditionalResource GBHours { get; private set; }

        [JsonPropertyName("imageTransformations")]
        public AdditionalResource ImageTransformations { get; private set; }

        [JsonPropertyName("credits")]
        public AdditionalResource? Credits { get; private set; }

        public UsageBillingPlan(
            AdditionalResource bandwidth,
            AdditionalResource executions,
            AdditionalResource? member,
            AdditionalResource realtime,
            AdditionalResource realtimeMessages,
            AdditionalResource? realtimeBandwidth,
            AdditionalResource storage,
            AdditionalResource users,
            AdditionalResource gBHours,
            AdditionalResource imageTransformations,
            AdditionalResource? credits
        )
        {
            Bandwidth = bandwidth;
            Executions = executions;
            Member = member;
            Realtime = realtime;
            RealtimeMessages = realtimeMessages;
            RealtimeBandwidth = realtimeBandwidth;
            Storage = storage;
            Users = users;
            GBHours = gBHours;
            ImageTransformations = imageTransformations;
            Credits = credits;
        }

        public static UsageBillingPlan From(Dictionary<string, object> map) => new UsageBillingPlan(
            bandwidth: Appwrite.Models.AdditionalResource.From(map: map["bandwidth"] is JsonElement jsonObj1 ? jsonObj1.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)map["bandwidth"]),
            executions: Appwrite.Models.AdditionalResource.From(map: map["executions"] is JsonElement jsonObj2 ? jsonObj2.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)map["executions"]),
            member: map.TryGetValue("member", out var objectRaw3) && objectRaw3 != null
                                    ? Appwrite.Models.AdditionalResource.From(map: objectRaw3 is JsonElement jsonObj3 ? jsonObj3.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)objectRaw3)
                                    : null,
            realtime: Appwrite.Models.AdditionalResource.From(map: map["realtime"] is JsonElement jsonObj4 ? jsonObj4.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)map["realtime"]),
            realtimeMessages: Appwrite.Models.AdditionalResource.From(map: map["realtimeMessages"] is JsonElement jsonObj5 ? jsonObj5.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)map["realtimeMessages"]),
            realtimeBandwidth: map.TryGetValue("realtimeBandwidth", out var objectRaw6) && objectRaw6 != null
                                    ? Appwrite.Models.AdditionalResource.From(map: objectRaw6 is JsonElement jsonObj6 ? jsonObj6.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)objectRaw6)
                                    : null,
            storage: Appwrite.Models.AdditionalResource.From(map: map["storage"] is JsonElement jsonObj7 ? jsonObj7.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)map["storage"]),
            users: Appwrite.Models.AdditionalResource.From(map: map["users"] is JsonElement jsonObj8 ? jsonObj8.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)map["users"]),
            gBHours: Appwrite.Models.AdditionalResource.From(map: map["GBHours"] is JsonElement jsonObj9 ? jsonObj9.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)map["GBHours"]),
            imageTransformations: Appwrite.Models.AdditionalResource.From(map: map["imageTransformations"] is JsonElement jsonObj10 ? jsonObj10.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)map["imageTransformations"]),
            credits: map.TryGetValue("credits", out var objectRaw11) && objectRaw11 != null
                                    ? Appwrite.Models.AdditionalResource.From(map: objectRaw11 is JsonElement jsonObj11 ? jsonObj11.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)objectRaw11)
                                    : null
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "bandwidth", Bandwidth?.ToMap() },
            { "executions", Executions?.ToMap() },
            { "member", Member?.ToMap() },
            { "realtime", Realtime?.ToMap() },
            { "realtimeMessages", RealtimeMessages?.ToMap() },
            { "realtimeBandwidth", RealtimeBandwidth?.ToMap() },
            { "storage", Storage?.ToMap() },
            { "users", Users?.ToMap() },
            { "GBHours", GBHours?.ToMap() },
            { "imageTransformations", ImageTransformations?.ToMap() },
            { "credits", Credits?.ToMap() }
        };
    }
}
