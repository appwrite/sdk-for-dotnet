
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Appwrite
{
    public class Database : Service
    {

        public Database(Client client) : base(client) { }


    
        /// List Collections
            /*
         * Get a list of all the user collections. You can use the query params to
     * filter your results. On admin mode, this endpoint will return a list of all
     * of the project collections. [Learn more about different API
     * modes](/docs/admin).
        */
        public async Task<HttpResponseMessage> ListCollections(string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC) 
        {
            string path = "/database/collections";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                    
                { "search", search },
                    
                { "limit", limit },
                    
                { "offset", offset },
                    
                { "orderType", orderType.ToString() }
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }
    
        /// Create Collection
            /*
         * Create a new Collection.
        */
        public async Task<HttpResponseMessage> CreateCollection(string name, List<object> read, List<object> write, List<object> rules) 
        {
            string path = "/database/collections";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                    
                { "name", name },
                    
                { "read", read },
                    
                { "write", write },
                    
                { "rules", rules }
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }
    
        /// Get Collection
            /*
         * Get collection by its unique ID. This endpoint response returns a JSON
     * object with the collection metadata.
        */
        public async Task<HttpResponseMessage> GetCollection(string collectionId) 
        {
            string path = "/database/collections/{collectionId}".Replace("{collectionId}", collectionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }
    
        /// Update Collection
            /*
         * Update collection by its unique ID.
        */
        public async Task<HttpResponseMessage> UpdateCollection(string collectionId, string name, List<object> read, List<object> write, List<object> rules = null) 
        {
            string path = "/database/collections/{collectionId}".Replace("{collectionId}", collectionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                    
                { "name", name },
                    
                { "read", read },
                    
                { "write", write },
                    
                { "rules", rules }
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("PUT", path, headers, parameters);
        }
    
        /// Delete Collection
            /*
         * Delete a collection by its unique ID. Only users with write permissions
     * have access to delete this resource.
        */
        public async Task<HttpResponseMessage> DeleteCollection(string collectionId) 
        {
            string path = "/database/collections/{collectionId}".Replace("{collectionId}", collectionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("DELETE", path, headers, parameters);
        }
    
        /// List Documents
            /*
         * Get a list of all the user documents. You can use the query params to
     * filter your results. On admin mode, this endpoint will return a list of all
     * of the project documents. [Learn more about different API
     * modes](/docs/admin).
        */
        public async Task<HttpResponseMessage> ListDocuments(string collectionId, List<object> filters = null, int? offset = 0, int? limit = 50, string orderField = "$id", OrderType orderType = OrderType.ASC, string orderCast = "string", string search = "") 
        {
            string path = "/database/collections/{collectionId}/documents".Replace("{collectionId}", collectionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                    
                { "filters", filters },
                    
                { "offset", offset },
                    
                { "limit", limit },
                    
                { "orderField", orderField },
                    
                { "orderType", orderType.ToString() },
                    
                { "orderCast", orderCast },
                    
                { "search", search }
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }
    
        /// Create Document
            /*
         * Create a new Document. Before using this route, you should create a new
     * collection resource using either a [server
     * integration](/docs/server/database?sdk=nodejs#createCollection) API or
     * directly from your database console.
        */
        public async Task<HttpResponseMessage> CreateDocument(string collectionId, object data, List<object> read, List<object> write, string parentDocument = "", string parentProperty = "", string parentPropertyType = "assign") 
        {
            string path = "/database/collections/{collectionId}/documents".Replace("{collectionId}", collectionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                    
                { "data", data },
                    
                { "read", read },
                    
                { "write", write },
                    
                { "parentDocument", parentDocument },
                    
                { "parentProperty", parentProperty },
                    
                { "parentPropertyType", parentPropertyType }
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }
    
        /// Get Document
            /*
         * Get document by its unique ID. This endpoint response returns a JSON object
     * with the document data.
        */
        public async Task<HttpResponseMessage> GetDocument(string collectionId, string documentId) 
        {
            string path = "/database/collections/{collectionId}/documents/{documentId}".Replace("{collectionId}", collectionId).Replace("{documentId}", documentId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }
    
        /// Update Document
        public async Task<HttpResponseMessage> UpdateDocument(string collectionId, string documentId, object data, List<object> read, List<object> write) 
        {
            string path = "/database/collections/{collectionId}/documents/{documentId}".Replace("{collectionId}", collectionId).Replace("{documentId}", documentId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                    
                { "data", data },
                    
                { "read", read },
                    
                { "write", write }
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }
    
        /// Delete Document
            /*
         * Delete document by its unique ID. This endpoint deletes only the parent
     * documents, his attributes and relations to other documents. Child documents
     * **will not** be deleted.
        */
        public async Task<HttpResponseMessage> DeleteDocument(string collectionId, string documentId) 
        {
            string path = "/database/collections/{collectionId}/documents/{documentId}".Replace("{collectionId}", collectionId).Replace("{documentId}", documentId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("DELETE", path, headers, parameters);
        }
        };
}