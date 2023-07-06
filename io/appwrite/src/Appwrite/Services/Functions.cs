
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Appwrite
{
    public class Functions : Service
    {
        public Functions(Client client) : base(client) { }

        /// <summary>
        /// List Functions
        /// <para>
        /// Get a list of all the project's functions. You can use the query params to
        /// filter your results.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> List(List<string> queries = null, string search = "") 
        {
            string path = "/functions";

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
        /// Create Function
        /// <para>
        /// Create a new function. You can pass a list of
        /// [permissions](/docs/permissions) to allow different project users or team
        /// with access to execute the function using the client API.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> Create(string functionId, string name, string runtime, List<string> execute = null, List<string> events = null, string schedule = "", int? timeout = 15, bool? enabled = true) 
        {
            string path = "/functions";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "functionId", functionId },
                { "name", name },
                { "execute", execute },
                { "runtime", runtime },
                { "events", events },
                { "schedule", schedule },
                { "timeout", timeout },
                { "enabled", enabled }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// List runtimes
        /// <para>
        /// Get a list of all runtimes that are currently active on your instance.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> ListRuntimes() 
        {
            string path = "/functions/runtimes";

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
        /// Get Function
        /// <para>
        /// Get a function by its unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> Get(string functionId) 
        {
            string path = "/functions/{functionId}".Replace("{functionId}", functionId);

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
        /// Update Function
        /// <para>
        /// Update function by its unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> Update(string functionId, string name, List<string> execute = null, List<string> events = null, string schedule = "", int? timeout = 15, bool? enabled = true) 
        {
            string path = "/functions/{functionId}".Replace("{functionId}", functionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "name", name },
                { "execute", execute },
                { "events", events },
                { "schedule", schedule },
                { "timeout", timeout },
                { "enabled", enabled }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PUT", path, headers, parameters);
        }

        /// <summary>
        /// Delete Function
        /// <para>
        /// Delete a function by its unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> Delete(string functionId) 
        {
            string path = "/functions/{functionId}".Replace("{functionId}", functionId);

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
        /// List Deployments
        /// <para>
        /// Get a list of all the project's code deployments. You can use the query
        /// params to filter your results.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> ListDeployments(string functionId, List<string> queries = null, string search = "") 
        {
            string path = "/functions/{functionId}/deployments".Replace("{functionId}", functionId);

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
        /// Create Deployment
        /// <para>
        /// Create a new function code deployment. Use this endpoint to upload a new
        /// version of your code function. To execute your newly uploaded code, you'll
        /// need to update the function's deployment to use your new deployment UID.
        /// 
        /// This endpoint accepts a tar.gz file compressed with your code. Make sure to
        /// include any dependencies your code has within the compressed file. You can
        /// learn more about code packaging in the [Appwrite Cloud Functions
        /// tutorial](/docs/functions).
        /// 
        /// Use the "command" param to set the entry point used to execute your code.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> CreateDeployment(string functionId, string entrypoint, FileInfo code, bool activate) 
        {
            string path = "/functions/{functionId}/deployments".Replace("{functionId}", functionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "entrypoint", entrypoint },
                { "code", code },
                { "activate", activate }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "multipart/form-data" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Get Deployment
        /// <para>
        /// Get a code deployment by its unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> GetDeployment(string functionId, string deploymentId) 
        {
            string path = "/functions/{functionId}/deployments/{deploymentId}".Replace("{functionId}", functionId).Replace("{deploymentId}", deploymentId);

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
        /// Update Function Deployment
        /// <para>
        /// Update the function code deployment ID using the unique function ID. Use
        /// this endpoint to switch the code deployment that should be executed by the
        /// execution endpoint.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> UpdateDeployment(string functionId, string deploymentId) 
        {
            string path = "/functions/{functionId}/deployments/{deploymentId}".Replace("{functionId}", functionId).Replace("{deploymentId}", deploymentId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }

        /// <summary>
        /// Delete Deployment
        /// <para>
        /// Delete a code deployment by its unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> DeleteDeployment(string functionId, string deploymentId) 
        {
            string path = "/functions/{functionId}/deployments/{deploymentId}".Replace("{functionId}", functionId).Replace("{deploymentId}", deploymentId);

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
        /// Create Build
        /// </summary>
        public async Task<HttpResponseMessage> CreateBuild(string functionId, string deploymentId, string buildId) 
        {
            string path = "/functions/{functionId}/deployments/{deploymentId}/builds/{buildId}".Replace("{functionId}", functionId).Replace("{deploymentId}", deploymentId).Replace("{buildId}", buildId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// List Executions
        /// <para>
        /// Get a list of all the current user function execution logs. You can use the
        /// query params to filter your results.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> ListExecutions(string functionId, List<string> queries = null, string search = "") 
        {
            string path = "/functions/{functionId}/executions".Replace("{functionId}", functionId);

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
        /// Create Execution
        /// <para>
        /// Trigger a function execution. The returned object will return you the
        /// current execution status. You can ping the `Get Execution` endpoint to get
        /// updates on the current execution status. Once this endpoint is called, your
        /// function execution process will start asynchronously.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> CreateExecution(string functionId, string data = "", bool? xasync = false) 
        {
            string path = "/functions/{functionId}/executions".Replace("{functionId}", functionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "data", data },
                { "async", xasync }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Get Execution
        /// <para>
        /// Get a function execution log by its unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> GetExecution(string functionId, string executionId) 
        {
            string path = "/functions/{functionId}/executions/{executionId}".Replace("{functionId}", functionId).Replace("{executionId}", executionId);

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
        /// List Variables
        /// <para>
        /// Get a list of all variables of a specific function.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> ListVariables(string functionId) 
        {
            string path = "/functions/{functionId}/variables".Replace("{functionId}", functionId);

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
        /// Create Variable
        /// <para>
        /// Create a new function variable. These variables can be accessed within
        /// function in the `env` object under the request variable.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> CreateVariable(string functionId, string key, string xvalue) 
        {
            string path = "/functions/{functionId}/variables".Replace("{functionId}", functionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "key", key },
                { "value", xvalue }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Get Variable
        /// <para>
        /// Get a variable by its unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> GetVariable(string functionId, string variableId) 
        {
            string path = "/functions/{functionId}/variables/{variableId}".Replace("{functionId}", functionId).Replace("{variableId}", variableId);

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
        /// Update Variable
        /// <para>
        /// Update variable by its unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> UpdateVariable(string functionId, string variableId, string key, string xvalue = "") 
        {
            string path = "/functions/{functionId}/variables/{variableId}".Replace("{functionId}", functionId).Replace("{variableId}", variableId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "key", key },
                { "value", xvalue }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PUT", path, headers, parameters);
        }

        /// <summary>
        /// Delete Variable
        /// <para>
        /// Delete a variable by its unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> DeleteVariable(string functionId, string variableId) 
        {
            string path = "/functions/{functionId}/variables/{variableId}".Replace("{functionId}", functionId).Replace("{variableId}", variableId);

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