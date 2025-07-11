
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Vcs : Service
    {
        public Vcs(Client client) : base(client)
        {
        }

        /// <para>
        /// Analyze a GitHub repository to automatically detect the programming
        /// language and runtime environment. This endpoint scans the repository's
        /// files and language statistics to determine the appropriate runtime settings
        /// for your function. The GitHub installation must be properly configured and
        /// the repository must be accessible through your installation for this
        /// endpoint to work.
        /// </para>
        /// </summary>
        public Task<Models.DetectionFramework> CreateRepositoryDetection(string installationId, string providerRepositoryId, Appwrite.Enums.VCSDetectionType type, string? providerRootDirectory = null)
        {
            var apiPath = "/vcs/github/installations/{installationId}/detections"
                .Replace("{installationId}", installationId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "providerRepositoryId", providerRepositoryId },
                { "type", type },
                { "providerRootDirectory", providerRootDirectory }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.DetectionFramework Convert(Dictionary<string, object> it) =>
                Models.DetectionFramework.From(map: it);

            return _client.Call<Models.DetectionFramework>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a list of GitHub repositories available through your installation. This
        /// endpoint returns repositories with their basic information, detected
        /// runtime environments, and latest push dates. You can optionally filter
        /// repositories using a search term. Each repository's runtime is
        /// automatically detected based on its contents and language statistics. The
        /// GitHub installation must be properly configured for this endpoint to work.
        /// </para>
        /// </summary>
        public Task<Models.ProviderRepositoryFrameworkList> ListRepositories(string installationId, Appwrite.Enums.VCSDetectionType type, string? search = null)
        {
            var apiPath = "/vcs/github/installations/{installationId}/providerRepositories"
                .Replace("{installationId}", installationId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "type", type },
                { "search", search }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.ProviderRepositoryFrameworkList Convert(Dictionary<string, object> it) =>
                Models.ProviderRepositoryFrameworkList.From(map: it);

            return _client.Call<Models.ProviderRepositoryFrameworkList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new GitHub repository through your installation. This endpoint
        /// allows you to create either a public or private repository by specifying a
        /// name and visibility setting. The repository will be created under your
        /// GitHub user account or organization, depending on your installation type.
        /// The GitHub installation must be properly configured and have the necessary
        /// permissions for repository creation.
        /// </para>
        /// </summary>
        public Task<Models.ProviderRepository> CreateRepository(string installationId, string name, bool xprivate)
        {
            var apiPath = "/vcs/github/installations/{installationId}/providerRepositories"
                .Replace("{installationId}", installationId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "private", xprivate }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.ProviderRepository Convert(Dictionary<string, object> it) =>
                Models.ProviderRepository.From(map: it);

            return _client.Call<Models.ProviderRepository>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get detailed information about a specific GitHub repository from your
        /// installation. This endpoint returns repository details including its ID,
        /// name, visibility status, organization, and latest push date. The GitHub
        /// installation must be properly configured and have access to the requested
        /// repository for this endpoint to work.
        /// </para>
        /// </summary>
        public Task<Models.ProviderRepository> GetRepository(string installationId, string providerRepositoryId)
        {
            var apiPath = "/vcs/github/installations/{installationId}/providerRepositories/{providerRepositoryId}"
                .Replace("{installationId}", installationId)
                .Replace("{providerRepositoryId}", providerRepositoryId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.ProviderRepository Convert(Dictionary<string, object> it) =>
                Models.ProviderRepository.From(map: it);

            return _client.Call<Models.ProviderRepository>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a list of all branches from a GitHub repository in your installation.
        /// This endpoint returns the names of all branches in the repository and their
        /// total count. The GitHub installation must be properly configured and have
        /// access to the requested repository for this endpoint to work.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.BranchList> ListRepositoryBranches(string installationId, string providerRepositoryId)
        {
            var apiPath = "/vcs/github/installations/{installationId}/providerRepositories/{providerRepositoryId}/branches"
                .Replace("{installationId}", installationId)
                .Replace("{providerRepositoryId}", providerRepositoryId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.BranchList Convert(Dictionary<string, object> it) =>
                Models.BranchList.From(map: it);

            return _client.Call<Models.BranchList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a list of files and directories from a GitHub repository connected to
        /// your project. This endpoint returns the contents of a specified repository
        /// path, including file names, sizes, and whether each item is a file or
        /// directory. The GitHub installation must be properly configured and the
        /// repository must be accessible through your installation for this endpoint
        /// to work.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.VcsContentList> GetRepositoryContents(string installationId, string providerRepositoryId, string? providerRootDirectory = null, string? providerReference = null)
        {
            var apiPath = "/vcs/github/installations/{installationId}/providerRepositories/{providerRepositoryId}/contents"
                .Replace("{installationId}", installationId)
                .Replace("{providerRepositoryId}", providerRepositoryId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "providerRootDirectory", providerRootDirectory },
                { "providerReference", providerReference }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.VcsContentList Convert(Dictionary<string, object> it) =>
                Models.VcsContentList.From(map: it);

            return _client.Call<Models.VcsContentList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Authorize and create deployments for a GitHub pull request in your project.
        /// This endpoint allows external contributions by creating deployments from
        /// pull requests, enabling preview environments for code review. The pull
        /// request must be open and not previously authorized. The GitHub installation
        /// must be properly configured and have access to both the repository and pull
        /// request for this endpoint to work.
        /// </para>
        /// </summary>
        public Task<object> UpdateExternalDeployments(string installationId, string repositoryId, string providerPullRequestId)
        {
            var apiPath = "/vcs/github/installations/{installationId}/repositories/{repositoryId}"
                .Replace("{installationId}", installationId)
                .Replace("{repositoryId}", repositoryId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "providerPullRequestId", providerPullRequestId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <para>
        /// List all VCS installations configured for the current project. This
        /// endpoint returns a list of installations including their provider,
        /// organization, and other configuration details.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.InstallationList> ListInstallations(List<string>? queries = null, string? search = null)
        {
            var apiPath = "/vcs/installations";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.InstallationList Convert(Dictionary<string, object> it) =>
                Models.InstallationList.From(map: it);

            return _client.Call<Models.InstallationList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a VCS installation by its unique ID. This endpoint returns the
        /// installation's details including its provider, organization, and
        /// configuration. 
        /// </para>
        /// </summary>
        public Task<Models.Installation> GetInstallation(string installationId)
        {
            var apiPath = "/vcs/installations/{installationId}"
                .Replace("{installationId}", installationId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.Installation Convert(Dictionary<string, object> it) =>
                Models.Installation.From(map: it);

            return _client.Call<Models.Installation>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a VCS installation by its unique ID. This endpoint removes the
        /// installation and all its associated repositories from the project.
        /// </para>
        /// </summary>
        public Task<object> DeleteInstallation(string installationId)
        {
            var apiPath = "/vcs/installations/{installationId}"
                .Replace("{installationId}", installationId);

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
