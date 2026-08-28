using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class VectorsDB : Service
    {
        public VectorsDB(Client client) : base(client)
        {
        }

        /// <para>
        /// Get a list of all databases from the current Appwrite project. You can use
        /// the search parameter to filter your results.
        /// </para>
        /// </summary>
        public Task<Models.DatabaseList> List(List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/vectorsdb";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.DatabaseList Convert(Dictionary<string, object> it)
            {
                return Models.DatabaseList.From(map: it);
            }

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
        public Task<Models.Database> Create(string databaseId, string name, bool? enabled = null, string? specification = null, long? replicas = null, string? syncMode = null)
        {
            var apiPath = "/vectorsdb";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "databaseId", databaseId },
                { "name", name },
                { "enabled", enabled },
                { "specification", specification },
                { "replicas", replicas },
                { "syncMode", syncMode }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Database Convert(Dictionary<string, object> it)
            {
                return Models.Database.From(map: it);
            }

            return _client.Call<Models.Database>(
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
            var apiPath = "/vectorsdb/specifications";

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
        /// List transactions across all databases.
        /// </para>
        /// </summary>
        public Task<Models.TransactionList> ListTransactions(List<string>? queries = null)
        {
            var apiPath = "/vectorsdb/transactions";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.TransactionList Convert(Dictionary<string, object> it)
            {
                return Models.TransactionList.From(map: it);
            }

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
            var apiPath = "/vectorsdb/transactions";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "ttl", ttl }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Transaction Convert(Dictionary<string, object> it)
            {
                return Models.Transaction.From(map: it);
            }

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
            var apiPath = "/vectorsdb/transactions/{transactionId}"
                .Replace("{transactionId}", transactionId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.Transaction Convert(Dictionary<string, object> it)
            {
                return Models.Transaction.From(map: it);
            }

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
            var apiPath = "/vectorsdb/transactions/{transactionId}"
                .Replace("{transactionId}", transactionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "commit", commit },
                { "rollback", rollback }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Transaction Convert(Dictionary<string, object> it)
            {
                return Models.Transaction.From(map: it);
            }

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
            var apiPath = "/vectorsdb/transactions/{transactionId}"
                .Replace("{transactionId}", transactionId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
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
            var apiPath = "/vectorsdb/transactions/{transactionId}/operations"
                .Replace("{transactionId}", transactionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "operations", operations }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Transaction Convert(Dictionary<string, object> it)
            {
                return Models.Transaction.From(map: it);
            }

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
            var apiPath = "/vectorsdb/{databaseId}"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.Database Convert(Dictionary<string, object> it)
            {
                return Models.Database.From(map: it);
            }

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
        public Task<Models.Database> Update(string databaseId, string name, bool? enabled = null, string? specification = null, long? replicas = null, string? syncMode = null)
        {
            var apiPath = "/vectorsdb/{databaseId}"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "enabled", enabled },
                { "specification", specification },
                { "replicas", replicas },
                { "syncMode", syncMode }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Database Convert(Dictionary<string, object> it)
            {
                return Models.Database.From(map: it);
            }

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
            var apiPath = "/vectorsdb/{databaseId}"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
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
        public Task<Models.VectorsdbCollectionList> ListCollections(string databaseId, List<string>? queries = null, string? search = null, bool? total = null)
        {
            var apiPath = "/vectorsdb/{databaseId}/collections"
                .Replace("{databaseId}", databaseId);

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


            static Models.VectorsdbCollectionList Convert(Dictionary<string, object> it)
            {
                return Models.VectorsdbCollectionList.From(map: it);
            }

            return _client.Call<Models.VectorsdbCollectionList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new Collection. Before using this route, you should create a new
        /// database resource using either a [server
        /// integration](https://appwrite.io/docs/server/databases#documentsDBCreateCollection)
        /// API or directly from your database console.
        /// </para>
        /// </summary>
        public Task<Models.VectorsdbCollection> CreateCollection(string databaseId, string collectionId, string name, long dimension, List<string>? permissions = null, bool? documentSecurity = null, bool? enabled = null)
        {
            var apiPath = "/vectorsdb/{databaseId}/collections"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "collectionId", collectionId },
                { "name", name },
                { "dimension", dimension },
                { "permissions", permissions },
                { "documentSecurity", documentSecurity },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.VectorsdbCollection Convert(Dictionary<string, object> it)
            {
                return Models.VectorsdbCollection.From(map: it);
            }

            return _client.Call<Models.VectorsdbCollection>(
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
        public Task<Models.VectorsdbCollection> GetCollection(string databaseId, string collectionId)
        {
            var apiPath = "/vectorsdb/{databaseId}/collections/{collectionId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.VectorsdbCollection Convert(Dictionary<string, object> it)
            {
                return Models.VectorsdbCollection.From(map: it);
            }

            return _client.Call<Models.VectorsdbCollection>(
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
        public Task<Models.VectorsdbCollection> UpdateCollection(string databaseId, string collectionId, string name, long? dimension = null, List<string>? permissions = null, bool? documentSecurity = null, bool? enabled = null)
        {
            var apiPath = "/vectorsdb/{databaseId}/collections/{collectionId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "dimension", dimension },
                { "permissions", permissions },
                { "documentSecurity", documentSecurity },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.VectorsdbCollection Convert(Dictionary<string, object> it)
            {
                return Models.VectorsdbCollection.From(map: it);
            }

            return _client.Call<Models.VectorsdbCollection>(
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
        public Task<object> DeleteCollection(string databaseId, string collectionId)
        {
            var apiPath = "/vectorsdb/{databaseId}/collections/{collectionId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <para>
        /// Get a list of all the user's documents in a given collection. You can use
        /// the query params to filter your results.
        /// </para>
        /// </summary>
        public Task<Models.DocumentList> ListDocuments(string databaseId, string collectionId, List<string>? queries = null, string? transactionId = null, bool? total = null, long? ttl = null)
        {
            var apiPath = "/vectorsdb/{databaseId}/collections/{collectionId}/documents"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "transactionId", transactionId },
                { "total", total },
                { "ttl", ttl }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.DocumentList Convert(Dictionary<string, object> it)
            {
                return Models.DocumentList.From(map: it);
            }

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
        /// integration](https://appwrite.io/docs/server/databases#documentsDBCreateCollection)
        /// API or directly from your database console.
        /// </para>
        /// </summary>
        public Task<Models.Document> CreateDocument(string databaseId, string collectionId, string documentId, object data, List<string>? permissions = null)
        {
            var apiPath = "/vectorsdb/{databaseId}/collections/{collectionId}/documents"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "documentId", documentId },
                { "data", data },
                { "permissions", permissions }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Document Convert(Dictionary<string, object> it)
            {
                return Models.Document.From(map: it);
            }

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
        /// integration](https://appwrite.io/docs/server/databases#documentsDBCreateCollection)
        /// API or directly from your database console.
        /// </para>
        /// </summary>
        public Task<Models.DocumentList> CreateDocuments(string databaseId, string collectionId, List<object> documents)
        {
            var apiPath = "/vectorsdb/{databaseId}/collections/{collectionId}/documents"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "documents", documents }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DocumentList Convert(Dictionary<string, object> it)
            {
                return Models.DocumentList.From(map: it);
            }

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
        /// integration](https://appwrite.io/docs/server/databases#documentsDBCreateCollection)
        /// API or directly from your database console.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.DocumentList> UpsertDocuments(string databaseId, string collectionId, List<object> documents, string? transactionId = null)
        {
            var apiPath = "/vectorsdb/{databaseId}/collections/{collectionId}/documents"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "documents", documents },
                { "transactionId", transactionId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DocumentList Convert(Dictionary<string, object> it)
            {
                return Models.DocumentList.From(map: it);
            }

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
        public Task<Models.DocumentList> UpdateDocuments(string databaseId, string collectionId, object? data = null, List<string>? queries = null, string? transactionId = null)
        {
            var apiPath = "/vectorsdb/{databaseId}/collections/{collectionId}/documents"
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
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DocumentList Convert(Dictionary<string, object> it)
            {
                return Models.DocumentList.From(map: it);
            }

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
        public Task<Models.DocumentList> DeleteDocuments(string databaseId, string collectionId, List<string>? queries = null, string? transactionId = null)
        {
            var apiPath = "/vectorsdb/{databaseId}/collections/{collectionId}/documents"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "transactionId", transactionId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DocumentList Convert(Dictionary<string, object> it)
            {
                return Models.DocumentList.From(map: it);
            }

            return _client.Call<Models.DocumentList>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a list of all the user's documents in a given collection using a POST
        /// request. This behaves identically to the list documents endpoint but
        /// accepts the queries in the request body, allowing much larger `queries`
        /// arrays than can fit in a URL query string.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.DocumentList> CreateQuery(string databaseId, string collectionId, List<string>? queries = null, string? transactionId = null, bool? total = null, long? ttl = null)
        {
            var apiPath = "/vectorsdb/{databaseId}/collections/{collectionId}/documents/query"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "transactionId", transactionId },
                { "total", total },
                { "ttl", ttl }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DocumentList Convert(Dictionary<string, object> it)
            {
                return Models.DocumentList.From(map: it);
            }

            return _client.Call<Models.DocumentList>(
                method: "POST",
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
        public Task<Models.Document> GetDocument(string databaseId, string collectionId, string documentId, List<string>? queries = null, string? transactionId = null)
        {
            var apiPath = "/vectorsdb/{databaseId}/collections/{collectionId}/documents/{documentId}"
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
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.Document Convert(Dictionary<string, object> it)
            {
                return Models.Document.From(map: it);
            }

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
        /// integration](https://appwrite.io/docs/server/databases#documentsDBCreateCollection)
        /// API or directly from your database console.
        /// </para>
        /// </summary>
        public Task<Models.Document> UpsertDocument(string databaseId, string collectionId, string documentId, object? data = null, List<string>? permissions = null, string? transactionId = null)
        {
            var apiPath = "/vectorsdb/{databaseId}/collections/{collectionId}/documents/{documentId}"
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
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Document Convert(Dictionary<string, object> it)
            {
                return Models.Document.From(map: it);
            }

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
        public Task<Models.Document> UpdateDocument(string databaseId, string collectionId, string documentId, object? data = null, List<string>? permissions = null, string? transactionId = null)
        {
            var apiPath = "/vectorsdb/{databaseId}/collections/{collectionId}/documents/{documentId}"
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
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Document Convert(Dictionary<string, object> it)
            {
                return Models.Document.From(map: it);
            }

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
        public Task<object> DeleteDocument(string databaseId, string collectionId, string documentId, string? transactionId = null)
        {
            var apiPath = "/vectorsdb/{databaseId}/collections/{collectionId}/documents/{documentId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{documentId}", documentId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "transactionId", transactionId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <para>
        /// List indexes in the collection.
        /// </para>
        /// </summary>
        public Task<Models.IndexList> ListIndexes(string databaseId, string collectionId, List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/vectorsdb/{databaseId}/collections/{collectionId}/indexes"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.IndexList Convert(Dictionary<string, object> it)
            {
                return Models.IndexList.From(map: it);
            }

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
        public Task<Models.Index> CreateIndex(string databaseId, string collectionId, string key, Appwrite.Enums.VectorsDBIndexType type, List<string> attributes, List<Appwrite.Enums.OrderBy>? orders = null, List<long>? lengths = null)
        {
            var apiPath = "/vectorsdb/{databaseId}/collections/{collectionId}/indexes"
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
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Index Convert(Dictionary<string, object> it)
            {
                return Models.Index.From(map: it);
            }

            return _client.Call<Models.Index>(
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
        public Task<Models.Index> GetIndex(string databaseId, string collectionId, string key)
        {
            var apiPath = "/vectorsdb/{databaseId}/collections/{collectionId}/indexes/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.Index Convert(Dictionary<string, object> it)
            {
                return Models.Index.From(map: it);
            }

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
        public Task<object> DeleteIndex(string databaseId, string collectionId, string key)
        {
            var apiPath = "/vectorsdb/{databaseId}/collections/{collectionId}/indexes/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

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
            var apiPath = "/vectorsdb/{databaseId}/failovers"
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
        /// List the lifecycle operations recorded for a dedicated database, newest
        /// first. Every provision, update, restore, backup and replication action is
        /// recorded here with its outcome, including an attempt that was abandoned
        /// because another worker took over the database.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabaseOperationList> ListOperations(string databaseId, string? status = null, long? limit = null, long? offset = null)
        {
            var apiPath = "/vectorsdb/{databaseId}/operations"
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
        /// Get high availability status for a dedicated database. Returns replica
        /// statuses, replication lag, and sync mode.
        /// </para>
        /// </summary>
        public Task<Models.DedicatedDatabaseReplicas> GetReplicas(string databaseId)
        {
            var apiPath = "/vectorsdb/{databaseId}/replicas"
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
        /// Get real-time health and status information for a dedicated database.
        /// Returns health status, readiness, uptime, connection info, replica status,
        /// and volume information.
        /// </para>
        /// </summary>
        public Task<Models.DatabaseStatus> GetStatus(string databaseId)
        {
            var apiPath = "/vectorsdb/{databaseId}/status"
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

    }
}
