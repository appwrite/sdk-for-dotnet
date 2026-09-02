using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Mysql : Service
    {
        public Mysql(Client client) : base(client)
        {
        }

        /// <para>
        /// List all dedicated databases. Results support pagination.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabaseList> List(List<string>? queries = null)
        {
            var apiPath = "/mysql";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.DedicatedDatabaseList Convert(Dictionary<string, object> it)
            {
                return Models.DedicatedDatabaseList.From(map: it);
            }

            return _client.Call<Models.DedicatedDatabaseList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new dedicated database with the chosen engine and configuration.
        /// Status will be 'provisioning' until the database is ready.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabase> Create(string databaseId, string name, string? version = null, string? specification = null, long? replicas = null, string? syncMode = null, long? networkIdleTimeoutSeconds = null, List<string>? networkIPAllowlist = null, long? idleTimeoutMinutes = null, bool? pitr = null, long? pitrRetentionDays = null, bool? storageAutoscaling = null, long? storageAutoscalingThresholdPercent = null, long? storageAutoscalingMaxGb = null)
        {
            var apiPath = "/mysql";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "databaseId", databaseId },
                { "name", name },
                { "version", version },
                { "specification", specification },
                { "replicas", replicas },
                { "syncMode", syncMode },
                { "networkIdleTimeoutSeconds", networkIdleTimeoutSeconds },
                { "networkIPAllowlist", networkIPAllowlist },
                { "idleTimeoutMinutes", idleTimeoutMinutes },
                { "pitr", pitr },
                { "pitrRetentionDays", pitrRetentionDays },
                { "storageAutoscaling", storageAutoscaling },
                { "storageAutoscalingThresholdPercent", storageAutoscalingThresholdPercent },
                { "storageAutoscalingMaxGb", storageAutoscalingMaxGb }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DedicatedDatabase Convert(Dictionary<string, object> it)
            {
                return Models.DedicatedDatabase.From(map: it);
            }

            return _client.Call<Models.DedicatedDatabase>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// List the dedicated database specifications available on the current plan.
        /// Each specification reports its resource limits, pricing, and whether it is
        /// enabled for the organization.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabaseSpecificationList> ListSpecifications()
        {
            var apiPath = "/mysql/specifications";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.DedicatedDatabaseSpecificationList Convert(Dictionary<string, object> it)
            {
                return Models.DedicatedDatabaseSpecificationList.From(map: it);
            }

            return _client.Call<Models.DedicatedDatabaseSpecificationList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a dedicated database by its unique ID. Returns the database
        /// configuration and current status.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabase> Get(string databaseId)
        {
            var apiPath = "/mysql/{databaseId}"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.DedicatedDatabase Convert(Dictionary<string, object> it)
            {
                return Models.DedicatedDatabase.From(map: it);
            }

            return _client.Call<Models.DedicatedDatabase>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a dedicated database configuration. All changes are applied with
        /// zero downtime. Specification changes (cpu, memory, storage) are handled via
        /// rolling cutover. Storage expansion is done online. All other settings are
        /// applied in-place.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabase> Update(string databaseId, string? name = null, string? status = null, string? specification = null, long? replicas = null, string? syncMode = null, long? networkIdleTimeoutSeconds = null, List<string>? networkIPAllowlist = null, long? idleTimeoutMinutes = null, bool? pitr = null, long? pitrRetentionDays = null, bool? storageAutoscaling = null, long? storageAutoscalingThresholdPercent = null, long? storageAutoscalingMaxGb = null, double? metricsTraceSampleRate = null, long? metricsSlowQueryLogThresholdMs = null, bool? sqlApiEnabled = null, List<string>? sqlApiAllowedStatements = null, long? sqlApiMaxRows = null, long? sqlApiMaxBytes = null, long? sqlApiTimeoutSeconds = null)
        {
            var apiPath = "/mysql/{databaseId}"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "status", status },
                { "specification", specification },
                { "replicas", replicas },
                { "syncMode", syncMode },
                { "networkIdleTimeoutSeconds", networkIdleTimeoutSeconds },
                { "networkIPAllowlist", networkIPAllowlist },
                { "idleTimeoutMinutes", idleTimeoutMinutes },
                { "pitr", pitr },
                { "pitrRetentionDays", pitrRetentionDays },
                { "storageAutoscaling", storageAutoscaling },
                { "storageAutoscalingThresholdPercent", storageAutoscalingThresholdPercent },
                { "storageAutoscalingMaxGb", storageAutoscalingMaxGb },
                { "metricsTraceSampleRate", metricsTraceSampleRate },
                { "metricsSlowQueryLogThresholdMs", metricsSlowQueryLogThresholdMs },
                { "sqlApiEnabled", sqlApiEnabled },
                { "sqlApiAllowedStatements", sqlApiAllowedStatements },
                { "sqlApiMaxRows", sqlApiMaxRows },
                { "sqlApiMaxBytes", sqlApiMaxBytes },
                { "sqlApiTimeoutSeconds", sqlApiTimeoutSeconds }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DedicatedDatabase Convert(Dictionary<string, object> it)
            {
                return Models.DedicatedDatabase.From(map: it);
            }

            return _client.Call<Models.DedicatedDatabase>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a dedicated database. This action is irreversible. The database
        /// status will be set to 'deleting' and all resources will be cleaned up.
        /// Deletion is allowed from any state, and repeating the call re-dispatches
        /// the cleanup.
        /// </para>
        /// </summary>
        public Task<object> Delete(string databaseId)
        {
            var apiPath = "/mysql/{databaseId}"
                .Replace("{databaseId}", databaseId);

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
        /// List all backups for a dedicated database. Results can be filtered by
        /// status and type.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabaseBackupList> ListBackups(string databaseId, List<string>? queries = null)
        {
            var apiPath = "/mysql/{databaseId}/backups"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.DedicatedDatabaseBackupList Convert(Dictionary<string, object> it)
            {
                return Models.DedicatedDatabaseBackupList.From(map: it);
            }

            return _client.Call<Models.DedicatedDatabaseBackupList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a manual backup of a dedicated database. The backup will be created
        /// asynchronously and its status can be checked via the get backup endpoint.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabaseBackup> CreateBackup(string databaseId, string? type = null)
        {
            var apiPath = "/mysql/{databaseId}/backups"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "type", type }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DedicatedDatabaseBackup Convert(Dictionary<string, object> it)
            {
                return Models.DedicatedDatabaseBackup.From(map: it);
            }

            return _client.Call<Models.DedicatedDatabaseBackup>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// List scheduled backup policies for a dedicated database.
        /// </para>
        /// </summary>
        public Task<Models.BackupPolicyList> ListBackupPolicies(string databaseId, List<string>? queries = null)
        {
            var apiPath = "/mysql/{databaseId}/backups/policies"
                .Replace("{databaseId}", databaseId);

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
        /// Create a scheduled backup policy for a dedicated database.
        /// </para>
        /// </summary>
        public Task<Models.BackupPolicy> CreateBackupPolicy(string databaseId, string policyId, string name, string schedule, long retention, string? type = null, bool? enabled = null)
        {
            var apiPath = "/mysql/{databaseId}/backups/policies"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "policyId", policyId },
                { "name", name },
                { "schedule", schedule },
                { "retention", retention },
                { "type", type },
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
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a scheduled backup policy for a dedicated database.
        /// </para>
        /// </summary>
        public Task<Models.BackupPolicy> GetBackupPolicy(string databaseId, string policyId)
        {
            var apiPath = "/mysql/{databaseId}/backups/policies/{policyId}"
                .Replace("{databaseId}", databaseId)
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
        /// Update a scheduled backup policy for a dedicated database.
        /// </para>
        /// </summary>
        public Task<Models.BackupPolicy> UpdateBackupPolicy(string databaseId, string policyId, string? name = null, string? schedule = null, long? retention = null, bool? enabled = null)
        {
            var apiPath = "/mysql/{databaseId}/backups/policies/{policyId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{policyId}", policyId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "schedule", schedule },
                { "retention", retention },
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
        /// Delete a scheduled backup policy for a dedicated database. Backups already
        /// taken by the policy are kept until their retention expires.
        /// </para>
        /// </summary>
        public Task<object> DeleteBackupPolicy(string databaseId, string policyId)
        {
            var apiPath = "/mysql/{databaseId}/backups/policies/{policyId}"
                .Replace("{databaseId}", databaseId)
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
        /// Configure off-cluster backup storage for a dedicated database. Supports S3,
        /// GCS, and Azure Blob Storage destinations. Backups will be stored to the
        /// configured destination in addition to on-cluster storage.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabaseBackupStorage> UpdateBackupStorage(string databaseId, string provider, string bucket, string accessKey, string secretKey, string? region = null, string? prefix = null, string? endpoint = null)
        {
            var apiPath = "/mysql/{databaseId}/backups/storage"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "provider", provider },
                { "bucket", bucket },
                { "region", region },
                { "prefix", prefix },
                { "endpoint", endpoint },
                { "accessKey", accessKey },
                { "secretKey", secretKey }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DedicatedDatabaseBackupStorage Convert(Dictionary<string, object> it)
            {
                return Models.DedicatedDatabaseBackupStorage.From(map: it);
            }

            return _client.Call<Models.DedicatedDatabaseBackupStorage>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get details of a specific database backup including its status, size, and
        /// timestamps.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabaseBackup> GetBackup(string databaseId, string backupId)
        {
            var apiPath = "/mysql/{databaseId}/backups/{backupId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{backupId}", backupId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.DedicatedDatabaseBackup Convert(Dictionary<string, object> it)
            {
                return Models.DedicatedDatabaseBackup.From(map: it);
            }

            return _client.Call<Models.DedicatedDatabaseBackup>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a database backup. This will permanently remove the backup from
        /// storage and cannot be undone.
        /// </para>
        /// </summary>
        public Task<object> DeleteBackup(string databaseId, string backupId)
        {
            var apiPath = "/mysql/{databaseId}/backups/{backupId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{backupId}", backupId);

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
        /// List all ephemeral branches for a dedicated database. Returns branch
        /// metadata including ID, name, namespace, and expiration time.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabaseBranchList> ListBranches(string databaseId)
        {
            var apiPath = "/mysql/{databaseId}/branches"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.DedicatedDatabaseBranchList Convert(Dictionary<string, object> it)
            {
                return Models.DedicatedDatabaseBranchList.From(map: it);
            }

            return _client.Call<Models.DedicatedDatabaseBranchList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create an ephemeral database branch from the primary via PVC snapshot. The
        /// branch is a full copy of the database at the current point in time, useful
        /// for testing schema migrations or running experiments without affecting
        /// production data. Branches expire after the configured TTL (default 24
        /// hours). The branch is created asynchronously.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabase> CreateBranch(string databaseId, string? branchId = null, long? ttl = null)
        {
            var apiPath = "/mysql/{databaseId}/branches"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "branchId", branchId },
                { "ttl", ttl }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DedicatedDatabase Convert(Dictionary<string, object> it)
            {
                return Models.DedicatedDatabase.From(map: it);
            }

            return _client.Call<Models.DedicatedDatabase>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete an ephemeral database branch. This removes the branch namespace, its
        /// PVC, and the associated VolumeSnapshot. The deletion runs asynchronously
        /// and is irreversible.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabase> DeleteBranch(string databaseId, string branchId)
        {
            var apiPath = "/mysql/{databaseId}/branches/{branchId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{branchId}", branchId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DedicatedDatabase Convert(Dictionary<string, object> it)
            {
                return Models.DedicatedDatabase.From(map: it);
            }

            return _client.Call<Models.DedicatedDatabase>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Queue a rotation of the primary connection credentials for a dedicated
        /// database. A hibernated database is woken by the worker before rotation.
        /// List database operations until the returned operation reaches a terminal
        /// status, then fetch the database again for the refreshed connection string.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabaseOperation> UpdateCredentials(string databaseId)
        {
            var apiPath = "/mysql/{databaseId}/credentials"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DedicatedDatabaseOperation Convert(Dictionary<string, object> it)
            {
                return Models.DedicatedDatabaseOperation.From(map: it);
            }

            return _client.Call<Models.DedicatedDatabaseOperation>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Execute SQL through the console-facing Cloud endpoint. Cloud proxies
        /// through the edge platform to the per-database SQL API sidecar. Application
        /// traffic should bypass cloud entirely and POST directly to the per-database
        /// hostname:
        /// `https://db-{project}-{db}.{region}.appwrite.center/v1/sql/executions` with
        /// an `X-Appwrite-Key` header — that path scales to the whole DB fleet
        /// without a per-query cloud round-trip. The statement type must be on the
        /// database's configured allow-list. Use bound parameters for any
        /// user-supplied values — the API does not interpolate raw strings.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabaseExecution> CreateExecution(string databaseId, string sql, object? bindings = null, long? timeoutSeconds = null)
        {
            var apiPath = "/mysql/{databaseId}/executions"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "sql", sql },
                { "bindings", bindings },
                { "timeoutSeconds", timeoutSeconds }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DedicatedDatabaseExecution Convert(Dictionary<string, object> it)
            {
                return Models.DedicatedDatabaseExecution.From(map: it);
            }

            return _client.Call<Models.DedicatedDatabaseExecution>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Trigger a manual failover for a dedicated database with high availability
        /// enabled. Promotes a replica to primary. The failover runs asynchronously;
        /// poll the database document for status updates. A database left
        /// mid-operation also accepts this call as a repair once nothing is driving
        /// the operation it is stuck in. Repairing a failover that did not finish, a
        /// `failed` database, a stranded upgrade or migrate, or a stranded compute
        /// resize additionally requires `targetReplicaId` to name the member to
        /// promote, because the default target may be the member that operation
        /// already promoted.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabase> CreateFailover(string databaseId, string? targetReplicaId = null)
        {
            var apiPath = "/mysql/{databaseId}/failovers"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "targetReplicaId", targetReplicaId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DedicatedDatabase Convert(Dictionary<string, object> it)
            {
                return Models.DedicatedDatabase.From(map: it);
            }

            return _client.Call<Models.DedicatedDatabase>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the maintenance window for a dedicated database. Maintenance
        /// operations like minor version upgrades will be performed during this
        /// window.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabase> UpdateMaintenance(string databaseId, string day, long hourUtc)
        {
            var apiPath = "/mysql/{databaseId}/maintenance"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "day", day },
                { "hourUtc", hourUtc }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DedicatedDatabase Convert(Dictionary<string, object> it)
            {
                return Models.DedicatedDatabase.From(map: it);
            }

            return _client.Call<Models.DedicatedDatabase>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Migrate a database between shared and dedicated types. Shared to dedicated
        /// provisions an always-on dedicated instance; dedicated to shared converts to
        /// a serverless instance that scales to zero when idle. Data is copied to the
        /// target with a brief read-only window during cutover.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabase> CreateMigration(string databaseId, string targetType, string? specification = null)
        {
            var apiPath = "/mysql/{databaseId}/migrations"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "targetType", targetType },
                { "specification", specification }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DedicatedDatabase Convert(Dictionary<string, object> it)
            {
                return Models.DedicatedDatabase.From(map: it);
            }

            return _client.Call<Models.DedicatedDatabase>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// List the lifecycle operations recorded for a dedicated database, newest
        /// first. Every provision, update, restore, backup and replication action is
        /// recorded here with its outcome, including an attempt that was abandoned
        /// because another worker took over the database.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabaseOperationList> ListOperations(string databaseId, string? status = null, long? limit = null, long? offset = null)
        {
            var apiPath = "/mysql/{databaseId}/operations"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "status", status },
                { "limit", limit },
                { "offset", offset }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.DedicatedDatabaseOperationList Convert(Dictionary<string, object> it)
            {
                return Models.DedicatedDatabaseOperationList.From(map: it);
            }

            return _client.Call<Models.DedicatedDatabaseOperationList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get available point-in-time recovery windows for a dedicated database.
        /// Returns the earliest and latest recovery points.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabasePITRWindows> GetPitr(string databaseId)
        {
            var apiPath = "/mysql/{databaseId}/pitr"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.DedicatedDatabasePITRWindows Convert(Dictionary<string, object> it)
            {
                return Models.DedicatedDatabasePITRWindows.From(map: it);
            }

            return _client.Call<Models.DedicatedDatabasePITRWindows>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get the connection pooler configuration for a dedicated database. Returns
        /// pooler mode, max connections, and pool size settings.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabasePooler> GetPooler(string databaseId)
        {
            var apiPath = "/mysql/{databaseId}/pooler"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.DedicatedDatabasePooler Convert(Dictionary<string, object> it)
            {
                return Models.DedicatedDatabasePooler.From(map: it);
            }

            return _client.Call<Models.DedicatedDatabasePooler>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the connection pooler configuration for a dedicated database.
        /// Configure pool mode, max connections, and pool sizes.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabasePooler> UpdatePooler(string databaseId, string? mode = null, long? maxConnections = null, long? defaultPoolSize = null, bool? readWriteSplitting = null, string? poolerCpuRequest = null, string? poolerCpuLimit = null, string? poolerMemoryRequest = null, string? poolerMemoryLimit = null)
        {
            var apiPath = "/mysql/{databaseId}/pooler"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "mode", mode },
                { "maxConnections", maxConnections },
                { "defaultPoolSize", defaultPoolSize },
                { "readWriteSplitting", readWriteSplitting },
                { "poolerCpuRequest", poolerCpuRequest },
                { "poolerCpuLimit", poolerCpuLimit },
                { "poolerMemoryRequest", poolerMemoryRequest },
                { "poolerMemoryLimit", poolerMemoryLimit }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DedicatedDatabasePooler Convert(Dictionary<string, object> it)
            {
                return Models.DedicatedDatabasePooler.From(map: it);
            }

            return _client.Call<Models.DedicatedDatabasePooler>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get high availability status for a dedicated database. Returns replica
        /// statuses, replication lag, and sync mode.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabaseReplicas> GetReplicas(string databaseId)
        {
            var apiPath = "/mysql/{databaseId}/replicas"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.DedicatedDatabaseReplicas Convert(Dictionary<string, object> it)
            {
                return Models.DedicatedDatabaseReplicas.From(map: it);
            }

            return _client.Call<Models.DedicatedDatabaseReplicas>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// List all restorations for a dedicated database. Results can be filtered by
        /// status and type.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabaseRestorationList> ListRestorations(string databaseId, string? status = null, string? type = null, long? limit = null, long? offset = null)
        {
            var apiPath = "/mysql/{databaseId}/restorations"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "status", status },
                { "type", type },
                { "limit", limit },
                { "offset", offset }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.DedicatedDatabaseRestorationList Convert(Dictionary<string, object> it)
            {
                return Models.DedicatedDatabaseRestorationList.From(map: it);
            }

            return _client.Call<Models.DedicatedDatabaseRestorationList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Restore a database from a backup or to a specific point in time (PITR). For
        /// backup restoration, provide a backupId. For PITR, provide a targetTime as
        /// an ISO 8601 datetime. PITR requires the database to have PITR enabled and
        /// is only available for enterprise databases.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabaseRestoration> CreateRestoration(string databaseId, string? type = null, string? backupId = null, string? targetDatabaseId = null, string? targetTime = null)
        {
            var apiPath = "/mysql/{databaseId}/restorations"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "type", type },
                { "backupId", backupId },
                { "targetDatabaseId", targetDatabaseId },
                { "targetTime", targetTime }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DedicatedDatabaseRestoration Convert(Dictionary<string, object> it)
            {
                return Models.DedicatedDatabaseRestoration.From(map: it);
            }

            return _client.Call<Models.DedicatedDatabaseRestoration>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get details of a specific database restoration including its status, type,
        /// and timestamps.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabaseRestoration> GetRestoration(string databaseId, string restorationId)
        {
            var apiPath = "/mysql/{databaseId}/restorations/{restorationId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{restorationId}", restorationId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.DedicatedDatabaseRestoration Convert(Dictionary<string, object> it)
            {
                return Models.DedicatedDatabaseRestoration.From(map: it);
            }

            return _client.Call<Models.DedicatedDatabaseRestoration>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get real-time health and status information for a dedicated database.
        /// Returns health status, readiness, uptime, connection info, replica status,
        /// and volume information.
        /// </para>
        /// </summary>
        public Task<Models.DatabaseStatus> GetStatus(string databaseId)
        {
            var apiPath = "/mysql/{databaseId}/status"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.DatabaseStatus Convert(Dictionary<string, object> it)
            {
                return Models.DatabaseStatus.From(map: it);
            }

            return _client.Call<Models.DatabaseStatus>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Upgrade a dedicated database to a new engine version. Uses blue-green
        /// deployment for zero-downtime cutover.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabase> CreateUpgrade(string databaseId, string targetVersion)
        {
            var apiPath = "/mysql/{databaseId}/upgrades"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "targetVersion", targetVersion }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DedicatedDatabase Convert(Dictionary<string, object> it)
            {
                return Models.DedicatedDatabase.From(map: it);
            }

            return _client.Call<Models.DedicatedDatabase>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

    }
}
