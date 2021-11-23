
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

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("registration")]
        public int Registration { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("passwordUpdate")]
        public int PasswordUpdate { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("emailVerification")]
        public bool EmailVerification { get; set; }

        [JsonProperty("prefs")]
        public Preferences Prefs { get; set; }


        public User(
            string id,
            string name,
            int registration,
            int status,
            int passwordUpdate,
            string email,
            bool emailVerification,
            Preferences prefs
        ) {
            Id = id;
            Name = name;
            Registration = registration;
            Status = status;
            PasswordUpdate = passwordUpdate;
            Email = email;
            EmailVerification = emailVerification;
            Prefs = prefs;
        }

        public static User From(Dictionary<string, object> map) => new User(
            id: (string)map["$id"],
            name: (string)map["name"],
            registration: (int)map["registration"],
            status: (int)map["status"],
            passwordUpdate: (int)map["passwordUpdate"],
            email: (string)map["email"],
            emailVerification: (bool)map["emailVerification"],
            prefs: Preferences.From(map: ((JObject)map["prefs"]).ToObject<Dictionary<string, object>>()!)
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "$id", Id },
            { "name", Name },
            { "registration", Registration },
            { "status", Status },
            { "passwordUpdate", PasswordUpdate },
            { "email", Email },
            { "emailVerification", EmailVerification },
            { "prefs", Prefs.ToMap() }
        };
    }
}