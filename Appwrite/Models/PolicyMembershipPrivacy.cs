
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class PolicyMembershipPrivacy
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("userId")]
        public bool UserId { get; private set; }

        [JsonPropertyName("userEmail")]
        public bool UserEmail { get; private set; }

        [JsonPropertyName("userPhone")]
        public bool UserPhone { get; private set; }

        [JsonPropertyName("userName")]
        public bool UserName { get; private set; }

        [JsonPropertyName("userMFA")]
        public bool UserMFA { get; private set; }

        public PolicyMembershipPrivacy(
            string id,
            bool userId,
            bool userEmail,
            bool userPhone,
            bool userName,
            bool userMFA
        )
        {
            Id = id;
            UserId = userId;
            UserEmail = userEmail;
            UserPhone = userPhone;
            UserName = userName;
            UserMFA = userMFA;
        }

        public static PolicyMembershipPrivacy From(Dictionary<string, object> map) => new PolicyMembershipPrivacy(
            id: map["$id"].ToString(),
            userId: (bool)map["userId"],
            userEmail: (bool)map["userEmail"],
            userPhone: (bool)map["userPhone"],
            userName: (bool)map["userName"],
            userMFA: (bool)map["userMFA"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "userId", UserId },
            { "userEmail", UserEmail },
            { "userPhone", UserPhone },
            { "userName", UserName },
            { "userMFA", UserMFA }
        };
    }
}
