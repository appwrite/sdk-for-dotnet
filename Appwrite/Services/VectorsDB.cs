
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

        /// </summary>
        public Task<Models.DatabaseList> List(List<string>? queries = null, string? search = null, bool? total = null)
        {
            var apiPath = "/vectorsdb";

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

        /// </summary>
        public Task<Models.Database> Create(string databaseId, string name, bool? enabled = null)
        {
            var apiPath = "/vectorsdb";

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

        /// </summary>
        public Task<Models.EmbeddingList> CreateTextEmbeddings(List<string> texts, Appwrite.Enums.Model? model = null)
        {
            var apiPath = "/vectorsdb/embeddings/text";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "texts", texts },
                { "model", model?.Value }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.EmbeddingList Convert(Dictionary<string, object> it) =>
                Models.EmbeddingList.From(map: it);

            return _client.Call<Models.EmbeddingList>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

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
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

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

        /// </summary>
        public Task<Models.Database> Update(string databaseId, string name, bool? enabled = null)
        {
            var apiPath = "/vectorsdb/{databaseId}"
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
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

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
            };


            static Models.VectorsdbCollectionList Convert(Dictionary<string, object> it) =>
                Models.VectorsdbCollectionList.From(map: it);

            return _client.Call<Models.VectorsdbCollectionList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

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
                { "content-type", "application/json" }
            };


            static Models.VectorsdbCollection Convert(Dictionary<string, object> it) =>
                Models.VectorsdbCollection.From(map: it);

            return _client.Call<Models.VectorsdbCollection>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

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
            };


            static Models.VectorsdbCollection Convert(Dictionary<string, object> it) =>
                Models.VectorsdbCollection.From(map: it);

            return _client.Call<Models.VectorsdbCollection>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

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
                { "content-type", "application/json" }
            };


            static Models.VectorsdbCollection Convert(Dictionary<string, object> it) =>
                Models.VectorsdbCollection.From(map: it);

            return _client.Call<Models.VectorsdbCollection>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

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
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

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
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

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
