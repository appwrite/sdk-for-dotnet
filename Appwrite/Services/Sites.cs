
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Sites : Service
    {
        public Sites(Client client) : base(client)
        {
        }

        /// <para>
        /// Get a list of all the project's sites. You can use the query params to
        /// filter your results.
        /// </para>
        /// </summary>
        public Task<Models.SiteList> List(List<string>? queries = null, string? search = null, bool? total = null)
        {
            var apiPath = "/sites";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.SiteList Convert(Dictionary<string, object> it) =>
                Models.SiteList.From(map: it);

            return _client.Call<Models.SiteList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new site.
        /// </para>
        /// </summary>
        public Task<Models.Site> Create(string siteId, string name, Appwrite.Enums.Framework framework, Appwrite.Enums.BuildRuntime buildRuntime, bool? enabled = null, bool? logging = null, long? timeout = null, string? installCommand = null, string? buildCommand = null, string? outputDirectory = null, Appwrite.Enums.Adapter? adapter = null, string? installationId = null, string? fallbackFile = null, string? providerRepositoryId = null, string? providerBranch = null, bool? providerSilentMode = null, string? providerRootDirectory = null, string? specification = null)
        {
            var apiPath = "/sites";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "siteId", siteId },
                { "name", name },
                { "framework", framework?.Value },
                { "enabled", enabled },
                { "logging", logging },
                { "timeout", timeout },
                { "installCommand", installCommand },
                { "buildCommand", buildCommand },
                { "outputDirectory", outputDirectory },
                { "buildRuntime", buildRuntime?.Value },
                { "adapter", adapter?.Value },
                { "installationId", installationId },
                { "fallbackFile", fallbackFile },
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


            static Models.Site Convert(Dictionary<string, object> it) =>
                Models.Site.From(map: it);

            return _client.Call<Models.Site>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a list of all frameworks that are currently available on the server
        /// instance.
        /// </para>
        /// </summary>
        public Task<Models.FrameworkList> ListFrameworks()
        {
            var apiPath = "/sites/frameworks";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.FrameworkList Convert(Dictionary<string, object> it) =>
                Models.FrameworkList.From(map: it);

            return _client.Call<Models.FrameworkList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// List allowed site specifications for this instance.
        /// </para>
        /// </summary>
        public Task<Models.SpecificationList> ListSpecifications()
        {
            var apiPath = "/sites/specifications";

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
        /// Get a site by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Site> Get(string siteId)
        {
            var apiPath = "/sites/{siteId}"
                .Replace("{siteId}", siteId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.Site Convert(Dictionary<string, object> it) =>
                Models.Site.From(map: it);

            return _client.Call<Models.Site>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update site by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Site> Update(string siteId, string name, Appwrite.Enums.Framework framework, bool? enabled = null, bool? logging = null, long? timeout = null, string? installCommand = null, string? buildCommand = null, string? outputDirectory = null, Appwrite.Enums.BuildRuntime? buildRuntime = null, Appwrite.Enums.Adapter? adapter = null, string? fallbackFile = null, string? installationId = null, string? providerRepositoryId = null, string? providerBranch = null, bool? providerSilentMode = null, string? providerRootDirectory = null, string? specification = null)
        {
            var apiPath = "/sites/{siteId}"
                .Replace("{siteId}", siteId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "framework", framework?.Value },
                { "enabled", enabled },
                { "logging", logging },
                { "timeout", timeout },
                { "installCommand", installCommand },
                { "buildCommand", buildCommand },
                { "outputDirectory", outputDirectory },
                { "buildRuntime", buildRuntime?.Value },
                { "adapter", adapter?.Value },
                { "fallbackFile", fallbackFile },
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


            static Models.Site Convert(Dictionary<string, object> it) =>
                Models.Site.From(map: it);

            return _client.Call<Models.Site>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a site by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> Delete(string siteId)
        {
            var apiPath = "/sites/{siteId}"
                .Replace("{siteId}", siteId);

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
        /// Update the site active deployment. Use this endpoint to switch the code
        /// deployment that should be used when visitor opens your site.
        /// </para>
        /// </summary>
        public Task<Models.Site> UpdateSiteDeployment(string siteId, string deploymentId)
        {
            var apiPath = "/sites/{siteId}/deployment"
                .Replace("{siteId}", siteId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "deploymentId", deploymentId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Site Convert(Dictionary<string, object> it) =>
                Models.Site.From(map: it);

            return _client.Call<Models.Site>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a list of all the site's code deployments. You can use the query params
        /// to filter your results.
        /// </para>
        /// </summary>
        public Task<Models.DeploymentList> ListDeployments(string siteId, List<string>? queries = null, string? search = null, bool? total = null)
        {
            var apiPath = "/sites/{siteId}/deployments"
                .Replace("{siteId}", siteId);

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
        /// Create a new site code deployment. Use this endpoint to upload a new
        /// version of your site code. To activate your newly uploaded code, you'll
        /// need to update the site's deployment to use your new deployment ID.
        /// </para>
        /// </summary>
        public Task<Models.Deployment> CreateDeployment(string siteId, InputFile code, bool activate, string? installCommand = null, string? buildCommand = null, string? outputDirectory = null, Action<UploadProgress>? onProgress = null)
        {
            var apiPath = "/sites/{siteId}/deployments"
                .Replace("{siteId}", siteId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "installCommand", installCommand },
                { "buildCommand", buildCommand },
                { "outputDirectory", outputDirectory },
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
        /// Create a new build for an existing site deployment. This endpoint allows
        /// you to rebuild a deployment with the updated site configuration, including
        /// its commands and output directory if they have been modified. The build
        /// process will be queued and executed asynchronously. The original
        /// deployment's code will be preserved and used for the new build.
        /// </para>
        /// </summary>
        public Task<Models.Deployment> CreateDuplicateDeployment(string siteId, string deploymentId)
        {
            var apiPath = "/sites/{siteId}/deployments/duplicate"
                .Replace("{siteId}", siteId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "deploymentId", deploymentId }
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
        /// [listTemplates](https://appwrite.io/docs/products/sites/templates) to find
        /// the template details.
        /// </para>
        /// </summary>
        public Task<Models.Deployment> CreateTemplateDeployment(string siteId, string repository, string owner, string rootDirectory, Appwrite.Enums.TemplateReferenceType type, string reference, bool? activate = null)
        {
            var apiPath = "/sites/{siteId}/deployments/template"
                .Replace("{siteId}", siteId);

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
        /// Create a deployment when a site is connected to VCS.
        /// 
        /// This endpoint lets you create deployment from a branch, commit, or a tag.
        /// </para>
        /// </summary>
        public Task<Models.Deployment> CreateVcsDeployment(string siteId, Appwrite.Enums.VCSReferenceType type, string reference, bool? activate = null)
        {
            var apiPath = "/sites/{siteId}/deployments/vcs"
                .Replace("{siteId}", siteId);

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
        /// Get a site deployment by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Deployment> GetDeployment(string siteId, string deploymentId)
        {
            var apiPath = "/sites/{siteId}/deployments/{deploymentId}"
                .Replace("{siteId}", siteId)
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
        /// Delete a site deployment by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> DeleteDeployment(string siteId, string deploymentId)
        {
            var apiPath = "/sites/{siteId}/deployments/{deploymentId}"
                .Replace("{siteId}", siteId)
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
        /// Get a site deployment content by its unique ID. The endpoint response
        /// return with a 'Content-Disposition: attachment' header that tells the
        /// browser to start downloading the file to user downloads directory.
        /// </para>
        /// </summary>
        public Task<byte[]> GetDeploymentDownload(string siteId, string deploymentId, Appwrite.Enums.DeploymentDownloadType? type = null)
        {
            var apiPath = "/sites/{siteId}/deployments/{deploymentId}/download"
                .Replace("{siteId}", siteId)
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
        /// Cancel an ongoing site deployment build. If the build is already in
        /// progress, it will be stopped and marked as canceled. If the build hasn't
        /// started yet, it will be marked as canceled without executing. You cannot
        /// cancel builds that have already completed (status 'ready') or failed. The
        /// response includes the final build status and details.
        /// </para>
        /// </summary>
        public Task<Models.Deployment> UpdateDeploymentStatus(string siteId, string deploymentId)
        {
            var apiPath = "/sites/{siteId}/deployments/{deploymentId}/status"
                .Replace("{siteId}", siteId)
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
        /// Get a list of all site logs. You can use the query params to filter your
        /// results.
        /// </para>
        /// </summary>
        public Task<Models.ExecutionList> ListLogs(string siteId, List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/sites/{siteId}/logs"
                .Replace("{siteId}", siteId);

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
        /// Get a site request log by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Execution> GetLog(string siteId, string logId)
        {
            var apiPath = "/sites/{siteId}/logs/{logId}"
                .Replace("{siteId}", siteId)
                .Replace("{logId}", logId);

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
        /// Delete a site log by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> DeleteLog(string siteId, string logId)
        {
            var apiPath = "/sites/{siteId}/logs/{logId}"
                .Replace("{siteId}", siteId)
                .Replace("{logId}", logId);

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
        /// Get a list of all variables of a specific site.
        /// </para>
        /// </summary>
        public Task<Models.VariableList> ListVariables(string siteId)
        {
            var apiPath = "/sites/{siteId}/variables"
                .Replace("{siteId}", siteId);

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
        /// Create a new site variable. These variables can be accessed during build
        /// and runtime (server-side rendering) as environment variables.
        /// </para>
        /// </summary>
        public Task<Models.Variable> CreateVariable(string siteId, string key, string xvalue, bool? secret = null)
        {
            var apiPath = "/sites/{siteId}/variables"
                .Replace("{siteId}", siteId);

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
        public Task<Models.Variable> GetVariable(string siteId, string variableId)
        {
            var apiPath = "/sites/{siteId}/variables/{variableId}"
                .Replace("{siteId}", siteId)
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
        public Task<Models.Variable> UpdateVariable(string siteId, string variableId, string key, string? xvalue = null, bool? secret = null)
        {
            var apiPath = "/sites/{siteId}/variables/{variableId}"
                .Replace("{siteId}", siteId)
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
        public Task<object> DeleteVariable(string siteId, string variableId)
        {
            var apiPath = "/sites/{siteId}/variables/{variableId}"
                .Replace("{siteId}", siteId)
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
