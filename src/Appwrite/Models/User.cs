
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
        public string Id { get; private set; }

        [JsonProperty("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonProperty("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("password")]
        public string? Password { get; private set; }

        [JsonProperty("hash")]
        public string? Hash { get; private set; }

        [JsonProperty("hashOptions")]
        public object? HashOptions { get; private set; }

        [JsonProperty("registration")]
        public string Registration { get; private set; }

        [JsonProperty("status")]
        public bool Status { get; private set; }

        [JsonProperty("labels")]
        public List<object> Labels { get; private set; }

        [JsonProperty("passwordUpdate")]
        public string PasswordUpdate { get; private set; }

        [JsonProperty("email")]
        public string Email { get; private set; }

        [JsonProperty("phone")]
        public string Phone { get; private set; }

        [JsonProperty("emailVerification")]
        public bool EmailVerification { get; private set; }

        [JsonProperty("phoneVerification")]
        public bool PhoneVerification { get; private set; }

        [JsonProperty("prefs")]
        public Preferences Prefs { get; private set; }

        [JsonProperty("accessedAt")]
        public string AccessedAt { get; private set; }

        public User(
            string id,
            string createdAt,
            string updatedAt,
            string name,
            string? password,
            string? hash,
            object? hashOptions,
            string registration,
            bool status,
            List<object> labels,
            string passwordUpdate,
            string email,
            string phone,
            bool emailVerification,
            bool phoneVerification,
            Preferences prefs,
            string accessedAt
        ) {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Name = name;
            Password = password;
            Hash = hash;
            HashOptions = hashOptions;
            Registration = registration;
            Status = status;
            Labels = labels;
            PasswordUpdate = passwordUpdate;
            Email = email;
            Phone = phone;
            EmailVerification = emailVerification;
            PhoneVerification = phoneVerification;
            Prefs = prefs;
            AccessedAt = accessedAt;
        }

        public static User From(Dictionary<string, object> map) => new User(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            name: map["name"].ToString(),
            password: map["password"]?.ToString(),
            hash: map["hash"]?.ToString(),
            hashOptions: map["hashOptions"]?.ToString(),
            registration: map["registration"].ToString(),
            status: (bool)map["status"],
            labels: ((JArray)map["labels"]).ToObject<List<object>>(),
            passwordUpdate: map["passwordUpdate"].ToString(),
            email: map["email"].ToString(),
            phone: map["phone"].ToString(),
            emailVerification: (bool)map["emailVerification"],
            phoneVerification: (bool)map["phoneVerification"],
            prefs: Preferences.From(map: ((JObject)map["prefs"]).ToObject<Dictionary<string, object>>()!),
            accessedAt: map["accessedAt"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "name", Name },
            { "password", Password },
            { "hash", Hash },
            { "hashOptions", HashOptions },
            { "registration", Registration },
            { "status", Status },
            { "labels", Labels },
            { "passwordUpdate", PasswordUpdate },
            { "email", Email },
            { "phone", Phone },
            { "emailVerification", EmailVerification },
            { "phoneVerification", PhoneVerification },
            { "prefs", Prefs.ToMap() },
            { "accessedAt", AccessedAt }
        };
    }
}