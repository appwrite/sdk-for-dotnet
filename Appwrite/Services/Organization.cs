using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Organization : Service
    {
        public Organization(Client client) : base(client)
        {
        }

        /// <para>
        /// Get a list of all API keys from the current organization.
        /// </para>
        /// </summary>
        public Task<Models.KeyList> ListKeys(List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/organization/keys";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.KeyList Convert(Dictionary<string, object> it)
            {
                return Models.KeyList.From(map: it);
            }

            return _client.Call<Models.KeyList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new organization API key.
        /// </para>
        /// </summary>
        public Task<Models.Key> CreateKey(string keyId, string name, List<Appwrite.Enums.OrganizationKeyScopes> scopes, string? expire = null)
        {
            var apiPath = "/organization/keys";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "keyId", keyId },
                { "name", name },
                { "scopes", scopes?.Select(e => e.Value).ToList() },
                { "expire", expire }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Key Convert(Dictionary<string, object> it)
            {
                return Models.Key.From(map: it);
            }

            return _client.Call<Models.Key>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a key by its unique ID. This endpoint returns details about a specific
        /// API key in your organization including its scopes.
        /// </para>
        /// </summary>
        public Task<Models.Key> GetKey(string keyId)
        {
            var apiPath = "/organization/keys/{keyId}"
                .Replace("{keyId}", keyId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.Key Convert(Dictionary<string, object> it)
            {
                return Models.Key.From(map: it);
            }

            return _client.Call<Models.Key>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a key by its unique ID. Use this endpoint to update the name,
        /// scopes, or expiration time of an API key.
        /// </para>
        /// </summary>
        public Task<Models.Key> UpdateKey(string keyId, string name, List<Appwrite.Enums.OrganizationKeyScopes> scopes, string? expire = null)
        {
            var apiPath = "/organization/keys/{keyId}"
                .Replace("{keyId}", keyId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "scopes", scopes?.Select(e => e.Value).ToList() },
                { "expire", expire }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Key Convert(Dictionary<string, object> it)
            {
                return Models.Key.From(map: it);
            }

            return _client.Call<Models.Key>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a key by its unique ID. Once deleted, the key can no longer be used
        /// to authenticate API calls.
        /// </para>
        /// </summary>
        public Task<object> DeleteKey(string keyId)
        {
            var apiPath = "/organization/keys/{keyId}"
                .Replace("{keyId}", keyId);

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
        /// Get a list of all projects. You can use the query params to filter your
        /// results.
        /// </para>
        /// </summary>
        public Task<Models.ProjectList> ListProjects(List<string>? queries = null, string? search = null, bool? total = null)
        {
            var apiPath = "/organization/projects";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.ProjectList Convert(Dictionary<string, object> it)
            {
                return Models.ProjectList.From(map: it);
            }

            return _client.Call<Models.ProjectList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new project.
        /// </para>
        /// </summary>
        public Task<Models.Project> CreateProject(string projectId, string name, Appwrite.Enums.Region? region = null)
        {
            var apiPath = "/organization/projects";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "projectId", projectId },
                { "name", name },
                { "region", region?.Value }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Project Convert(Dictionary<string, object> it)
            {
                return Models.Project.From(map: it);
            }

            return _client.Call<Models.Project>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a project.
        /// </para>
        /// </summary>
        public Task<Models.Project> GetProject(string projectId)
        {
            var apiPath = "/organization/projects/{projectId}"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.Project Convert(Dictionary<string, object> it)
            {
                return Models.Project.From(map: it);
            }

            return _client.Call<Models.Project>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a project by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateProject(string projectId, string name)
        {
            var apiPath = "/organization/projects/{projectId}"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Project Convert(Dictionary<string, object> it)
            {
                return Models.Project.From(map: it);
            }

            return _client.Call<Models.Project>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a project by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> DeleteProject(string projectId)
        {
            var apiPath = "/organization/projects/{projectId}"
                .Replace("{projectId}", projectId);

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
