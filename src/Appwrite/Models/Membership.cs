
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
        public string Id { get; private set; }

        [JsonProperty("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonProperty("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonProperty("userId")]
        public string UserId { get; private set; }

        [JsonProperty("userName")]
        public string UserName { get; private set; }

        [JsonProperty("userEmail")]
        public string UserEmail { get; private set; }

        [JsonProperty("teamId")]
        public string TeamId { get; private set; }

        [JsonProperty("teamName")]
        public string TeamName { get; private set; }

        [JsonProperty("invited")]
        public string Invited { get; private set; }

        [JsonProperty("joined")]
        public string Joined { get; private set; }

        [JsonProperty("confirm")]
        public bool Confirm { get; private set; }

        [JsonProperty("roles")]
        public List<object> Roles { get; private set; }

        public Membership(
            string id,
            string createdAt,
            string updatedAt,
            string userId,
            string userName,
            string userEmail,
            string teamId,
            string teamName,
            string invited,
            string joined,
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
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            userId: map["userId"].ToString(),
            userName: map["userName"].ToString(),
            userEmail: map["userEmail"].ToString(),
            teamId: map["teamId"].ToString(),
            teamName: map["teamName"].ToString(),
            invited: map["invited"].ToString(),
            joined: map["joined"].ToString(),
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