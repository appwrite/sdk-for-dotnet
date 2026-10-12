
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class User
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

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
        public List<string> Labels { get; private set; }

        [JsonPropertyName("passwordUpdate")]
        public string PasswordUpdate { get; private set; }

        [JsonPropertyName("email")]
        public string Email { get; private set; }

        [JsonPropertyName("phone")]
        public string Phone { get; private set; }

        [JsonPropertyName("emailVerification")]
        public bool EmailVerification { get; private set; }

        [JsonPropertyName("emailCanonical")]
        public string? EmailCanonical { get; private set; }

        [JsonPropertyName("emailIsFree")]
        public bool? EmailIsFree { get; private set; }

        [JsonPropertyName("emailIsDisposable")]
        public bool? EmailIsDisposable { get; private set; }

        [JsonPropertyName("emailIsCorporate")]
        public bool? EmailIsCorporate { get; private set; }

        [JsonPropertyName("emailIsCanonical")]
        public bool? EmailIsCanonical { get; private set; }

        [JsonPropertyName("passwordPwned")]
        public bool? PasswordPwned { get; private set; }

        [JsonPropertyName("phoneVerification")]
        public bool PhoneVerification { get; private set; }

        [JsonPropertyName("mfa")]
        public bool Mfa { get; private set; }

        [JsonPropertyName("prefs")]
        public Preferences Prefs { get; private set; }

        [JsonPropertyName("targets")]
        public List<Target> Targets { get; private set; }

        [JsonPropertyName("accessedAt")]
        public string AccessedAt { get; private set; }

        [JsonPropertyName("impersonator")]
        public bool? Impersonator { get; private set; }

        [JsonPropertyName("impersonatorUserId")]
        public string? ImpersonatorUserId { get; private set; }

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
            List<string> labels,
            string passwordUpdate,
            string email,
            string phone,
            bool emailVerification,
            string? emailCanonical,
            bool? emailIsFree,
            bool? emailIsDisposable,
            bool? emailIsCorporate,
            bool? emailIsCanonical,
            bool? passwordPwned,
            bool phoneVerification,
            bool mfa,
            Preferences prefs,
            List<Target> targets,
            string accessedAt,
            bool? impersonator,
            string? impersonatorUserId
        )
        {
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
            EmailCanonical = emailCanonical;
            EmailIsFree = emailIsFree;
            EmailIsDisposable = emailIsDisposable;
            EmailIsCorporate = emailIsCorporate;
            EmailIsCanonical = emailIsCanonical;
            PasswordPwned = passwordPwned;
            PhoneVerification = phoneVerification;
            Mfa = mfa;
            Prefs = prefs;
            Targets = targets;
            AccessedAt = accessedAt;
            Impersonator = impersonator;
            ImpersonatorUserId = impersonatorUserId;
        }

        public static User From(Dictionary<string, object> map) => new User(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            name: (map.ContainsKey("name") ? map["name"] : "").ToString(),
            password: map.TryGetValue("password", out var password) ? password?.ToString() : null,
            hash: map.TryGetValue("hash", out var hash) ? hash?.ToString() : null,
            hashOptions: map.TryGetValue("hashOptions", out var objectRaw7) ? objectRaw7 : null,
            registration: (map.ContainsKey("registration") ? map["registration"] : "").ToString(),
            status: (bool)(map.ContainsKey("status") ? map["status"] : true),
            labels: (map.ContainsKey("labels") ? map["labels"] : new List<object>()).ConvertToList<string>(),
            passwordUpdate: (map.ContainsKey("passwordUpdate") ? map["passwordUpdate"] : "").ToString(),
            email: (map.ContainsKey("email") ? map["email"] : "").ToString(),
            phone: (map.ContainsKey("phone") ? map["phone"] : "").ToString(),
            emailVerification: (bool)(map.ContainsKey("emailVerification") ? map["emailVerification"] : false),
            emailCanonical: map.TryGetValue("emailCanonical", out var emailCanonical) ? emailCanonical?.ToString() : null,
            emailIsFree: map.TryGetValue("emailIsFree", out var boolRaw16) && boolRaw16 != null
                                        ? (bool?)boolRaw16
                                        : null,
            emailIsDisposable: map.TryGetValue("emailIsDisposable", out var boolRaw17) && boolRaw17 != null
                                        ? (bool?)boolRaw17
                                        : null,
            emailIsCorporate: map.TryGetValue("emailIsCorporate", out var boolRaw18) && boolRaw18 != null
                                        ? (bool?)boolRaw18
                                        : null,
            emailIsCanonical: map.TryGetValue("emailIsCanonical", out var boolRaw19) && boolRaw19 != null
                                        ? (bool?)boolRaw19
                                        : null,
            passwordPwned: map.TryGetValue("passwordPwned", out var boolRaw20) && boolRaw20 != null
                                        ? (bool?)boolRaw20
                                        : null,
            phoneVerification: (bool)(map.ContainsKey("phoneVerification") ? map["phoneVerification"] : false),
            mfa: (bool)(map.ContainsKey("mfa") ? map["mfa"] : false),
            prefs: Appwrite.Models.Preferences.From(map: map["prefs"] is JsonElement jsonObj23 ? jsonObj23.Deserialize<Dictionary<string, object>>()! : (Dictionary<string, object>)map["prefs"]),
            targets: map["targets"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.Target.From(map: it)).ToList(),
            accessedAt: (map.ContainsKey("accessedAt") ? map["accessedAt"] : "").ToString(),
            impersonator: map.TryGetValue("impersonator", out var boolRaw26) && boolRaw26 != null
                                        ? (bool?)boolRaw26
                                        : null,
            impersonatorUserId: map.TryGetValue("impersonatorUserId", out var impersonatorUserId) ? impersonatorUserId?.ToString() : null
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
            { "emailCanonical", EmailCanonical },
            { "emailIsFree", EmailIsFree },
            { "emailIsDisposable", EmailIsDisposable },
            { "emailIsCorporate", EmailIsCorporate },
            { "emailIsCanonical", EmailIsCanonical },
            { "passwordPwned", PasswordPwned },
            { "phoneVerification", PhoneVerification },
            { "mfa", Mfa },
            { "prefs", Prefs?.ToMap() },
            { "targets", Targets?.Select(it => it.ToMap()).ToList() },
            { "accessedAt", AccessedAt },
            { "impersonator", Impersonator },
            { "impersonatorUserId", ImpersonatorUserId }
        };
    }
}
