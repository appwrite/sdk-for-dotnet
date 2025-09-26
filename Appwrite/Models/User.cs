using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class User
    {
        [JsonPropertyName("$id")]
        public string id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string createdAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string updatedAt { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("password")]
        public string? Password { get; private set; }

        [JsonPropertyName("hash")]
        public string? Hash { get; private set; }

        [JsonPropertyName("hashOptions")]
        public object? HashOptions { get; private set; }

        [JsonPropertyName("registration")]
        public string Registration { get; private set; }

        [JsonPropertyName("status")]
        public bool Status { get; private set; }

        [JsonPropertyName("labels")]
        public List&lt;string&gt; Labels { get; private set; }

        [JsonPropertyName("passwordUpdate")]
        public string PasswordUpdate { get; private set; }

        [JsonPropertyName("email")]
        public string Email { get; private set; }

        [JsonPropertyName("phone")]
        public string Phone { get; private set; }

        [JsonPropertyName("emailVerification")]
        public bool EmailVerification { get; private set; }

        [JsonPropertyName("phoneVerification")]
        public bool PhoneVerification { get; private set; }

        [JsonPropertyName("mfa")]
        public bool Mfa { get; private set; }

        [JsonPropertyName("prefs")]
        public Preferences Prefs { get; private set; }

        [JsonPropertyName("targets")]
        public List&lt;Target&gt; Targets { get; private set; }

        [JsonPropertyName("accessedAt")]
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
            List&lt;string&gt; labels,
            string passwordUpdate,
            string email,
            string phone,
            bool emailVerification,
            bool phoneVerification,
            bool mfa,
            Preferences prefs,
            List&lt;Target&gt; targets,
            string accessedAt
        ) {
            id = id;
            createdAt = createdAt;
            updatedAt = updatedAt;
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
            Mfa = mfa;
            Prefs = prefs;
            Targets = targets;
            AccessedAt = accessedAt;
        }

        public static User From(Dictionary<string, object> map) => new User(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            name: map["name"].ToString(),
            password: map.TryGetValue("password", out var password) ? password?.ToString() : null,
            hash: map.TryGetValue("hash", out var hash) ? hash?.ToString() : null,
            hashOptions: map.TryGetValue("hashOptions", out var hashOptions) ? hashOptions?.ToString() : null,
            registration: map["registration"].ToString(),
            status: (bool)map["status"],
            labels: map["labels"] is JsonElement jsonArrayProp10 ? jsonArrayProp10.Deserialize<List<string>>()! : (List<string>)map["labels"],
            passwordUpdate: map["passwordUpdate"].ToString(),
            email: map["email"].ToString(),
            phone: map["phone"].ToString(),
            emailVerification: (bool)map["emailVerification"],
            phoneVerification: (bool)map["phoneVerification"],
            mfa: (bool)map["mfa"],
            prefs: Preferences.From(map: map["prefs"] is JsonElement jsonObj17 ? jsonObj17.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)map["prefs"]),
            targets: map["targets"] is JsonElement jsonArray18 ? jsonArray18.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Target.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["targets"]).Select(it => Target.From(map: it)).ToList(),
            accessedAt: map["accessedAt"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", id },
            { "$createdAt", createdAt },
            { "$updatedAt", updatedAt },
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
            { "mfa", Mfa },
            { "prefs", Prefs.ToMap() },
            { "targets", Targets.Select(it => it.ToMap()) },
            { "accessedAt", AccessedAt }
        };
    }
}
