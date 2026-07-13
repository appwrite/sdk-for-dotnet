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
        /// Get the current organization.
        /// </para>
        /// </summary>
        public Task<Models.Organization> Get()
        {
            var apiPath = "/organization";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.Organization Convert(Dictionary<string, object> it)
            {
                return Models.Organization.From(map: it);
            }

            return _client.Call<Models.Organization>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the current organization's name.
        /// </para>
        /// </summary>
        public Task<Models.Organization> Update(string name)
        {
            var apiPath = "/organization";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Organization Convert(Dictionary<string, object> it)
            {
                return Models.Organization.From(map: it);
            }

            return _client.Call<Models.Organization>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete the current organization. All projects that belong to the
        /// organization are deleted as well.
        /// </para>
        /// </summary>
        public Task<object> Delete()
        {
            var apiPath = "/organization";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

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
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
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
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
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
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
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
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
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
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <para>
        /// Get a list of all memberships from the current organization.
        /// </para>
        /// </summary>
        public Task<Models.MembershipList> ListMemberships(List<string>? queries = null, string? search = null, bool? total = null)
        {
            var apiPath = "/organization/memberships";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.MembershipList Convert(Dictionary<string, object> it)
            {
                return Models.MembershipList.From(map: it);
            }

            return _client.Call<Models.MembershipList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Invite a new member to join the current organization. An email with a link
        /// to join the organization will be sent to the new member's email address. If
        /// member doesn't exist in the project it will be automatically created.
        /// </para>
        /// </summary>
        public Task<Models.Membership> CreateMembership(List<string> roles, string? email = null, string? userId = null, string? phone = null, string? url = null, string? name = null)
        {
            var apiPath = "/organization/memberships";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "email", email },
                { "userId", userId },
                { "phone", phone },
                { "roles", roles },
                { "url", url },
                { "name", name }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Membership Convert(Dictionary<string, object> it)
            {
                return Models.Membership.From(map: it);
            }

            return _client.Call<Models.Membership>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a membership from the current organization by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Membership> GetMembership(string membershipId)
        {
            var apiPath = "/organization/memberships/{membershipId}"
                .Replace("{membershipId}", membershipId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.Membership Convert(Dictionary<string, object> it)
            {
                return Models.Membership.From(map: it);
            }

            return _client.Call<Models.Membership>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Modify the roles of a member in the current organization.
        /// </para>
        /// </summary>
        public Task<Models.Membership> UpdateMembership(string membershipId, List<string> roles)
        {
            var apiPath = "/organization/memberships/{membershipId}"
                .Replace("{membershipId}", membershipId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "roles", roles }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Membership Convert(Dictionary<string, object> it)
            {
                return Models.Membership.From(map: it);
            }

            return _client.Call<Models.Membership>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Remove a member from the current organization. The member is removed
        /// whether they accepted the invitation or not; a pending invitation is
        /// revoked.
        /// </para>
        /// </summary>
        public Task<object> DeleteMembership(string membershipId)
        {
            var apiPath = "/organization/memberships/{membershipId}"
                .Replace("{membershipId}", membershipId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
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
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
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
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
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
                { "X-Appwrite-Project", _client.GetConfig("project") }
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
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
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
                { "X-Appwrite-Project", _client.GetConfig("project") },
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
