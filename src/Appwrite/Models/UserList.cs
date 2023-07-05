
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class UserList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("users")]
        public List<User> Users { get; private set; }

        public UserList(
            long total,
            List<User> users
        ) {
            Total = total;
            Users = users;
        }

        public static UserList From(Dictionary<string, object> map) => new UserList(
            total: Convert.ToInt64(map["total"]),
            users: ((JArray)map["users"]).ToObject<List<Dictionary<string, object>>>().Select(it => User.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "users", Users.Select(it => it.ToMap()) }
        };
    }
}