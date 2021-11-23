
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Membership
    {
        [JsonProperty("$id")]
        public string Id { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("teamId")]
        public string TeamId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("invited")]
        public int Invited { get; set; }

        [JsonProperty("joined")]
        public int Joined { get; set; }

        [JsonProperty("confirm")]
        public bool Confirm { get; set; }

        [JsonProperty("roles")]
        public List<object> Roles { get; set; }


        public Membership(
            string id,
            string userId,
            string teamId,
            string name,
            string email,
            int invited,
            int joined,
            bool confirm,
            List<object> roles
        ) {
            Id = id;
            UserId = userId;
            TeamId = teamId;
            Name = name;
            Email = email;
            Invited = invited;
            Joined = joined;
            Confirm = confirm;
            Roles = roles;
        }

        public static Membership From(Dictionary<string, object> map) => new Membership(
            id: (string)map["$id"],
            userId: (string)map["userId"],
            teamId: (string)map["teamId"],
            name: (string)map["name"],
            email: (string)map["email"],
            invited: (int)map["invited"],
            joined: (int)map["joined"],
            confirm: (bool)map["confirm"],
            roles: ((JArray)map["roles"]).ToObject<List<object>>()
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "$id", Id },
            { "userId", UserId },
            { "teamId", TeamId },
            { "name", Name },
            { "email", Email },
            { "invited", Invited },
            { "joined", Joined },
            { "confirm", Confirm },
            { "roles", Roles }
        };
    }
}