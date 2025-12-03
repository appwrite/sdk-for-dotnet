
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Functions : Service
    {
        public Functions(Client client) : base(client)
        {
        }

        /// <para>
        /// Get a list of all the project's functions. You can use the query params to
        /// filter your results.
        /// </para>
        /// </summary>
        public Task<Models.FunctionList> List(List<string>? queries = null, string? search = null, bool? total = null)
        {
            var apiPath = "/functions";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
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

        /// <para>
        /// Create a new function. You can pass a list of
        /// [permissions](https://appwrite.io/docs/permissions) to allow different
        /// project users or team with access to execute the function using the client
        /// API.
        /// </para>
        /// </summary>
        public Task<Models.Function> Create(string functionId, string name, Appwrite.Enums.Runtime runtime, List<string>? execute = null, List<string>? events = null, string? schedule = null, long? timeout = null, bool? enabled = null, bool? logging = null, string? entrypoint = null, string? commands = null, List<string>? scopes = null, string? installationId = null, string? providerRepositoryId = null, string? providerBranch = null, bool? providerSilentMode = null, string? providerRootDirectory = null, string? specification = null)
        {
            var apiPath = "/functions";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "functionId", functionId },
                { "name", name },
                { "runtime", runtime?.Value },
                { "execute", execute },
                { "events", events },
                { "schedule", schedule },
                { "timeout", timeout },
                { "enabled", enabled },
                { "logging", logging },
                { "entrypoint", entrypoint },
                { "commands", commands },
                { "scopes", scopes },
                { "installationId", installationId },
                { "providerRepositoryId", providerRepositoryId },
                { "providerBranch", providerBranch },
                { "providerSilentMode", providerSilentMode },
                { "providerRootDirectory", providerRootDirectory },
                { "specification", specification }
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

        /// <para>
        /// List allowed function specifications for this instance.
        /// </para>
        /// </summary>
        public Task<Models.SpecificationList> ListSpecifications()
        {
            var apiPath = "/functions/specifications";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.SpecificationList Convert(Dictionary<string, object> it) =>
                Models.SpecificationList.From(map: it);

            return _client.Call<Models.SpecificationList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

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

        /// <para>
        /// Update function by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Function> Update(string functionId, string name, Appwrite.Enums.Runtime? runtime = null, List<string>? execute = null, List<string>? events = null, string? schedule = null, long? timeout = null, bool? enabled = null, bool? logging = null, string? entrypoint = null, string? commands = null, List<string>? scopes = null, string? installationId = null, string? providerRepositoryId = null, string? providerBranch = null, bool? providerSilentMode = null, string? providerRootDirectory = null, string? specification = null)
        {
            var apiPath = "/functions/{functionId}"
                .Replace("{functionId}", functionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "runtime", runtime?.Value },
                { "execute", execute },
                { "events", events },
                { "schedule", schedule },
                { "timeout", timeout },
                { "enabled", enabled },
                { "logging", logging },
                { "entrypoint", entrypoint },
                { "commands", commands },
                { "scopes", scopes },
                { "installationId", installationId },
                { "providerRepositoryId", providerRepositoryId },
                { "providerBranch", providerBranch },
                { "providerSilentMode", providerSilentMode },
                { "providerRootDirectory", providerRootDirectory },
                { "specification", specification }
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

        /// <para>
        /// Update the function active deployment. Use this endpoint to switch the code
        /// deployment that should be used when visitor opens your function.
        /// </para>
        /// </summary>
        public Task<Models.Function> UpdateFunctionDeployment(string functionId, string deploymentId)
        {
            var apiPath = "/functions/{functionId}/deployment"
                .Replace("{functionId}", functionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "deploymentId", deploymentId }
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

        /// <para>
        /// Get a list of all the function's code deployments. You can use the query
        /// params to filter your results.
        /// </para>
        /// </summary>
        public Task<Models.DeploymentList> ListDeployments(string functionId, List<string>? queries = null, string? search = null, bool? total = null)
        {
            var apiPath = "/functions/{functionId}/deployments"
                .Replace("{functionId}", functionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
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

        /// <para>
        /// Create a new function code deployment. Use this endpoint to upload a new
        /// version of your code function. To execute your newly uploaded code, you'll
        /// need to update the function's deployment to use your new deployment UID.
        /// 
        /// This endpoint accepts a tar.gz file compressed with your code. Make sure to
        /// include any dependencies your code has within the compressed file. You can
        /// learn more about code packaging in the [Appwrite Cloud Functions
        /// tutorial](https://appwrite.io/docs/functions).
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

        /// <para>
        /// Create a new build for an existing function deployment. This endpoint
        /// allows you to rebuild a deployment with the updated function configuration,
        /// including its entrypoint and build commands if they have been modified. The
        /// build process will be queued and executed asynchronously. The original
        /// deployment's code will be preserved and used for the new build.
        /// </para>
        /// </summary>
        public Task<Models.Deployment> CreateDuplicateDeployment(string functionId, string deploymentId, string? buildId = null)
        {
            var apiPath = "/functions/{functionId}/deployments/duplicate"
                .Replace("{functionId}", functionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "deploymentId", deploymentId },
                { "buildId", buildId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Deployment Convert(Dictionary<string, object> it) =>
                Models.Deployment.From(map: it);

            return _client.Call<Models.Deployment>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a deployment based on a template.
        /// 
        /// Use this endpoint with combination of
        /// [listTemplates](https://appwrite.io/docs/products/functions/templates) to
        /// find the template details.
        /// </para>
        /// </summary>
        public Task<Models.Deployment> CreateTemplateDeployment(string functionId, string repository, string owner, string rootDirectory, Appwrite.Enums.TemplateReferenceType type, string reference, bool? activate = null)
        {
            var apiPath = "/functions/{functionId}/deployments/template"
                .Replace("{functionId}", functionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "repository", repository },
                { "owner", owner },
                { "rootDirectory", rootDirectory },
                { "type", type?.Value },
                { "reference", reference },
                { "activate", activate }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Deployment Convert(Dictionary<string, object> it) =>
                Models.Deployment.From(map: it);

            return _client.Call<Models.Deployment>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a deployment when a function is connected to VCS.
        /// 
        /// This endpoint lets you create deployment from a branch, commit, or a tag.
        /// </para>
        /// </summary>
        public Task<Models.Deployment> CreateVcsDeployment(string functionId, Appwrite.Enums.VCSReferenceType type, string reference, bool? activate = null)
        {
            var apiPath = "/functions/{functionId}/deployments/vcs"
                .Replace("{functionId}", functionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "type", type?.Value },
                { "reference", reference },
                { "activate", activate }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Deployment Convert(Dictionary<string, object> it) =>
                Models.Deployment.From(map: it);

            return _client.Call<Models.Deployment>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a function deployment by its unique ID.
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

        /// <para>
        /// Get a function deployment content by its unique ID. The endpoint response
        /// return with a 'Content-Disposition: attachment' header that tells the
        /// browser to start downloading the file to user downloads directory.
        /// </para>
        /// </summary>
        public Task<byte[]> GetDeploymentDownload(string functionId, string deploymentId, Appwrite.Enums.DeploymentDownloadType? type = null)
        {
            var apiPath = "/functions/{functionId}/deployments/{deploymentId}/download"
                .Replace("{functionId}", functionId)
                .Replace("{deploymentId}", deploymentId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "type", type?.Value }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };



            return _client.Call<byte[]>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <para>
        /// Cancel an ongoing function deployment build. If the build is already in
        /// progress, it will be stopped and marked as canceled. If the build hasn't
        /// started yet, it will be marked as canceled without executing. You cannot
        /// cancel builds that have already completed (status 'ready') or failed. The
        /// response includes the final build status and details.
        /// </para>
        /// </summary>
        public Task<Models.Deployment> UpdateDeploymentStatus(string functionId, string deploymentId)
        {
            var apiPath = "/functions/{functionId}/deployments/{deploymentId}/status"
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
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a list of all the current user function execution logs. You can use the
        /// query params to filter your results.
        /// </para>
        /// </summary>
        public Task<Models.ExecutionList> ListExecutions(string functionId, List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/functions/{functionId}/executions"
                .Replace("{functionId}", functionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
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

        /// <para>
        /// Trigger a function execution. The returned object will return you the
        /// current execution status. You can ping the `Get Execution` endpoint to get
        /// updates on the current execution status. Once this endpoint is called, your
        /// function execution process will start asynchronously.
        /// </para>
        /// </summary>
        public Task<Models.Execution> CreateExecution(string functionId, string? body = null, bool? xasync = null, string? xpath = null, Appwrite.Enums.ExecutionMethod? method = null, object? headers = null, string? scheduledAt = null)
        {
            var apiPath = "/functions/{functionId}/executions"
                .Replace("{functionId}", functionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "body", body },
                { "async", xasync },
                { "path", xpath },
                { "method", method?.Value },
                { "headers", headers },
                { "scheduledAt", scheduledAt }
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

        /// <para>
        /// Delete a function execution by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> DeleteExecution(string functionId, string executionId)
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



            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

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

        /// <para>
        /// Create a new function environment variable. These variables can be accessed
        /// in the function at runtime as environment variables.
        /// </para>
        /// </summary>
        public Task<Models.Variable> CreateVariable(string functionId, string key, string xvalue, bool? secret = null)
        {
            var apiPath = "/functions/{functionId}/variables"
                .Replace("{functionId}", functionId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "value", xvalue },
                { "secret", secret }
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

        /// <para>
        /// Update variable by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Variable> UpdateVariable(string functionId, string variableId, string key, string? xvalue = null, bool? secret = null)
        {
            var apiPath = "/functions/{functionId}/variables/{variableId}"
                .Replace("{functionId}", functionId)
                .Replace("{variableId}", variableId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "value", xvalue },
                { "secret", secret }
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
