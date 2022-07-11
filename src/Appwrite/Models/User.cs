
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class User
    {
        [JsonProperty("$id")]
        public string Id { get; set; }

        [JsonProperty("$createdAt")]
        public long CreatedAt { get; set; }

        [JsonProperty("$updatedAt")]
        public long UpdatedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("registration")]
        public long Registration { get; set; }

        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("passwordUpdate")]
        public long PasswordUpdate { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("emailVerification")]
        public bool EmailVerification { get; set; }

        [JsonProperty("phoneVerification")]
        public bool PhoneVerification { get; set; }

        [JsonProperty("prefs")]
        public Preferences Prefs { get; set; }


        public User(
            string id,
            long createdAt,
            long updatedAt,
            string name,
            long registration,
            bool status,
            long passwordUpdate,
            string email,
            string phone,
            bool emailVerification,
            bool phoneVerification,
            Preferences prefs
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Name = name;
            Registration = registration;
            Status = status;
            PasswordUpdate = passwordUpdate;
            Email = email;
            Phone = phone;
            EmailVerification = emailVerification;
            PhoneVerification = phoneVerification;
            Prefs = prefs;
        }

        public static User From(Dictionary<string, object> map) => new User(
            id: (string)map["$id"],
            createdAt: Convert.ToInt64(map["$createdAt"]),
            updatedAt: Convert.ToInt64(map["$updatedAt"]),
            name: (string)map["name"],
            registration: Convert.ToInt64(map["registration"]),
            status: (bool)map["status"],
            passwordUpdate: Convert.ToInt64(map["passwordUpdate"]),
            email: (string)map["email"],
            phone: (string)map["phone"],
            emailVerification: (bool)map["emailVerification"],
            phoneVerification: (bool)map["phoneVerification"],
            prefs: Preferences.From(map: ((JObject)map["prefs"]).ToObject<Dictionary<string, object>>()!)
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "name", Name },
            { "registration", Registration },
            { "status", Status },
            { "passwordUpdate", PasswordUpdate },
            { "email", Email },
            { "phone", Phone },
            { "emailVerification", EmailVerification },
            { "phoneVerification", PhoneVerification },
            { "prefs", Prefs.ToMap() }
        };
    }
}