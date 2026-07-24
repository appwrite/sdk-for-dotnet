using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Apps : Service
    {
        public Apps(Client client) : base(client)
        {
        }

        /// <para>
        /// List applications.
        /// </para>
        /// </summary>
        public Task<Models.AppsList> List(List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/apps";

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


            static Models.AppsList Convert(Dictionary<string, object> it)
            {
                return Models.AppsList.From(map: it);
            }

            return _client.Call<Models.AppsList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new application.
        /// </para>
        /// </summary>
        public Task<Models.App> Create(string appId, string name, List<string> redirectUris, string? description = null, string? clientUri = null, string? logoUri = null, string? privacyPolicyUrl = null, string? termsUrl = null, List<string>? contacts = null, string? tagline = null, List<string>? tags = null, List<string>? images = null, string? supportUrl = null, string? dataDeletionUrl = null, List<string>? postLogoutRedirectUris = null, bool? enabled = null, string? type = null, bool? deviceFlow = null, string? teamId = null)
        {
            var apiPath = "/apps";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "appId", appId },
                { "name", name },
                { "description", description },
                { "clientUri", clientUri },
                { "logoUri", logoUri },
                { "privacyPolicyUrl", privacyPolicyUrl },
                { "termsUrl", termsUrl },
                { "contacts", contacts },
                { "tagline", tagline },
                { "tags", tags },
                { "images", images },
                { "supportUrl", supportUrl },
                { "dataDeletionUrl", dataDeletionUrl },
                { "redirectUris", redirectUris },
                { "postLogoutRedirectUris", postLogoutRedirectUris },
                { "enabled", enabled },
                { "type", type },
                { "deviceFlow", deviceFlow },
                { "teamId", teamId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.App Convert(Dictionary<string, object> it)
            {
                return Models.App.From(map: it);
            }

            return _client.Call<Models.App>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// List scopes an application can request when installed on a team.
        /// </para>
        /// </summary>
        public Task<Models.AppScopeList> ListInstallationScopes()
        {
            var apiPath = "/apps/scopes/installations";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.AppScopeList Convert(Dictionary<string, object> it)
            {
                return Models.AppScopeList.From(map: it);
            }

            return _client.Call<Models.AppScopeList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// List scopes an application can request during the OAuth2 flow.
        /// </para>
        /// </summary>
        public Task<Models.AppScopeList> ListOAuth2Scopes()
        {
            var apiPath = "/apps/scopes/oauth2";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.AppScopeList Convert(Dictionary<string, object> it)
            {
                return Models.AppScopeList.From(map: it);
            }

            return _client.Call<Models.AppScopeList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get an application by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.App> Get(string appId)
        {
            var apiPath = "/apps/{appId}"
                .Replace("{appId}", appId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.App Convert(Dictionary<string, object> it)
            {
                return Models.App.From(map: it);
            }

            return _client.Call<Models.App>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an application by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.App> Update(string appId, string name, string? description = null, string? clientUri = null, string? logoUri = null, string? privacyPolicyUrl = null, string? termsUrl = null, List<string>? contacts = null, string? tagline = null, List<string>? tags = null, List<string>? images = null, string? supportUrl = null, string? dataDeletionUrl = null, bool? enabled = null, List<string>? redirectUris = null, List<string>? postLogoutRedirectUris = null, string? type = null, bool? deviceFlow = null, List<string>? installationScopes = null, string? installationRedirectUrl = null)
        {
            var apiPath = "/apps/{appId}"
                .Replace("{appId}", appId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "description", description },
                { "clientUri", clientUri },
                { "logoUri", logoUri },
                { "privacyPolicyUrl", privacyPolicyUrl },
                { "termsUrl", termsUrl },
                { "contacts", contacts },
                { "tagline", tagline },
                { "tags", tags },
                { "images", images },
                { "supportUrl", supportUrl },
                { "dataDeletionUrl", dataDeletionUrl },
                { "enabled", enabled },
                { "redirectUris", redirectUris },
                { "postLogoutRedirectUris", postLogoutRedirectUris },
                { "type", type },
                { "deviceFlow", deviceFlow },
                { "installationScopes", installationScopes },
                { "installationRedirectUrl", installationRedirectUrl }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.App Convert(Dictionary<string, object> it)
            {
                return Models.App.From(map: it);
            }

            return _client.Call<Models.App>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete an application by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> Delete(string appId)
        {
            var apiPath = "/apps/{appId}"
                .Replace("{appId}", appId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };



            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <para>
        /// List installations of an application. Requires an app key sent in the
        /// `X-Appwrite-Key` header alongside the `X-Appwrite-App` header.
        /// </para>
        /// </summary>
        public Task<Models.AppInstallationList> ListInstallations(string appId, List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/apps/{appId}/installations"
                .Replace("{appId}", appId);

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


            static Models.AppInstallationList Convert(Dictionary<string, object> it)
            {
                return Models.AppInstallationList.From(map: it);
            }

            return _client.Call<Models.AppInstallationList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get an installation of an application by its unique ID. Requires an app key
        /// sent in the `X-Appwrite-Key` header alongside the `X-Appwrite-App` header.
        /// </para>
        /// </summary>
        public Task<Models.AppInstallation> GetInstallation(string appId, string installationId)
        {
            var apiPath = "/apps/{appId}/installations/{installationId}"
                .Replace("{appId}", appId)
                .Replace("{installationId}", installationId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.AppInstallation Convert(Dictionary<string, object> it)
            {
                return Models.AppInstallation.From(map: it);
            }

            return _client.Call<Models.AppInstallation>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a token for an installation of an application. Requires an app key
        /// sent in the `X-Appwrite-Key` header alongside the `X-Appwrite-App` header.
        /// The returned token carries the scopes and authorization details granted to
        /// the installation, and can be used as an `Authorization: Bearer` header
        /// everywhere OAuth2 access tokens are accepted. Multiple tokens can be active
        /// for the same installation at once; each token stays valid until it expires
        /// or the installation is updated or deleted.
        /// </para>
        /// </summary>
        public Task<Models.Oauth2Token> CreateInstallationToken(string appId, string installationId)
        {
            var apiPath = "/apps/{appId}/installations/{installationId}/tokens"
                .Replace("{appId}", appId)
                .Replace("{installationId}", installationId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Oauth2Token Convert(Dictionary<string, object> it)
            {
                return Models.Oauth2Token.From(map: it);
            }

            return _client.Call<Models.Oauth2Token>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// List app keys for an application.
        /// </para>
        /// </summary>
        public Task<Models.AppKeyList> ListKeys(string appId, List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/apps/{appId}/keys"
                .Replace("{appId}", appId);

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


            static Models.AppKeyList Convert(Dictionary<string, object> it)
            {
                return Models.AppKeyList.From(map: it);
            }

            return _client.Call<Models.AppKeyList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new app key for an application. App keys carry no scopes; send one
        /// in the `X-Appwrite-Key` header alongside the `X-Appwrite-App` header to
        /// list the application's installations and create installation access tokens.
        /// </para>
        /// </summary>
        public Task<Models.AppKey> CreateKey(string appId)
        {
            var apiPath = "/apps/{appId}/keys"
                .Replace("{appId}", appId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.AppKey Convert(Dictionary<string, object> it)
            {
                return Models.AppKey.From(map: it);
            }

            return _client.Call<Models.AppKey>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get an app key by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.AppKey> GetKey(string appId, string keyId)
        {
            var apiPath = "/apps/{appId}/keys/{keyId}"
                .Replace("{appId}", appId)
                .Replace("{keyId}", keyId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.AppKey Convert(Dictionary<string, object> it)
            {
                return Models.AppKey.From(map: it);
            }

            return _client.Call<Models.AppKey>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete an app key by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> DeleteKey(string appId, string keyId)
        {
            var apiPath = "/apps/{appId}/keys/{keyId}"
                .Replace("{appId}", appId)
                .Replace("{keyId}", keyId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };



            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <para>
        /// Update the labels of an application. Labels are read-only for clients; only
        /// a server SDK using a project API key can set them. Replaces the previous
        /// labels.
        /// </para>
        /// </summary>
        public Task<Models.App> UpdateLabels(string appId, List<string> labels)
        {
            var apiPath = "/apps/{appId}/labels"
                .Replace("{appId}", appId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "labels", labels }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.App Convert(Dictionary<string, object> it)
            {
                return Models.App.From(map: it);
            }

            return _client.Call<Models.App>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// List client secrets for an application.
        /// </para>
        /// </summary>
        public Task<Models.AppSecretList> ListSecrets(string appId, List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/apps/{appId}/secrets"
                .Replace("{appId}", appId);

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


            static Models.AppSecretList Convert(Dictionary<string, object> it)
            {
                return Models.AppSecretList.From(map: it);
            }

            return _client.Call<Models.AppSecretList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new client secret for an application.
        /// </para>
        /// </summary>
        public Task<Models.AppSecretPlaintext> CreateSecret(string appId)
        {
            var apiPath = "/apps/{appId}/secrets"
                .Replace("{appId}", appId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.AppSecretPlaintext Convert(Dictionary<string, object> it)
            {
                return Models.AppSecretPlaintext.From(map: it);
            }

            return _client.Call<Models.AppSecretPlaintext>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get an application client secret by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.AppSecret> GetSecret(string appId, string secretId)
        {
            var apiPath = "/apps/{appId}/secrets/{secretId}"
                .Replace("{appId}", appId)
                .Replace("{secretId}", secretId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.AppSecret Convert(Dictionary<string, object> it)
            {
                return Models.AppSecret.From(map: it);
            }

            return _client.Call<Models.AppSecret>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete an application client secret by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> DeleteSecret(string appId, string secretId)
        {
            var apiPath = "/apps/{appId}/secrets/{secretId}"
                .Replace("{appId}", appId)
                .Replace("{secretId}", secretId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };



            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <para>
        /// Transfer an application to another team by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.App> UpdateTeam(string appId, string teamId)
        {
            var apiPath = "/apps/{appId}/team"
                .Replace("{appId}", appId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "teamId", teamId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.App Convert(Dictionary<string, object> it)
            {
                return Models.App.From(map: it);
            }

            return _client.Call<Models.App>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Revoke all tokens for an application by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> DeleteTokens(string appId)
        {
            var apiPath = "/apps/{appId}/tokens"
                .Replace("{appId}", appId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };



            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

    }
}
