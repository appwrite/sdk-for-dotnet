
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

        [JsonProperty("$createdAt")]
        public long CreatedAt { get; set; }

        [JsonProperty("$updatedAt")]
        public long UpdatedAt { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("userEmail")]
        public string UserEmail { get; set; }

        [JsonProperty("teamId")]
        public string TeamId { get; set; }

        [JsonProperty("teamName")]
        public string TeamName { get; set; }

        [JsonProperty("invited")]
        public long Invited { get; set; }

        [JsonProperty("joined")]
        public long Joined { get; set; }

        [JsonProperty("confirm")]
        public bool Confirm { get; set; }

        [JsonProperty("roles")]
        public List<object> Roles { get; set; }


        public Membership(
            string id,
            long createdAt,
            long updatedAt,
            string userId,
            string userName,
            string userEmail,
            string teamId,
            string teamName,
            long invited,
            long joined,
            bool confirm,
            List<object> roles
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            UserId = userId;
            UserName = userName;
            UserEmail = userEmail;
            TeamId = teamId;
            TeamName = teamName;
            Invited = invited;
            Joined = joined;
            Confirm = confirm;
            Roles = roles;
        }

        public static Membership From(Dictionary<string, object> map) => new Membership(
            id: (string)map["$id"],
            createdAt: Convert.ToInt64(map["$createdAt"]),
            updatedAt: Convert.ToInt64(map["$updatedAt"]),
            userId: (string)map["userId"],
            userName: (string)map["userName"],
            userEmail: (string)map["userEmail"],
            teamId: (string)map["teamId"],
            teamName: (string)map["teamName"],
            invited: Convert.ToInt64(map["invited"]),
            joined: Convert.ToInt64(map["joined"]),
            confirm: (bool)map["confirm"],
            roles: ((JArray)map["roles"]).ToObject<List<object>>()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "userId", UserId },
            { "userName", UserName },
            { "userEmail", UserEmail },
            { "teamId", TeamId },
            { "teamName", TeamName },
            { "invited", Invited },
            { "joined", Joined },
            { "confirm", Confirm },
            { "roles", Roles }
        };
    }
}