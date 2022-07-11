
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Appwrite.Models;

namespace Appwrite
{
    public class Databases : Service
    {

        public string DatabaseId { get; set; }


        public Databases(Client client, string databaseId) : base(client)
        {
            DatabaseId = databaseId;
        }

        /// <summary>
        /// List Databases
        /// </summary>
        public Task<Models.DatabaseList> List(string? search = null, long? limit = null, long? offset = null, string? cursor = null, string? cursorDirection = null, OrderType orderType = OrderType.ASC)
        {
            var path = "/databases";

            var parameters = new Dictionary<string, object?>()
            {
                { "search", search },
                { "limit", limit },
                { "offset", offset },
                { "cursor", cursor },
                { "cursorDirection", cursorDirection },
                { "orderType", orderType.ToString() }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.DatabaseList Convert(Dictionary<string, object> it) =>
                Models.DatabaseList.From(map: it);


            return _client.Call<Models.DatabaseList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Create Database
        /// </summary>
        public Task<Models.Database> Create(string name)
        {
            var path = "/databases";

            var parameters = new Dictionary<string, object?>()
            {
                { "databaseId", DatabaseId },
                { "name", name }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Database Convert(Dictionary<string, object> it) =>
                Models.Database.From(map: it);


            return _client.Call<Models.Database>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Get Database
        /// </summary>
        public Task<Models.Collection> Get()
        {
            var path = "/databases/{databaseId}"
                .Replace("{databaseId}", databaseId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Collection Convert(Dictionary<string, object> it) =>
                Models.Collection.From(map: it);


            return _client.Call<Models.Collection>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Update Database
        /// </summary>
        public Task<Models.Collection> Update(string name)
        {
            var path = "/databases/{databaseId}"
                .Replace("{databaseId}", databaseId);

            var parameters = new Dictionary<string, object?>()
            {
                { "name", name }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Collection Convert(Dictionary<string, object> it) =>
                Models.Collection.From(map: it);


            return _client.Call<Models.Collection>(
                method: "PUT",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Delete Database
        /// </summary>
        public Task<object> Delete()
        {
            var path = "/databases/{databaseId}"
                .Replace("{databaseId}", databaseId);

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
        /// List Collections
        /// </summary>
        public Task<Models.CollectionList> ListCollections(string? search = null, long? limit = null, long? offset = null, string? cursor = null, string? cursorDirection = null, OrderType orderType = OrderType.ASC)
        {
            var path = "/databases/{databaseId}/collections"
                .Replace("{databaseId}", databaseId);

            var parameters = new Dictionary<string, object?>()
            {
                { "search", search },
                { "limit", limit },
                { "offset", offset },
                { "cursor", cursor },
                { "cursorDirection", cursorDirection },
                { "orderType", orderType.ToString() }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.CollectionList Convert(Dictionary<string, object> it) =>
                Models.CollectionList.From(map: it);


            return _client.Call<Models.CollectionList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Create Collection
        /// </summary>
        public Task<Models.Collection> CreateCollection(string collectionId, string name, string permission, List<object> read, List<object> write)
        {
            var path = "/databases/{databaseId}/collections"
                .Replace("{databaseId}", databaseId);

            var parameters = new Dictionary<string, object?>()
            {
                { "collectionId", collectionId },
                { "name", name },
                { "permission", permission },
                { "read", read },
                { "write", write }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Collection Convert(Dictionary<string, object> it) =>
                Models.Collection.From(map: it);


            return _client.Call<Models.Collection>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Get Collection
        /// </summary>
        public Task<Models.Collection> GetCollection(string collectionId)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Collection Convert(Dictionary<string, object> it) =>
                Models.Collection.From(map: it);


            return _client.Call<Models.Collection>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Update Collection
        /// </summary>
        public Task<Models.Collection> UpdateCollection(string collectionId, string name, string permission, List<object>? read = null, List<object>? write = null, bool? enabled = null)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "permission", permission },
                { "read", read },
                { "write", write },
                { "enabled", enabled }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Collection Convert(Dictionary<string, object> it) =>
                Models.Collection.From(map: it);


            return _client.Call<Models.Collection>(
                method: "PUT",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Delete Collection
        /// </summary>
        public Task<object> DeleteCollection(string collectionId)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}"
                .Replace("{databaseId}", databaseId)
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
        /// List Attributes
        /// </summary>
        public Task<Models.AttributeList> ListAttributes(string collectionId)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/attributes"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeList Convert(Dictionary<string, object> it) =>
                Models.AttributeList.From(map: it);


            return _client.Call<Models.AttributeList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Create Boolean Attribute
        /// </summary>
        public Task<Models.AttributeBoolean> CreateBooleanAttribute(string collectionId, string key, bool required, bool? xdefault = null, bool? array = null)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/attributes/boolean"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "required", required },
                { "default", xdefault },
                { "array", array }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeBoolean Convert(Dictionary<string, object> it) =>
                Models.AttributeBoolean.From(map: it);


            return _client.Call<Models.AttributeBoolean>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Create Email Attribute
        /// </summary>
        public Task<Models.AttributeEmail> CreateEmailAttribute(string collectionId, string key, bool required, string? xdefault = null, bool? array = null)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/attributes/email"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "required", required },
                { "default", xdefault },
                { "array", array }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeEmail Convert(Dictionary<string, object> it) =>
                Models.AttributeEmail.From(map: it);


            return _client.Call<Models.AttributeEmail>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Create Enum Attribute
        /// </summary>
        public Task<Models.AttributeEnum> CreateEnumAttribute(string collectionId, string key, List<object> elements, bool required, string? xdefault = null, bool? array = null)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/attributes/enum"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "elements", elements },
                { "required", required },
                { "default", xdefault },
                { "array", array }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeEnum Convert(Dictionary<string, object> it) =>
                Models.AttributeEnum.From(map: it);


            return _client.Call<Models.AttributeEnum>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Create Float Attribute
        /// </summary>
        public Task<Models.AttributeFloat> CreateFloatAttribute(string collectionId, string key, bool required, double? min = null, double? max = null, double? xdefault = null, bool? array = null)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/attributes/float"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "required", required },
                { "min", min },
                { "max", max },
                { "default", xdefault },
                { "array", array }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeFloat Convert(Dictionary<string, object> it) =>
                Models.AttributeFloat.From(map: it);


            return _client.Call<Models.AttributeFloat>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Create Integer Attribute
        /// </summary>
        public Task<Models.AttributeInteger> CreateIntegerAttribute(string collectionId, string key, bool required, long? min = null, long? max = null, long? xdefault = null, bool? array = null)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/attributes/integer"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "required", required },
                { "min", min },
                { "max", max },
                { "default", xdefault },
                { "array", array }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeInteger Convert(Dictionary<string, object> it) =>
                Models.AttributeInteger.From(map: it);


            return _client.Call<Models.AttributeInteger>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Create IP Address Attribute
        /// </summary>
        public Task<Models.AttributeIp> CreateIpAttribute(string collectionId, string key, bool required, string? xdefault = null, bool? array = null)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/attributes/ip"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "required", required },
                { "default", xdefault },
                { "array", array }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeIp Convert(Dictionary<string, object> it) =>
                Models.AttributeIp.From(map: it);


            return _client.Call<Models.AttributeIp>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Create String Attribute
        /// </summary>
        public Task<Models.AttributeString> CreateStringAttribute(string collectionId, string key, long size, bool required, string? xdefault = null, bool? array = null)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/attributes/string"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "size", size },
                { "required", required },
                { "default", xdefault },
                { "array", array }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeString Convert(Dictionary<string, object> it) =>
                Models.AttributeString.From(map: it);


            return _client.Call<Models.AttributeString>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Create URL Attribute
        /// </summary>
        public Task<Models.AttributeUrl> CreateUrlAttribute(string collectionId, string key, bool required, string? xdefault = null, bool? array = null)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/attributes/url"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "required", required },
                { "default", xdefault },
                { "array", array }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.AttributeUrl Convert(Dictionary<string, object> it) =>
                Models.AttributeUrl.From(map: it);


            return _client.Call<Models.AttributeUrl>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Get Attribute
        /// </summary>
        public Task<object> GetAttribute(string collectionId, string key)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/attributes/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };




            return _client.Call<object>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);
        }

        /// <summary>
        /// Delete Attribute
        /// </summary>
        public Task<object> DeleteAttribute(string collectionId, string key)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/attributes/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

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
        /// </summary>
        public Task<Models.DocumentList> ListDocuments(string collectionId, List<object>? queries = null, long? limit = null, long? offset = null, string? cursor = null, string? cursorDirection = null, List<object>? orderAttributes = null, List<object>? orderTypes = null)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/documents"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "limit", limit },
                { "offset", offset },
                { "cursor", cursor },
                { "cursorDirection", cursorDirection },
                { "orderAttributes", orderAttributes },
                { "orderTypes", orderTypes }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.DocumentList Convert(Dictionary<string, object> it) =>
                Models.DocumentList.From(map: it);


            return _client.Call<Models.DocumentList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Create Document
        /// </summary>
        public Task<Models.Document> CreateDocument(string collectionId, string documentId, object data, List<object>? read = null, List<object>? write = null)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/documents"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "documentId", documentId },
                { "data", data },
                { "read", read },
                { "write", write }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Document Convert(Dictionary<string, object> it) =>
                Models.Document.From(map: it);


            return _client.Call<Models.Document>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Get Document
        /// </summary>
        public Task<Models.Document> GetDocument(string collectionId, string documentId)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/documents/{documentId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{documentId}", documentId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Document Convert(Dictionary<string, object> it) =>
                Models.Document.From(map: it);


            return _client.Call<Models.Document>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Update Document
        /// </summary>
        public Task<Models.Document> UpdateDocument(string collectionId, string documentId, object? data = null, List<object>? read = null, List<object>? write = null)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/documents/{documentId}"
                .Replace("{databaseId}", databaseId)
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


            static Models.Document Convert(Dictionary<string, object> it) =>
                Models.Document.From(map: it);


            return _client.Call<Models.Document>(
                method: "PATCH",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Delete Document
        /// </summary>
        public Task<object> DeleteDocument(string collectionId, string documentId)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/documents/{documentId}"
                .Replace("{databaseId}", databaseId)
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

        /// <summary>
        /// List Indexes
        /// </summary>
        public Task<Models.IndexList> ListIndexes(string collectionId)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/indexes"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.IndexList Convert(Dictionary<string, object> it) =>
                Models.IndexList.From(map: it);


            return _client.Call<Models.IndexList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Create Index
        /// </summary>
        public Task<Models.Index> CreateIndex(string collectionId, string key, string type, List<object> attributes, List<object>? orders = null)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/indexes"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "type", type },
                { "attributes", attributes },
                { "orders", orders }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Index Convert(Dictionary<string, object> it) =>
                Models.Index.From(map: it);


            return _client.Call<Models.Index>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Get Index
        /// </summary>
        public Task<Models.Index> GetIndex(string collectionId, string key)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/indexes/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Index Convert(Dictionary<string, object> it) =>
                Models.Index.From(map: it);


            return _client.Call<Models.Index>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Delete Index
        /// </summary>
        public Task<object> DeleteIndex(string collectionId, string key)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/indexes/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

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
    }
}