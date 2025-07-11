
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Projects : Service
    {
        public Projects(Client client) : base(client)
        {
        }

        /// <para>
        /// Get a list of all projects. You can use the query params to filter your
        /// results. 
        /// </para>
        /// </summary>
        public Task<Models.ProjectList> List(List<string>? queries = null, string? search = null)
        {
            var apiPath = "/projects";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.ProjectList Convert(Dictionary<string, object> it) =>
                Models.ProjectList.From(map: it);

            return _client.Call<Models.ProjectList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new project. You can create a maximum of 100 projects per account.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.Project> Create(string projectId, string name, string teamId, Appwrite.Enums.Region? region = null, string? description = null, string? logo = null, string? url = null, string? legalName = null, string? legalCountry = null, string? legalState = null, string? legalCity = null, string? legalAddress = null, string? legalTaxId = null)
        {
            var apiPath = "/projects";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "projectId", projectId },
                { "name", name },
                { "teamId", teamId },
                { "region", region },
                { "description", description },
                { "logo", logo },
                { "url", url },
                { "legalName", legalName },
                { "legalCountry", legalCountry },
                { "legalState", legalState },
                { "legalCity", legalCity },
                { "legalAddress", legalAddress },
                { "legalTaxId", legalTaxId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Project Convert(Dictionary<string, object> it) =>
                Models.Project.From(map: it);

            return _client.Call<Models.Project>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a project by its unique ID. This endpoint allows you to retrieve the
        /// project's details, including its name, description, team, region, and other
        /// metadata. 
        /// </para>
        /// </summary>
        public Task<Models.Project> Get(string projectId)
        {
            var apiPath = "/projects/{projectId}"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.Project Convert(Dictionary<string, object> it) =>
                Models.Project.From(map: it);

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
        public Task<Models.Project> Update(string projectId, string name, string? description = null, string? logo = null, string? url = null, string? legalName = null, string? legalCountry = null, string? legalState = null, string? legalCity = null, string? legalAddress = null, string? legalTaxId = null)
        {
            var apiPath = "/projects/{projectId}"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "description", description },
                { "logo", logo },
                { "url", url },
                { "legalName", legalName },
                { "legalCountry", legalCountry },
                { "legalState", legalState },
                { "legalCity", legalCity },
                { "legalAddress", legalAddress },
                { "legalTaxId", legalTaxId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Project Convert(Dictionary<string, object> it) =>
                Models.Project.From(map: it);

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
        public Task<object> Delete(string projectId)
        {
            var apiPath = "/projects/{projectId}"
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

        /// <para>
        /// Update the status of a specific API type. Use this endpoint to enable or
        /// disable API types such as REST, GraphQL and Realtime.
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateApiStatus(string projectId, Appwrite.Enums.Api api, bool status)
        {
            var apiPath = "/projects/{projectId}/api"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "api", api },
                { "status", status }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Project Convert(Dictionary<string, object> it) =>
                Models.Project.From(map: it);

            return _client.Call<Models.Project>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the status of all API types. Use this endpoint to enable or disable
        /// API types such as REST, GraphQL and Realtime all at once.
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateApiStatusAll(string projectId, bool status)
        {
            var apiPath = "/projects/{projectId}/api/all"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "status", status }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Project Convert(Dictionary<string, object> it) =>
                Models.Project.From(map: it);

            return _client.Call<Models.Project>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update how long sessions created within a project should stay active for.
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateAuthDuration(string projectId, long duration)
        {
            var apiPath = "/projects/{projectId}/auth/duration"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "duration", duration }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Project Convert(Dictionary<string, object> it) =>
                Models.Project.From(map: it);

            return _client.Call<Models.Project>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the maximum number of users allowed in this project. Set to 0 for
        /// unlimited users. 
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateAuthLimit(string projectId, long limit)
        {
            var apiPath = "/projects/{projectId}/auth/limit"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "limit", limit }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Project Convert(Dictionary<string, object> it) =>
                Models.Project.From(map: it);

            return _client.Call<Models.Project>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the maximum number of sessions allowed per user within the project,
        /// if the limit is hit the oldest session will be deleted to make room for new
        /// sessions.
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateAuthSessionsLimit(string projectId, long limit)
        {
            var apiPath = "/projects/{projectId}/auth/max-sessions"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "limit", limit }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Project Convert(Dictionary<string, object> it) =>
                Models.Project.From(map: it);

            return _client.Call<Models.Project>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update project membership privacy settings. Use this endpoint to control
        /// what user information is visible to other team members, such as user name,
        /// email, and MFA status. 
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateMembershipsPrivacy(string projectId, bool userName, bool userEmail, bool mfa)
        {
            var apiPath = "/projects/{projectId}/auth/memberships-privacy"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userName", userName },
                { "userEmail", userEmail },
                { "mfa", mfa }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Project Convert(Dictionary<string, object> it) =>
                Models.Project.From(map: it);

            return _client.Call<Models.Project>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the list of mock phone numbers for testing. Use these numbers to
        /// bypass SMS verification in development. 
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateMockNumbers(string projectId, List<object> numbers)
        {
            var apiPath = "/projects/{projectId}/auth/mock-numbers"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "numbers", numbers }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Project Convert(Dictionary<string, object> it) =>
                Models.Project.From(map: it);

            return _client.Call<Models.Project>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Enable or disable checking user passwords against common passwords
        /// dictionary. This helps ensure users don't use common and insecure
        /// passwords. 
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateAuthPasswordDictionary(string projectId, bool enabled)
        {
            var apiPath = "/projects/{projectId}/auth/password-dictionary"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Project Convert(Dictionary<string, object> it) =>
                Models.Project.From(map: it);

            return _client.Call<Models.Project>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the authentication password history requirement. Use this endpoint
        /// to require new passwords to be different than the last X amount of
        /// previously used ones.
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateAuthPasswordHistory(string projectId, long limit)
        {
            var apiPath = "/projects/{projectId}/auth/password-history"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "limit", limit }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Project Convert(Dictionary<string, object> it) =>
                Models.Project.From(map: it);

            return _client.Call<Models.Project>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Enable or disable checking user passwords against their personal data. This
        /// helps prevent users from using personal information in their passwords. 
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdatePersonalDataCheck(string projectId, bool enabled)
        {
            var apiPath = "/projects/{projectId}/auth/personal-data"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Project Convert(Dictionary<string, object> it) =>
                Models.Project.From(map: it);

            return _client.Call<Models.Project>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Enable or disable session email alerts. When enabled, users will receive
        /// email notifications when new sessions are created.
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateSessionAlerts(string projectId, bool alerts)
        {
            var apiPath = "/projects/{projectId}/auth/session-alerts"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "alerts", alerts }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Project Convert(Dictionary<string, object> it) =>
                Models.Project.From(map: it);

            return _client.Call<Models.Project>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the status of a specific authentication method. Use this endpoint to
        /// enable or disable different authentication methods such as email, magic
        /// urls or sms in your project. 
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateAuthStatus(string projectId, Appwrite.Enums.AuthMethod method, bool status)
        {
            var apiPath = "/projects/{projectId}/auth/{method}"
                .Replace("{projectId}", projectId)
                .Replace("{method}", method.Value);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "status", status }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Project Convert(Dictionary<string, object> it) =>
                Models.Project.From(map: it);

            return _client.Call<Models.Project>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// List all the project\'s dev keys. Dev keys are project specific and allow
        /// you to bypass rate limits and get better error logging during development.'
        /// </para>
        /// </summary>
        public Task<Models.DevKeyList> ListDevKeys(string projectId, List<string>? queries = null)
        {
            var apiPath = "/projects/{projectId}/dev-keys"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.DevKeyList Convert(Dictionary<string, object> it) =>
                Models.DevKeyList.From(map: it);

            return _client.Call<Models.DevKeyList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new project dev key. Dev keys are project specific and allow you
        /// to bypass rate limits and get better error logging during development.
        /// Strictly meant for development purposes only.
        /// </para>
        /// </summary>
        public Task<Models.DevKey> CreateDevKey(string projectId, string name, string expire)
        {
            var apiPath = "/projects/{projectId}/dev-keys"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "expire", expire }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.DevKey Convert(Dictionary<string, object> it) =>
                Models.DevKey.From(map: it);

            return _client.Call<Models.DevKey>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a project\'s dev key by its unique ID. Dev keys are project specific
        /// and allow you to bypass rate limits and get better error logging during
        /// development.
        /// </para>
        /// </summary>
        public Task<Models.DevKey> GetDevKey(string projectId, string keyId)
        {
            var apiPath = "/projects/{projectId}/dev-keys/{keyId}"
                .Replace("{projectId}", projectId)
                .Replace("{keyId}", keyId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.DevKey Convert(Dictionary<string, object> it) =>
                Models.DevKey.From(map: it);

            return _client.Call<Models.DevKey>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a project\'s dev key by its unique ID. Use this endpoint to update a
        /// project\'s dev key name or expiration time.'
        /// </para>
        /// </summary>
        public Task<Models.DevKey> UpdateDevKey(string projectId, string keyId, string name, string expire)
        {
            var apiPath = "/projects/{projectId}/dev-keys/{keyId}"
                .Replace("{projectId}", projectId)
                .Replace("{keyId}", keyId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "expire", expire }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.DevKey Convert(Dictionary<string, object> it) =>
                Models.DevKey.From(map: it);

            return _client.Call<Models.DevKey>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a project\'s dev key by its unique ID. Once deleted, the key will no
        /// longer allow bypassing of rate limits and better logging of errors.
        /// </para>
        /// </summary>
        public Task<object> DeleteDevKey(string projectId, string keyId)
        {
            var apiPath = "/projects/{projectId}/dev-keys/{keyId}"
                .Replace("{projectId}", projectId)
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
        /// Create a new JWT token. This token can be used to authenticate users with
        /// custom scopes and expiration time. 
        /// </para>
        /// </summary>
        public Task<Models.JWT> CreateJWT(string projectId, List<string> scopes, long? duration = null)
        {
            var apiPath = "/projects/{projectId}/jwts"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "scopes", scopes },
                { "duration", duration }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.JWT Convert(Dictionary<string, object> it) =>
                Models.JWT.From(map: it);

            return _client.Call<Models.JWT>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a list of all API keys from the current project. 
        /// </para>
        /// </summary>
        public Task<Models.KeyList> ListKeys(string projectId)
        {
            var apiPath = "/projects/{projectId}/keys"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.KeyList Convert(Dictionary<string, object> it) =>
                Models.KeyList.From(map: it);

            return _client.Call<Models.KeyList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new API key. It's recommended to have multiple API keys with
        /// strict scopes for separate functions within your project.
        /// </para>
        /// </summary>
        public Task<Models.Key> CreateKey(string projectId, string name, List<string> scopes, string? expire = null)
        {
            var apiPath = "/projects/{projectId}/keys"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "scopes", scopes },
                { "expire", expire }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Key Convert(Dictionary<string, object> it) =>
                Models.Key.From(map: it);

            return _client.Call<Models.Key>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a key by its unique ID. This endpoint returns details about a specific
        /// API key in your project including it's scopes.
        /// </para>
        /// </summary>
        public Task<Models.Key> GetKey(string projectId, string keyId)
        {
            var apiPath = "/projects/{projectId}/keys/{keyId}"
                .Replace("{projectId}", projectId)
                .Replace("{keyId}", keyId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.Key Convert(Dictionary<string, object> it) =>
                Models.Key.From(map: it);

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
        public Task<Models.Key> UpdateKey(string projectId, string keyId, string name, List<string> scopes, string? expire = null)
        {
            var apiPath = "/projects/{projectId}/keys/{keyId}"
                .Replace("{projectId}", projectId)
                .Replace("{keyId}", keyId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "scopes", scopes },
                { "expire", expire }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Key Convert(Dictionary<string, object> it) =>
                Models.Key.From(map: it);

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
        public Task<object> DeleteKey(string projectId, string keyId)
        {
            var apiPath = "/projects/{projectId}/keys/{keyId}"
                .Replace("{projectId}", projectId)
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
        /// Update the OAuth2 provider configurations. Use this endpoint to set up or
        /// update the OAuth2 provider credentials or enable/disable providers. 
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateOAuth2(string projectId, Appwrite.Enums.OAuthProvider provider, string? appId = null, string? secret = null, bool? enabled = null)
        {
            var apiPath = "/projects/{projectId}/oauth2"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "provider", provider },
                { "appId", appId },
                { "secret", secret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Project Convert(Dictionary<string, object> it) =>
                Models.Project.From(map: it);

            return _client.Call<Models.Project>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a list of all platforms in the project. This endpoint returns an array
        /// of all platforms and their configurations. 
        /// </para>
        /// </summary>
        public Task<Models.PlatformList> ListPlatforms(string projectId)
        {
            var apiPath = "/projects/{projectId}/platforms"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.PlatformList Convert(Dictionary<string, object> it) =>
                Models.PlatformList.From(map: it);

            return _client.Call<Models.PlatformList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new platform for your project. Use this endpoint to register a new
        /// platform where your users will run your application which will interact
        /// with the Appwrite API.
        /// </para>
        /// </summary>
        public Task<Models.Platform> CreatePlatform(string projectId, Appwrite.Enums.PlatformType type, string name, string? key = null, string? store = null, string? hostname = null)
        {
            var apiPath = "/projects/{projectId}/platforms"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "type", type },
                { "name", name },
                { "key", key },
                { "store", store },
                { "hostname", hostname }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Platform Convert(Dictionary<string, object> it) =>
                Models.Platform.From(map: it);

            return _client.Call<Models.Platform>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a platform by its unique ID. This endpoint returns the platform's
        /// details, including its name, type, and key configurations. 
        /// </para>
        /// </summary>
        public Task<Models.Platform> GetPlatform(string projectId, string platformId)
        {
            var apiPath = "/projects/{projectId}/platforms/{platformId}"
                .Replace("{projectId}", projectId)
                .Replace("{platformId}", platformId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.Platform Convert(Dictionary<string, object> it) =>
                Models.Platform.From(map: it);

            return _client.Call<Models.Platform>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a platform by its unique ID. Use this endpoint to update the
        /// platform's name, key, platform store ID, or hostname. 
        /// </para>
        /// </summary>
        public Task<Models.Platform> UpdatePlatform(string projectId, string platformId, string name, string? key = null, string? store = null, string? hostname = null)
        {
            var apiPath = "/projects/{projectId}/platforms/{platformId}"
                .Replace("{projectId}", projectId)
                .Replace("{platformId}", platformId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "key", key },
                { "store", store },
                { "hostname", hostname }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Platform Convert(Dictionary<string, object> it) =>
                Models.Platform.From(map: it);

            return _client.Call<Models.Platform>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a platform by its unique ID. This endpoint removes the platform and
        /// all its configurations from the project. 
        /// </para>
        /// </summary>
        public Task<object> DeletePlatform(string projectId, string platformId)
        {
            var apiPath = "/projects/{projectId}/platforms/{platformId}"
                .Replace("{projectId}", projectId)
                .Replace("{platformId}", platformId);

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
        /// Update the status of a specific service. Use this endpoint to enable or
        /// disable a service in your project. 
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateServiceStatus(string projectId, Appwrite.Enums.ApiService service, bool status)
        {
            var apiPath = "/projects/{projectId}/service"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "service", service },
                { "status", status }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Project Convert(Dictionary<string, object> it) =>
                Models.Project.From(map: it);

            return _client.Call<Models.Project>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the status of all services. Use this endpoint to enable or disable
        /// all optional services at once. 
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateServiceStatusAll(string projectId, bool status)
        {
            var apiPath = "/projects/{projectId}/service/all"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "status", status }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Project Convert(Dictionary<string, object> it) =>
                Models.Project.From(map: it);

            return _client.Call<Models.Project>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the SMTP configuration for your project. Use this endpoint to
        /// configure your project's SMTP provider with your custom settings for
        /// sending transactional emails. 
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateSmtp(string projectId, bool enabled, string? senderName = null, string? senderEmail = null, string? replyTo = null, string? host = null, long? port = null, string? username = null, string? password = null, Appwrite.Enums.SMTPSecure? secure = null)
        {
            var apiPath = "/projects/{projectId}/smtp"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "enabled", enabled },
                { "senderName", senderName },
                { "senderEmail", senderEmail },
                { "replyTo", replyTo },
                { "host", host },
                { "port", port },
                { "username", username },
                { "password", password },
                { "secure", secure }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Project Convert(Dictionary<string, object> it) =>
                Models.Project.From(map: it);

            return _client.Call<Models.Project>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Send a test email to verify SMTP configuration. 
        /// </para>
        /// </summary>
        public Task<object> CreateSmtpTest(string projectId, List<string> emails, string senderName, string senderEmail, string host, string? replyTo = null, long? port = null, string? username = null, string? password = null, Appwrite.Enums.SMTPSecure? secure = null)
        {
            var apiPath = "/projects/{projectId}/smtp/tests"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "emails", emails },
                { "senderName", senderName },
                { "senderEmail", senderEmail },
                { "replyTo", replyTo },
                { "host", host },
                { "port", port },
                { "username", username },
                { "password", password },
                { "secure", secure }
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

        /// <para>
        /// Update the team ID of a project allowing for it to be transferred to
        /// another team.
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateTeam(string projectId, string teamId)
        {
            var apiPath = "/projects/{projectId}/team"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "teamId", teamId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Project Convert(Dictionary<string, object> it) =>
                Models.Project.From(map: it);

            return _client.Call<Models.Project>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a custom email template for the specified locale and type. This
        /// endpoint returns the template content, subject, and other configuration
        /// details. 
        /// </para>
        /// </summary>
        public Task<Models.EmailTemplate> GetEmailTemplate(string projectId, Appwrite.Enums.EmailTemplateType type, Appwrite.Enums.EmailTemplateLocale locale)
        {
            var apiPath = "/projects/{projectId}/templates/email/{type}/{locale}"
                .Replace("{projectId}", projectId)
                .Replace("{type}", type.Value)
                .Replace("{locale}", locale.Value);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.EmailTemplate Convert(Dictionary<string, object> it) =>
                Models.EmailTemplate.From(map: it);

            return _client.Call<Models.EmailTemplate>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a custom email template for the specified locale and type. Use this
        /// endpoint to modify the content of your email templates.
        /// </para>
        /// </summary>
        public Task<Models.EmailTemplate> UpdateEmailTemplate(string projectId, Appwrite.Enums.EmailTemplateType type, Appwrite.Enums.EmailTemplateLocale locale, string subject, string message, string? senderName = null, string? senderEmail = null, string? replyTo = null)
        {
            var apiPath = "/projects/{projectId}/templates/email/{type}/{locale}"
                .Replace("{projectId}", projectId)
                .Replace("{type}", type.Value)
                .Replace("{locale}", locale.Value);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "subject", subject },
                { "message", message },
                { "senderName", senderName },
                { "senderEmail", senderEmail },
                { "replyTo", replyTo }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.EmailTemplate Convert(Dictionary<string, object> it) =>
                Models.EmailTemplate.From(map: it);

            return _client.Call<Models.EmailTemplate>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Reset a custom email template to its default value. This endpoint removes
        /// any custom content and restores the template to its original state. 
        /// </para>
        /// </summary>
        public Task<Models.EmailTemplate> DeleteEmailTemplate(string projectId, Appwrite.Enums.EmailTemplateType type, Appwrite.Enums.EmailTemplateLocale locale)
        {
            var apiPath = "/projects/{projectId}/templates/email/{type}/{locale}"
                .Replace("{projectId}", projectId)
                .Replace("{type}", type.Value)
                .Replace("{locale}", locale.Value);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.EmailTemplate Convert(Dictionary<string, object> it) =>
                Models.EmailTemplate.From(map: it);

            return _client.Call<Models.EmailTemplate>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a custom SMS template for the specified locale and type returning it's
        /// contents.
        /// </para>
        /// </summary>
        public Task<Models.SmsTemplate> GetSmsTemplate(string projectId, Appwrite.Enums.SmsTemplateType type, Appwrite.Enums.SmsTemplateLocale locale)
        {
            var apiPath = "/projects/{projectId}/templates/sms/{type}/{locale}"
                .Replace("{projectId}", projectId)
                .Replace("{type}", type.Value)
                .Replace("{locale}", locale.Value);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.SmsTemplate Convert(Dictionary<string, object> it) =>
                Models.SmsTemplate.From(map: it);

            return _client.Call<Models.SmsTemplate>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a custom SMS template for the specified locale and type. Use this
        /// endpoint to modify the content of your SMS templates. 
        /// </para>
        /// </summary>
        public Task<Models.SmsTemplate> UpdateSmsTemplate(string projectId, Appwrite.Enums.SmsTemplateType type, Appwrite.Enums.SmsTemplateLocale locale, string message)
        {
            var apiPath = "/projects/{projectId}/templates/sms/{type}/{locale}"
                .Replace("{projectId}", projectId)
                .Replace("{type}", type.Value)
                .Replace("{locale}", locale.Value);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "message", message }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.SmsTemplate Convert(Dictionary<string, object> it) =>
                Models.SmsTemplate.From(map: it);

            return _client.Call<Models.SmsTemplate>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Reset a custom SMS template to its default value. This endpoint removes any
        /// custom message and restores the template to its original state. 
        /// </para>
        /// </summary>
        public Task<Models.SmsTemplate> DeleteSmsTemplate(string projectId, Appwrite.Enums.SmsTemplateType type, Appwrite.Enums.SmsTemplateLocale locale)
        {
            var apiPath = "/projects/{projectId}/templates/sms/{type}/{locale}"
                .Replace("{projectId}", projectId)
                .Replace("{type}", type.Value)
                .Replace("{locale}", locale.Value);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.SmsTemplate Convert(Dictionary<string, object> it) =>
                Models.SmsTemplate.From(map: it);

            return _client.Call<Models.SmsTemplate>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a list of all webhooks belonging to the project. You can use the query
        /// params to filter your results. 
        /// </para>
        /// </summary>
        public Task<Models.WebhookList> ListWebhooks(string projectId)
        {
            var apiPath = "/projects/{projectId}/webhooks"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.WebhookList Convert(Dictionary<string, object> it) =>
                Models.WebhookList.From(map: it);

            return _client.Call<Models.WebhookList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new webhook. Use this endpoint to configure a URL that will
        /// receive events from Appwrite when specific events occur. 
        /// </para>
        /// </summary>
        public Task<Models.Webhook> CreateWebhook(string projectId, string name, List<string> events, string url, bool security, bool? enabled = null, string? httpUser = null, string? httpPass = null)
        {
            var apiPath = "/projects/{projectId}/webhooks"
                .Replace("{projectId}", projectId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "enabled", enabled },
                { "events", events },
                { "url", url },
                { "security", security },
                { "httpUser", httpUser },
                { "httpPass", httpPass }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Webhook Convert(Dictionary<string, object> it) =>
                Models.Webhook.From(map: it);

            return _client.Call<Models.Webhook>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a webhook by its unique ID. This endpoint returns details about a
        /// specific webhook configured for a project. 
        /// </para>
        /// </summary>
        public Task<Models.Webhook> GetWebhook(string projectId, string webhookId)
        {
            var apiPath = "/projects/{projectId}/webhooks/{webhookId}"
                .Replace("{projectId}", projectId)
                .Replace("{webhookId}", webhookId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.Webhook Convert(Dictionary<string, object> it) =>
                Models.Webhook.From(map: it);

            return _client.Call<Models.Webhook>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a webhook by its unique ID. Use this endpoint to update the URL,
        /// events, or status of an existing webhook. 
        /// </para>
        /// </summary>
        public Task<Models.Webhook> UpdateWebhook(string projectId, string webhookId, string name, List<string> events, string url, bool security, bool? enabled = null, string? httpUser = null, string? httpPass = null)
        {
            var apiPath = "/projects/{projectId}/webhooks/{webhookId}"
                .Replace("{projectId}", projectId)
                .Replace("{webhookId}", webhookId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "enabled", enabled },
                { "events", events },
                { "url", url },
                { "security", security },
                { "httpUser", httpUser },
                { "httpPass", httpPass }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Webhook Convert(Dictionary<string, object> it) =>
                Models.Webhook.From(map: it);

            return _client.Call<Models.Webhook>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a webhook by its unique ID. Once deleted, the webhook will no longer
        /// receive project events. 
        /// </para>
        /// </summary>
        public Task<object> DeleteWebhook(string projectId, string webhookId)
        {
            var apiPath = "/projects/{projectId}/webhooks/{webhookId}"
                .Replace("{projectId}", projectId)
                .Replace("{webhookId}", webhookId);

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
        /// Update the webhook signature key. This endpoint can be used to regenerate
        /// the signature key used to sign and validate payload deliveries for a
        /// specific webhook. 
        /// </para>
        /// </summary>
        public Task<Models.Webhook> UpdateWebhookSignature(string projectId, string webhookId)
        {
            var apiPath = "/projects/{projectId}/webhooks/{webhookId}/signature"
                .Replace("{projectId}", projectId)
                .Replace("{webhookId}", webhookId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Webhook Convert(Dictionary<string, object> it) =>
                Models.Webhook.From(map: it);

            return _client.Call<Models.Webhook>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

    }
}
