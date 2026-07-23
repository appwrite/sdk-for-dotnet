using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Oauth2 : Service
    {
        public Oauth2(Client client) : base(client)
        {
        }

        /// <para>
        /// Approve an OAuth2 grant after the user gives consent. Returns the
        /// `redirectUrl` the end user should be sent to. The consent screen may
        /// optionally pass enriched `authorization_details` to record the concrete
        /// resources the user selected. You can pass Accept header of
        /// `application/json` to receive a JSON response instead of a redirect.
        /// </para>
        /// </summary>
        public Task<Models.Oauth2Approve> Approve(string grantId, string? authorizationDetails = null, string? scope = null)
        {
            var apiPath = "/oauth2/{project_id}/approve"
                .Replace("{project_id}", _client.GetConfig("project"));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "grant_id", grantId },
                { "authorization_details", authorizationDetails },
                { "scope", scope }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Oauth2Approve Convert(Dictionary<string, object> it)
            {
                return Models.Oauth2Approve.From(map: it);
            }

            return _client.Call<Models.Oauth2Approve>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Begin the OAuth2 authorization flow. When called without a session, the
        /// user is redirected to the consent screen without grant ID. When called with
        /// a session, the redirect URL includes param for grant ID. You can pass
        /// Accept header of `application/json` to receive a JSON response instead of a
        /// redirect.
        /// </para>
        /// </summary>
        public Task<Models.Oauth2Authorize> Authorize(string? clientId = null, string? redirectUri = null, string? responseType = null, string? scope = null, string? state = null, string? nonce = null, string? codeChallenge = null, string? codeChallengeMethod = null, string? prompt = null, long? maxAge = null, string? authorizationDetails = null, string? resource = null, string? audience = null, string? requestUri = null)
        {
            var apiPath = "/oauth2/{project_id}/authorize"
                .Replace("{project_id}", _client.GetConfig("project"));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "client_id", clientId },
                { "redirect_uri", redirectUri },
                { "response_type", responseType },
                { "scope", scope },
                { "state", state },
                { "nonce", nonce },
                { "code_challenge", codeChallenge },
                { "code_challenge_method", codeChallengeMethod },
                { "prompt", prompt },
                { "max_age", maxAge },
                { "authorization_details", authorizationDetails },
                { "resource", resource },
                { "audience", audience },
                { "request_uri", requestUri }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "accept", "application/json" }
            };


            static Models.Oauth2Authorize Convert(Dictionary<string, object> it)
            {
                return Models.Oauth2Authorize.From(map: it);
            }

            return _client.Call<Models.Oauth2Authorize>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Begin the OAuth2 authorization flow. When called without a session, the
        /// user is redirected to the consent screen without grant ID. When called with
        /// a session, the redirect URL includes param for grant ID. You can pass
        /// Accept header of `application/json` to receive a JSON response instead of a
        /// redirect.
        /// </para>
        /// </summary>
        public Task<Models.Oauth2Authorize> AuthorizePost(string? clientId = null, string? redirectUri = null, string? responseType = null, string? scope = null, string? state = null, string? nonce = null, string? codeChallenge = null, string? codeChallengeMethod = null, string? prompt = null, long? maxAge = null, string? authorizationDetails = null, string? resource = null, string? audience = null, string? requestUri = null)
        {
            var apiPath = "/oauth2/{project_id}/authorize"
                .Replace("{project_id}", _client.GetConfig("project"));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "client_id", clientId },
                { "redirect_uri", redirectUri },
                { "response_type", responseType },
                { "scope", scope },
                { "state", state },
                { "nonce", nonce },
                { "code_challenge", codeChallenge },
                { "code_challenge_method", codeChallengeMethod },
                { "prompt", prompt },
                { "max_age", maxAge },
                { "authorization_details", authorizationDetails },
                { "resource", resource },
                { "audience", audience },
                { "request_uri", requestUri }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Oauth2Authorize Convert(Dictionary<string, object> it)
            {
                return Models.Oauth2Authorize.From(map: it);
            }

            return _client.Call<Models.Oauth2Authorize>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Start the OAuth2 Device Authorization Grant. Returns the device code, user
        /// code, verification URL, expiration, and polling interval.
        /// </para>
        /// </summary>
        public Task<Models.Oauth2DeviceAuthorization> CreateDeviceAuthorization(string? clientId = null, string? scope = null, string? authorizationDetails = null, string? resource = null, string? audience = null)
        {
            var apiPath = "/oauth2/{project_id}/device_authorization"
                .Replace("{project_id}", _client.GetConfig("project"));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "client_id", clientId },
                { "scope", scope },
                { "authorization_details", authorizationDetails },
                { "resource", resource },
                { "audience", audience }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Oauth2DeviceAuthorization Convert(Dictionary<string, object> it)
            {
                return Models.Oauth2DeviceAuthorization.From(map: it);
            }

            return _client.Call<Models.Oauth2DeviceAuthorization>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Exchange a device flow user code for an OAuth2 grant. The authenticated
        /// user is bound to the pending grant. Pass the returned grant ID to the get
        /// grant endpoint to render the consent screen, then to the approve or reject
        /// endpoint to complete the flow.
        /// </para>
        /// </summary>
        public Task<Models.Oauth2Grant> CreateGrant(string userCode)
        {
            var apiPath = "/oauth2/{project_id}/grants"
                .Replace("{project_id}", _client.GetConfig("project"));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "user_code", userCode }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Oauth2Grant Convert(Dictionary<string, object> it)
            {
                return Models.Oauth2Grant.From(map: it);
            }

            return _client.Call<Models.Oauth2Grant>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get an OAuth2 grant by its ID. Used by the consent screen to display the
        /// details of the authorization the user is being asked to approve. A grant
        /// can only be read by the user it belongs to, or by server SDK.
        /// </para>
        /// </summary>
        public Task<Models.Oauth2Grant> GetGrant(string grantId)
        {
            var apiPath = "/oauth2/{project_id}/grants/{grant_id}"
                .Replace("{project_id}", _client.GetConfig("project"))
                .Replace("{grant_id}", grantId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "accept", "application/json" }
            };


            static Models.Oauth2Grant Convert(Dictionary<string, object> it)
            {
                return Models.Oauth2Grant.From(map: it);
            }

            return _client.Call<Models.Oauth2Grant>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// List the organizations the OAuth2 access token can access. Resolves the
        /// token's `organization` authorization details, expanding the `*` wildcard
        /// into the concrete set of organizations the user can see.
        /// </para>
        /// </summary>
        public Task<Models.Oauth2OrganizationList> ListOrganizations(long? limit = null, long? offset = null, string? search = null)
        {
            var apiPath = "/oauth2/{project_id}/organizations"
                .Replace("{project_id}", _client.GetConfig("project"));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "limit", limit },
                { "offset", offset },
                { "search", search }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "accept", "application/json" }
            };


            static Models.Oauth2OrganizationList Convert(Dictionary<string, object> it)
            {
                return Models.Oauth2OrganizationList.From(map: it);
            }

            return _client.Call<Models.Oauth2OrganizationList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Store an OAuth2 authorization request server-side and receive a short-lived
        /// request_uri handle for the authorize endpoint.
        /// </para>
        /// </summary>
        public Task<Models.Oauth2PAR> CreatePAR(string clientId, string redirectUri, string responseType, string? scope = null, string? state = null, string? nonce = null, string? codeChallenge = null, string? codeChallengeMethod = null, string? prompt = null, long? maxAge = null, string? authorizationDetails = null, string? resource = null, string? audience = null)
        {
            var apiPath = "/oauth2/{project_id}/par"
                .Replace("{project_id}", _client.GetConfig("project"));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "client_id", clientId },
                { "redirect_uri", redirectUri },
                { "response_type", responseType },
                { "scope", scope },
                { "state", state },
                { "nonce", nonce },
                { "code_challenge", codeChallenge },
                { "code_challenge_method", codeChallengeMethod },
                { "prompt", prompt },
                { "max_age", maxAge },
                { "authorization_details", authorizationDetails },
                { "resource", resource },
                { "audience", audience }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Oauth2PAR Convert(Dictionary<string, object> it)
            {
                return Models.Oauth2PAR.From(map: it);
            }

            return _client.Call<Models.Oauth2PAR>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// List the projects the OAuth2 access token can access. Resolves the token's
        /// `project` authorization details, expanding the `*` wildcard into the
        /// concrete set of projects the user can see.
        /// </para>
        /// </summary>
        public Task<Models.Oauth2ProjectList> ListProjects(long? limit = null, long? offset = null, string? search = null)
        {
            var apiPath = "/oauth2/{project_id}/projects"
                .Replace("{project_id}", _client.GetConfig("project"));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "limit", limit },
                { "offset", offset },
                { "search", search }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "accept", "application/json" }
            };


            static Models.Oauth2ProjectList Convert(Dictionary<string, object> it)
            {
                return Models.Oauth2ProjectList.From(map: it);
            }

            return _client.Call<Models.Oauth2ProjectList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Reject an OAuth2 grant when the user denies consent. Returns the
        /// `redirectUrl` the end user should be sent to with an `access_denied` error.
        /// You can pass Accept header of `application/json` to receive a JSON response
        /// instead of a redirect.
        /// </para>
        /// </summary>
        public Task<Models.Oauth2Reject> Reject(string grantId)
        {
            var apiPath = "/oauth2/{project_id}/reject"
                .Replace("{project_id}", _client.GetConfig("project"));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "grant_id", grantId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Oauth2Reject Convert(Dictionary<string, object> it)
            {
                return Models.Oauth2Reject.From(map: it);
            }

            return _client.Call<Models.Oauth2Reject>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Revoke an OAuth2 access token or refresh token.
        /// </para>
        /// </summary>
        public Task<object> Revoke(string token, string? tokenTypeHint = null, string? clientId = null, string? clientSecret = null)
        {
            var apiPath = "/oauth2/{project_id}/revoke"
                .Replace("{project_id}", _client.GetConfig("project"));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "token", token },
                { "token_type_hint", tokenTypeHint },
                { "client_id", clientId },
                { "client_secret", clientSecret }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };



            return _client.Call<object>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <para>
        /// Exchange an OAuth2 authorization code, refresh token, or device code for
        /// access and refresh tokens.
        /// </para>
        /// </summary>
        public Task<Models.Oauth2Token> CreateToken(string grantType, string? code = null, string? refreshToken = null, string? deviceCode = null, string? clientId = null, string? clientSecret = null, string? codeVerifier = null, string? redirectUri = null, string? resource = null, string? audience = null)
        {
            var apiPath = "/oauth2/{project_id}/token"
                .Replace("{project_id}", _client.GetConfig("project"));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "grant_type", grantType },
                { "code", code },
                { "refresh_token", refreshToken },
                { "device_code", deviceCode },
                { "client_id", clientId },
                { "client_secret", clientSecret },
                { "code_verifier", codeVerifier },
                { "redirect_uri", redirectUri },
                { "resource", resource },
                { "audience", audience }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
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

    }
}
