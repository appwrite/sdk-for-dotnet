
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class WebhookList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("webhooks")]
        public List<Webhook> Webhooks { get; private set; }

        public WebhookList(
            long total,
            List<Webhook> webhooks
        ) {
            Total = total;
            Webhooks = webhooks;
        }

        public static WebhookList From(Dictionary<string, object> map) => new WebhookList(
            total: Convert.ToInt64(map["total"]),
            webhooks: map["webhooks"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Webhook.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["webhooks"]).Select(it => Webhook.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "webhooks", Webhooks.Select(it => it.ToMap()) }
        };
    }
}
