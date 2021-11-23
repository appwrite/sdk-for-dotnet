
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Appwrite
{
    public class Database : Service
    {
        public Database(Client client) : base(client) { }

        /// <summary>
        /// List Collections
        /// <para>
        /// Get a list of all the user collections. You can use the query params to
        /// filter your results. On admin mode, this endpoint will return a list of all
        /// of the project's collections. [Learn more about different API
        /// modes](/docs/admin).
        /// </para>
        /// </summary>
        public Task<Models.CollectionList> ListCollections(string? search = null, int? limit = null, int? offset = null, OrderType orderType = OrderType.ASC)
        {
            var path = "/database/collections";

            var parameters = new Dictionary<string, object?>()
            {
                { "search", search },
                { "limit", limit },
                { "offset", offset },
                { "orderType", orderType.ToString() }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.CollectionList convert(Dictionary<string, object> it)
            {
                return Models.CollectionList.From(map: it);
            }

            return _client.Call<Models.CollectionList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.CollectionList));
        }

        /// <summary>
        /// Create Collection
        /// <para>
        /// Create a new Collection.
        /// </para>
        /// </summary>
        public Task<Models.Collection> CreateCollection(string name, List<object> read, List<object> write, List<object> rules)
        {
            var path = "/database/collections";

            var parameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "read", read },
                { "write", write },
                { "rules", rules }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Collection convert(Dictionary<string, object> it)
            {
                return Models.Collection.From(map: it);
            }

            return _client.Call<Models.Collection>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.Collection));
        }

        /// <summary>
        /// Get Collection
        /// <para>
        /// Get a collection by its unique ID. This endpoint response returns a JSON
        /// object with the collection metadata.
        /// </para>
        /// </summary>
        public Task<Models.Collection> GetCollection(string collectionId)
        {
            var path = "/database/collections/{collectionId}"
                .Replace("{collectionId}", collectionId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Collection convert(Dictionary<string, object> it)
            {
                return Models.Collection.From(map: it);
            }

            return _client.Call<Models.Collection>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.Collection));
        }

        /// <summary>
        /// Update Collection
        /// <para>
        /// Update a collection by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Collection> UpdateCollection(string collectionId, string name, List<object>? read = null, List<object>? write = null, List<object>? rules = null)
        {
            var path = "/database/collections/{collectionId}"
                .Replace("{collectionId}", collectionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "read", read },
                { "write", write },
                { "rules", rules }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Collection convert(Dictionary<string, object> it)
            {
                return Models.Collection.From(map: it);
            }

            return _client.Call<Models.Collection>(
                method: "PUT",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.Collection));
        }

        /// <summary>
        /// Delete Collection
        /// <para>
        /// Delete a collection by its unique ID. Only users with write permissions
        /// have access to delete this resource.
        /// </para>
        /// </summary>
        public Task<object> DeleteCollection(string collectionId)
        {
            var path = "/database/collections/{collectionId}"
                .Replace("{collectionId}", collectionId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "DELETE",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);
        }

        /// <summary>
        /// List Documents
        /// <para>
        /// Get a list of all the user documents. You can use the query params to
        /// filter your results. On admin mode, this endpoint will return a list of all
        /// of the project's documents. [Learn more about different API
        /// modes](/docs/admin).
        /// </para>
        /// </summary>
        public Task<Models.DocumentList> ListDocuments(string collectionId, List<object>? filters = null, int? limit = null, int? offset = null, string? orderField = null, OrderType orderType = OrderType.ASC, string? orderCast = null, string? search = null)
        {
            var path = "/database/collections/{collectionId}/documents"
                .Replace("{collectionId}", collectionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "filters", filters },
                { "limit", limit },
                { "offset", offset },
                { "orderField", orderField },
                { "orderType", orderType.ToString() },
                { "orderCast", orderCast },
                { "search", search }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.DocumentList convert(Dictionary<string, object> it)
            {
                return Models.DocumentList.From(map: it);
            }

            return _client.Call<Models.DocumentList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.DocumentList));
        }

        /// <summary>
        /// Create Document
        /// <para>
        /// Create a new Document. Before using this route, you should create a new
        /// collection resource using either a [server
        /// integration](/docs/server/database#databaseCreateCollection) API or
        /// directly from your database console.
        /// </para>
        /// </summary>
        public Task<Models.Document> CreateDocument(string collectionId, object data, List<object>? read = null, List<object>? write = null, string? parentDocument = null, string? parentProperty = null, string? parentPropertyType = null)
        {
            var path = "/database/collections/{collectionId}/documents"
                .Replace("{collectionId}", collectionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "data", data },
                { "read", read },
                { "write", write },
                { "parentDocument", parentDocument },
                { "parentProperty", parentProperty },
                { "parentPropertyType", parentPropertyType }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Document convert(Dictionary<string, object> it)
            {
                return Models.Document.From(map: it);
            }

            return _client.Call<Models.Document>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.Document));
        }

        /// <summary>
        /// Get Document
        /// <para>
        /// Get a document by its unique ID. This endpoint response returns a JSON
        /// object with the document data.
        /// </para>
        /// </summary>
        public Task<Models.Document> GetDocument(string collectionId, string documentId)
        {
            var path = "/database/collections/{collectionId}/documents/{documentId}"
                .Replace("{collectionId}", collectionId)
                .Replace("{documentId}", documentId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Document convert(Dictionary<string, object> it)
            {
                return Models.Document.From(map: it);
            }

            return _client.Call<Models.Document>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.Document));
        }

        /// <summary>
        /// Update Document
        /// <para>
        /// Update a document by its unique ID. Using the patch method you can pass
        /// only specific fields that will get updated.
        /// </para>
        /// </summary>
        public Task<Models.Document> UpdateDocument(string collectionId, string documentId, object data, List<object>? read = null, List<object>? write = null)
        {
            var path = "/database/collections/{collectionId}/documents/{documentId}"
                .Replace("{collectionId}", collectionId)
                .Replace("{documentId}", documentId);

            var parameters = new Dictionary<string, object?>()
            {
                { "data", data },
                { "read", read },
                { "write", write }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Document convert(Dictionary<string, object> it)
            {
                return Models.Document.From(map: it);
            }

            return _client.Call<Models.Document>(
                method: "PATCH",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.Document));
        }

        /// <summary>
        /// Delete Document
        /// <para>
        /// Delete a document by its unique ID. This endpoint deletes only the parent
        /// documents, its attributes and relations to other documents. Child documents
        /// **will not** be deleted.
        /// </para>
        /// </summary>
        public Task<object> DeleteDocument(string collectionId, string documentId)
        {
            var path = "/database/collections/{collectionId}/documents/{documentId}"
                .Replace("{collectionId}", collectionId)
                .Replace("{documentId}", documentId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "DELETE",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);
        }
    };
}