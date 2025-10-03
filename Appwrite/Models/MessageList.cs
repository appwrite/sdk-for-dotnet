using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class MessageList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("messages")]
        public List&lt;Message&gt; Messages { get; private set; }

        public MessageList(
            long total,
            List&lt;Message&gt; messages
        ) {
            Total = total;
            Messages = messages;
        }

        public static MessageList From(Dictionary<string, object> map) => new MessageList(
            total: Convert.ToInt64(map["total"]),
            messages: map["messages"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Message.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["messages"]).Select(it => Message.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "messages", Messages.Select(it => it.ToMap()) }
        };
    }
}
