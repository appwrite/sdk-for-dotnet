
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
        public Task<Models.MigrationList> List(List<string>? queries = null, string? search = null)
        {
            var apiPath = "/migrations";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.MigrationList Convert(Dictionary<string, object> it) =>
                Models.MigrationList.From(map: it);

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
        public Task<Models.Migration> CreateAppwriteMigration(List<string> resources, string endpoint, string projectId, string apiKey)
        {
            var apiPath = "/migrations/appwrite";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "resources", resources },
                { "endpoint", endpoint },
                { "projectId", projectId },
                { "apiKey", apiKey }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Migration Convert(Dictionary<string, object> it) =>
                Models.Migration.From(map: it);

            return _client.Call<Models.Migration>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Generate a report of the data in an Appwrite project before migrating. This
        /// endpoint analyzes the source project and returns information about the
        /// resources that can be migrated.
        /// </para>
        /// </summary>
        public Task<Models.MigrationReport> GetAppwriteReport(List<string> resources, string endpoint, string projectID, string key)
        {
            var apiPath = "/migrations/appwrite/report";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "resources", resources },
                { "endpoint", endpoint },
                { "projectID", projectID },
                { "key", key }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.MigrationReport Convert(Dictionary<string, object> it) =>
                Models.MigrationReport.From(map: it);

            return _client.Call<Models.MigrationReport>(
                method: "GET",
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
        public Task<Models.Migration> CreateCsvMigration(string bucketId, string fileId, string resourceId)
        {
            var apiPath = "/migrations/csv";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "bucketId", bucketId },
                { "fileId", fileId },
                { "resourceId", resourceId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Migration Convert(Dictionary<string, object> it) =>
                Models.Migration.From(map: it);

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
        public Task<Models.Migration> CreateFirebaseMigration(List<string> resources, string serviceAccount)
        {
            var apiPath = "/migrations/firebase";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "resources", resources },
                { "serviceAccount", serviceAccount }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Migration Convert(Dictionary<string, object> it) =>
                Models.Migration.From(map: it);

            return _client.Call<Models.Migration>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Generate a report of the data in a Firebase project before migrating. This
        /// endpoint analyzes the source project and returns information about the
        /// resources that can be migrated.
        /// </para>
        /// </summary>
        public Task<Models.MigrationReport> GetFirebaseReport(List<string> resources, string serviceAccount)
        {
            var apiPath = "/migrations/firebase/report";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "resources", resources },
                { "serviceAccount", serviceAccount }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.MigrationReport Convert(Dictionary<string, object> it) =>
                Models.MigrationReport.From(map: it);

            return _client.Call<Models.MigrationReport>(
                method: "GET",
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
        public Task<Models.Migration> CreateNHostMigration(List<string> resources, string subdomain, string region, string adminSecret, string database, string username, string password, long? port = null)
        {
            var apiPath = "/migrations/nhost";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "resources", resources },
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
                { "content-type", "application/json" }
            };


            static Models.Migration Convert(Dictionary<string, object> it) =>
                Models.Migration.From(map: it);

            return _client.Call<Models.Migration>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Generate a detailed report of the data in an NHost project before
        /// migrating. This endpoint analyzes the source project and returns
        /// information about the resources that can be migrated. 
        /// </para>
        /// </summary>
        public Task<Models.MigrationReport> GetNHostReport(List<string> resources, string subdomain, string region, string adminSecret, string database, string username, string password, long? port = null)
        {
            var apiPath = "/migrations/nhost/report";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "resources", resources },
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
            };


            static Models.MigrationReport Convert(Dictionary<string, object> it) =>
                Models.MigrationReport.From(map: it);

            return _client.Call<Models.MigrationReport>(
                method: "GET",
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
        public Task<Models.Migration> CreateSupabaseMigration(List<string> resources, string endpoint, string apiKey, string databaseHost, string username, string password, long? port = null)
        {
            var apiPath = "/migrations/supabase";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "resources", resources },
                { "endpoint", endpoint },
                { "apiKey", apiKey },
                { "databaseHost", databaseHost },
                { "username", username },
                { "password", password },
                { "port", port }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Migration Convert(Dictionary<string, object> it) =>
                Models.Migration.From(map: it);

            return _client.Call<Models.Migration>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Generate a report of the data in a Supabase project before migrating. This
        /// endpoint analyzes the source project and returns information about the
        /// resources that can be migrated. 
        /// </para>
        /// </summary>
        public Task<Models.MigrationReport> GetSupabaseReport(List<string> resources, string endpoint, string apiKey, string databaseHost, string username, string password, long? port = null)
        {
            var apiPath = "/migrations/supabase/report";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "resources", resources },
                { "endpoint", endpoint },
                { "apiKey", apiKey },
                { "databaseHost", databaseHost },
                { "username", username },
                { "password", password },
                { "port", port }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.MigrationReport Convert(Dictionary<string, object> it) =>
                Models.MigrationReport.From(map: it);

            return _client.Call<Models.MigrationReport>(
                method: "GET",
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
            var apiPath = "/migrations/{migrationId}"
                .Replace("{migrationId}", migrationId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.Migration Convert(Dictionary<string, object> it) =>
                Models.Migration.From(map: it);

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
            var apiPath = "/migrations/{migrationId}"
                .Replace("{migrationId}", migrationId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Migration Convert(Dictionary<string, object> it) =>
                Models.Migration.From(map: it);

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
            var apiPath = "/migrations/{migrationId}"
                .Replace("{migrationId}", migrationId);

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

    }
}
