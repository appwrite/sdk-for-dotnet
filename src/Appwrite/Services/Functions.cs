
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;

namespace Appwrite.Services
{
    public class Functions : Service
    {
        public Functions(Client client) : base(client)
        {
        }

        /// <summary>
        /// List Functions
        /// <para>
        /// Get a list of all the project's functions. You can use the query params to
        /// filter your results.
        /// </para>
        /// </summary>
        public Task<Models.FunctionList> List(List<string>? queries = null, string? search = null)
        {
            var apiPath = "/functions";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.FunctionList Convert(Dictionary<string, object> it) =>
                Models.FunctionList.From(map: it);


            return _client.Call<Models.FunctionList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
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
        public Task<Models.Function> Create(string functionId, string name, string runtime, List<string>? execute = null, List<string>? events = null, string? schedule = null, long? timeout = null, bool? enabled = null, bool? logging = null, string? entrypoint = null, string? commands = null, string? installationId = null, string? providerRepositoryId = null, string? providerBranch = null, bool? providerSilentMode = null, string? providerRootDirectory = null, string? templateRepository = null, string? templateOwner = null, string? templateRootDirectory = null, string? templateBranch = null)
        {
            var apiPath = "/functions";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "functionId", functionId },
                { "name", name },
                { "runtime", runtime },
                { "execute", execute },
                { "events", events },
                { "schedule", schedule },
                { "timeout", timeout },
                { "enabled", enabled },
                { "logging", logging },
                { "entrypoint", entrypoint },
                { "commands", commands },
                { "installationId", installationId },
                { "providerRepositoryId", providerRepositoryId },
                { "providerBranch", providerBranch },
                { "providerSilentMode", providerSilentMode },
                { "providerRootDirectory", providerRootDirectory },
                { "templateRepository", templateRepository },
                { "templateOwner", templateOwner },
                { "templateRootDirectory", templateRootDirectory },
                { "templateBranch", templateBranch }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Function Convert(Dictionary<string, object> it) =>
                Models.Function.From(map: it);


            return _client.Call<Models.Function>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
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
            var apiPath = "/functions/runtimes";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.RuntimeList Convert(Dictionary<string, object> it) =>
                Models.RuntimeList.From(map: it);


            return _client.Call<Models.RuntimeList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
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
            var apiPath = "/functions/{functionId}"
                .Replace("{functionId}", functionId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Function Convert(Dictionary<string, object> it) =>
                Models.Function.From(map: it);


            return _client.Call<Models.Function>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update Function
        /// <para>
        /// Update function by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Function> Update(string functionId, string name, string runtime, List<string>? execute = null, List<string>? events = null, string? schedule = null, long? timeout = null, bool? enabled = null, bool? logging = null, string? entrypoint = null, string? commands = null, string? installationId = null, string? providerRepositoryId = null, string? providerBranch = null, bool? providerSilentMode = null, string? providerRootDirectory = null)
        {
            var apiPath = "/functions/{functionId}"
                .Replace("{functionId}", functionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "runtime", runtime },
                { "execute", execute },
                { "events", events },
                { "schedule", schedule },
                { "timeout", timeout },
                { "enabled", enabled },
                { "logging", logging },
                { "entrypoint", entrypoint },
                { "commands", commands },
                { "installationId", installationId },
                { "providerRepositoryId", providerRepositoryId },
                { "providerBranch", providerBranch },
                { "providerSilentMode", providerSilentMode },
                { "providerRootDirectory", providerRootDirectory }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Function Convert(Dictionary<string, object> it) =>
                Models.Function.From(map: it);


            return _client.Call<Models.Function>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
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
            var apiPath = "/functions/{functionId}"
                .Replace("{functionId}", functionId);

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

        /// <summary>
        /// List Deployments
        /// <para>
        /// Get a list of all the project's code deployments. You can use the query
        /// params to filter your results.
        /// </para>
        /// </summary>
        public Task<Models.DeploymentList> ListDeployments(string functionId, List<string>? queries = null, string? search = null)
        {
            var apiPath = "/functions/{functionId}/deployments"
                .Replace("{functionId}", functionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.DeploymentList Convert(Dictionary<string, object> it) =>
                Models.DeploymentList.From(map: it);


            return _client.Call<Models.DeploymentList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
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
        /// Use the "command" param to set the entrypoint used to execute your code.
        /// </para>
        /// </summary>
        public Task<Models.Deployment> CreateDeployment(string functionId, InputFile code, bool activate, string? entrypoint = null, string? commands = null, Action<UploadProgress>? onProgress = null)
        {
            var apiPath = "/functions/{functionId}/deployments"
                .Replace("{functionId}", functionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "entrypoint", entrypoint },
                { "commands", commands },
                { "code", code },
                { "activate", activate }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "multipart/form-data" }
            };



            static Models.Deployment Convert(Dictionary<string, object> it) =>
                Models.Deployment.From(map: it);

            string? idParamName = null;

            var paramName = "code";

            return _client.ChunkedUpload(
                apiPath,
                apiHeaders,
                apiParameters,
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
        public Task<Models.Deployment> GetDeployment(string functionId, string deploymentId)
        {
            var apiPath = "/functions/{functionId}/deployments/{deploymentId}"
                .Replace("{functionId}", functionId)
                .Replace("{deploymentId}", deploymentId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Deployment Convert(Dictionary<string, object> it) =>
                Models.Deployment.From(map: it);


            return _client.Call<Models.Deployment>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
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
            var apiPath = "/functions/{functionId}/deployments/{deploymentId}"
                .Replace("{functionId}", functionId)
                .Replace("{deploymentId}", deploymentId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Function Convert(Dictionary<string, object> it) =>
                Models.Function.From(map: it);


            return _client.Call<Models.Function>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
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
            var apiPath = "/functions/{functionId}/deployments/{deploymentId}"
                .Replace("{functionId}", functionId)
                .Replace("{deploymentId}", deploymentId);

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

        /// <summary>
        /// Create Build
        /// <para>
        /// Create a new build for an Appwrite Function deployment. This endpoint can
        /// be used to retry a failed build.
        /// </para>
        /// </summary>
        public Task<object> CreateBuild(string functionId, string deploymentId, string buildId)
        {
            var apiPath = "/functions/{functionId}/deployments/{deploymentId}/builds/{buildId}"
                .Replace("{functionId}", functionId)
                .Replace("{deploymentId}", deploymentId)
                .Replace("{buildId}", buildId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };





            return _client.Call<object>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <summary>
        /// Download Deployment
        /// </summary>
        public Task<byte[]> DownloadDeployment(string functionId, string deploymentId)
        {
            var apiPath = "/functions/{functionId}/deployments/{deploymentId}/download"
                .Replace("{functionId}", functionId)
                .Replace("{deploymentId}", deploymentId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            return _client.Call<byte[]>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <summary>
        /// List Executions
        /// <para>
        /// Get a list of all the current user function execution logs. You can use the
        /// query params to filter your results.
        /// </para>
        /// </summary>
        public Task<Models.ExecutionList> ListExecutions(string functionId, List<string>? queries = null, string? search = null)
        {
            var apiPath = "/functions/{functionId}/executions"
                .Replace("{functionId}", functionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.ExecutionList Convert(Dictionary<string, object> it) =>
                Models.ExecutionList.From(map: it);


            return _client.Call<Models.ExecutionList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
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
        public Task<Models.Execution> CreateExecution(string functionId, string? body = null, bool? xasync = null, string? xpath = null, string? method = null, object? headers = null)
        {
            var apiPath = "/functions/{functionId}/executions"
                .Replace("{functionId}", functionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "body", body },
                { "async", xasync },
                { "path", xpath },
                { "method", method },
                { "headers", headers }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Execution Convert(Dictionary<string, object> it) =>
                Models.Execution.From(map: it);


            return _client.Call<Models.Execution>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
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
            var apiPath = "/functions/{functionId}/executions/{executionId}"
                .Replace("{functionId}", functionId)
                .Replace("{executionId}", executionId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Execution Convert(Dictionary<string, object> it) =>
                Models.Execution.From(map: it);


            return _client.Call<Models.Execution>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// List Variables
        /// <para>
        /// Get a list of all variables of a specific function.
        /// </para>
        /// </summary>
        public Task<Models.VariableList> ListVariables(string functionId)
        {
            var apiPath = "/functions/{functionId}/variables"
                .Replace("{functionId}", functionId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.VariableList Convert(Dictionary<string, object> it) =>
                Models.VariableList.From(map: it);


            return _client.Call<Models.VariableList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create Variable
        /// <para>
        /// Create a new function environment variable. These variables can be accessed
        /// in the function at runtime as environment variables.
        /// </para>
        /// </summary>
        public Task<Models.Variable> CreateVariable(string functionId, string key, string xvalue)
        {
            var apiPath = "/functions/{functionId}/variables"
                .Replace("{functionId}", functionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "value", xvalue }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Variable Convert(Dictionary<string, object> it) =>
                Models.Variable.From(map: it);


            return _client.Call<Models.Variable>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get Variable
        /// <para>
        /// Get a variable by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Variable> GetVariable(string functionId, string variableId)
        {
            var apiPath = "/functions/{functionId}/variables/{variableId}"
                .Replace("{functionId}", functionId)
                .Replace("{variableId}", variableId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Variable Convert(Dictionary<string, object> it) =>
                Models.Variable.From(map: it);


            return _client.Call<Models.Variable>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update Variable
        /// <para>
        /// Update variable by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Variable> UpdateVariable(string functionId, string variableId, string key, string? xvalue = null)
        {
            var apiPath = "/functions/{functionId}/variables/{variableId}"
                .Replace("{functionId}", functionId)
                .Replace("{variableId}", variableId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "value", xvalue }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Variable Convert(Dictionary<string, object> it) =>
                Models.Variable.From(map: it);


            return _client.Call<Models.Variable>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Delete Variable
        /// <para>
        /// Delete a variable by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> DeleteVariable(string functionId, string variableId)
        {
            var apiPath = "/functions/{functionId}/variables/{variableId}"
                .Replace("{functionId}", functionId)
                .Replace("{variableId}", variableId);

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
