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
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.BackupArchiveList Convert(Dictionary<string, object> it)
            {
                return Models.BackupArchiveList.From(map: it);
            }

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
        public Task<Models.BackupArchive> CreateArchive(List<Appwrite.Enums.BackupServices> services, string? resourceId = null)
        {
            var apiPath = "/backups/archives";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "services", services?.Select(e => e.Value).ToList() },
                { "resourceId", resourceId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.BackupArchive Convert(Dictionary<string, object> it)
            {
                return Models.BackupArchive.From(map: it);
            }

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
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.BackupArchive Convert(Dictionary<string, object> it)
            {
                return Models.BackupArchive.From(map: it);
            }

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
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
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
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.BackupPolicyList Convert(Dictionary<string, object> it)
            {
                return Models.BackupPolicyList.From(map: it);
            }

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
        public Task<Models.BackupPolicy> CreatePolicy(string policyId, List<Appwrite.Enums.BackupServices> services, long retention, string schedule, string? name = null, string? resourceId = null, bool? enabled = null)
        {
            var apiPath = "/backups/policies";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "policyId", policyId },
                { "name", name },
                { "services", services?.Select(e => e.Value).ToList() },
                { "resourceId", resourceId },
                { "enabled", enabled },
                { "retention", retention },
                { "schedule", schedule }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.BackupPolicy Convert(Dictionary<string, object> it)
            {
                return Models.BackupPolicy.From(map: it);
            }

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
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.BackupPolicy Convert(Dictionary<string, object> it)
            {
                return Models.BackupPolicy.From(map: it);
            }

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
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.BackupPolicy Convert(Dictionary<string, object> it)
            {
                return Models.BackupPolicy.From(map: it);
            }

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
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };



            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <para>
        /// Create and trigger a new restoration for a backup on a project.
        /// 
        /// For a backup of one database, the restoration resolves its destination
        /// before it is queued. Pass `newResourceId` to restore into that database ID,
        /// including the archived database ID to overwrite it. When `newResourceId` is
        /// omitted, a new database ID is generated and returned in `options`.
        /// 
        /// The restoration migration records the archived database in `resourceId` and
        /// `resourceType`, and the resolved database in `destinationResourceId` and
        /// `destinationResourceType`. Database types are stored canonically as
        /// `database`, `documentsdb`, or `vectorsdb`. Project-wide restorations leave
        /// these fields empty because they do not have a single source or destination
        /// database.
        /// 
        /// To list every migration related to one database, use its canonical type in
        /// a nested `OR(AND(...), AND(...), AND(...))` across the root, parent, and
        /// destination relation pairs: `(resourceType, resourceId)`,
        /// `(parentResourceType, parentResourceId)`, and `(destinationResourceType,
        /// destinationResourceId)`. Legacy and TablesDB databases use `database`; the
        /// operational `resourceType` of a table migration is not rewritten to
        /// `tablesdb`.
        /// 
        /// When restoring a DocumentsDB or VectorsDB database to a new resource from a
        /// dedicated source, the restore provisions a fresh dedicated backing database
        /// at the source database's own specification.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.BackupRestoration> CreateRestoration(string archiveId, List<Appwrite.Enums.BackupServices> services, string? newResourceId = null, string? newResourceName = null)
        {
            var apiPath = "/backups/restoration";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "archiveId", archiveId },
                { "services", services?.Select(e => e.Value).ToList() },
                { "newResourceId", newResourceId },
                { "newResourceName", newResourceName }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.BackupRestoration Convert(Dictionary<string, object> it)
            {
                return Models.BackupRestoration.From(map: it);
            }

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
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.BackupRestorationList Convert(Dictionary<string, object> it)
            {
                return Models.BackupRestorationList.From(map: it);
            }

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
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.BackupRestoration Convert(Dictionary<string, object> it)
            {
                return Models.BackupRestoration.From(map: it);
            }

            return _client.Call<Models.BackupRestoration>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

    }
}
