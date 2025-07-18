
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
        public Task<Models.DatabaseList> List(List<string>? queries = null, string? search = null)
        {
            var apiPath = "/databases";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search }
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
        /// Get a database by its unique ID. This endpoint response returns a JSON
        /// object with the database metadata.
        /// </para>
        /// </summary>
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
        public Task<Models.Database> Update(string databaseId, string name, bool? enabled = null)
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
        public Task<Models.CollectionList> ListCollections(string databaseId, List<string>? queries = null, string? search = null)
        {
            var apiPath = "/databases/{databaseId}/collections"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search }
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
        public Task<Models.Collection> CreateCollection(string databaseId, string collectionId, string name, List<string>? permissions = null, bool? documentSecurity = null, bool? enabled = null)
        {
            var apiPath = "/databases/{databaseId}/collections"
                .Replace("{databaseId}", databaseId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "collectionId", collectionId },
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
        public Task<Models.Collection> UpdateCollection(string databaseId, string collectionId, string name, List<string>? permissions = null, bool? documentSecurity = null, bool? enabled = null)
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
        public Task<Models.AttributeList> ListAttributes(string databaseId, string collectionId, List<string>? queries = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries }
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
        /// Create an enumeration attribute. The `elements` param acts as a white-list
        /// of accepted values for this attribute. 
        /// 
        /// </para>
        /// </summary>
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
        /// Create relationship attribute. [Learn more about relationship
        /// attributes](https://appwrite.io/docs/databases-relationships#relationship-attributes).
        /// 
        /// </para>
        /// </summary>
        public Task<Models.AttributeRelationship> CreateRelationshipAttribute(string databaseId, string collectionId, string relatedCollectionId, Appwrite.Enums.RelationshipType type, bool? twoWay = null, string? key = null, string? twoWayKey = null, Appwrite.Enums.RelationMutate? onDelete = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/relationship"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "relatedCollectionId", relatedCollectionId },
                { "type", type },
                { "twoWay", twoWay },
                { "key", key },
                { "twoWayKey", twoWayKey },
                { "onDelete", onDelete }
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
        /// Create a URL attribute.
        /// 
        /// </para>
        /// </summary>
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
        /// Get attribute by ID.
        /// </para>
        /// </summary>
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



            return _client.Call<object>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <para>
        /// Deletes an attribute.
        /// </para>
        /// </summary>
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
        public Task<Models.AttributeRelationship> UpdateRelationshipAttribute(string databaseId, string collectionId, string key, Appwrite.Enums.RelationMutate? onDelete = null, string? newKey = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/attributes/{key}/relationship"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{key}", key);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "onDelete", onDelete },
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
        public Task<Models.DocumentList> ListDocuments(string databaseId, string collectionId, List<string>? queries = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/documents"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries }
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
        public Task<Models.Document> CreateDocument(string databaseId, string collectionId, string documentId, object data, List<string>? permissions = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/documents"
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

        /// <para>
        /// **WARNING: Experimental Feature** - This endpoint is experimental and not
        /// yet officially supported. It may be subject to breaking changes or removal
        /// in future versions.
        /// 
        /// Create new Documents. Before using this route, you should create a new
        /// collection resource using either a [server
        /// integration](https://appwrite.io/docs/server/databases#databasesCreateCollection)
        /// API or directly from your database console.
        /// </para>
        /// </summary>
        public Task<Models.DocumentList> CreateDocuments(string databaseId, string collectionId, List<object> documents)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/documents"
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

        /// <para>
        /// **WARNING: Experimental Feature** - This endpoint is experimental and not
        /// yet officially supported. It may be subject to breaking changes or removal
        /// in future versions.
        /// 
        /// Create or update Documents. Before using this route, you should create a
        /// new collection resource using either a [server
        /// integration](https://appwrite.io/docs/server/databases#databasesCreateCollection)
        /// API or directly from your database console.
        /// </para>
        /// </summary>
        public Task<Models.DocumentList> UpsertDocuments(string databaseId, string collectionId, List<object> documents)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/documents"
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
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// **WARNING: Experimental Feature** - This endpoint is experimental and not
        /// yet officially supported. It may be subject to breaking changes or removal
        /// in future versions.
        /// 
        /// Update all documents that match your queries, if no queries are submitted
        /// then all documents are updated. You can pass only specific fields to be
        /// updated.
        /// </para>
        /// </summary>
        public Task<Models.DocumentList> UpdateDocuments(string databaseId, string collectionId, object? data = null, List<string>? queries = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/documents"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "data", data },
                { "queries", queries }
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
        /// **WARNING: Experimental Feature** - This endpoint is experimental and not
        /// yet officially supported. It may be subject to breaking changes or removal
        /// in future versions.
        /// 
        /// Bulk delete documents using queries, if no queries are passed then all
        /// documents are deleted.
        /// </para>
        /// </summary>
        public Task<Models.DocumentList> DeleteDocuments(string databaseId, string collectionId, List<string>? queries = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/documents"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries }
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
        public Task<Models.Document> GetDocument(string databaseId, string collectionId, string documentId, List<string>? queries = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/documents/{documentId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{documentId}", documentId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries }
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
        /// **WARNING: Experimental Feature** - This endpoint is experimental and not
        /// yet officially supported. It may be subject to breaking changes or removal
        /// in future versions.
        /// 
        /// Create or update a Document. Before using this route, you should create a
        /// new collection resource using either a [server
        /// integration](https://appwrite.io/docs/server/databases#databasesCreateCollection)
        /// API or directly from your database console.
        /// </para>
        /// </summary>
        public Task<Models.Document> UpsertDocument(string databaseId, string collectionId, string documentId, object data, List<string>? permissions = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/documents/{documentId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{documentId}", documentId);

            var apiParameters = new Dictionary<string, object?>()
            {
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
        public Task<Models.Document> UpdateDocument(string databaseId, string collectionId, string documentId, object? data = null, List<string>? permissions = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/documents/{documentId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{documentId}", documentId);

            var apiParameters = new Dictionary<string, object?>()
            {
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
        public Task<object> DeleteDocument(string databaseId, string collectionId, string documentId)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/documents/{documentId}"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{documentId}", documentId);

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
        /// Decrement a specific attribute of a document by a given value.
        /// </para>
        /// </summary>
        public Task<Models.Document> DecrementDocumentAttribute(string databaseId, string collectionId, string documentId, string attribute, double? xvalue = null, double? min = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/documents/{documentId}/{attribute}/decrement"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{documentId}", documentId)
                .Replace("{attribute}", attribute);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "value", xvalue },
                { "min", min }
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
        public Task<Models.Document> IncrementDocumentAttribute(string databaseId, string collectionId, string documentId, string attribute, double? xvalue = null, double? max = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/documents/{documentId}/{attribute}/increment"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId)
                .Replace("{documentId}", documentId)
                .Replace("{attribute}", attribute);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "value", xvalue },
                { "max", max }
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
        public Task<Models.IndexList> ListIndexes(string databaseId, string collectionId, List<string>? queries = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/indexes"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries }
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
        public Task<Models.Index> CreateIndex(string databaseId, string collectionId, string key, Appwrite.Enums.IndexType type, List<string> attributes, List<string>? orders = null, List<long>? lengths = null)
        {
            var apiPath = "/databases/{databaseId}/collections/{collectionId}/indexes"
                .Replace("{databaseId}", databaseId)
                .Replace("{collectionId}", collectionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "type", type },
                { "attributes", attributes },
                { "orders", orders },
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
        /// Get index by ID.
        /// </para>
        /// </summary>
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
