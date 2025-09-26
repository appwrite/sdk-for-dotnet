using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class UserList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("users")]
        public List&lt;User&gt; Users { get; private set; }

        public UserList(
            long total,
            List&lt;User&gt; users
        ) {
            Total = total;
            Users = users;
        }

        public static UserList From(Dictionary<string, object> map) => new UserList(
            total: Convert.ToInt64(map["total"]),
            users: map["users"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => User.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["users"]).Select(it => User.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "users", Users.Select(it => it.ToMap()) }
        };
    }
}
