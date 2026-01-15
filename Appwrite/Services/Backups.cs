
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Backups : Service
    {
        public Backups(Client client) : base(client)
        {
        }

        /// <para>
        /// List all archives for a project.
        /// </para>
        /// </summary>
        public Task<Models.BackupArchiveList> ListArchives(List<string>? queries = null)
        {
            var apiPath = "/backups/archives";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.BackupArchiveList Convert(Dictionary<string, object> it) =>
                Models.BackupArchiveList.From(map: it);

            return _client.Call<Models.BackupArchiveList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new archive asynchronously for a project.
        /// </para>
        /// </summary>
        public Task<Models.BackupArchive> CreateArchive(List<string> services, string? resourceId = null)
        {
            var apiPath = "/backups/archives";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "services", services },
                { "resourceId", resourceId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.BackupArchive Convert(Dictionary<string, object> it) =>
                Models.BackupArchive.From(map: it);

            return _client.Call<Models.BackupArchive>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a backup archive using it's ID.
        /// </para>
        /// </summary>
        public Task<Models.BackupArchive> GetArchive(string archiveId)
        {
            var apiPath = "/backups/archives/{archiveId}"
                .Replace("{archiveId}", archiveId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.BackupArchive Convert(Dictionary<string, object> it) =>
                Models.BackupArchive.From(map: it);

            return _client.Call<Models.BackupArchive>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete an existing archive for a project.
        /// </para>
        /// </summary>
        public Task<object> DeleteArchive(string archiveId)
        {
            var apiPath = "/backups/archives/{archiveId}"
                .Replace("{archiveId}", archiveId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <para>
        /// List all policies for a project.
        /// </para>
        /// </summary>
        public Task<Models.BackupPolicyList> ListPolicies(List<string>? queries = null)
        {
            var apiPath = "/backups/policies";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.BackupPolicyList Convert(Dictionary<string, object> it) =>
                Models.BackupPolicyList.From(map: it);

            return _client.Call<Models.BackupPolicyList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new backup policy.
        /// </para>
        /// </summary>
        public Task<Models.BackupPolicy> CreatePolicy(string policyId, List<string> services, long retention, string schedule, string? name = null, string? resourceId = null, bool? enabled = null)
        {
            var apiPath = "/backups/policies";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "policyId", policyId },
                { "name", name },
                { "services", services },
                { "resourceId", resourceId },
                { "enabled", enabled },
                { "retention", retention },
                { "schedule", schedule }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.BackupPolicy Convert(Dictionary<string, object> it) =>
                Models.BackupPolicy.From(map: it);

            return _client.Call<Models.BackupPolicy>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a backup policy using it's ID.
        /// </para>
        /// </summary>
        public Task<Models.BackupPolicy> GetPolicy(string policyId)
        {
            var apiPath = "/backups/policies/{policyId}"
                .Replace("{policyId}", policyId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.BackupPolicy Convert(Dictionary<string, object> it) =>
                Models.BackupPolicy.From(map: it);

            return _client.Call<Models.BackupPolicy>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an existing policy using it's ID.
        /// </para>
        /// </summary>
        public Task<Models.BackupPolicy> UpdatePolicy(string policyId, string? name = null, long? retention = null, string? schedule = null, bool? enabled = null)
        {
            var apiPath = "/backups/policies/{policyId}"
                .Replace("{policyId}", policyId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "retention", retention },
                { "schedule", schedule },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.BackupPolicy Convert(Dictionary<string, object> it) =>
                Models.BackupPolicy.From(map: it);

            return _client.Call<Models.BackupPolicy>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a policy using it's ID.
        /// </para>
        /// </summary>
        public Task<object> DeletePolicy(string policyId)
        {
            var apiPath = "/backups/policies/{policyId}"
                .Replace("{policyId}", policyId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <para>
        /// Create and trigger a new restoration for a backup on a project.
        /// </para>
        /// </summary>
        public Task<Models.BackupRestoration> CreateRestoration(string archiveId, List<string> services, string? newResourceId = null, string? newResourceName = null)
        {
            var apiPath = "/backups/restoration";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "archiveId", archiveId },
                { "services", services },
                { "newResourceId", newResourceId },
                { "newResourceName", newResourceName }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.BackupRestoration Convert(Dictionary<string, object> it) =>
                Models.BackupRestoration.From(map: it);

            return _client.Call<Models.BackupRestoration>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// List all backup restorations for a project.
        /// </para>
        /// </summary>
        public Task<Models.BackupRestorationList> ListRestorations(List<string>? queries = null)
        {
            var apiPath = "/backups/restorations";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.BackupRestorationList Convert(Dictionary<string, object> it) =>
                Models.BackupRestorationList.From(map: it);

            return _client.Call<Models.BackupRestorationList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get the current status of a backup restoration.
        /// </para>
        /// </summary>
        public Task<Models.BackupRestoration> GetRestoration(string restorationId)
        {
            var apiPath = "/backups/restorations/{restorationId}"
                .Replace("{restorationId}", restorationId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.BackupRestoration Convert(Dictionary<string, object> it) =>
                Models.BackupRestoration.From(map: it);

            return _client.Call<Models.BackupRestoration>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

    }
}
