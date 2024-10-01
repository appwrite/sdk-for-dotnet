
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class MessageList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("messages")]
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
            messages: ((JArray)map["messages"]).ToObject<List<Dictionary<string, object>>>().Select(it => Message.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "messages", Messages.Select(it => it.ToMap()) }
        };
    }
}
