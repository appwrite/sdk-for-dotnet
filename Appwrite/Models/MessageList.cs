
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class MessageList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("messages")]
        public List<Message> Messages { get; private set; }

        public MessageList(
            long total,
            List<Message> messages
        ) {
            Total = total;
            Messages = messages;
        }

        public static MessageList From(Dictionary<string, object> map) => new MessageList(
            total: Convert.ToInt64(map["total"]),
            messages: map["messages"].ConvertToList<Dictionary<string, object>>().Select(it => Message.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "messages", Messages.Select(it => it.ToMap()) }
        };
    }
}
