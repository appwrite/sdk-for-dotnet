
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Appwrite.Models;

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
        public Task<Models.FunctionList> List(string? search = null, long? limit = null, long? offset = null, string? cursor = null, string? cursorDirection = null, OrderType orderType = OrderType.ASC)
        {
            var path = "/functions";

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


            static Models.FunctionList Convert(Dictionary<string, object> it) =>
                Models.FunctionList.From(map: it);


            return _client.Call<Models.FunctionList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Create Function
        /// <para>
        /// Create a new function. You can pass a list of
        /// [permissions](/docs/permissions) to allow different project users or team
        /// with access to execute the function using the client API.
        /// </para>
        /// </summary>
        public Task<Models.Function> Create(string functionId, string name, List<object> execute, string runtime, object? vars = null, List<object>? events = null, string? schedule = null, long? timeout = null)
        {
            var path = "/functions";

            var parameters = new Dictionary<string, object?>()
            {
                { "functionId", functionId },
                { "name", name },
                { "execute", execute },
                { "runtime", runtime },
                { "vars", vars },
                { "events", events },
                { "schedule", schedule },
                { "timeout", timeout }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Function Convert(Dictionary<string, object> it) =>
                Models.Function.From(map: it);


            return _client.Call<Models.Function>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// List runtimes
        /// <para>
        /// Get a list of all runtimes that are currently active on your instance.
        /// </para>
        /// </summary>
        public Task<Models.RuntimeList> ListRuntimes()
        {
            var path = "/functions/runtimes";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.RuntimeList Convert(Dictionary<string, object> it) =>
                Models.RuntimeList.From(map: it);


            return _client.Call<Models.RuntimeList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Get Function
        /// <para>
        /// Get a function by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Function> Get(string functionId)
        {
            var path = "/functions/{functionId}"
                .Replace("{functionId}", functionId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Function Convert(Dictionary<string, object> it) =>
                Models.Function.From(map: it);


            return _client.Call<Models.Function>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Update Function
        /// <para>
        /// Update function by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Function> Update(string functionId, string name, List<object> execute, object? vars = null, List<object>? events = null, string? schedule = null, long? timeout = null)
        {
            var path = "/functions/{functionId}"
                .Replace("{functionId}", functionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "execute", execute },
                { "vars", vars },
                { "events", events },
                { "schedule", schedule },
                { "timeout", timeout }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Function Convert(Dictionary<string, object> it) =>
                Models.Function.From(map: it);


            return _client.Call<Models.Function>(
                method: "PUT",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Delete Function
        /// <para>
        /// Delete a function by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> Delete(string functionId)
        {
            var path = "/functions/{functionId}"
                .Replace("{functionId}", functionId);

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
        /// List Deployments
        /// <para>
        /// Get a list of all the project's code deployments. You can use the query
        /// params to filter your results.
        /// </para>
        /// </summary>
        public Task<Models.DeploymentList> ListDeployments(string functionId, string? search = null, long? limit = null, long? offset = null, string? cursor = null, string? cursorDirection = null, OrderType orderType = OrderType.ASC)
        {
            var path = "/functions/{functionId}/deployments"
                .Replace("{functionId}", functionId);

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


            static Models.DeploymentList Convert(Dictionary<string, object> it) =>
                Models.DeploymentList.From(map: it);


            return _client.Call<Models.DeploymentList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
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
        public Task<Models.Deployment> CreateDeployment(string functionId, string entrypoint, InputFile code, bool activate, Action<UploadProgress>? onProgress = null)
        {
            var path = "/functions/{functionId}/deployments"
                .Replace("{functionId}", functionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "entrypoint", entrypoint },
                { "code", code },
                { "activate", activate }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "multipart/form-data" }
            };


            static Models.Deployment Convert(Dictionary<string, object> it) =>
                Models.Deployment.From(map: it);

            string? idParamName = null;

            var paramName = "code";

            return _client.ChunkedUpload(
                path,
                headers,
                parameters,
                Convert,
                paramName,
                idParamName,
                onProgress);
        }

        /// <summary>
        /// Get Deployment
        /// <para>
        /// Get a code deployment by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.DeploymentList> GetDeployment(string functionId, string deploymentId)
        {
            var path = "/functions/{functionId}/deployments/{deploymentId}"
                .Replace("{functionId}", functionId)
                .Replace("{deploymentId}", deploymentId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.DeploymentList Convert(Dictionary<string, object> it) =>
                Models.DeploymentList.From(map: it);


            return _client.Call<Models.DeploymentList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Update Function Deployment
        /// <para>
        /// Update the function code deployment ID using the unique function ID. Use
        /// this endpoint to switch the code deployment that should be executed by the
        /// execution endpoint.
        /// </para>
        /// </summary>
        public Task<Models.Function> UpdateDeployment(string functionId, string deploymentId)
        {
            var path = "/functions/{functionId}/deployments/{deploymentId}"
                .Replace("{functionId}", functionId)
                .Replace("{deploymentId}", deploymentId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Function Convert(Dictionary<string, object> it) =>
                Models.Function.From(map: it);


            return _client.Call<Models.Function>(
                method: "PATCH",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Delete Deployment
        /// <para>
        /// Delete a code deployment by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> DeleteDeployment(string functionId, string deploymentId)
        {
            var path = "/functions/{functionId}/deployments/{deploymentId}"
                .Replace("{functionId}", functionId)
                .Replace("{deploymentId}", deploymentId);

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
        /// Retry Build
        /// </summary>
        public Task<object> RetryBuild(string functionId, string deploymentId, string buildId)
        {
            var path = "/functions/{functionId}/deployments/{deploymentId}/builds/{buildId}"
                .Replace("{functionId}", functionId)
                .Replace("{deploymentId}", deploymentId)
                .Replace("{buildId}", buildId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };




            return _client.Call<object>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);
        }

        /// <summary>
        /// List Executions
        /// <para>
        /// Get a list of all the current user function execution logs. You can use the
        /// query params to filter your results. On admin mode, this endpoint will
        /// return a list of all of the project's executions. [Learn more about
        /// different API modes](/docs/admin).
        /// </para>
        /// </summary>
        public Task<Models.ExecutionList> ListExecutions(string functionId, long? limit = null, long? offset = null, string? search = null, string? cursor = null, string? cursorDirection = null)
        {
            var path = "/functions/{functionId}/executions"
                .Replace("{functionId}", functionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "limit", limit },
                { "offset", offset },
                { "search", search },
                { "cursor", cursor },
                { "cursorDirection", cursorDirection }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.ExecutionList Convert(Dictionary<string, object> it) =>
                Models.ExecutionList.From(map: it);


            return _client.Call<Models.ExecutionList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
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
        public Task<Models.Execution> CreateExecution(string functionId, string? data = null, bool? xasync = null)
        {
            var path = "/functions/{functionId}/executions"
                .Replace("{functionId}", functionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "data", data },
                { "async", xasync }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Execution Convert(Dictionary<string, object> it) =>
                Models.Execution.From(map: it);


            return _client.Call<Models.Execution>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Get Execution
        /// <para>
        /// Get a function execution log by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Execution> GetExecution(string functionId, string executionId)
        {
            var path = "/functions/{functionId}/executions/{executionId}"
                .Replace("{functionId}", functionId)
                .Replace("{executionId}", executionId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Execution Convert(Dictionary<string, object> it) =>
                Models.Execution.From(map: it);


            return _client.Call<Models.Execution>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }
    }
}