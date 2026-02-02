
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Databases : Service
    {
        public Databases(Client client) : base(client)
        {
        }

        /// <para>
        /// Get a list of all databases from the current Appwrite project. You can use
        /// the search parameter to filter your results.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.list` instead.")]
        public Task<Models.DatabaseList> List(List<string>? queries = null, string? search = null, bool? total = null)
        {
            var apiPath = "/databases";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.DatabaseList Convert(Dictionary<string, object> it) =>
                Models.DatabaseList.From(map: it);

            return _client.Call<Models.DatabaseList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new Database.
        /// 
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.create` instead.")]
        public Task<Models.Database> Create(string databaseId, string name, bool? enabled = null)
        {
            var apiPath = "/databases";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "databaseId", databaseId },
                { "name", name },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Database Convert(Dictionary<string, object> it) =>
                Models.Database.From(map: it);

            return _client.Call<Models.Database>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// List transactions across all databases.
        /// </para>
        /// </summary>
        public Task<Models.TransactionList> ListTransactions(List<string>? queries = null)
        {
            var apiPath = "/databases/transactions";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.TransactionList Convert(Dictionary<string, object> it) =>
                Models.TransactionList.From(map: it);

            return _client.Call<Models.TransactionList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new transaction.
        /// </para>
        /// </summary>
        public Task<Models.Transaction> CreateTransaction(long? ttl = null)
        {
            var apiPath = "/databases/transactions";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "ttl", ttl }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Transaction Convert(Dictionary<string, object> it) =>
                Models.Transaction.From(map: it);

            return _client.Call<Models.Transaction>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a transaction by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Transaction> GetTransaction(string transactionId)
        {
            var apiPath = "/databases/transactions/{transactionId}"
                .Replace("{transactionId}", transactionId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.Transaction Convert(Dictionary<string, object> it) =>
                Models.Transaction.From(map: it);

            return _client.Call<Models.Transaction>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a transaction, to either commit or roll back its operations.
        /// </para>
        /// </summary>
        public Task<Models.Transaction> UpdateTransaction(string transactionId, bool? commit = null, bool? rollback = null)
        {
            var apiPath = "/databases/transactions/{transactionId}"
                .Replace("{transactionId}", transactionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "commit", commit },
                { "rollback", rollback }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Transaction Convert(Dictionary<string, object> it) =>
                Models.Transaction.From(map: it);

            return _client.Call<Models.Transaction>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a transaction by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> DeleteTransaction(string transactionId)
        {
            var apiPath = "/databases/transactions/{transactionId}"
                .Replace("{transactionId}", transactionId);

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
        /// Create multiple operations in a single transaction.
        /// </para>
        /// </summary>
        public Task<Models.Transaction> CreateOperations(string transactionId, List<object>? operations = null)
        {
            var apiPath = "/databases/transactions/{transactionId}/operations"
                .Replace("{transactionId}", transactionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "operations", operations }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Transaction Convert(Dictionary<string, object> it) =>
                Models.Transaction.From(map: it);

            return _client.Call<Models.Transaction>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a database by its unique ID. This endpoint response returns a JSON
        /// object with the database metadata.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.get` instead.")]
        public Task<Models.Database> Get(string databaseId)
        {
            var apiPath = "/databases/{databaseId}"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.Database Convert(Dictionary<string, object> it) =>
                Models.Database.From(map: it);

            return _client.Call<Models.Database>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a database by its unique ID.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.update` instead.")]
        public Task<Models.Database> Update(string databaseId, string? name = null, bool? enabled = null)
        {
            var apiPath = "/databases/{databaseId}"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Database Convert(Dictionary<string, object> it) =>
                Models.Database.From(map: it);

            return _client.Call<Models.Database>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a database by its unique ID. Only API keys with with databases.write
        /// scope can delete a database.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.delete` instead.")]
        public Task<object> Delete(string databaseId)
        {
            var apiPath = "/databases/{databaseId}"
                .Replace("{databaseId}", databaseId);

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
        /// Get a list of all collections that belong to the provided databaseId. You
        /// can use the search parameter to filter your results.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.listTables` instead.")]
        public Task<Models.CollectionList> ListCollections(string databaseId, List<string>? queries = null, string? search = null, bool? total = null)
        {
            var apiPath = "/databases/{databaseId}/collections"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.CollectionList Convert(Dictionary<string, object> it) =>
                Models.CollectionList.From(map: it);

            return _client.Call<Models.CollectionList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new Collection. Before using this route, you should create a new
        /// database resource using either a [server
        /// integration](https://appwrite.io/docs/server/databases#databasesCreateCollection)
        /// API or directly from your database console.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.createTable` instead.")]
        public Task<Models.Collection> CreateCollection(string databaseId, string collectionId, string name, List<string>? permissions = null, bool? documentSecurity = null, bool? enabled = null, List<object>? attributes = null, List<object>? indexes = null)
        {
            var apiPath = "/databases/{databaseId}/collections"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "collectionId", collectionId },
                { "name", name },
                { "permissions", permissions },
                { "documentSecurity", documentSecurity },
                { "enabled", enabled },
                { "attributes", attributes },
                { "indexes", indexes }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Collection Convert(Dictionary<string, object> it) =>
                Models.Collection.From(map: it);

            return _client.Call<Models.Collection>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a collection by its unique ID. This endpoint response returns a JSON
        /// object with the collection metadata.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.getTable` instead.")]
        public Task<Models.Collection> GetCollection(string databaseId, string collectionId)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.Collection Convert(Dictionary<string, object> it) =>
                Models.Collection.From(map: it);

            return _client.Call<Models.Collection>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a collection by its unique ID.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.updateTable` instead.")]
        public Task<Models.Collection> UpdateCollection(string databaseId, string collectionId, string? name = null, List<string>? permissions = null, bool? documentSecurity = null, bool? enabled = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "permissions", permissions },
                { "documentSecurity", documentSecurity },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Collection Convert(Dictionary<string, object> it) =>
                Models.Collection.From(map: it);

            return _client.Call<Models.Collection>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a collection by its unique ID. Only users with write permissions
        /// have access to delete this resource.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.deleteTable` instead.")]
        public Task<object> DeleteCollection(string databaseId, string collectionId)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

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
        /// List attributes in the collection.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.listColumns` instead.")]
        public Task<Models.AttributeList> ListAttributes(string databaseId, string collectionId, List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.AttributeList Convert(Dictionary<string, object> it) =>
                Models.AttributeList.From(map: it);

            return _client.Call<Models.AttributeList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a boolean attribute.
        /// 
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.createBooleanColumn` instead.")]
        public Task<Models.AttributeBoolean> CreateBooleanAttribute(string databaseId, string collectionId, string key, bool required, bool? xdefault = null, bool? array = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/boolean"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "required", required },
                { "default", xdefault },
                { "array", array }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeBoolean Convert(Dictionary<string, object> it) =>
                Models.AttributeBoolean.From(map: it);

            return _client.Call<Models.AttributeBoolean>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a boolean attribute. Changing the `default` value will not update
        /// already existing documents.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.updateBooleanColumn` instead.")]
        public Task<Models.AttributeBoolean> UpdateBooleanAttribute(string databaseId, string collectionId, string key, bool required, bool xdefault, string? newKey = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/boolean/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "required", required },
                { "default", xdefault },
                { "newKey", newKey }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeBoolean Convert(Dictionary<string, object> it) =>
                Models.AttributeBoolean.From(map: it);

            return _client.Call<Models.AttributeBoolean>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a date time attribute according to the ISO 8601 standard.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.createDatetimeColumn` instead.")]
        public Task<Models.AttributeDatetime> CreateDatetimeAttribute(string databaseId, string collectionId, string key, bool required, string? xdefault = null, bool? array = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/datetime"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "required", required },
                { "default", xdefault },
                { "array", array }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeDatetime Convert(Dictionary<string, object> it) =>
                Models.AttributeDatetime.From(map: it);

            return _client.Call<Models.AttributeDatetime>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a date time attribute. Changing the `default` value will not update
        /// already existing documents.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.updateDatetimeColumn` instead.")]
        public Task<Models.AttributeDatetime> UpdateDatetimeAttribute(string databaseId, string collectionId, string key, bool required, string xdefault, string? newKey = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/datetime/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "required", required },
                { "default", xdefault },
                { "newKey", newKey }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeDatetime Convert(Dictionary<string, object> it) =>
                Models.AttributeDatetime.From(map: it);

            return _client.Call<Models.AttributeDatetime>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create an email attribute.
        /// 
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.createEmailColumn` instead.")]
        public Task<Models.AttributeEmail> CreateEmailAttribute(string databaseId, string collectionId, string key, bool required, string? xdefault = null, bool? array = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/email"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "required", required },
                { "default", xdefault },
                { "array", array }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeEmail Convert(Dictionary<string, object> it) =>
                Models.AttributeEmail.From(map: it);

            return _client.Call<Models.AttributeEmail>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an email attribute. Changing the `default` value will not update
        /// already existing documents.
        /// 
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.updateEmailColumn` instead.")]
        public Task<Models.AttributeEmail> UpdateEmailAttribute(string databaseId, string collectionId, string key, bool required, string xdefault, string? newKey = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/email/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "required", required },
                { "default", xdefault },
                { "newKey", newKey }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeEmail Convert(Dictionary<string, object> it) =>
                Models.AttributeEmail.From(map: it);

            return _client.Call<Models.AttributeEmail>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create an enum attribute. The `elements` param acts as a white-list of
        /// accepted values for this attribute. 
        /// 
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.createEnumColumn` instead.")]
        public Task<Models.AttributeEnum> CreateEnumAttribute(string databaseId, string collectionId, string key, List<string> elements, bool required, string? xdefault = null, bool? array = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/enum"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "elements", elements },
                { "required", required },
                { "default", xdefault },
                { "array", array }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeEnum Convert(Dictionary<string, object> it) =>
                Models.AttributeEnum.From(map: it);

            return _client.Call<Models.AttributeEnum>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an enum attribute. Changing the `default` value will not update
        /// already existing documents.
        /// 
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.updateEnumColumn` instead.")]
        public Task<Models.AttributeEnum> UpdateEnumAttribute(string databaseId, string collectionId, string key, List<string> elements, bool required, string xdefault, string? newKey = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/enum/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "elements", elements },
                { "required", required },
                { "default", xdefault },
                { "newKey", newKey }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeEnum Convert(Dictionary<string, object> it) =>
                Models.AttributeEnum.From(map: it);

            return _client.Call<Models.AttributeEnum>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a float attribute. Optionally, minimum and maximum values can be
        /// provided.
        /// 
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.createFloatColumn` instead.")]
        public Task<Models.AttributeFloat> CreateFloatAttribute(string databaseId, string collectionId, string key, bool required, double? min = null, double? max = null, double? xdefault = null, bool? array = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/float"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "required", required },
                { "min", min },
                { "max", max },
                { "default", xdefault },
                { "array", array }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeFloat Convert(Dictionary<string, object> it) =>
                Models.AttributeFloat.From(map: it);

            return _client.Call<Models.AttributeFloat>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a float attribute. Changing the `default` value will not update
        /// already existing documents.
        /// 
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.updateFloatColumn` instead.")]
        public Task<Models.AttributeFloat> UpdateFloatAttribute(string databaseId, string collectionId, string key, bool required, double xdefault, double? min = null, double? max = null, string? newKey = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/float/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "required", required },
                { "min", min },
                { "max", max },
                { "default", xdefault },
                { "newKey", newKey }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeFloat Convert(Dictionary<string, object> it) =>
                Models.AttributeFloat.From(map: it);

            return _client.Call<Models.AttributeFloat>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create an integer attribute. Optionally, minimum and maximum values can be
        /// provided.
        /// 
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.createIntegerColumn` instead.")]
        public Task<Models.AttributeInteger> CreateIntegerAttribute(string databaseId, string collectionId, string key, bool required, long? min = null, long? max = null, long? xdefault = null, bool? array = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/integer"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "required", required },
                { "min", min },
                { "max", max },
                { "default", xdefault },
                { "array", array }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeInteger Convert(Dictionary<string, object> it) =>
                Models.AttributeInteger.From(map: it);

            return _client.Call<Models.AttributeInteger>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an integer attribute. Changing the `default` value will not update
        /// already existing documents.
        /// 
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.updateIntegerColumn` instead.")]
        public Task<Models.AttributeInteger> UpdateIntegerAttribute(string databaseId, string collectionId, string key, bool required, long xdefault, long? min = null, long? max = null, string? newKey = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/integer/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "required", required },
                { "min", min },
                { "max", max },
                { "default", xdefault },
                { "newKey", newKey }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeInteger Convert(Dictionary<string, object> it) =>
                Models.AttributeInteger.From(map: it);

            return _client.Call<Models.AttributeInteger>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create IP address attribute.
        /// 
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.createIpColumn` instead.")]
        public Task<Models.AttributeIp> CreateIpAttribute(string databaseId, string collectionId, string key, bool required, string? xdefault = null, bool? array = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/ip"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "required", required },
                { "default", xdefault },
                { "array", array }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeIp Convert(Dictionary<string, object> it) =>
                Models.AttributeIp.From(map: it);

            return _client.Call<Models.AttributeIp>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an ip attribute. Changing the `default` value will not update
        /// already existing documents.
        /// 
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.updateIpColumn` instead.")]
        public Task<Models.AttributeIp> UpdateIpAttribute(string databaseId, string collectionId, string key, bool required, string xdefault, string? newKey = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/ip/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "required", required },
                { "default", xdefault },
                { "newKey", newKey }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeIp Convert(Dictionary<string, object> it) =>
                Models.AttributeIp.From(map: it);

            return _client.Call<Models.AttributeIp>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a geometric line attribute.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.createLineColumn` instead.")]
        public Task<Models.AttributeLine> CreateLineAttribute(string databaseId, string collectionId, string key, bool required, List<object>? xdefault = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/line"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "required", required },
                { "default", xdefault }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeLine Convert(Dictionary<string, object> it) =>
                Models.AttributeLine.From(map: it);

            return _client.Call<Models.AttributeLine>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a line attribute. Changing the `default` value will not update
        /// already existing documents.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.updateLineColumn` instead.")]
        public Task<Models.AttributeLine> UpdateLineAttribute(string databaseId, string collectionId, string key, bool required, List<object>? xdefault = null, string? newKey = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/line/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "required", required },
                { "default", xdefault },
                { "newKey", newKey }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeLine Convert(Dictionary<string, object> it) =>
                Models.AttributeLine.From(map: it);

            return _client.Call<Models.AttributeLine>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a longtext attribute.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.AttributeLongtext> CreateLongtextAttribute(string databaseId, string collectionId, string key, bool required, string? xdefault = null, bool? array = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/longtext"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "required", required },
                { "default", xdefault },
                { "array", array }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeLongtext Convert(Dictionary<string, object> it) =>
                Models.AttributeLongtext.From(map: it);

            return _client.Call<Models.AttributeLongtext>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a longtext attribute. Changing the `default` value will not update
        /// already existing documents.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.AttributeLongtext> UpdateLongtextAttribute(string databaseId, string collectionId, string key, bool required, string xdefault, string? newKey = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/longtext/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "required", required },
                { "default", xdefault },
                { "newKey", newKey }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeLongtext Convert(Dictionary<string, object> it) =>
                Models.AttributeLongtext.From(map: it);

            return _client.Call<Models.AttributeLongtext>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a mediumtext attribute.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.AttributeMediumtext> CreateMediumtextAttribute(string databaseId, string collectionId, string key, bool required, string? xdefault = null, bool? array = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/mediumtext"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "required", required },
                { "default", xdefault },
                { "array", array }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeMediumtext Convert(Dictionary<string, object> it) =>
                Models.AttributeMediumtext.From(map: it);

            return _client.Call<Models.AttributeMediumtext>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a mediumtext attribute. Changing the `default` value will not update
        /// already existing documents.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.AttributeMediumtext> UpdateMediumtextAttribute(string databaseId, string collectionId, string key, bool required, string xdefault, string? newKey = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/mediumtext/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "required", required },
                { "default", xdefault },
                { "newKey", newKey }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeMediumtext Convert(Dictionary<string, object> it) =>
                Models.AttributeMediumtext.From(map: it);

            return _client.Call<Models.AttributeMediumtext>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a geometric point attribute.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.createPointColumn` instead.")]
        public Task<Models.AttributePoint> CreatePointAttribute(string databaseId, string collectionId, string key, bool required, List<object>? xdefault = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/point"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "required", required },
                { "default", xdefault }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributePoint Convert(Dictionary<string, object> it) =>
                Models.AttributePoint.From(map: it);

            return _client.Call<Models.AttributePoint>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a point attribute. Changing the `default` value will not update
        /// already existing documents.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.updatePointColumn` instead.")]
        public Task<Models.AttributePoint> UpdatePointAttribute(string databaseId, string collectionId, string key, bool required, List<object>? xdefault = null, string? newKey = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/point/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "required", required },
                { "default", xdefault },
                { "newKey", newKey }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributePoint Convert(Dictionary<string, object> it) =>
                Models.AttributePoint.From(map: it);

            return _client.Call<Models.AttributePoint>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a geometric polygon attribute.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.createPolygonColumn` instead.")]
        public Task<Models.AttributePolygon> CreatePolygonAttribute(string databaseId, string collectionId, string key, bool required, List<object>? xdefault = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/polygon"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "required", required },
                { "default", xdefault }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributePolygon Convert(Dictionary<string, object> it) =>
                Models.AttributePolygon.From(map: it);

            return _client.Call<Models.AttributePolygon>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a polygon attribute. Changing the `default` value will not update
        /// already existing documents.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.updatePolygonColumn` instead.")]
        public Task<Models.AttributePolygon> UpdatePolygonAttribute(string databaseId, string collectionId, string key, bool required, List<object>? xdefault = null, string? newKey = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/polygon/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "required", required },
                { "default", xdefault },
                { "newKey", newKey }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributePolygon Convert(Dictionary<string, object> it) =>
                Models.AttributePolygon.From(map: it);

            return _client.Call<Models.AttributePolygon>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create relationship attribute. [Learn more about relationship
        /// attributes](https://appwrite.io/docs/databases-relationships#relationship-attributes).
        /// 
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.createRelationshipColumn` instead.")]
        public Task<Models.AttributeRelationship> CreateRelationshipAttribute(string databaseId, string collectionId, string relatedCollectionId, Appwrite.Enums.RelationshipType type, bool? twoWay = null, string? key = null, string? twoWayKey = null, Appwrite.Enums.RelationMutate? onDelete = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/relationship"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "relatedCollectionId", relatedCollectionId },
                { "type", type?.Value },
                { "twoWay", twoWay },
                { "key", key },
                { "twoWayKey", twoWayKey },
                { "onDelete", onDelete?.Value }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeRelationship Convert(Dictionary<string, object> it) =>
                Models.AttributeRelationship.From(map: it);

            return _client.Call<Models.AttributeRelationship>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a string attribute.
        /// 
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.createStringColumn` instead.")]
        public Task<Models.AttributeString> CreateStringAttribute(string databaseId, string collectionId, string key, long size, bool required, string? xdefault = null, bool? array = null, bool? encrypt = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/string"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "size", size },
                { "required", required },
                { "default", xdefault },
                { "array", array },
                { "encrypt", encrypt }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeString Convert(Dictionary<string, object> it) =>
                Models.AttributeString.From(map: it);

            return _client.Call<Models.AttributeString>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a string attribute. Changing the `default` value will not update
        /// already existing documents.
        /// 
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.updateStringColumn` instead.")]
        public Task<Models.AttributeString> UpdateStringAttribute(string databaseId, string collectionId, string key, bool required, string xdefault, long? size = null, string? newKey = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/string/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "required", required },
                { "default", xdefault },
                { "size", size },
                { "newKey", newKey }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeString Convert(Dictionary<string, object> it) =>
                Models.AttributeString.From(map: it);

            return _client.Call<Models.AttributeString>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a text attribute.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.AttributeText> CreateTextAttribute(string databaseId, string collectionId, string key, bool required, string? xdefault = null, bool? array = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/text"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "required", required },
                { "default", xdefault },
                { "array", array }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeText Convert(Dictionary<string, object> it) =>
                Models.AttributeText.From(map: it);

            return _client.Call<Models.AttributeText>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a text attribute. Changing the `default` value will not update
        /// already existing documents.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.AttributeText> UpdateTextAttribute(string databaseId, string collectionId, string key, bool required, string xdefault, string? newKey = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/text/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "required", required },
                { "default", xdefault },
                { "newKey", newKey }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeText Convert(Dictionary<string, object> it) =>
                Models.AttributeText.From(map: it);

            return _client.Call<Models.AttributeText>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a URL attribute.
        /// 
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.createUrlColumn` instead.")]
        public Task<Models.AttributeUrl> CreateUrlAttribute(string databaseId, string collectionId, string key, bool required, string? xdefault = null, bool? array = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/url"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "required", required },
                { "default", xdefault },
                { "array", array }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeUrl Convert(Dictionary<string, object> it) =>
                Models.AttributeUrl.From(map: it);

            return _client.Call<Models.AttributeUrl>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an url attribute. Changing the `default` value will not update
        /// already existing documents.
        /// 
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.updateUrlColumn` instead.")]
        public Task<Models.AttributeUrl> UpdateUrlAttribute(string databaseId, string collectionId, string key, bool required, string xdefault, string? newKey = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/url/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "required", required },
                { "default", xdefault },
                { "newKey", newKey }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeUrl Convert(Dictionary<string, object> it) =>
                Models.AttributeUrl.From(map: it);

            return _client.Call<Models.AttributeUrl>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a varchar attribute.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.AttributeVarchar> CreateVarcharAttribute(string databaseId, string collectionId, string key, long size, bool required, string? xdefault = null, bool? array = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/varchar"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "size", size },
                { "required", required },
                { "default", xdefault },
                { "array", array }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeVarchar Convert(Dictionary<string, object> it) =>
                Models.AttributeVarchar.From(map: it);

            return _client.Call<Models.AttributeVarchar>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a varchar attribute. Changing the `default` value will not update
        /// already existing documents.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.AttributeVarchar> UpdateVarcharAttribute(string databaseId, string collectionId, string key, bool required, string xdefault, long? size = null, string? newKey = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/varchar/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "required", required },
                { "default", xdefault },
                { "size", size },
                { "newKey", newKey }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeVarchar Convert(Dictionary<string, object> it) =>
                Models.AttributeVarchar.From(map: it);

            return _client.Call<Models.AttributeVarchar>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get attribute by ID.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.getColumn` instead.")]
        public Task<object> GetAttribute(string databaseId, string collectionId, string key)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static object Convert(Dictionary<string, object> it) =>
                it;

            return _client.Call<object>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Deletes an attribute.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.deleteColumn` instead.")]
        public Task<object> DeleteAttribute(string databaseId, string collectionId, string key)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

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
        /// Update relationship attribute. [Learn more about relationship
        /// attributes](https://appwrite.io/docs/databases-relationships#relationship-attributes).
        /// 
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.updateRelationshipColumn` instead.")]
        public Task<Models.AttributeRelationship> UpdateRelationshipAttribute(string databaseId, string collectionId, string key, Appwrite.Enums.RelationMutate? onDelete = null, string? newKey = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/{key}/relationship"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "onDelete", onDelete?.Value },
                { "newKey", newKey }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeRelationship Convert(Dictionary<string, object> it) =>
                Models.AttributeRelationship.From(map: it);

            return _client.Call<Models.AttributeRelationship>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a list of all the user's documents in a given collection. You can use
        /// the query params to filter your results.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.listRows` instead.")]
        public Task<Models.DocumentList> ListDocuments(string databaseId, string collectionId, List<string>? queries = null, string? transactionId = null, bool? total = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/documents"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "transactionId", transactionId },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.DocumentList Convert(Dictionary<string, object> it) =>
                Models.DocumentList.From(map: it);

            return _client.Call<Models.DocumentList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new Document. Before using this route, you should create a new
        /// collection resource using either a [server
        /// integration](https://appwrite.io/docs/server/databases#databasesCreateCollection)
        /// API or directly from your database console.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.createRow` instead.")]
        public Task<Models.Document> CreateDocument(string databaseId, string collectionId, string documentId, object data, List<string>? permissions = null, string? transactionId = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/documents"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "documentId", documentId },
                { "data", data },
                { "permissions", permissions },
                { "transactionId", transactionId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Document Convert(Dictionary<string, object> it) =>
                Models.Document.From(map: it);

            return _client.Call<Models.Document>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create new Documents. Before using this route, you should create a new
        /// collection resource using either a [server
        /// integration](https://appwrite.io/docs/server/databases#databasesCreateCollection)
        /// API or directly from your database console.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.createRows` instead.")]
        public Task<Models.DocumentList> CreateDocuments(string databaseId, string collectionId, List<object> documents, string? transactionId = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/documents"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "documents", documents },
                { "transactionId", transactionId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.DocumentList Convert(Dictionary<string, object> it) =>
                Models.DocumentList.From(map: it);

            return _client.Call<Models.DocumentList>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create or update Documents. Before using this route, you should create a
        /// new collection resource using either a [server
        /// integration](https://appwrite.io/docs/server/databases#databasesCreateCollection)
        /// API or directly from your database console.
        /// 
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.upsertRows` instead.")]
        public Task<Models.DocumentList> UpsertDocuments(string databaseId, string collectionId, List<object> documents, string? transactionId = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/documents"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "documents", documents },
                { "transactionId", transactionId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.DocumentList Convert(Dictionary<string, object> it) =>
                Models.DocumentList.From(map: it);

            return _client.Call<Models.DocumentList>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update all documents that match your queries, if no queries are submitted
        /// then all documents are updated. You can pass only specific fields to be
        /// updated.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.updateRows` instead.")]
        public Task<Models.DocumentList> UpdateDocuments(string databaseId, string collectionId, object? data = null, List<string>? queries = null, string? transactionId = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/documents"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "data", data },
                { "queries", queries },
                { "transactionId", transactionId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.DocumentList Convert(Dictionary<string, object> it) =>
                Models.DocumentList.From(map: it);

            return _client.Call<Models.DocumentList>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Bulk delete documents using queries, if no queries are passed then all
        /// documents are deleted.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.deleteRows` instead.")]
        public Task<Models.DocumentList> DeleteDocuments(string databaseId, string collectionId, List<string>? queries = null, string? transactionId = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/documents"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "transactionId", transactionId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.DocumentList Convert(Dictionary<string, object> it) =>
                Models.DocumentList.From(map: it);

            return _client.Call<Models.DocumentList>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a document by its unique ID. This endpoint response returns a JSON
        /// object with the document data.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.getRow` instead.")]
        public Task<Models.Document> GetDocument(string databaseId, string collectionId, string documentId, List<string>? queries = null, string? transactionId = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/documents/{documentId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{documentId}", documentId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "transactionId", transactionId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.Document Convert(Dictionary<string, object> it) =>
                Models.Document.From(map: it);

            return _client.Call<Models.Document>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create or update a Document. Before using this route, you should create a
        /// new collection resource using either a [server
        /// integration](https://appwrite.io/docs/server/databases#databasesCreateCollection)
        /// API or directly from your database console.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.upsertRow` instead.")]
        public Task<Models.Document> UpsertDocument(string databaseId, string collectionId, string documentId, object? data = null, List<string>? permissions = null, string? transactionId = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/documents/{documentId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{documentId}", documentId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "data", data },
                { "permissions", permissions },
                { "transactionId", transactionId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Document Convert(Dictionary<string, object> it) =>
                Models.Document.From(map: it);

            return _client.Call<Models.Document>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a document by its unique ID. Using the patch method you can pass
        /// only specific fields that will get updated.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.updateRow` instead.")]
        public Task<Models.Document> UpdateDocument(string databaseId, string collectionId, string documentId, object? data = null, List<string>? permissions = null, string? transactionId = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/documents/{documentId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{documentId}", documentId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "data", data },
                { "permissions", permissions },
                { "transactionId", transactionId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Document Convert(Dictionary<string, object> it) =>
                Models.Document.From(map: it);

            return _client.Call<Models.Document>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a document by its unique ID.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.deleteRow` instead.")]
        public Task<object> DeleteDocument(string databaseId, string collectionId, string documentId, string? transactionId = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/documents/{documentId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{documentId}", documentId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "transactionId", transactionId }
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
        /// Decrement a specific attribute of a document by a given value.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.decrementRowColumn` instead.")]
        public Task<Models.Document> DecrementDocumentAttribute(string databaseId, string collectionId, string documentId, string attribute, double? xvalue = null, double? min = null, string? transactionId = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/documents/{documentId}/{attribute}/decrement"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{documentId}", documentId)
                .Replace("{attribute}", attribute);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "value", xvalue },
                { "min", min },
                { "transactionId", transactionId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Document Convert(Dictionary<string, object> it) =>
                Models.Document.From(map: it);

            return _client.Call<Models.Document>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Increment a specific attribute of a document by a given value.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.incrementRowColumn` instead.")]
        public Task<Models.Document> IncrementDocumentAttribute(string databaseId, string collectionId, string documentId, string attribute, double? xvalue = null, double? max = null, string? transactionId = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/documents/{documentId}/{attribute}/increment"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{documentId}", documentId)
                .Replace("{attribute}", attribute);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "value", xvalue },
                { "max", max },
                { "transactionId", transactionId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Document Convert(Dictionary<string, object> it) =>
                Models.Document.From(map: it);

            return _client.Call<Models.Document>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// List indexes in the collection.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.listIndexes` instead.")]
        public Task<Models.IndexList> ListIndexes(string databaseId, string collectionId, List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/indexes"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.IndexList Convert(Dictionary<string, object> it) =>
                Models.IndexList.From(map: it);

            return _client.Call<Models.IndexList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Creates an index on the attributes listed. Your index should include all
        /// the attributes you will query in a single request.
        /// Attributes can be `key`, `fulltext`, and `unique`.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.createIndex` instead.")]
        public Task<Models.Index> CreateIndex(string databaseId, string collectionId, string key, Appwrite.Enums.IndexType type, List<string> attributes, List<Appwrite.Enums.OrderBy>? orders = null, List<long>? lengths = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/indexes"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "type", type?.Value },
                { "attributes", attributes },
                { "orders", orders?.Select(e => e.Value).ToList() },
                { "lengths", lengths }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Index Convert(Dictionary<string, object> it) =>
                Models.Index.From(map: it);

            return _client.Call<Models.Index>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get an index by its unique ID.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.getIndex` instead.")]
        public Task<Models.Index> GetIndex(string databaseId, string collectionId, string key)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/indexes/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.Index Convert(Dictionary<string, object> it) =>
                Models.Index.From(map: it);

            return _client.Call<Models.Index>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete an index.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `TablesDB.deleteIndex` instead.")]
        public Task<object> DeleteIndex(string databaseId, string collectionId, string key)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/indexes/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

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
