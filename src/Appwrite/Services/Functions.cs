
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Appwrite
{
    public class Functions : Service
    {

        public Functions(Client client) : base(client) { }


    
        /// List Functions
            /*
         * Get a list of all the project's functions. You can use the query params to
     * filter your results.
        */
        public async Task<HttpResponseMessage> List(string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC) 
        {
            string path = "/functions";

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
    
        /// Create Function
            /*
         * Create a new function. You can pass a list of
     * [permissions](/docs/permissions) to allow different project users or team
     * with access to execute the function using the client API.
        */
        public async Task<HttpResponseMessage> Create(string name, List<object> execute, string env, object vars = null, List<object> events = null, string schedule = "", int? timeout = 15) 
        {
            string path = "/functions";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                    
                { "name", name },
                    
                { "execute", execute },
                    
                { "env", env },
                    
                { "vars", vars },
                    
                { "events", events },
                    
                { "schedule", schedule },
                    
                { "timeout", timeout }
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }
    
        /// Get Function
            /*
         * Get a function by its unique ID.
        */
        public async Task<HttpResponseMessage> Get(string functionId) 
        {
            string path = "/functions/{functionId}".Replace("{functionId}", functionId);

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
    
        /// Update Function
            /*
         * Update function by its unique ID.
        */
        public async Task<HttpResponseMessage> Update(string functionId, string name, List<object> execute, object vars = null, List<object> events = null, string schedule = "", int? timeout = 15) 
        {
            string path = "/functions/{functionId}".Replace("{functionId}", functionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                    
                { "name", name },
                    
                { "execute", execute },
                    
                { "vars", vars },
                    
                { "events", events },
                    
                { "schedule", schedule },
                    
                { "timeout", timeout }
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("PUT", path, headers, parameters);
        }
    
        /// Delete Function
            /*
         * Delete a function by its unique ID.
        */
        public async Task<HttpResponseMessage> Delete(string functionId) 
        {
            string path = "/functions/{functionId}".Replace("{functionId}", functionId);

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
    
        /// List Executions
            /*
         * Get a list of all the current user function execution logs. You can use the
     * query params to filter your results. On admin mode, this endpoint will
     * return a list of all of the project's teams. [Learn more about different
     * API modes](/docs/admin).
        */
        public async Task<HttpResponseMessage> ListExecutions(string functionId, string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC) 
        {
            string path = "/functions/{functionId}/executions".Replace("{functionId}", functionId);

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
    
        /// Create Execution
            /*
         * Trigger a function execution. The returned object will return you the
     * current execution status. You can ping the `Get Execution` endpoint to get
     * updates on the current execution status. Once this endpoint is called, your
     * function execution process will start asynchronously.
        */
        public async Task<HttpResponseMessage> CreateExecution(string functionId) 
        {
            string path = "/functions/{functionId}/executions".Replace("{functionId}", functionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }
    
        /// Get Execution
            /*
         * Get a function execution log by its unique ID.
        */
        public async Task<HttpResponseMessage> GetExecution(string functionId, string executionId) 
        {
            string path = "/functions/{functionId}/executions/{executionId}".Replace("{functionId}", functionId).Replace("{executionId}", executionId);

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
    
        /// Update Function Tag
            /*
         * Update the function code tag ID using the unique function ID. Use this
     * endpoint to switch the code tag that should be executed by the execution
     * endpoint.
        */
        public async Task<HttpResponseMessage> UpdateTag(string functionId, string tag) 
        {
            string path = "/functions/{functionId}/tag".Replace("{functionId}", functionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                    
                { "tag", tag }
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }
    
        /// List Tags
            /*
         * Get a list of all the project's code tags. You can use the query params to
     * filter your results.
        */
        public async Task<HttpResponseMessage> ListTags(string functionId, string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC) 
        {
            string path = "/functions/{functionId}/tags".Replace("{functionId}", functionId);

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
    
        /// Create Tag
            /*
         * Create a new function code tag. Use this endpoint to upload a new version
     * of your code function. To execute your newly uploaded code, you'll need to
     * update the function's tag to use your new tag UID.
     * 
     * This endpoint accepts a tar.gz file compressed with your code. Make sure to
     * include any dependencies your code has within the compressed file. You can
     * learn more about code packaging in the [Appwrite Cloud Functions
     * tutorial](/docs/functions).
     * 
     * Use the "command" param to set the entry point used to execute your code.
        */
        public async Task<HttpResponseMessage> CreateTag(string functionId, string command, FileInfo code) 
        {
            string path = "/functions/{functionId}/tags".Replace("{functionId}", functionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                    
                { "command", command },
                    
                { "code", code }
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "multipart/form-data" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }
    
        /// Get Tag
            /*
         * Get a code tag by its unique ID.
        */
        public async Task<HttpResponseMessage> GetTag(string functionId, string tagId) 
        {
            string path = "/functions/{functionId}/tags/{tagId}".Replace("{functionId}", functionId).Replace("{tagId}", tagId);

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
    
        /// Delete Tag
            /*
         * Delete a code tag by its unique ID.
        */
        public async Task<HttpResponseMessage> DeleteTag(string functionId, string tagId) 
        {
            string path = "/functions/{functionId}/tags/{tagId}".Replace("{functionId}", functionId).Replace("{tagId}", tagId);

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