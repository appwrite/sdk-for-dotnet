
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Program
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("title")]
        public string Title { get; private set; }

        [JsonPropertyName("description")]
        public string Description { get; private set; }

        [JsonPropertyName("tag")]
        public string Tag { get; private set; }

        [JsonPropertyName("icon")]
        public string Icon { get; private set; }

        [JsonPropertyName("url")]
        public string Url { get; private set; }

        [JsonPropertyName("active")]
        public bool Active { get; private set; }

        [JsonPropertyName("external")]
        public bool External { get; private set; }

        [JsonPropertyName("billingPlanId")]
        public string BillingPlanId { get; private set; }

        public Program(
            string id,
            string title,
            string description,
            string tag,
            string icon,
            string url,
            bool active,
            bool external,
            string billingPlanId
        )
        {
            Id = id;
            Title = title;
            Description = description;
            Tag = tag;
            Icon = icon;
            Url = url;
            Active = active;
            External = external;
            BillingPlanId = billingPlanId;
        }

        public static Program From(Dictionary<string, object> map) => new Program(
            id: map["$id"].ToString(),
            title: map["title"].ToString(),
            description: map["description"].ToString(),
            tag: map["tag"].ToString(),
            icon: map["icon"].ToString(),
            url: map["url"].ToString(),
            active: (bool)map["active"],
            external: (bool)map["external"],
            billingPlanId: map["billingPlanId"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "title", Title },
            { "description", Description },
            { "tag", Tag },
            { "icon", Icon },
            { "url", Url },
            { "active", Active },
            { "external", External },
            { "billingPlanId", BillingPlanId }
        };
    }
}
