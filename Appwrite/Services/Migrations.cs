using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Migrations : Service
    {
        public Migrations(Client client) : base(client)
        {
        }

        /// <para>
        /// List all migrations in the current project. This endpoint returns a list of
        /// all migrations including their status, progress, and any errors that
        /// occurred during the migration process.
        /// </para>
        /// </summary>
        public Task<Models.MigrationList> List(List<string>? queries = null, string? search = null, bool? total = null)
        {
            var apiPath = "/migrations";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.MigrationList Convert(Dictionary<string, object> it)
            {
                return Models.MigrationList.From(map: it);
            }

            return _client.Call<Models.MigrationList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Migrate data from another Appwrite project to your current project. This
        /// endpoint allows you to migrate resources like databases, collections,
        /// documents, users, and files from an existing Appwrite project. 
        /// </para>
        /// </summary>
        public Task<Models.Migration> CreateAppwriteMigration(List<Appwrite.Enums.AppwriteMigrationResource> resources, string endpoint, string projectId, string apiKey, Appwrite.Enums.OnDuplicate? onDuplicate = null)
        {
            var apiPath = "/migrations/appwrite";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "resources", resources?.Select(e => e.Value).ToList() },
                { "endpoint", endpoint },
                { "projectId", projectId },
                { "apiKey", apiKey },
                { "onDuplicate", onDuplicate?.Value }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Migration Convert(Dictionary<string, object> it)
            {
                return Models.Migration.From(map: it);
            }

            return _client.Call<Models.Migration>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Export documents to a CSV file from your Appwrite database. This endpoint
        /// allows you to export documents to a CSV file stored in a secure internal
        /// bucket. You'll receive an email with a download link when the export is
        /// complete.
        /// </para>
        /// </summary>
        public Task<Models.Migration> CreateCSVExport(string databaseId, string collectionId, string filename, List<string>? columns = null, List<string>? queries = null, string? delimiter = null, string? enclosure = null, string? escape = null, bool? header = null, bool? notify = null)
        {
            var apiPath = "/migrations/csv/exports";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "databaseId", databaseId },
                { "collectionId", collectionId },
                { "filename", filename },
                { "columns", columns },
                { "queries", queries },
                { "delimiter", delimiter },
                { "enclosure", enclosure },
                { "escape", escape },
                { "header", header },
                { "notify", notify }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Migration Convert(Dictionary<string, object> it)
            {
                return Models.Migration.From(map: it);
            }

            return _client.Call<Models.Migration>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Import documents from a CSV file into your Appwrite database. This endpoint
        /// allows you to import documents from a CSV file uploaded to Appwrite Storage
        /// bucket.
        /// </para>
        /// </summary>
        public Task<Models.Migration> CreateCSVImport(string bucketId, string fileId, string databaseId, string collectionId, bool? internalFile = null, Appwrite.Enums.OnDuplicate? onDuplicate = null)
        {
            var apiPath = "/migrations/csv/imports";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "bucketId", bucketId },
                { "fileId", fileId },
                { "databaseId", databaseId },
                { "collectionId", collectionId },
                { "internalFile", internalFile },
                { "onDuplicate", onDuplicate?.Value }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Migration Convert(Dictionary<string, object> it)
            {
                return Models.Migration.From(map: it);
            }

            return _client.Call<Models.Migration>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Migrate data from a Firebase project to your Appwrite project. This
        /// endpoint allows you to migrate resources like authentication and other
        /// supported services from a Firebase project. 
        /// </para>
        /// </summary>
        public Task<Models.Migration> CreateFirebaseMigration(List<Appwrite.Enums.FirebaseMigrationResource> resources, string serviceAccount)
        {
            var apiPath = "/migrations/firebase";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "resources", resources?.Select(e => e.Value).ToList() },
                { "serviceAccount", serviceAccount }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Migration Convert(Dictionary<string, object> it)
            {
                return Models.Migration.From(map: it);
            }

            return _client.Call<Models.Migration>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Export documents to a JSON file from your Appwrite database. This endpoint
        /// allows you to export documents to a JSON file stored in a secure internal
        /// bucket. You'll receive an email with a download link when the export is
        /// complete.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.Migration> CreateJSONExport(string databaseId, string collectionId, string filename, List<string>? columns = null, List<string>? queries = null, bool? notify = null)
        {
            var apiPath = "/migrations/json/exports";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "databaseId", databaseId },
                { "collectionId", collectionId },
                { "filename", filename },
                { "columns", columns },
                { "queries", queries },
                { "notify", notify }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Migration Convert(Dictionary<string, object> it)
            {
                return Models.Migration.From(map: it);
            }

            return _client.Call<Models.Migration>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Import documents from a JSON file into your Appwrite database. This
        /// endpoint allows you to import documents from a JSON file uploaded to
        /// Appwrite Storage bucket.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.Migration> CreateJSONImport(string bucketId, string fileId, string databaseId, string collectionId, bool? internalFile = null, Appwrite.Enums.OnDuplicate? onDuplicate = null)
        {
            var apiPath = "/migrations/json/imports";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "bucketId", bucketId },
                { "fileId", fileId },
                { "databaseId", databaseId },
                { "collectionId", collectionId },
                { "internalFile", internalFile },
                { "onDuplicate", onDuplicate?.Value }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Migration Convert(Dictionary<string, object> it)
            {
                return Models.Migration.From(map: it);
            }

            return _client.Call<Models.Migration>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Migrate data from an NHost project to your Appwrite project. This endpoint
        /// allows you to migrate resources like authentication, databases, and other
        /// supported services from an NHost project. 
        /// </para>
        /// </summary>
        public Task<Models.Migration> CreateNHostMigration(List<Appwrite.Enums.NHostMigrationResource> resources, string subdomain, string region, string adminSecret, string database, string username, string password, long? port = null)
        {
            var apiPath = "/migrations/nhost";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "resources", resources?.Select(e => e.Value).ToList() },
                { "subdomain", subdomain },
                { "region", region },
                { "adminSecret", adminSecret },
                { "database", database },
                { "username", username },
                { "password", password },
                { "port", port }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Migration Convert(Dictionary<string, object> it)
            {
                return Models.Migration.From(map: it);
            }

            return _client.Call<Models.Migration>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Migrate data from a Supabase project to your Appwrite project. This
        /// endpoint allows you to migrate resources like authentication, databases,
        /// and other supported services from a Supabase project. 
        /// </para>
        /// </summary>
        public Task<Models.Migration> CreateSupabaseMigration(List<Appwrite.Enums.SupabaseMigrationResource> resources, string endpoint, string apiKey, string databaseHost, string username, string password, long? port = null)
        {
            var apiPath = "/migrations/supabase";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "resources", resources?.Select(e => e.Value).ToList() },
                { "endpoint", endpoint },
                { "apiKey", apiKey },
                { "databaseHost", databaseHost },
                { "username", username },
                { "password", password },
                { "port", port }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Migration Convert(Dictionary<string, object> it)
            {
                return Models.Migration.From(map: it);
            }

            return _client.Call<Models.Migration>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a migration by its unique ID. This endpoint returns detailed
        /// information about a specific migration including its current status,
        /// progress, and any errors that occurred during the migration process. 
        /// </para>
        /// </summary>
        public Task<Models.Migration> Get(string migrationId)
        {
            if (migrationId == "")
            {
                throw new AppwriteException("Missing required parameter: \"migrationId\"");
            }

            var apiPath = "/migrations/{migrationId}"
                .Replace("{migrationId}", Client.EncodePath(migrationId));

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.Migration Convert(Dictionary<string, object> it)
            {
                return Models.Migration.From(map: it);
            }

            return _client.Call<Models.Migration>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Retry a failed migration. This endpoint allows you to retry a migration
        /// that has previously failed.
        /// </para>
        /// </summary>
        public Task<Models.Migration> Retry(string migrationId)
        {
            if (migrationId == "")
            {
                throw new AppwriteException("Missing required parameter: \"migrationId\"");
            }

            var apiPath = "/migrations/{migrationId}"
                .Replace("{migrationId}", Client.EncodePath(migrationId));

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Migration Convert(Dictionary<string, object> it)
            {
                return Models.Migration.From(map: it);
            }

            return _client.Call<Models.Migration>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a migration by its unique ID. This endpoint allows you to remove a
        /// migration from your project's migration history. 
        /// </para>
        /// </summary>
        public Task<object> Delete(string migrationId)
        {
            if (migrationId == "")
            {
                throw new AppwriteException("Missing required parameter: \"migrationId\"");
            }

            var apiPath = "/migrations/{migrationId}"
                .Replace("{migrationId}", Client.EncodePath(migrationId));

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

    }
}
