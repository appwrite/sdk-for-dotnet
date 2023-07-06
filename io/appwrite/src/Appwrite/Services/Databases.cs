
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Appwrite
{
    public class Databases : Service
    {
        public Databases(Client client) : base(client) { }

        /// <summary>
        /// List Databases
        /// <para>
        /// Get a list of all databases from the current Appwrite project. You can use
        /// the search parameter to filter your results.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> List(List<string> queries = null, string search = "") 
        {
            string path = "/databases";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "queries", queries },
                { "search", search }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }

        /// <summary>
        /// Create Database
        /// <para>
        /// Create a new Database.
        /// 
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> Create(string databaseId, string name) 
        {
            string path = "/databases";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "databaseId", databaseId },
                { "name", name }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Get Database
        /// <para>
        /// Get a database by its unique ID. This endpoint response returns a JSON
        /// object with the database metadata.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> Get(string databaseId) 
        {
            string path = "/databases/{databaseId}".Replace("{databaseId}", databaseId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }

        /// <summary>
        /// Update Database
        /// <para>
        /// Update a database by its unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> Update(string databaseId, string name) 
        {
            string path = "/databases/{databaseId}".Replace("{databaseId}", databaseId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "name", name }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PUT", path, headers, parameters);
        }

        /// <summary>
        /// Delete Database
        /// <para>
        /// Delete a database by its unique ID. Only API keys with with databases.write
        /// scope can delete a database.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> Delete(string databaseId) 
        {
            string path = "/databases/{databaseId}".Replace("{databaseId}", databaseId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("DELETE", path, headers, parameters);
        }

        /// <summary>
        /// List Collections
        /// <para>
        /// Get a list of all collections that belong to the provided databaseId. You
        /// can use the search parameter to filter your results.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> ListCollections(string databaseId, List<string> queries = null, string search = "") 
        {
            string path = "/databases/{databaseId}/collections".Replace("{databaseId}", databaseId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "queries", queries },
                { "search", search }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
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
        public async Task<HttpResponseMessage> CreateCollection(string databaseId, string collectionId, string name, List<string> permissions = null, bool? documentSecurity = false) 
        {
            string path = "/databases/{databaseId}/collections".Replace("{databaseId}", databaseId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "collectionId", collectionId },
                { "name", name },
                { "permissions", permissions },
                { "documentSecurity", documentSecurity }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Get Collection
        /// <para>
        /// Get a collection by its unique ID. This endpoint response returns a JSON
        /// object with the collection metadata.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> GetCollection(string databaseId, string collectionId) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }

        /// <summary>
        /// Update Collection
        /// <para>
        /// Update a collection by its unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> UpdateCollection(string databaseId, string collectionId, string name, List<string> permissions = null, bool? documentSecurity = false, bool? enabled = true) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "name", name },
                { "permissions", permissions },
                { "documentSecurity", documentSecurity },
                { "enabled", enabled }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PUT", path, headers, parameters);
        }

        /// <summary>
        /// Delete Collection
        /// <para>
        /// Delete a collection by its unique ID. Only users with write permissions
        /// have access to delete this resource.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> DeleteCollection(string databaseId, string collectionId) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("DELETE", path, headers, parameters);
        }

        /// <summary>
        /// List Attributes
        /// </summary>
        public async Task<HttpResponseMessage> ListAttributes(string databaseId, string collectionId) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/attributes".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }

        /// <summary>
        /// Create Boolean Attribute
        /// <para>
        /// Create a boolean attribute.
        /// 
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> CreateBooleanAttribute(string databaseId, string collectionId, string key, bool required, bool? xdefault = null, bool? array = false) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/attributes/boolean".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "key", key },
                { "required", required },
                { "default", xdefault },
                { "array", array }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Update Boolean Attribute
        /// </summary>
        public async Task<HttpResponseMessage> UpdateBooleanAttribute(string databaseId, string collectionId, string key, bool required, bool xdefault) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/attributes/boolean/{key}".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId).Replace("{key}", key);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "required", required },
                { "default", xdefault }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }

        /// <summary>
        /// Create DateTime Attribute
        /// </summary>
        public async Task<HttpResponseMessage> CreateDatetimeAttribute(string databaseId, string collectionId, string key, bool required, string xdefault = "", bool? array = false) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/attributes/datetime".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "key", key },
                { "required", required },
                { "default", xdefault },
                { "array", array }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Update DateTime Attribute
        /// </summary>
        public async Task<HttpResponseMessage> UpdateDatetimeAttribute(string databaseId, string collectionId, string key, bool required, string xdefault) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/attributes/datetime/{key}".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId).Replace("{key}", key);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "required", required },
                { "default", xdefault }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }

        /// <summary>
        /// Create Email Attribute
        /// <para>
        /// Create an email attribute.
        /// 
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> CreateEmailAttribute(string databaseId, string collectionId, string key, bool required, string xdefault = "", bool? array = false) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/attributes/email".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "key", key },
                { "required", required },
                { "default", xdefault },
                { "array", array }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Update Email Attribute
        /// <para>
        /// Update an email attribute. Changing the `default` value will not update
        /// already existing documents.
        /// 
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> UpdateEmailAttribute(string databaseId, string collectionId, string key, bool required, string xdefault) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/attributes/email/{key}".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId).Replace("{key}", key);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "required", required },
                { "default", xdefault }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }

        /// <summary>
        /// Create Enum Attribute
        /// </summary>
        public async Task<HttpResponseMessage> CreateEnumAttribute(string databaseId, string collectionId, string key, List<string> elements, bool required, string xdefault = "", bool? array = false) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/attributes/enum".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "key", key },
                { "elements", elements },
                { "required", required },
                { "default", xdefault },
                { "array", array }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Update Enum Attribute
        /// <para>
        /// Update an enum attribute. Changing the `default` value will not update
        /// already existing documents.
        /// 
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> UpdateEnumAttribute(string databaseId, string collectionId, string key, List<string> elements, bool required, string xdefault) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/attributes/enum/{key}".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId).Replace("{key}", key);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "elements", elements },
                { "required", required },
                { "default", xdefault }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }

        /// <summary>
        /// Create Float Attribute
        /// <para>
        /// Create a float attribute. Optionally, minimum and maximum values can be
        /// provided.
        /// 
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> CreateFloatAttribute(string databaseId, string collectionId, string key, bool required, number min = , number max = , number xdefault = , bool? array = false) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/attributes/float".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "key", key },
                { "required", required },
                { "min", min },
                { "max", max },
                { "default", xdefault },
                { "array", array }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Update Float Attribute
        /// <para>
        /// Update a float attribute. Changing the `default` value will not update
        /// already existing documents.
        /// 
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> UpdateFloatAttribute(string databaseId, string collectionId, string key, bool required, number min, number max, number xdefault) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/attributes/float/{key}".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId).Replace("{key}", key);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "required", required },
                { "min", min },
                { "max", max },
                { "default", xdefault }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }

        /// <summary>
        /// Create Integer Attribute
        /// <para>
        /// Create an integer attribute. Optionally, minimum and maximum values can be
        /// provided.
        /// 
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> CreateIntegerAttribute(string databaseId, string collectionId, string key, bool required, int? min = null, int? max = null, int? xdefault = null, bool? array = false) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/attributes/integer".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "key", key },
                { "required", required },
                { "min", min },
                { "max", max },
                { "default", xdefault },
                { "array", array }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Update Integer Attribute
        /// <para>
        /// Update an integer attribute. Changing the `default` value will not update
        /// already existing documents.
        /// 
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> UpdateIntegerAttribute(string databaseId, string collectionId, string key, bool required, int min, int max, int xdefault) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/attributes/integer/{key}".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId).Replace("{key}", key);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "required", required },
                { "min", min },
                { "max", max },
                { "default", xdefault }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }

        /// <summary>
        /// Create IP Address Attribute
        /// <para>
        /// Create IP address attribute.
        /// 
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> CreateIpAttribute(string databaseId, string collectionId, string key, bool required, string xdefault = "", bool? array = false) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/attributes/ip".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "key", key },
                { "required", required },
                { "default", xdefault },
                { "array", array }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Update IP Address Attribute
        /// <para>
        /// Update an ip attribute. Changing the `default` value will not update
        /// already existing documents.
        /// 
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> UpdateIpAttribute(string databaseId, string collectionId, string key, bool required, string xdefault) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/attributes/ip/{key}".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId).Replace("{key}", key);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "required", required },
                { "default", xdefault }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }

        /// <summary>
        /// Create Relationship Attribute
        /// <para>
        /// Create relationship attribute. [Learn more about relationship
        /// attributes](/docs/databases-relationships#relationship-attributes).
        /// 
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> CreateRelationshipAttribute(string databaseId, string collectionId, string relatedCollectionId, string type, bool? twoWay = false, string key = "", string twoWayKey = "", string onDelete = "restrict") 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/attributes/relationship".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "relatedCollectionId", relatedCollectionId },
                { "type", type },
                { "twoWay", twoWay },
                { "key", key },
                { "twoWayKey", twoWayKey },
                { "onDelete", onDelete }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Create String Attribute
        /// <para>
        /// Create a string attribute.
        /// 
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> CreateStringAttribute(string databaseId, string collectionId, string key, int size, bool required, string xdefault = "", bool? array = false) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/attributes/string".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "key", key },
                { "size", size },
                { "required", required },
                { "default", xdefault },
                { "array", array }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Update String Attribute
        /// <para>
        /// Update a string attribute. Changing the `default` value will not update
        /// already existing documents.
        /// 
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> UpdateStringAttribute(string databaseId, string collectionId, string key, bool required, string xdefault) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/attributes/string/{key}".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId).Replace("{key}", key);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "required", required },
                { "default", xdefault }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }

        /// <summary>
        /// Create URL Attribute
        /// <para>
        /// Create a URL attribute.
        /// 
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> CreateUrlAttribute(string databaseId, string collectionId, string key, bool required, string xdefault = "", bool? array = false) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/attributes/url".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "key", key },
                { "required", required },
                { "default", xdefault },
                { "array", array }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Update URL Attribute
        /// <para>
        /// Update an url attribute. Changing the `default` value will not update
        /// already existing documents.
        /// 
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> UpdateUrlAttribute(string databaseId, string collectionId, string key, bool required, string xdefault) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/attributes/url/{key}".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId).Replace("{key}", key);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "required", required },
                { "default", xdefault }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }

        /// <summary>
        /// Get Attribute
        /// </summary>
        public async Task<HttpResponseMessage> GetAttribute(string databaseId, string collectionId, string key) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/attributes/{key}".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId).Replace("{key}", key);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }

        /// <summary>
        /// Delete Attribute
        /// </summary>
        public async Task<HttpResponseMessage> DeleteAttribute(string databaseId, string collectionId, string key) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/attributes/{key}".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId).Replace("{key}", key);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("DELETE", path, headers, parameters);
        }

        /// <summary>
        /// Update Relationship Attribute
        /// <para>
        /// Update relationship attribute. [Learn more about relationship
        /// attributes](/docs/databases-relationships#relationship-attributes).
        /// 
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> UpdateRelationshipAttribute(string databaseId, string collectionId, string key, string onDelete = "") 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/attributes/{key}/relationship".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId).Replace("{key}", key);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "onDelete", onDelete }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }

        /// <summary>
        /// List Documents
        /// <para>
        /// Get a list of all the user's documents in a given collection. You can use
        /// the query params to filter your results.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> ListDocuments(string databaseId, string collectionId, List<string> queries = null) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/documents".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "queries", queries }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
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
        public async Task<HttpResponseMessage> CreateDocument(string databaseId, string collectionId, string documentId, object data, List<string> permissions = null) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/documents".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "documentId", documentId },
                { "data", data },
                { "permissions", permissions }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Get Document
        /// <para>
        /// Get a document by its unique ID. This endpoint response returns a JSON
        /// object with the document data.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> GetDocument(string databaseId, string collectionId, string documentId, List<string> queries = null) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/documents/{documentId}".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId).Replace("{documentId}", documentId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "queries", queries }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }

        /// <summary>
        /// Update Document
        /// <para>
        /// Update a document by its unique ID. Using the patch method you can pass
        /// only specific fields that will get updated.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> UpdateDocument(string databaseId, string collectionId, string documentId, object data = null, List<string> permissions = null) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/documents/{documentId}".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId).Replace("{documentId}", documentId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "data", data },
                { "permissions", permissions }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }

        /// <summary>
        /// Delete Document
        /// <para>
        /// Delete a document by its unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> DeleteDocument(string databaseId, string collectionId, string documentId) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/documents/{documentId}".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId).Replace("{documentId}", documentId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("DELETE", path, headers, parameters);
        }

        /// <summary>
        /// List Indexes
        /// </summary>
        public async Task<HttpResponseMessage> ListIndexes(string databaseId, string collectionId) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/indexes".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }

        /// <summary>
        /// Create Index
        /// </summary>
        public async Task<HttpResponseMessage> CreateIndex(string databaseId, string collectionId, string key, string type, List<string> attributes, List<string> orders = null) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/indexes".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "key", key },
                { "type", type },
                { "attributes", attributes },
                { "orders", orders }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Get Index
        /// </summary>
        public async Task<HttpResponseMessage> GetIndex(string databaseId, string collectionId, string key) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/indexes/{key}".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId).Replace("{key}", key);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }

        /// <summary>
        /// Delete Index
        /// </summary>
        public async Task<HttpResponseMessage> DeleteIndex(string databaseId, string collectionId, string key) 
        {
            string path = "/databases/{databaseId}/collections/{collectionId}/indexes/{key}".Replace("{databaseId}", databaseId).Replace("{collectionId}", collectionId).Replace("{key}", key);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("DELETE", path, headers, parameters);
        }
    };
}