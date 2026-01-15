
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class TablesDB : Service
    {
        public TablesDB(Client client) : base(client)
        {
        }

        /// <para>
        /// Get a list of all databases from the current Appwrite project. You can use
        /// the search parameter to filter your results.
        /// </para>
        /// </summary>
        public Task<Models.DatabaseList> List(List<string>? queries = null, string? search = null, bool? total = null)
        {
            var apiPath = "/tablesdb";

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
        public Task<Models.Database> Create(string databaseId, string name, bool? enabled = null)
        {
            var apiPath = "/tablesdb";

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
            var apiPath = "/tablesdb/transactions";

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
            var apiPath = "/tablesdb/transactions";

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
            var apiPath = "/tablesdb/transactions/{transactionId}"
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
            var apiPath = "/tablesdb/transactions/{transactionId}"
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
            var apiPath = "/tablesdb/transactions/{transactionId}"
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
            var apiPath = "/tablesdb/transactions/{transactionId}/operations"
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
        public Task<Models.Database> Get(string databaseId)
        {
            var apiPath = "/tablesdb/{databaseId}"
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
        public Task<Models.Database> Update(string databaseId, string name, bool? enabled = null)
        {
            var apiPath = "/tablesdb/{databaseId}"
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
        public Task<object> Delete(string databaseId)
        {
            var apiPath = "/tablesdb/{databaseId}"
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
        /// Get a list of all tables that belong to the provided databaseId. You can
        /// use the search parameter to filter your results.
        /// </para>
        /// </summary>
        public Task<Models.TableList> ListTables(string databaseId, List<string>? queries = null, string? search = null, bool? total = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables"
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


            static Models.TableList Convert(Dictionary<string, object> it) =>
                Models.TableList.From(map: it);

            return _client.Call<Models.TableList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new Table. Before using this route, you should create a new
        /// database resource using either a [server
        /// integration](https://appwrite.io/docs/references/cloud/server-dart/tablesDB#createTable)
        /// API or directly from your database console.
        /// </para>
        /// </summary>
        public Task<Models.Table> CreateTable(string databaseId, string tableId, string name, List<string>? permissions = null, bool? rowSecurity = null, bool? enabled = null, List<object>? columns = null, List<object>? indexes = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "tableId", tableId },
                { "name", name },
                { "permissions", permissions },
                { "rowSecurity", rowSecurity },
                { "enabled", enabled },
                { "columns", columns },
                { "indexes", indexes }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Table Convert(Dictionary<string, object> it) =>
                Models.Table.From(map: it);

            return _client.Call<Models.Table>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a table by its unique ID. This endpoint response returns a JSON object
        /// with the table metadata.
        /// </para>
        /// </summary>
        public Task<Models.Table> GetTable(string databaseId, string tableId)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.Table Convert(Dictionary<string, object> it) =>
                Models.Table.From(map: it);

            return _client.Call<Models.Table>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a table by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Table> UpdateTable(string databaseId, string tableId, string name, List<string>? permissions = null, bool? rowSecurity = null, bool? enabled = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "permissions", permissions },
                { "rowSecurity", rowSecurity },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Table Convert(Dictionary<string, object> it) =>
                Models.Table.From(map: it);

            return _client.Call<Models.Table>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a table by its unique ID. Only users with write permissions have
        /// access to delete this resource.
        /// </para>
        /// </summary>
        public Task<object> DeleteTable(string databaseId, string tableId)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId);

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
        /// List columns in the table.
        /// </para>
        /// </summary>
        public Task<Models.ColumnList> ListColumns(string databaseId, string tableId, List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.ColumnList Convert(Dictionary<string, object> it) =>
                Models.ColumnList.From(map: it);

            return _client.Call<Models.ColumnList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a boolean column.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.ColumnBoolean> CreateBooleanColumn(string databaseId, string tableId, string key, bool required, bool? xdefault = null, bool? array = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/boolean"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId);

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


            static Models.ColumnBoolean Convert(Dictionary<string, object> it) =>
                Models.ColumnBoolean.From(map: it);

            return _client.Call<Models.ColumnBoolean>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a boolean column. Changing the `default` value will not update
        /// already existing rows.
        /// </para>
        /// </summary>
        public Task<Models.ColumnBoolean> UpdateBooleanColumn(string databaseId, string tableId, string key, bool required, bool xdefault, string? newKey = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/boolean/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId)
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


            static Models.ColumnBoolean Convert(Dictionary<string, object> it) =>
                Models.ColumnBoolean.From(map: it);

            return _client.Call<Models.ColumnBoolean>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a date time column according to the ISO 8601 standard.
        /// </para>
        /// </summary>
        public Task<Models.ColumnDatetime> CreateDatetimeColumn(string databaseId, string tableId, string key, bool required, string? xdefault = null, bool? array = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/datetime"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId);

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


            static Models.ColumnDatetime Convert(Dictionary<string, object> it) =>
                Models.ColumnDatetime.From(map: it);

            return _client.Call<Models.ColumnDatetime>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a date time column. Changing the `default` value will not update
        /// already existing rows.
        /// </para>
        /// </summary>
        public Task<Models.ColumnDatetime> UpdateDatetimeColumn(string databaseId, string tableId, string key, bool required, string xdefault, string? newKey = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/datetime/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId)
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


            static Models.ColumnDatetime Convert(Dictionary<string, object> it) =>
                Models.ColumnDatetime.From(map: it);

            return _client.Call<Models.ColumnDatetime>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create an email column.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.ColumnEmail> CreateEmailColumn(string databaseId, string tableId, string key, bool required, string? xdefault = null, bool? array = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/email"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId);

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


            static Models.ColumnEmail Convert(Dictionary<string, object> it) =>
                Models.ColumnEmail.From(map: it);

            return _client.Call<Models.ColumnEmail>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an email column. Changing the `default` value will not update
        /// already existing rows.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.ColumnEmail> UpdateEmailColumn(string databaseId, string tableId, string key, bool required, string xdefault, string? newKey = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/email/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId)
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


            static Models.ColumnEmail Convert(Dictionary<string, object> it) =>
                Models.ColumnEmail.From(map: it);

            return _client.Call<Models.ColumnEmail>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create an enumeration column. The `elements` param acts as a white-list of
        /// accepted values for this column.
        /// </para>
        /// </summary>
        public Task<Models.ColumnEnum> CreateEnumColumn(string databaseId, string tableId, string key, List<string> elements, bool required, string? xdefault = null, bool? array = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/enum"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId);

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


            static Models.ColumnEnum Convert(Dictionary<string, object> it) =>
                Models.ColumnEnum.From(map: it);

            return _client.Call<Models.ColumnEnum>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an enum column. Changing the `default` value will not update already
        /// existing rows.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.ColumnEnum> UpdateEnumColumn(string databaseId, string tableId, string key, List<string> elements, bool required, string xdefault, string? newKey = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/enum/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId)
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


            static Models.ColumnEnum Convert(Dictionary<string, object> it) =>
                Models.ColumnEnum.From(map: it);

            return _client.Call<Models.ColumnEnum>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a float column. Optionally, minimum and maximum values can be
        /// provided.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.ColumnFloat> CreateFloatColumn(string databaseId, string tableId, string key, bool required, double? min = null, double? max = null, double? xdefault = null, bool? array = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/float"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId);

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


            static Models.ColumnFloat Convert(Dictionary<string, object> it) =>
                Models.ColumnFloat.From(map: it);

            return _client.Call<Models.ColumnFloat>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a float column. Changing the `default` value will not update already
        /// existing rows.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.ColumnFloat> UpdateFloatColumn(string databaseId, string tableId, string key, bool required, double xdefault, double? min = null, double? max = null, string? newKey = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/float/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId)
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


            static Models.ColumnFloat Convert(Dictionary<string, object> it) =>
                Models.ColumnFloat.From(map: it);

            return _client.Call<Models.ColumnFloat>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create an integer column. Optionally, minimum and maximum values can be
        /// provided.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.ColumnInteger> CreateIntegerColumn(string databaseId, string tableId, string key, bool required, long? min = null, long? max = null, long? xdefault = null, bool? array = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/integer"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId);

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


            static Models.ColumnInteger Convert(Dictionary<string, object> it) =>
                Models.ColumnInteger.From(map: it);

            return _client.Call<Models.ColumnInteger>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an integer column. Changing the `default` value will not update
        /// already existing rows.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.ColumnInteger> UpdateIntegerColumn(string databaseId, string tableId, string key, bool required, long xdefault, long? min = null, long? max = null, string? newKey = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/integer/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId)
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


            static Models.ColumnInteger Convert(Dictionary<string, object> it) =>
                Models.ColumnInteger.From(map: it);

            return _client.Call<Models.ColumnInteger>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create IP address column.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.ColumnIp> CreateIpColumn(string databaseId, string tableId, string key, bool required, string? xdefault = null, bool? array = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/ip"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId);

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


            static Models.ColumnIp Convert(Dictionary<string, object> it) =>
                Models.ColumnIp.From(map: it);

            return _client.Call<Models.ColumnIp>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an ip column. Changing the `default` value will not update already
        /// existing rows.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.ColumnIp> UpdateIpColumn(string databaseId, string tableId, string key, bool required, string xdefault, string? newKey = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/ip/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId)
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


            static Models.ColumnIp Convert(Dictionary<string, object> it) =>
                Models.ColumnIp.From(map: it);

            return _client.Call<Models.ColumnIp>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a geometric line column.
        /// </para>
        /// </summary>
        public Task<Models.ColumnLine> CreateLineColumn(string databaseId, string tableId, string key, bool required, List<object>? xdefault = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/line"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId);

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


            static Models.ColumnLine Convert(Dictionary<string, object> it) =>
                Models.ColumnLine.From(map: it);

            return _client.Call<Models.ColumnLine>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a line column. Changing the `default` value will not update already
        /// existing rows.
        /// </para>
        /// </summary>
        public Task<Models.ColumnLine> UpdateLineColumn(string databaseId, string tableId, string key, bool required, List<object>? xdefault = null, string? newKey = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/line/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId)
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


            static Models.ColumnLine Convert(Dictionary<string, object> it) =>
                Models.ColumnLine.From(map: it);

            return _client.Call<Models.ColumnLine>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a geometric point column.
        /// </para>
        /// </summary>
        public Task<Models.ColumnPoint> CreatePointColumn(string databaseId, string tableId, string key, bool required, List<object>? xdefault = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/point"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId);

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


            static Models.ColumnPoint Convert(Dictionary<string, object> it) =>
                Models.ColumnPoint.From(map: it);

            return _client.Call<Models.ColumnPoint>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a point column. Changing the `default` value will not update already
        /// existing rows.
        /// </para>
        /// </summary>
        public Task<Models.ColumnPoint> UpdatePointColumn(string databaseId, string tableId, string key, bool required, List<object>? xdefault = null, string? newKey = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/point/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId)
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


            static Models.ColumnPoint Convert(Dictionary<string, object> it) =>
                Models.ColumnPoint.From(map: it);

            return _client.Call<Models.ColumnPoint>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a geometric polygon column.
        /// </para>
        /// </summary>
        public Task<Models.ColumnPolygon> CreatePolygonColumn(string databaseId, string tableId, string key, bool required, List<object>? xdefault = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/polygon"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId);

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


            static Models.ColumnPolygon Convert(Dictionary<string, object> it) =>
                Models.ColumnPolygon.From(map: it);

            return _client.Call<Models.ColumnPolygon>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a polygon column. Changing the `default` value will not update
        /// already existing rows.
        /// </para>
        /// </summary>
        public Task<Models.ColumnPolygon> UpdatePolygonColumn(string databaseId, string tableId, string key, bool required, List<object>? xdefault = null, string? newKey = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/polygon/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId)
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


            static Models.ColumnPolygon Convert(Dictionary<string, object> it) =>
                Models.ColumnPolygon.From(map: it);

            return _client.Call<Models.ColumnPolygon>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create relationship column. [Learn more about relationship
        /// columns](https://appwrite.io/docs/databases-relationships#relationship-columns).
        /// 
        /// </para>
        /// </summary>
        public Task<Models.ColumnRelationship> CreateRelationshipColumn(string databaseId, string tableId, string relatedTableId, Appwrite.Enums.RelationshipType type, bool? twoWay = null, string? key = null, string? twoWayKey = null, Appwrite.Enums.RelationMutate? onDelete = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/relationship"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "relatedTableId", relatedTableId },
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


            static Models.ColumnRelationship Convert(Dictionary<string, object> it) =>
                Models.ColumnRelationship.From(map: it);

            return _client.Call<Models.ColumnRelationship>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a string column.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.ColumnString> CreateStringColumn(string databaseId, string tableId, string key, long size, bool required, string? xdefault = null, bool? array = null, bool? encrypt = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/string"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId);

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


            static Models.ColumnString Convert(Dictionary<string, object> it) =>
                Models.ColumnString.From(map: it);

            return _client.Call<Models.ColumnString>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a string column. Changing the `default` value will not update
        /// already existing rows.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.ColumnString> UpdateStringColumn(string databaseId, string tableId, string key, bool required, string xdefault, long? size = null, string? newKey = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/string/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId)
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


            static Models.ColumnString Convert(Dictionary<string, object> it) =>
                Models.ColumnString.From(map: it);

            return _client.Call<Models.ColumnString>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a URL column.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.ColumnUrl> CreateUrlColumn(string databaseId, string tableId, string key, bool required, string? xdefault = null, bool? array = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/url"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId);

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


            static Models.ColumnUrl Convert(Dictionary<string, object> it) =>
                Models.ColumnUrl.From(map: it);

            return _client.Call<Models.ColumnUrl>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an url column. Changing the `default` value will not update already
        /// existing rows.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.ColumnUrl> UpdateUrlColumn(string databaseId, string tableId, string key, bool required, string xdefault, string? newKey = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/url/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId)
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


            static Models.ColumnUrl Convert(Dictionary<string, object> it) =>
                Models.ColumnUrl.From(map: it);

            return _client.Call<Models.ColumnUrl>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get column by ID.
        /// </para>
        /// </summary>
        public Task<object> GetColumn(string databaseId, string tableId, string key)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId)
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
        /// Deletes a column.
        /// </para>
        /// </summary>
        public Task<object> DeleteColumn(string databaseId, string tableId, string key)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId)
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
        /// Update relationship column. [Learn more about relationship
        /// columns](https://appwrite.io/docs/databases-relationships#relationship-columns).
        /// 
        /// </para>
        /// </summary>
        public Task<Models.ColumnRelationship> UpdateRelationshipColumn(string databaseId, string tableId, string key, Appwrite.Enums.RelationMutate? onDelete = null, string? newKey = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/columns/{key}/relationship"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId)
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


            static Models.ColumnRelationship Convert(Dictionary<string, object> it) =>
                Models.ColumnRelationship.From(map: it);

            return _client.Call<Models.ColumnRelationship>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// List indexes on the table.
        /// </para>
        /// </summary>
        public Task<Models.ColumnIndexList> ListIndexes(string databaseId, string tableId, List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/indexes"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.ColumnIndexList Convert(Dictionary<string, object> it) =>
                Models.ColumnIndexList.From(map: it);

            return _client.Call<Models.ColumnIndexList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Creates an index on the columns listed. Your index should include all the
        /// columns you will query in a single request.
        /// Type can be `key`, `fulltext`, or `unique`.
        /// </para>
        /// </summary>
        public Task<Models.ColumnIndex> CreateIndex(string databaseId, string tableId, string key, Appwrite.Enums.IndexType type, List<string> columns, List<string>? orders = null, List<long>? lengths = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/indexes"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "type", type?.Value },
                { "columns", columns },
                { "orders", orders },
                { "lengths", lengths }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.ColumnIndex Convert(Dictionary<string, object> it) =>
                Models.ColumnIndex.From(map: it);

            return _client.Call<Models.ColumnIndex>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get index by ID.
        /// </para>
        /// </summary>
        public Task<Models.ColumnIndex> GetIndex(string databaseId, string tableId, string key)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/indexes/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId)
                .Replace("{key}", key);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.ColumnIndex Convert(Dictionary<string, object> it) =>
                Models.ColumnIndex.From(map: it);

            return _client.Call<Models.ColumnIndex>(
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
        public Task<object> DeleteIndex(string databaseId, string tableId, string key)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/indexes/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId)
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
        /// Get a list of all the user's rows in a given table. You can use the query
        /// params to filter your results.
        /// </para>
        /// </summary>
        public Task<Models.RowList> ListRows(string databaseId, string tableId, List<string>? queries = null, string? transactionId = null, bool? total = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/rows"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "transactionId", transactionId },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.RowList Convert(Dictionary<string, object> it) =>
                Models.RowList.From(map: it);

            return _client.Call<Models.RowList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new Row. Before using this route, you should create a new table
        /// resource using either a [server
        /// integration](https://appwrite.io/docs/references/cloud/server-dart/tablesDB#createTable)
        /// API or directly from your database console.
        /// </para>
        /// </summary>
        public Task<Models.Row> CreateRow(string databaseId, string tableId, string rowId, object data, List<string>? permissions = null, string? transactionId = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/rows"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "rowId", rowId },
                { "data", data },
                { "permissions", permissions },
                { "transactionId", transactionId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Row Convert(Dictionary<string, object> it) =>
                Models.Row.From(map: it);

            return _client.Call<Models.Row>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create new Rows. Before using this route, you should create a new table
        /// resource using either a [server
        /// integration](https://appwrite.io/docs/references/cloud/server-dart/tablesDB#createTable)
        /// API or directly from your database console.
        /// </para>
        /// </summary>
        public Task<Models.RowList> CreateRows(string databaseId, string tableId, List<object> rows, string? transactionId = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/rows"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "rows", rows },
                { "transactionId", transactionId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.RowList Convert(Dictionary<string, object> it) =>
                Models.RowList.From(map: it);

            return _client.Call<Models.RowList>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create or update Rows. Before using this route, you should create a new
        /// table resource using either a [server
        /// integration](https://appwrite.io/docs/references/cloud/server-dart/tablesDB#createTable)
        /// API or directly from your database console.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.RowList> UpsertRows(string databaseId, string tableId, List<object> rows, string? transactionId = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/rows"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "rows", rows },
                { "transactionId", transactionId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.RowList Convert(Dictionary<string, object> it) =>
                Models.RowList.From(map: it);

            return _client.Call<Models.RowList>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update all rows that match your queries, if no queries are submitted then
        /// all rows are updated. You can pass only specific fields to be updated.
        /// </para>
        /// </summary>
        public Task<Models.RowList> UpdateRows(string databaseId, string tableId, object? data = null, List<string>? queries = null, string? transactionId = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/rows"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId);

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


            static Models.RowList Convert(Dictionary<string, object> it) =>
                Models.RowList.From(map: it);

            return _client.Call<Models.RowList>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Bulk delete rows using queries, if no queries are passed then all rows are
        /// deleted.
        /// </para>
        /// </summary>
        public Task<Models.RowList> DeleteRows(string databaseId, string tableId, List<string>? queries = null, string? transactionId = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/rows"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "transactionId", transactionId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.RowList Convert(Dictionary<string, object> it) =>
                Models.RowList.From(map: it);

            return _client.Call<Models.RowList>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a row by its unique ID. This endpoint response returns a JSON object
        /// with the row data.
        /// </para>
        /// </summary>
        public Task<Models.Row> GetRow(string databaseId, string tableId, string rowId, List<string>? queries = null, string? transactionId = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/rows/{rowId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId)
                .Replace("{rowId}", rowId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "transactionId", transactionId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.Row Convert(Dictionary<string, object> it) =>
                Models.Row.From(map: it);

            return _client.Call<Models.Row>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create or update a Row. Before using this route, you should create a new
        /// table resource using either a [server
        /// integration](https://appwrite.io/docs/references/cloud/server-dart/tablesDB#createTable)
        /// API or directly from your database console.
        /// </para>
        /// </summary>
        public Task<Models.Row> UpsertRow(string databaseId, string tableId, string rowId, object? data = null, List<string>? permissions = null, string? transactionId = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/rows/{rowId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId)
                .Replace("{rowId}", rowId);

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


            static Models.Row Convert(Dictionary<string, object> it) =>
                Models.Row.From(map: it);

            return _client.Call<Models.Row>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a row by its unique ID. Using the patch method you can pass only
        /// specific fields that will get updated.
        /// </para>
        /// </summary>
        public Task<Models.Row> UpdateRow(string databaseId, string tableId, string rowId, object? data = null, List<string>? permissions = null, string? transactionId = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/rows/{rowId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId)
                .Replace("{rowId}", rowId);

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


            static Models.Row Convert(Dictionary<string, object> it) =>
                Models.Row.From(map: it);

            return _client.Call<Models.Row>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a row by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> DeleteRow(string databaseId, string tableId, string rowId, string? transactionId = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/rows/{rowId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId)
                .Replace("{rowId}", rowId);

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
        /// Decrement a specific column of a row by a given value.
        /// </para>
        /// </summary>
        public Task<Models.Row> DecrementRowColumn(string databaseId, string tableId, string rowId, string column, double? xvalue = null, double? min = null, string? transactionId = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/rows/{rowId}/{column}/decrement"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId)
                .Replace("{rowId}", rowId)
                .Replace("{column}", column);

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


            static Models.Row Convert(Dictionary<string, object> it) =>
                Models.Row.From(map: it);

            return _client.Call<Models.Row>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Increment a specific column of a row by a given value.
        /// </para>
        /// </summary>
        public Task<Models.Row> IncrementRowColumn(string databaseId, string tableId, string rowId, string column, double? xvalue = null, double? max = null, string? transactionId = null)
        {
            var apiPath = "/tablesdb/{databaseId}/tables/{tableId}/rows/{rowId}/{column}/increment"
                .Replace("{databaseId}", databaseId)
                .Replace("{tableId}", tableId)
                .Replace("{rowId}", rowId)
                .Replace("{column}", column);

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


            static Models.Row Convert(Dictionary<string, object> it) =>
                Models.Row.From(map: it);

            return _client.Call<Models.Row>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

    }
}
