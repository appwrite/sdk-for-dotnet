
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class Membership
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("userId")]
        public string UserId { get; private set; }

        [JsonPropertyName("userName")]
        public string UserName { get; private set; }

        [JsonPropertyName("userEmail")]
        public string UserEmail { get; private set; }

        [JsonPropertyName("teamId")]
        public string TeamId { get; private set; }

        [JsonPropertyName("teamName")]
        public string TeamName { get; private set; }

        [JsonPropertyName("invited")]
        public string Invited { get; private set; }

        [JsonPropertyName("joined")]
        public string Joined { get; private set; }

        [JsonPropertyName("confirm")]
        public bool Confirm { get; private set; }

        [JsonPropertyName("mfa")]
        public bool Mfa { get; private set; }

        [JsonPropertyName("roles")]
        public List<string> Roles { get; private set; }

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
            bool mfa,
            List<string> roles
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
            Mfa = mfa;
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
            mfa: (bool)map["mfa"],
            roles: map["roles"].ConvertToList<string>()
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
            { "mfa", Mfa },
            { "roles", Roles }
        };
    }
}
