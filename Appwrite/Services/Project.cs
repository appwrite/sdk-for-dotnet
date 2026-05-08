
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Project : Service
    {
        public Project(Client client) : base(client)
        {
        }

        /// <para>
        /// Delete a project.
        /// </para>
        /// </summary>
        public Task<object> Delete()
        {
            var apiPath = "/project";

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
        /// Update properties of a specific auth method. Use this endpoint to enable or
        /// disable a method in your project. 
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateAuthMethod(Appwrite.Enums.MethodId methodId, bool enabled)
        {
            var apiPath = "/project/auth-methods/{methodId}"
                .Replace("{methodId}", methodId.Value);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "enabled", enabled }
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
        /// Get a list of all API keys from the current project.
        /// </para>
        /// </summary>
        public Task<Models.KeyList> ListKeys(List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/project/keys";

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
        /// Create a new API key. It's recommended to have multiple API keys with
        /// strict scopes for separate functions within your project.
        /// 
        /// You can also create an ephemeral API key if you need a short-lived key
        /// instead.
        /// </para>
        /// </summary>
        public Task<Models.Key> CreateKey(string keyId, string name, List<Appwrite.Enums.Scopes> scopes, string? expire = null)
        {
            var apiPath = "/project/keys";

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
        /// Create a new ephemeral API key. It's recommended to have multiple API keys
        /// with strict scopes for separate functions within your project.
        /// 
        /// You can also create a standard API key if you need a longer-lived key
        /// instead.
        /// </para>
        /// </summary>
        public Task<Models.EphemeralKey> CreateEphemeralKey(List<Appwrite.Enums.Scopes> scopes, long duration)
        {
            var apiPath = "/project/keys/ephemeral";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "scopes", scopes?.Select(e => e.Value).ToList() },
                { "duration", duration }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.EphemeralKey Convert(Dictionary<string, object> it)
            {
                return Models.EphemeralKey.From(map: it);
            }

            return _client.Call<Models.EphemeralKey>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a key by its unique ID. 
        /// </para>
        /// </summary>
        public Task<Models.Key> GetKey(string keyId)
        {
            var apiPath = "/project/keys/{keyId}"
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
        public Task<Models.Key> UpdateKey(string keyId, string name, List<Appwrite.Enums.Scopes> scopes, string? expire = null)
        {
            var apiPath = "/project/keys/{keyId}"
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
            var apiPath = "/project/keys/{keyId}"
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
        /// Update the project labels. Labels can be used to easily filter projects in
        /// an organization.
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateLabels(List<string> labels)
        {
            var apiPath = "/project/labels";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "labels", labels }
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
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a list of all mock phones in the project. This endpoint returns an
        /// array of all mock phones and their OTPs.
        /// </para>
        /// </summary>
        public Task<Models.MockNumberList> ListMockPhones(List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/project/mock-phones";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.MockNumberList Convert(Dictionary<string, object> it)
            {
                return Models.MockNumberList.From(map: it);
            }

            return _client.Call<Models.MockNumberList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new mock phone for your project. Use this endpoint to register a
        /// mock phone number and its sign-in OTP for your testers.
        /// </para>
        /// </summary>
        public Task<Models.MockNumber> CreateMockPhone(string number, string otp)
        {
            var apiPath = "/project/mock-phones";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "number", number },
                { "otp", otp }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.MockNumber Convert(Dictionary<string, object> it)
            {
                return Models.MockNumber.From(map: it);
            }

            return _client.Call<Models.MockNumber>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a mock phone by its unique number. This endpoint returns the mock
        /// phone's OTP.
        /// </para>
        /// </summary>
        public Task<Models.MockNumber> GetMockPhone(string number)
        {
            var apiPath = "/project/mock-phones/{number}"
                .Replace("{number}", number);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.MockNumber Convert(Dictionary<string, object> it)
            {
                return Models.MockNumber.From(map: it);
            }

            return _client.Call<Models.MockNumber>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a mock phone by its unique number. Use this endpoint to update the
        /// mock phone's OTP.
        /// </para>
        /// </summary>
        public Task<Models.MockNumber> UpdateMockPhone(string number, string otp)
        {
            var apiPath = "/project/mock-phones/{number}"
                .Replace("{number}", number);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "otp", otp }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.MockNumber Convert(Dictionary<string, object> it)
            {
                return Models.MockNumber.From(map: it);
            }

            return _client.Call<Models.MockNumber>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a mock phone by its unique number. This endpoint removes the mock
        /// phone and its OTP configuration from the project.
        /// </para>
        /// </summary>
        public Task<object> DeleteMockPhone(string number)
        {
            var apiPath = "/project/mock-phones/{number}"
                .Replace("{number}", number);

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
        /// Get a list of all OAuth2 providers supported by the server, along with the
        /// project's configuration for each. Credential fields are write-only and
        /// always returned empty.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2ProviderList> ListOAuth2Providers(List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/project/oauth2";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.OAuth2ProviderList Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2ProviderList.From(map: it);
            }

            return _client.Call<Models.OAuth2ProviderList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a single OAuth2 provider configuration. Credential fields (client
        /// secret, p8 file, key/team IDs) are write-only and always returned empty.
        /// </para>
        /// </summary>
        public Task<object> GetOAuth2Provider(Appwrite.Enums.ProviderId providerId)
        {
            var apiPath = "/project/oauth2/:provider";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "providerId", providerId?.Value }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static object Convert(Dictionary<string, object> it)
            {
                if (it.TryGetValue("$id", out var idValue1) && idValue1?.ToString() == "github")
                {
                    return Appwrite.Models.OAuth2Github.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue2) && idValue2?.ToString() == "discord")
                {
                    return Appwrite.Models.OAuth2Discord.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue3) && idValue3?.ToString() == "figma")
                {
                    return Appwrite.Models.OAuth2Figma.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue4) && idValue4?.ToString() == "dropbox")
                {
                    return Appwrite.Models.OAuth2Dropbox.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue5) && idValue5?.ToString() == "dailymotion")
                {
                    return Appwrite.Models.OAuth2Dailymotion.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue6) && idValue6?.ToString() == "bitbucket")
                {
                    return Appwrite.Models.OAuth2Bitbucket.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue7) && idValue7?.ToString() == "bitly")
                {
                    return Appwrite.Models.OAuth2Bitly.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue8) && idValue8?.ToString() == "box")
                {
                    return Appwrite.Models.OAuth2Box.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue9) && idValue9?.ToString() == "autodesk")
                {
                    return Appwrite.Models.OAuth2Autodesk.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue10) && idValue10?.ToString() == "google")
                {
                    return Appwrite.Models.OAuth2Google.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue11) && idValue11?.ToString() == "zoom")
                {
                    return Appwrite.Models.OAuth2Zoom.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue12) && idValue12?.ToString() == "zoho")
                {
                    return Appwrite.Models.OAuth2Zoho.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue13) && idValue13?.ToString() == "yandex")
                {
                    return Appwrite.Models.OAuth2Yandex.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue14) && idValue14?.ToString() == "x")
                {
                    return Appwrite.Models.OAuth2X.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue15) && idValue15?.ToString() == "wordpress")
                {
                    return Appwrite.Models.OAuth2WordPress.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue16) && idValue16?.ToString() == "twitch")
                {
                    return Appwrite.Models.OAuth2Twitch.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue17) && idValue17?.ToString() == "stripe")
                {
                    return Appwrite.Models.OAuth2Stripe.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue18) && idValue18?.ToString() == "spotify")
                {
                    return Appwrite.Models.OAuth2Spotify.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue19) && idValue19?.ToString() == "slack")
                {
                    return Appwrite.Models.OAuth2Slack.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue20) && idValue20?.ToString() == "podio")
                {
                    return Appwrite.Models.OAuth2Podio.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue21) && idValue21?.ToString() == "notion")
                {
                    return Appwrite.Models.OAuth2Notion.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue22) && idValue22?.ToString() == "salesforce")
                {
                    return Appwrite.Models.OAuth2Salesforce.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue23) && idValue23?.ToString() == "yahoo")
                {
                    return Appwrite.Models.OAuth2Yahoo.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue24) && idValue24?.ToString() == "linkedin")
                {
                    return Appwrite.Models.OAuth2Linkedin.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue25) && idValue25?.ToString() == "disqus")
                {
                    return Appwrite.Models.OAuth2Disqus.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue26) && idValue26?.ToString() == "amazon")
                {
                    return Appwrite.Models.OAuth2Amazon.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue27) && idValue27?.ToString() == "etsy")
                {
                    return Appwrite.Models.OAuth2Etsy.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue28) && idValue28?.ToString() == "facebook")
                {
                    return Appwrite.Models.OAuth2Facebook.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue29) && idValue29?.ToString() == "tradeshiftBox")
                {
                    return Appwrite.Models.OAuth2Tradeshift.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue30) && idValue30?.ToString() == "paypalSandbox")
                {
                    return Appwrite.Models.OAuth2Paypal.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue31) && idValue31?.ToString() == "gitlab")
                {
                    return Appwrite.Models.OAuth2Gitlab.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue32) && idValue32?.ToString() == "authentik")
                {
                    return Appwrite.Models.OAuth2Authentik.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue33) && idValue33?.ToString() == "auth0")
                {
                    return Appwrite.Models.OAuth2Auth0.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue34) && idValue34?.ToString() == "fusionauth")
                {
                    return Appwrite.Models.OAuth2FusionAuth.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue35) && idValue35?.ToString() == "keycloak")
                {
                    return Appwrite.Models.OAuth2Keycloak.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue36) && idValue36?.ToString() == "oidc")
                {
                    return Appwrite.Models.OAuth2Oidc.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue37) && idValue37?.ToString() == "apple")
                {
                    return Appwrite.Models.OAuth2Apple.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue38) && idValue38?.ToString() == "okta")
                {
                    return Appwrite.Models.OAuth2Okta.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue39) && idValue39?.ToString() == "kick")
                {
                    return Appwrite.Models.OAuth2Kick.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue40) && idValue40?.ToString() == "microsoft")
                {
                    return Appwrite.Models.OAuth2Microsoft.From(map: it);
                }
                throw new System.Exception("Unable to match response to any expected response model");
            }

            return _client.Call<object>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Amazon configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Amazon> UpdateOAuth2Amazon(string? clientId = null, string? clientSecret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/amazon";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "clientSecret", clientSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Amazon Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Amazon.From(map: it);
            }

            return _client.Call<Models.OAuth2Amazon>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Apple configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Apple> UpdateOAuth2Apple(string? serviceId = null, string? keyId = null, string? teamId = null, string? p8File = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/apple";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "serviceId", serviceId },
                { "keyId", keyId },
                { "teamId", teamId },
                { "p8File", p8File },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Apple Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Apple.From(map: it);
            }

            return _client.Call<Models.OAuth2Apple>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Auth0 configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Auth0> UpdateOAuth2Auth0(string? clientId = null, string? clientSecret = null, string? endpoint = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/auth0";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "clientSecret", clientSecret },
                { "endpoint", endpoint },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Auth0 Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Auth0.From(map: it);
            }

            return _client.Call<Models.OAuth2Auth0>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Authentik configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Authentik> UpdateOAuth2Authentik(string? clientId = null, string? clientSecret = null, string? endpoint = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/authentik";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "clientSecret", clientSecret },
                { "endpoint", endpoint },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Authentik Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Authentik.From(map: it);
            }

            return _client.Call<Models.OAuth2Authentik>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Autodesk configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Autodesk> UpdateOAuth2Autodesk(string? clientId = null, string? clientSecret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/autodesk";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "clientSecret", clientSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Autodesk Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Autodesk.From(map: it);
            }

            return _client.Call<Models.OAuth2Autodesk>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Bitbucket configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Bitbucket> UpdateOAuth2Bitbucket(string? key = null, string? secret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/bitbucket";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "secret", secret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Bitbucket Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Bitbucket.From(map: it);
            }

            return _client.Call<Models.OAuth2Bitbucket>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Bitly configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Bitly> UpdateOAuth2Bitly(string? clientId = null, string? clientSecret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/bitly";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "clientSecret", clientSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Bitly Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Bitly.From(map: it);
            }

            return _client.Call<Models.OAuth2Bitly>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Box configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Box> UpdateOAuth2Box(string? clientId = null, string? clientSecret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/box";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "clientSecret", clientSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Box Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Box.From(map: it);
            }

            return _client.Call<Models.OAuth2Box>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Dailymotion configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Dailymotion> UpdateOAuth2Dailymotion(string? apiKey = null, string? apiSecret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/dailymotion";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "apiKey", apiKey },
                { "apiSecret", apiSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Dailymotion Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Dailymotion.From(map: it);
            }

            return _client.Call<Models.OAuth2Dailymotion>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Discord configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Discord> UpdateOAuth2Discord(string? clientId = null, string? clientSecret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/discord";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "clientSecret", clientSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Discord Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Discord.From(map: it);
            }

            return _client.Call<Models.OAuth2Discord>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Disqus configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Disqus> UpdateOAuth2Disqus(string? publicKey = null, string? secretKey = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/disqus";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "publicKey", publicKey },
                { "secretKey", secretKey },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Disqus Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Disqus.From(map: it);
            }

            return _client.Call<Models.OAuth2Disqus>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Dropbox configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Dropbox> UpdateOAuth2Dropbox(string? appKey = null, string? appSecret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/dropbox";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "appKey", appKey },
                { "appSecret", appSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Dropbox Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Dropbox.From(map: it);
            }

            return _client.Call<Models.OAuth2Dropbox>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Etsy configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Etsy> UpdateOAuth2Etsy(string? keyString = null, string? sharedSecret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/etsy";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "keyString", keyString },
                { "sharedSecret", sharedSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Etsy Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Etsy.From(map: it);
            }

            return _client.Call<Models.OAuth2Etsy>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Facebook configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Facebook> UpdateOAuth2Facebook(string? appId = null, string? appSecret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/facebook";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "appId", appId },
                { "appSecret", appSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Facebook Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Facebook.From(map: it);
            }

            return _client.Call<Models.OAuth2Facebook>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Figma configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Figma> UpdateOAuth2Figma(string? clientId = null, string? clientSecret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/figma";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "clientSecret", clientSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Figma Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Figma.From(map: it);
            }

            return _client.Call<Models.OAuth2Figma>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 FusionAuth configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2FusionAuth> UpdateOAuth2FusionAuth(string? clientId = null, string? clientSecret = null, string? endpoint = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/fusionauth";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "clientSecret", clientSecret },
                { "endpoint", endpoint },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2FusionAuth Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2FusionAuth.From(map: it);
            }

            return _client.Call<Models.OAuth2FusionAuth>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 GitHub configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Github> UpdateOAuth2GitHub(string? clientId = null, string? clientSecret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/github";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "clientSecret", clientSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Github Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Github.From(map: it);
            }

            return _client.Call<Models.OAuth2Github>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Gitlab configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Gitlab> UpdateOAuth2Gitlab(string? applicationId = null, string? secret = null, string? endpoint = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/gitlab";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "applicationId", applicationId },
                { "secret", secret },
                { "endpoint", endpoint },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Gitlab Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Gitlab.From(map: it);
            }

            return _client.Call<Models.OAuth2Gitlab>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Google configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Google> UpdateOAuth2Google(string? clientId = null, string? clientSecret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/google";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "clientSecret", clientSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Google Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Google.From(map: it);
            }

            return _client.Call<Models.OAuth2Google>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Keycloak configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Keycloak> UpdateOAuth2Keycloak(string? clientId = null, string? clientSecret = null, string? endpoint = null, string? realmName = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/keycloak";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "clientSecret", clientSecret },
                { "endpoint", endpoint },
                { "realmName", realmName },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Keycloak Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Keycloak.From(map: it);
            }

            return _client.Call<Models.OAuth2Keycloak>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Kick configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Kick> UpdateOAuth2Kick(string? clientId = null, string? clientSecret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/kick";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "clientSecret", clientSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Kick Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Kick.From(map: it);
            }

            return _client.Call<Models.OAuth2Kick>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Linkedin configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Linkedin> UpdateOAuth2Linkedin(string? clientId = null, string? primaryClientSecret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/linkedin";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "primaryClientSecret", primaryClientSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Linkedin Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Linkedin.From(map: it);
            }

            return _client.Call<Models.OAuth2Linkedin>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Microsoft configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Microsoft> UpdateOAuth2Microsoft(string? applicationId = null, string? applicationSecret = null, string? tenant = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/microsoft";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "applicationId", applicationId },
                { "applicationSecret", applicationSecret },
                { "tenant", tenant },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Microsoft Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Microsoft.From(map: it);
            }

            return _client.Call<Models.OAuth2Microsoft>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Notion configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Notion> UpdateOAuth2Notion(string? oauthClientId = null, string? oauthClientSecret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/notion";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "oauthClientId", oauthClientId },
                { "oauthClientSecret", oauthClientSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Notion Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Notion.From(map: it);
            }

            return _client.Call<Models.OAuth2Notion>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Oidc configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Oidc> UpdateOAuth2Oidc(string? clientId = null, string? clientSecret = null, string? wellKnownURL = null, string? authorizationURL = null, string? tokenURL = null, string? userInfoURL = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/oidc";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "clientSecret", clientSecret },
                { "wellKnownURL", wellKnownURL },
                { "authorizationURL", authorizationURL },
                { "tokenURL", tokenURL },
                { "userInfoURL", userInfoURL },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Oidc Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Oidc.From(map: it);
            }

            return _client.Call<Models.OAuth2Oidc>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Okta configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Okta> UpdateOAuth2Okta(string? clientId = null, string? clientSecret = null, string? domain = null, string? authorizationServerId = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/okta";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "clientSecret", clientSecret },
                { "domain", domain },
                { "authorizationServerId", authorizationServerId },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Okta Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Okta.From(map: it);
            }

            return _client.Call<Models.OAuth2Okta>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Paypal configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Paypal> UpdateOAuth2Paypal(string? clientId = null, string? secretKey = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/paypal";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "secretKey", secretKey },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Paypal Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Paypal.From(map: it);
            }

            return _client.Call<Models.OAuth2Paypal>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 PaypalSandbox configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Paypal> UpdateOAuth2PaypalSandbox(string? clientId = null, string? secretKey = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/paypalSandbox";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "secretKey", secretKey },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Paypal Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Paypal.From(map: it);
            }

            return _client.Call<Models.OAuth2Paypal>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Podio configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Podio> UpdateOAuth2Podio(string? clientId = null, string? clientSecret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/podio";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "clientSecret", clientSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Podio Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Podio.From(map: it);
            }

            return _client.Call<Models.OAuth2Podio>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Salesforce configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Salesforce> UpdateOAuth2Salesforce(string? customerKey = null, string? customerSecret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/salesforce";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "customerKey", customerKey },
                { "customerSecret", customerSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Salesforce Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Salesforce.From(map: it);
            }

            return _client.Call<Models.OAuth2Salesforce>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Slack configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Slack> UpdateOAuth2Slack(string? clientId = null, string? clientSecret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/slack";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "clientSecret", clientSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Slack Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Slack.From(map: it);
            }

            return _client.Call<Models.OAuth2Slack>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Spotify configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Spotify> UpdateOAuth2Spotify(string? clientId = null, string? clientSecret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/spotify";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "clientSecret", clientSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Spotify Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Spotify.From(map: it);
            }

            return _client.Call<Models.OAuth2Spotify>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Stripe configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Stripe> UpdateOAuth2Stripe(string? clientId = null, string? apiSecretKey = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/stripe";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "apiSecretKey", apiSecretKey },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Stripe Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Stripe.From(map: it);
            }

            return _client.Call<Models.OAuth2Stripe>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Tradeshift configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Tradeshift> UpdateOAuth2Tradeshift(string? oauth2ClientId = null, string? oauth2ClientSecret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/tradeshift";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "oauth2ClientId", oauth2ClientId },
                { "oauth2ClientSecret", oauth2ClientSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Tradeshift Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Tradeshift.From(map: it);
            }

            return _client.Call<Models.OAuth2Tradeshift>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Tradeshift Sandbox configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Tradeshift> UpdateOAuth2TradeshiftSandbox(string? oauth2ClientId = null, string? oauth2ClientSecret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/tradeshiftBox";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "oauth2ClientId", oauth2ClientId },
                { "oauth2ClientSecret", oauth2ClientSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Tradeshift Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Tradeshift.From(map: it);
            }

            return _client.Call<Models.OAuth2Tradeshift>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Twitch configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Twitch> UpdateOAuth2Twitch(string? clientId = null, string? clientSecret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/twitch";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "clientSecret", clientSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Twitch Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Twitch.From(map: it);
            }

            return _client.Call<Models.OAuth2Twitch>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 WordPress configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2WordPress> UpdateOAuth2WordPress(string? clientId = null, string? clientSecret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/wordpress";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "clientSecret", clientSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2WordPress Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2WordPress.From(map: it);
            }

            return _client.Call<Models.OAuth2WordPress>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 X configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2X> UpdateOAuth2X(string? customerKey = null, string? secretKey = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/x";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "customerKey", customerKey },
                { "secretKey", secretKey },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2X Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2X.From(map: it);
            }

            return _client.Call<Models.OAuth2X>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Yahoo configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Yahoo> UpdateOAuth2Yahoo(string? clientId = null, string? clientSecret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/yahoo";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "clientSecret", clientSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Yahoo Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Yahoo.From(map: it);
            }

            return _client.Call<Models.OAuth2Yahoo>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Yandex configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Yandex> UpdateOAuth2Yandex(string? clientId = null, string? clientSecret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/yandex";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "clientSecret", clientSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Yandex Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Yandex.From(map: it);
            }

            return _client.Call<Models.OAuth2Yandex>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Zoho configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Zoho> UpdateOAuth2Zoho(string? clientId = null, string? clientSecret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/zoho";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "clientSecret", clientSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Zoho Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Zoho.From(map: it);
            }

            return _client.Call<Models.OAuth2Zoho>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the project OAuth2 Zoom configuration.
        /// </para>
        /// </summary>
        public Task<Models.OAuth2Zoom> UpdateOAuth2Zoom(string? clientId = null, string? clientSecret = null, bool? enabled = null)
        {
            var apiPath = "/project/oauth2/zoom";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "clientId", clientId },
                { "clientSecret", clientSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.OAuth2Zoom Convert(Dictionary<string, object> it)
            {
                return Models.OAuth2Zoom.From(map: it);
            }

            return _client.Call<Models.OAuth2Zoom>(
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
        public Task<Models.PlatformList> ListPlatforms(List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/project/platforms";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.PlatformList Convert(Dictionary<string, object> it)
            {
                return Models.PlatformList.From(map: it);
            }

            return _client.Call<Models.PlatformList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new Android platform for your project. Use this endpoint to
        /// register a new Android platform where your users will run your application
        /// which will interact with the Appwrite API.
        /// </para>
        /// </summary>
        public Task<Models.PlatformAndroid> CreateAndroidPlatform(string platformId, string name, string applicationId)
        {
            var apiPath = "/project/platforms/android";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "platformId", platformId },
                { "name", name },
                { "applicationId", applicationId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.PlatformAndroid Convert(Dictionary<string, object> it)
            {
                return Models.PlatformAndroid.From(map: it);
            }

            return _client.Call<Models.PlatformAndroid>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an Android platform by its unique ID. Use this endpoint to update
        /// the platform's name or application ID.
        /// </para>
        /// </summary>
        public Task<Models.PlatformAndroid> UpdateAndroidPlatform(string platformId, string name, string applicationId)
        {
            var apiPath = "/project/platforms/android/{platformId}"
                .Replace("{platformId}", platformId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "applicationId", applicationId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.PlatformAndroid Convert(Dictionary<string, object> it)
            {
                return Models.PlatformAndroid.From(map: it);
            }

            return _client.Call<Models.PlatformAndroid>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new Apple platform for your project. Use this endpoint to register
        /// a new Apple platform where your users will run your application which will
        /// interact with the Appwrite API.
        /// </para>
        /// </summary>
        public Task<Models.PlatformApple> CreateApplePlatform(string platformId, string name, string bundleIdentifier)
        {
            var apiPath = "/project/platforms/apple";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "platformId", platformId },
                { "name", name },
                { "bundleIdentifier", bundleIdentifier }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.PlatformApple Convert(Dictionary<string, object> it)
            {
                return Models.PlatformApple.From(map: it);
            }

            return _client.Call<Models.PlatformApple>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an Apple platform by its unique ID. Use this endpoint to update the
        /// platform's name or bundle identifier.
        /// </para>
        /// </summary>
        public Task<Models.PlatformApple> UpdateApplePlatform(string platformId, string name, string bundleIdentifier)
        {
            var apiPath = "/project/platforms/apple/{platformId}"
                .Replace("{platformId}", platformId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "bundleIdentifier", bundleIdentifier }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.PlatformApple Convert(Dictionary<string, object> it)
            {
                return Models.PlatformApple.From(map: it);
            }

            return _client.Call<Models.PlatformApple>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new Linux platform for your project. Use this endpoint to register
        /// a new Linux platform where your users will run your application which will
        /// interact with the Appwrite API.
        /// </para>
        /// </summary>
        public Task<Models.PlatformLinux> CreateLinuxPlatform(string platformId, string name, string packageName)
        {
            var apiPath = "/project/platforms/linux";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "platformId", platformId },
                { "name", name },
                { "packageName", packageName }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.PlatformLinux Convert(Dictionary<string, object> it)
            {
                return Models.PlatformLinux.From(map: it);
            }

            return _client.Call<Models.PlatformLinux>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a Linux platform by its unique ID. Use this endpoint to update the
        /// platform's name or package name.
        /// </para>
        /// </summary>
        public Task<Models.PlatformLinux> UpdateLinuxPlatform(string platformId, string name, string packageName)
        {
            var apiPath = "/project/platforms/linux/{platformId}"
                .Replace("{platformId}", platformId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "packageName", packageName }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.PlatformLinux Convert(Dictionary<string, object> it)
            {
                return Models.PlatformLinux.From(map: it);
            }

            return _client.Call<Models.PlatformLinux>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new web platform for your project. Use this endpoint to register a
        /// new platform where your users will run your application which will interact
        /// with the Appwrite API.
        /// </para>
        /// </summary>
        public Task<Models.PlatformWeb> CreateWebPlatform(string platformId, string name, string hostname)
        {
            var apiPath = "/project/platforms/web";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "platformId", platformId },
                { "name", name },
                { "hostname", hostname }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.PlatformWeb Convert(Dictionary<string, object> it)
            {
                return Models.PlatformWeb.From(map: it);
            }

            return _client.Call<Models.PlatformWeb>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a web platform by its unique ID. Use this endpoint to update the
        /// platform's name or hostname.
        /// </para>
        /// </summary>
        public Task<Models.PlatformWeb> UpdateWebPlatform(string platformId, string name, string hostname)
        {
            var apiPath = "/project/platforms/web/{platformId}"
                .Replace("{platformId}", platformId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "hostname", hostname }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.PlatformWeb Convert(Dictionary<string, object> it)
            {
                return Models.PlatformWeb.From(map: it);
            }

            return _client.Call<Models.PlatformWeb>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new Windows platform for your project. Use this endpoint to
        /// register a new Windows platform where your users will run your application
        /// which will interact with the Appwrite API.
        /// </para>
        /// </summary>
        public Task<Models.PlatformWindows> CreateWindowsPlatform(string platformId, string name, string packageIdentifierName)
        {
            var apiPath = "/project/platforms/windows";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "platformId", platformId },
                { "name", name },
                { "packageIdentifierName", packageIdentifierName }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.PlatformWindows Convert(Dictionary<string, object> it)
            {
                return Models.PlatformWindows.From(map: it);
            }

            return _client.Call<Models.PlatformWindows>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a Windows platform by its unique ID. Use this endpoint to update the
        /// platform's name or package identifier name.
        /// </para>
        /// </summary>
        public Task<Models.PlatformWindows> UpdateWindowsPlatform(string platformId, string name, string packageIdentifierName)
        {
            var apiPath = "/project/platforms/windows/{platformId}"
                .Replace("{platformId}", platformId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "packageIdentifierName", packageIdentifierName }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.PlatformWindows Convert(Dictionary<string, object> it)
            {
                return Models.PlatformWindows.From(map: it);
            }

            return _client.Call<Models.PlatformWindows>(
                method: "PUT",
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
        public Task<object> GetPlatform(string platformId)
        {
            var apiPath = "/project/platforms/{platformId}"
                .Replace("{platformId}", platformId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static object Convert(Dictionary<string, object> it)
            {
                if (it.TryGetValue("type", out var typeValue1) && typeValue1?.ToString() == "web")
                {
                    return Appwrite.Models.PlatformWeb.From(map: it);
                }
                if (it.TryGetValue("type", out var typeValue2) && typeValue2?.ToString() == "apple")
                {
                    return Appwrite.Models.PlatformApple.From(map: it);
                }
                if (it.TryGetValue("type", out var typeValue3) && typeValue3?.ToString() == "android")
                {
                    return Appwrite.Models.PlatformAndroid.From(map: it);
                }
                if (it.TryGetValue("type", out var typeValue4) && typeValue4?.ToString() == "windows")
                {
                    return Appwrite.Models.PlatformWindows.From(map: it);
                }
                if (it.TryGetValue("type", out var typeValue5) && typeValue5?.ToString() == "linux")
                {
                    return Appwrite.Models.PlatformLinux.From(map: it);
                }
                throw new System.Exception("Unable to match response to any expected response model");
            }

            return _client.Call<object>(
                method: "GET",
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
        public Task<object> DeletePlatform(string platformId)
        {
            var apiPath = "/project/platforms/{platformId}"
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
        /// Get a list of all project policies and their current configuration.
        /// </para>
        /// </summary>
        public Task<Models.PolicyList> ListPolicies(List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/project/policies";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.PolicyList Convert(Dictionary<string, object> it)
            {
                return Models.PolicyList.From(map: it);
            }

            return _client.Call<Models.PolicyList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Updating this policy allows you to control if team members can see other
        /// members information. When enabled, all team members can see ID, name,
        /// email, phone number, and MFA status of other members..
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateMembershipPrivacyPolicy(bool? userId = null, bool? userEmail = null, bool? userPhone = null, bool? userName = null, bool? userMFA = null)
        {
            var apiPath = "/project/policies/membership-privacy";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "userEmail", userEmail },
                { "userPhone", userPhone },
                { "userName", userName },
                { "userMFA", userMFA }
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
        /// Updating this policy allows you to control if new passwords are checked
        /// against most common passwords dictionary. When enabled, and user changes
        /// their password, password must not be contained in the dictionary.
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdatePasswordDictionaryPolicy(bool enabled)
        {
            var apiPath = "/project/policies/password-dictionary";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "enabled", enabled }
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
        /// Updates one of password strength policies. Based on total length
        /// configured, previous password hashes are stored, and users cannot choose a
        /// new password that is already stored in the passwird history list, when
        /// updating an user password, or setting new one through password recovery.
        /// 
        /// Keep in mind, while password history policy is disabled, the history is not
        /// being stored. Enabling the policy will not have any history on existing
        /// users, and it will only start to collect and enforce the policy on password
        /// changes since the policy is enabled.
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdatePasswordHistoryPolicy(long total)
        {
            var apiPath = "/project/policies/password-history";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "total", total }
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
        /// Updating this policy allows you to control if password strength is checked
        /// against personal data. When enabled, and user sets or changes their
        /// password, the password must not contain user ID, name, email or phone
        /// number.
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdatePasswordPersonalDataPolicy(bool enabled)
        {
            var apiPath = "/project/policies/password-personal-data";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "enabled", enabled }
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
        /// Updating this policy allows you to control if email alert is sent upon
        /// session creation. When enabled, and user signs into their account, they
        /// will be sent an email notification. There is an exception, the first
        /// session after a new sign up does not trigger an alert, even if the policy
        /// is enabled.
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateSessionAlertPolicy(bool enabled)
        {
            var apiPath = "/project/policies/session-alert";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "enabled", enabled }
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
        /// Update maximum duration how long sessions created within a project should
        /// stay active for.
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateSessionDurationPolicy(long duration)
        {
            var apiPath = "/project/policies/session-duration";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "duration", duration }
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
        /// Updating this policy allows you to control if existing sessions should be
        /// invalidated when a password of a user is changed. When enabled, and user
        /// changes their password, they will be logged out of all their devices.
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateSessionInvalidationPolicy(bool enabled)
        {
            var apiPath = "/project/policies/session-invalidation";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "enabled", enabled }
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
        /// Update the maximum number of sessions allowed per user. When the limit is
        /// hit, the oldest session will be deleted to make room for new one.
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateSessionLimitPolicy(long total)
        {
            var apiPath = "/project/policies/session-limit";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "total", total }
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
        /// Update the maximum number of users in the project. When the limit is hit or
        /// amount of existing users already exceeded the limit, all users remain
        /// active, but new user sign up will be prohibited.
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateUserLimitPolicy(long total)
        {
            var apiPath = "/project/policies/user-limit";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "total", total }
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
        /// Get a policy by its unique ID. This endpoint returns the current
        /// configuration for the requested project policy.
        /// </para>
        /// </summary>
        public Task<object> GetPolicy(Appwrite.Enums.PolicyId policyId)
        {
            var apiPath = "/project/policies/{policyId}"
                .Replace("{policyId}", policyId.Value);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static object Convert(Dictionary<string, object> it)
            {
                if (it.TryGetValue("$id", out var idValue1) && idValue1?.ToString() == "password-dictionary")
                {
                    return Appwrite.Models.PolicyPasswordDictionary.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue2) && idValue2?.ToString() == "password-history")
                {
                    return Appwrite.Models.PolicyPasswordHistory.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue3) && idValue3?.ToString() == "password-personal-data")
                {
                    return Appwrite.Models.PolicyPasswordPersonalData.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue4) && idValue4?.ToString() == "session-alert")
                {
                    return Appwrite.Models.PolicySessionAlert.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue5) && idValue5?.ToString() == "session-duration")
                {
                    return Appwrite.Models.PolicySessionDuration.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue6) && idValue6?.ToString() == "session-invalidation")
                {
                    return Appwrite.Models.PolicySessionInvalidation.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue7) && idValue7?.ToString() == "session-limit")
                {
                    return Appwrite.Models.PolicySessionLimit.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue8) && idValue8?.ToString() == "user-limit")
                {
                    return Appwrite.Models.PolicyUserLimit.From(map: it);
                }
                if (it.TryGetValue("$id", out var idValue9) && idValue9?.ToString() == "membership-privacy")
                {
                    return Appwrite.Models.PolicyMembershipPrivacy.From(map: it);
                }
                throw new System.Exception("Unable to match response to any expected response model");
            }

            return _client.Call<object>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update properties of a specific protocol. Use this endpoint to enable or
        /// disable a protocol in your project. 
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateProtocol(Appwrite.Enums.ProtocolId protocolId, bool enabled)
        {
            var apiPath = "/project/protocols/{protocolId}"
                .Replace("{protocolId}", protocolId.Value);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "enabled", enabled }
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
        /// Update properties of a specific service. Use this endpoint to enable or
        /// disable a service in your project. 
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateService(Appwrite.Enums.ServiceId serviceId, bool enabled)
        {
            var apiPath = "/project/services/{serviceId}"
                .Replace("{serviceId}", serviceId.Value);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "enabled", enabled }
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
        /// Update the SMTP configuration for your project. Use this endpoint to
        /// configure your project's SMTP provider with your custom settings for
        /// sending transactional emails.
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateSMTP(string? host = null, long? port = null, string? username = null, string? password = null, string? senderEmail = null, string? senderName = null, string? replyToEmail = null, string? replyToName = null, Appwrite.Enums.Secure? secure = null, bool? enabled = null)
        {
            var apiPath = "/project/smtp";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "host", host },
                { "port", port },
                { "username", username },
                { "password", password },
                { "senderEmail", senderEmail },
                { "senderName", senderName },
                { "replyToEmail", replyToEmail },
                { "replyToName", replyToName },
                { "secure", secure?.Value },
                { "enabled", enabled }
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
        /// Send a test email to verify SMTP configuration. 
        /// </para>
        /// </summary>
        public Task<object> CreateSMTPTest(List<string> emails)
        {
            var apiPath = "/project/smtp/tests";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "emails", emails }
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
        /// Get a list of all custom email templates configured for the project. This
        /// endpoint returns an array of all configured email templates and their
        /// locales.
        /// </para>
        /// </summary>
        public Task<Models.EmailTemplateList> ListEmailTemplates(List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/project/templates/email";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.EmailTemplateList Convert(Dictionary<string, object> it)
            {
                return Models.EmailTemplateList.From(map: it);
            }

            return _client.Call<Models.EmailTemplateList>(
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
        public Task<Models.EmailTemplate> UpdateEmailTemplate(Appwrite.Enums.EmailTemplateType templateId, Appwrite.Enums.EmailTemplateLocale? locale = null, string? subject = null, string? message = null, string? senderName = null, string? senderEmail = null, string? replyToEmail = null, string? replyToName = null)
        {
            var apiPath = "/project/templates/email";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "templateId", templateId?.Value },
                { "locale", locale?.Value },
                { "subject", subject },
                { "message", message },
                { "senderName", senderName },
                { "senderEmail", senderEmail },
                { "replyToEmail", replyToEmail },
                { "replyToName", replyToName }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.EmailTemplate Convert(Dictionary<string, object> it)
            {
                return Models.EmailTemplate.From(map: it);
            }

            return _client.Call<Models.EmailTemplate>(
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
        public Task<Models.EmailTemplate> GetEmailTemplate(Appwrite.Enums.EmailTemplateType templateId, Appwrite.Enums.EmailTemplateLocale? locale = null)
        {
            var apiPath = "/project/templates/email/{templateId}"
                .Replace("{templateId}", templateId.Value);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "locale", locale?.Value }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.EmailTemplate Convert(Dictionary<string, object> it)
            {
                return Models.EmailTemplate.From(map: it);
            }

            return _client.Call<Models.EmailTemplate>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a list of all project environment variables.
        /// </para>
        /// </summary>
        public Task<Models.VariableList> ListVariables(List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/project/variables";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.VariableList Convert(Dictionary<string, object> it)
            {
                return Models.VariableList.From(map: it);
            }

            return _client.Call<Models.VariableList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new project environment variable. These variables can be accessed
        /// by all functions and sites in the project.
        /// </para>
        /// </summary>
        public Task<Models.Variable> CreateVariable(string variableId, string key, string xvalue, bool? secret = null)
        {
            var apiPath = "/project/variables";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "variableId", variableId },
                { "key", key },
                { "value", xvalue },
                { "secret", secret }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Variable Convert(Dictionary<string, object> it)
            {
                return Models.Variable.From(map: it);
            }

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
        public Task<Models.Variable> GetVariable(string variableId)
        {
            var apiPath = "/project/variables/{variableId}"
                .Replace("{variableId}", variableId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.Variable Convert(Dictionary<string, object> it)
            {
                return Models.Variable.From(map: it);
            }

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
        public Task<Models.Variable> UpdateVariable(string variableId, string? key = null, string? xvalue = null, bool? secret = null)
        {
            var apiPath = "/project/variables/{variableId}"
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


            static Models.Variable Convert(Dictionary<string, object> it)
            {
                return Models.Variable.From(map: it);
            }

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
        public Task<object> DeleteVariable(string variableId)
        {
            var apiPath = "/project/variables/{variableId}"
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
