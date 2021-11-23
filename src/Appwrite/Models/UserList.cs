
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class UserList
    {
        [JsonProperty("sum")]
        public int Sum { get; set; }

        [JsonProperty("users")]
        public List<User> Users { get; set; }


        public UserList(
            int sum,
            List<User> users
        ) {
            Sum = sum;
            Users = users;
        }

        public static UserList From(Dictionary<string, object> map) => new UserList(
            sum: (int)map["sum"],
            users: ((JArray)map["users"]).ToObject<List<User>>()!
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "sum", Sum },
            { "users", Users.Select(it => it.ToMap()) }
        };
    }
}