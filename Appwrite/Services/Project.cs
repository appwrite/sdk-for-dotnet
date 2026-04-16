
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
        /// Update the status of a specific protocol. Use this endpoint to enable or
        /// disable a protocol in your project. 
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateProtocolStatus(Appwrite.Enums.ProtocolId protocolId, bool enabled)
        {
            var apiPath = "/project/protocols/{protocolId}/status"
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
        /// Update the status of a specific service. Use this endpoint to enable or
        /// disable a service in your project. 
        /// </para>
        /// </summary>
        public Task<Models.Project> UpdateServiceStatus(Appwrite.Enums.ServiceId serviceId, bool enabled)
        {
            var apiPath = "/project/services/{serviceId}/status"
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
