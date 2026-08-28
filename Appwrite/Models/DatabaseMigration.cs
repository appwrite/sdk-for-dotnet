
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DatabaseMigration
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("projectId")]
        public string ProjectId { get; private set; }

        [JsonPropertyName("databaseId")]
        public string DatabaseId { get; private set; }

        [JsonPropertyName("specification")]
        public string Specification { get; private set; }

        [JsonPropertyName("phase")]
        public string Phase { get; private set; }

        [JsonPropertyName("attempt")]
        public long Attempt { get; private set; }

        [JsonPropertyName("lastError")]
        public string LastError { get; private set; }

        [JsonPropertyName("lagDocuments")]
        public long LagDocuments { get; private set; }

        [JsonPropertyName("changelogWatermark")]
        public long ChangelogWatermark { get; private set; }

        [JsonPropertyName("verifiedAt")]
        public string VerifiedAt { get; private set; }

        [JsonPropertyName("cutoverAt")]
        public string CutoverAt { get; private set; }

        [JsonPropertyName("soakUntil")]
        public string SoakUntil { get; private set; }

        [JsonPropertyName("autoCutover")]
        public bool AutoCutover { get; private set; }

        [JsonPropertyName("cutoverRequested")]
        public bool CutoverRequested { get; private set; }

        [JsonPropertyName("paused")]
        public bool Paused { get; private set; }

        public DatabaseMigration(
            string id,
            string createdAt,
            string updatedAt,
            string projectId,
            string databaseId,
            string specification,
            string phase,
            long attempt,
            string lastError,
            long lagDocuments,
            long changelogWatermark,
            string verifiedAt,
            string cutoverAt,
            string soakUntil,
            bool autoCutover,
            bool cutoverRequested,
            bool paused
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            ProjectId = projectId;
            DatabaseId = databaseId;
            Specification = specification;
            Phase = phase;
            Attempt = attempt;
            LastError = lastError;
            LagDocuments = lagDocuments;
            ChangelogWatermark = changelogWatermark;
            VerifiedAt = verifiedAt;
            CutoverAt = cutoverAt;
            SoakUntil = soakUntil;
            AutoCutover = autoCutover;
            CutoverRequested = cutoverRequested;
            Paused = paused;
        }

        public static DatabaseMigration From(Dictionary<string, object> map) => new DatabaseMigration(
            id: map["$id"].ToString(),
            createdAt: map["$createdAt"].ToString(),
            updatedAt: map["$updatedAt"].ToString(),
            projectId: map["projectId"].ToString(),
            databaseId: map["databaseId"].ToString(),
            specification: map["specification"].ToString(),
            phase: map["phase"].ToString(),
            attempt: Convert.ToInt64(map["attempt"]),
            lastError: map["lastError"].ToString(),
            lagDocuments: Convert.ToInt64(map["lagDocuments"]),
            changelogWatermark: Convert.ToInt64(map["changelogWatermark"]),
            verifiedAt: map["verifiedAt"].ToString(),
            cutoverAt: map["cutoverAt"].ToString(),
            soakUntil: map["soakUntil"].ToString(),
            autoCutover: (bool)map["autoCutover"],
            cutoverRequested: (bool)map["cutoverRequested"],
            paused: (bool)map["paused"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "projectId", ProjectId },
            { "databaseId", DatabaseId },
            { "specification", Specification },
            { "phase", Phase },
            { "attempt", Attempt },
            { "lastError", LastError },
            { "lagDocuments", LagDocuments },
            { "changelogWatermark", ChangelogWatermark },
            { "verifiedAt", VerifiedAt },
            { "cutoverAt", CutoverAt },
            { "soakUntil", SoakUntil },
            { "autoCutover", AutoCutover },
            { "cutoverRequested", CutoverRequested },
            { "paused", Paused }
        };
    }
}
