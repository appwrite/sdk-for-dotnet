
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;

namespace Appwrite.Services
{
    public class Databases : Service
    {
        public Databases(Client client) : base(client)
        {
        }

        /// <summary>
        /// List Databases
        /// <para>
        /// Get a list of all databases from the current Appwrite project. You can use
        /// the search parameter to filter your results.
        /// </para>
        /// </summary>
        public Task<Models.DatabaseList> List(List<string>? queries = null, string? search = null)
        {
            var path = "/databases";

            var parameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search }
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
        /// <para>
        /// Create a new Database.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.Database> Create(string databaseId, string name)
        {
            var path = "/databases";

            var parameters = new Dictionary<string, object?>()
            {
                { "databaseId", databaseId },
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
        /// <para>
        /// Get a database by its unique ID. This endpoint response returns a JSON
        /// object with the database metadata.
        /// </para>
        /// </summary>
        public Task<Models.Database> Get(string databaseId)
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



            static Models.Database Convert(Dictionary<string, object> it) =>
                Models.Database.From(map: it);


            return _client.Call<Models.Database>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update Database
        /// <para>
        /// Update a database by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Database> Update(string databaseId, string name)
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



            static Models.Database Convert(Dictionary<string, object> it) =>
                Models.Database.From(map: it);


            return _client.Call<Models.Database>(
                method: "PUT",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Delete Database
        /// <para>
        /// Delete a database by its unique ID. Only API keys with with databases.write
        /// scope can delete a database.
        /// </para>
        /// </summary>
        public Task<object> Delete(string databaseId)
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
        /// <para>
        /// Get a list of all collections that belong to the provided databaseId. You
        /// can use the search parameter to filter your results.
        /// </para>
        /// </summary>
        public Task<Models.CollectionList> ListCollections(string databaseId, List<string>? queries = null, string? search = null)
        {
            var path = "/databases/{databaseId}/collections"
                .Replace("{databaseId}", databaseId);

            var parameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search }
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
        /// <para>
        /// Create a new Collection. Before using this route, you should create a new
        /// database resource using either a [server
        /// integration](/docs/server/databases#databasesCreateCollection) API or
        /// directly from your database console.
        /// </para>
        /// </summary>
        public Task<Models.Collection> CreateCollection(string databaseId, string collectionId, string name, List<string>? permissions = null, bool? documentSecurity = null)
        {
            var path = "/databases/{databaseId}/collections"
                .Replace("{databaseId}", databaseId);

            var parameters = new Dictionary<string, object?>()
            {
                { "collectionId", collectionId },
                { "name", name },
                { "permissions", permissions },
                { "documentSecurity", documentSecurity }
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
        /// <para>
        /// Get a collection by its unique ID. This endpoint response returns a JSON
        /// object with the collection metadata.
        /// </para>
        /// </summary>
        public Task<Models.Collection> GetCollection(string databaseId, string collectionId)
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
        /// <para>
        /// Update a collection by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Collection> UpdateCollection(string databaseId, string collectionId, string name, List<string>? permissions = null, bool? documentSecurity = null, bool? enabled = null)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "permissions", permissions },
                { "documentSecurity", documentSecurity },
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
        /// <para>
        /// Delete a collection by its unique ID. Only users with write permissions
        /// have access to delete this resource.
        /// </para>
        /// </summary>
        public Task<object> DeleteCollection(string databaseId, string collectionId)
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
        public Task<Models.AttributeList> ListAttributes(string databaseId, string collectionId)
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
        /// <para>
        /// Create a boolean attribute.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.AttributeBoolean> CreateBooleanAttribute(string databaseId, string collectionId, string key, bool required, bool? xdefault = null, bool? array = null)
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
        /// Update Boolean Attribute
        /// </summary>
        public Task<Models.AttributeBoolean> UpdateBooleanAttribute(string databaseId, string collectionId, string key, bool required, bool xdefault)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/attributes/boolean/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var parameters = new Dictionary<string, object?>()
            {
                { "required", required },
                { "default", xdefault }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.AttributeBoolean Convert(Dictionary<string, object> it) =>
                Models.AttributeBoolean.From(map: it);


            return _client.Call<Models.AttributeBoolean>(
                method: "PATCH",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create DateTime Attribute
        /// </summary>
        public Task<Models.AttributeDatetime> CreateDatetimeAttribute(string databaseId, string collectionId, string key, bool required, string? xdefault = null, bool? array = null)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/attributes/datetime"
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



            static Models.AttributeDatetime Convert(Dictionary<string, object> it) =>
                Models.AttributeDatetime.From(map: it);


            return _client.Call<Models.AttributeDatetime>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update DateTime Attribute
        /// </summary>
        public Task<Models.AttributeDatetime> UpdateDatetimeAttribute(string databaseId, string collectionId, string key, bool required, string xdefault)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/attributes/datetime/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var parameters = new Dictionary<string, object?>()
            {
                { "required", required },
                { "default", xdefault }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.AttributeDatetime Convert(Dictionary<string, object> it) =>
                Models.AttributeDatetime.From(map: it);


            return _client.Call<Models.AttributeDatetime>(
                method: "PATCH",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create Email Attribute
        /// <para>
        /// Create an email attribute.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.AttributeEmail> CreateEmailAttribute(string databaseId, string collectionId, string key, bool required, string? xdefault = null, bool? array = null)
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
        /// Update Email Attribute
        /// <para>
        /// Update an email attribute. Changing the `default` value will not update
        /// already existing documents.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.AttributeEmail> UpdateEmailAttribute(string databaseId, string collectionId, string key, bool required, string xdefault)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/attributes/email/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var parameters = new Dictionary<string, object?>()
            {
                { "required", required },
                { "default", xdefault }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.AttributeEmail Convert(Dictionary<string, object> it) =>
                Models.AttributeEmail.From(map: it);


            return _client.Call<Models.AttributeEmail>(
                method: "PATCH",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create Enum Attribute
        /// </summary>
        public Task<Models.AttributeEnum> CreateEnumAttribute(string databaseId, string collectionId, string key, List<string> elements, bool required, string? xdefault = null, bool? array = null)
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
        /// Update Enum Attribute
        /// <para>
        /// Update an enum attribute. Changing the `default` value will not update
        /// already existing documents.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.AttributeEnum> UpdateEnumAttribute(string databaseId, string collectionId, string key, List<string> elements, bool required, string xdefault)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/attributes/enum/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var parameters = new Dictionary<string, object?>()
            {
                { "elements", elements },
                { "required", required },
                { "default", xdefault }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.AttributeEnum Convert(Dictionary<string, object> it) =>
                Models.AttributeEnum.From(map: it);


            return _client.Call<Models.AttributeEnum>(
                method: "PATCH",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create Float Attribute
        /// <para>
        /// Create a float attribute. Optionally, minimum and maximum values can be
        /// provided.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.AttributeFloat> CreateFloatAttribute(string databaseId, string collectionId, string key, bool required, double? min = null, double? max = null, double? xdefault = null, bool? array = null)
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
        /// Update Float Attribute
        /// <para>
        /// Update a float attribute. Changing the `default` value will not update
        /// already existing documents.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.AttributeFloat> UpdateFloatAttribute(string databaseId, string collectionId, string key, bool required, double min, double max, double xdefault)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/attributes/float/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var parameters = new Dictionary<string, object?>()
            {
                { "required", required },
                { "min", min },
                { "max", max },
                { "default", xdefault }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.AttributeFloat Convert(Dictionary<string, object> it) =>
                Models.AttributeFloat.From(map: it);


            return _client.Call<Models.AttributeFloat>(
                method: "PATCH",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create Integer Attribute
        /// <para>
        /// Create an integer attribute. Optionally, minimum and maximum values can be
        /// provided.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.AttributeInteger> CreateIntegerAttribute(string databaseId, string collectionId, string key, bool required, long? min = null, long? max = null, long? xdefault = null, bool? array = null)
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
        /// Update Integer Attribute
        /// <para>
        /// Update an integer attribute. Changing the `default` value will not update
        /// already existing documents.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.AttributeInteger> UpdateIntegerAttribute(string databaseId, string collectionId, string key, bool required, long min, long max, long xdefault)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/attributes/integer/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var parameters = new Dictionary<string, object?>()
            {
                { "required", required },
                { "min", min },
                { "max", max },
                { "default", xdefault }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.AttributeInteger Convert(Dictionary<string, object> it) =>
                Models.AttributeInteger.From(map: it);


            return _client.Call<Models.AttributeInteger>(
                method: "PATCH",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create IP Address Attribute
        /// <para>
        /// Create IP address attribute.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.AttributeIp> CreateIpAttribute(string databaseId, string collectionId, string key, bool required, string? xdefault = null, bool? array = null)
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
        /// Update IP Address Attribute
        /// <para>
        /// Update an ip attribute. Changing the `default` value will not update
        /// already existing documents.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.AttributeIp> UpdateIpAttribute(string databaseId, string collectionId, string key, bool required, string xdefault)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/attributes/ip/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var parameters = new Dictionary<string, object?>()
            {
                { "required", required },
                { "default", xdefault }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.AttributeIp Convert(Dictionary<string, object> it) =>
                Models.AttributeIp.From(map: it);


            return _client.Call<Models.AttributeIp>(
                method: "PATCH",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create Relationship Attribute
        /// <para>
        /// Create relationship attribute. [Learn more about relationship
        /// attributes](/docs/databases-relationships#relationship-attributes).
        /// 
        /// </para>
        /// </summary>
        public Task<Models.AttributeRelationship> CreateRelationshipAttribute(string databaseId, string collectionId, string relatedCollectionId, string type, bool? twoWay = null, string? key = null, string? twoWayKey = null, string? onDelete = null)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/attributes/relationship"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "relatedCollectionId", relatedCollectionId },
                { "type", type },
                { "twoWay", twoWay },
                { "key", key },
                { "twoWayKey", twoWayKey },
                { "onDelete", onDelete }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.AttributeRelationship Convert(Dictionary<string, object> it) =>
                Models.AttributeRelationship.From(map: it);


            return _client.Call<Models.AttributeRelationship>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create String Attribute
        /// <para>
        /// Create a string attribute.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.AttributeString> CreateStringAttribute(string databaseId, string collectionId, string key, long size, bool required, string? xdefault = null, bool? array = null)
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
        /// Update String Attribute
        /// <para>
        /// Update a string attribute. Changing the `default` value will not update
        /// already existing documents.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.AttributeString> UpdateStringAttribute(string databaseId, string collectionId, string key, bool required, string xdefault)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/attributes/string/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var parameters = new Dictionary<string, object?>()
            {
                { "required", required },
                { "default", xdefault }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.AttributeString Convert(Dictionary<string, object> it) =>
                Models.AttributeString.From(map: it);


            return _client.Call<Models.AttributeString>(
                method: "PATCH",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create URL Attribute
        /// <para>
        /// Create a URL attribute.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.AttributeUrl> CreateUrlAttribute(string databaseId, string collectionId, string key, bool required, string? xdefault = null, bool? array = null)
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
        /// Update URL Attribute
        /// <para>
        /// Update an url attribute. Changing the `default` value will not update
        /// already existing documents.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.AttributeUrl> UpdateUrlAttribute(string databaseId, string collectionId, string key, bool required, string xdefault)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/attributes/url/{key}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var parameters = new Dictionary<string, object?>()
            {
                { "required", required },
                { "default", xdefault }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.AttributeUrl Convert(Dictionary<string, object> it) =>
                Models.AttributeUrl.From(map: it);


            return _client.Call<Models.AttributeUrl>(
                method: "PATCH",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get Attribute
        /// </summary>
        public Task<object> GetAttribute(string databaseId, string collectionId, string key)
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
        public Task<object> DeleteAttribute(string databaseId, string collectionId, string key)
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
        /// Update Relationship Attribute
        /// <para>
        /// Update relationship attribute. [Learn more about relationship
        /// attributes](/docs/databases-relationships#relationship-attributes).
        /// 
        /// </para>
        /// </summary>
        public Task<Models.AttributeRelationship> UpdateRelationshipAttribute(string databaseId, string collectionId, string key, string? onDelete = null)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/attributes/{key}/relationship"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var parameters = new Dictionary<string, object?>()
            {
                { "onDelete", onDelete }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.AttributeRelationship Convert(Dictionary<string, object> it) =>
                Models.AttributeRelationship.From(map: it);


            return _client.Call<Models.AttributeRelationship>(
                method: "PATCH",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// List Documents
        /// <para>
        /// Get a list of all the user's documents in a given collection. You can use
        /// the query params to filter your results.
        /// </para>
        /// </summary>
        public Task<Models.DocumentList> ListDocuments(string databaseId, string collectionId, List<string>? queries = null)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/documents"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "queries", queries }
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
        /// <para>
        /// Create a new Document. Before using this route, you should create a new
        /// collection resource using either a [server
        /// integration](/docs/server/databases#databasesCreateCollection) API or
        /// directly from your database console.
        /// </para>
        /// </summary>
        public Task<Models.Document> CreateDocument(string databaseId, string collectionId, string documentId, object data, List<string>? permissions = null)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/documents"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "documentId", documentId },
                { "data", data },
                { "permissions", permissions }
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
        /// <para>
        /// Get a document by its unique ID. This endpoint response returns a JSON
        /// object with the document data.
        /// </para>
        /// </summary>
        public Task<Models.Document> GetDocument(string databaseId, string collectionId, string documentId, List<string>? queries = null)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/documents/{documentId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{documentId}", documentId);

            var parameters = new Dictionary<string, object?>()
            {
                { "queries", queries }
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
        /// <para>
        /// Update a document by its unique ID. Using the patch method you can pass
        /// only specific fields that will get updated.
        /// </para>
        /// </summary>
        public Task<Models.Document> UpdateDocument(string databaseId, string collectionId, string documentId, object? data = null, List<string>? permissions = null)
        {
            var path = "/databases/{databaseId}/collections/{collectionId}/documents/{documentId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{documentId}", documentId);

            var parameters = new Dictionary<string, object?>()
            {
                { "data", data },
                { "permissions", permissions }
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
        /// <para>
        /// Delete a document by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> DeleteDocument(string databaseId, string collectionId, string documentId)
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
        public Task<Models.IndexList> ListIndexes(string databaseId, string collectionId)
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
        public Task<Models.Index> CreateIndex(string databaseId, string collectionId, string key, string type, List<string> attributes, List<string>? orders = null)
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
        public Task<Models.Index> GetIndex(string databaseId, string collectionId, string key)
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
        public Task<object> DeleteIndex(string databaseId, string collectionId, string key)
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
