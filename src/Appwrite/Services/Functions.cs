
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Appwrite
{
    public class Functions : Service
    {
        public Functions(Client client) : base(client) { }

        /// <summary>
        /// List Functions
        /// <para>
        /// Get a list of all the project's functions. You can use the query params to
        /// filter your results.
        /// </para>
        /// </summary>
        public Task<Models.FunctionList> List(string? search = null, int? limit = null, int? offset = null, OrderType orderType = OrderType.ASC)
        {
            var path = "/functions";

            var parameters = new Dictionary<string, object?>()
            {
                { "search", search },
                { "limit", limit },
                { "offset", offset },
                { "orderType", orderType.ToString() }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.FunctionList convert(Dictionary<string, object> it)
            {
                return Models.FunctionList.From(map: it);
            }

            return _client.Call<Models.FunctionList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.FunctionList));
        }

        /// <summary>
        /// Create Function
        /// <para>
        /// Create a new function. You can pass a list of
        /// [permissions](/docs/permissions) to allow different project users or team
        /// with access to execute the function using the client API.
        /// </para>
        /// </summary>
        public Task<Models.Function> Create(string name, List<object> execute, string runtime, object? vars = null, List<object>? events = null, string? schedule = null, int? timeout = null)
        {
            var path = "/functions";

            var parameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "execute", execute },
                { "runtime", runtime },
                { "vars", vars },
                { "events", events },
                { "schedule", schedule },
                { "timeout", timeout }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Function convert(Dictionary<string, object> it)
            {
                return Models.Function.From(map: it);
            }

            return _client.Call<Models.Function>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.Function));
        }

        /// <summary>
        /// Get Function
        /// <para>
        /// Get a function by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Function> Get(string functionId)
        {
            var path = "/functions/{functionId}"
                .Replace("{functionId}", functionId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Function convert(Dictionary<string, object> it)
            {
                return Models.Function.From(map: it);
            }

            return _client.Call<Models.Function>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.Function));
        }

        /// <summary>
        /// Update Function
        /// <para>
        /// Update function by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Function> Update(string functionId, string name, List<object> execute, object? vars = null, List<object>? events = null, string? schedule = null, int? timeout = null)
        {
            var path = "/functions/{functionId}"
                .Replace("{functionId}", functionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "execute", execute },
                { "vars", vars },
                { "events", events },
                { "schedule", schedule },
                { "timeout", timeout }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Function convert(Dictionary<string, object> it)
            {
                return Models.Function.From(map: it);
            }

            return _client.Call<Models.Function>(
                method: "PUT",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.Function));
        }

        /// <summary>
        /// Delete Function
        /// <para>
        /// Delete a function by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> Delete(string functionId)
        {
            var path = "/functions/{functionId}"
                .Replace("{functionId}", functionId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "DELETE",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);
        }

        /// <summary>
        /// List Executions
        /// <para>
        /// Get a list of all the current user function execution logs. You can use the
        /// query params to filter your results. On admin mode, this endpoint will
        /// return a list of all of the project's executions. [Learn more about
        /// different API modes](/docs/admin).
        /// </para>
        /// </summary>
        public Task<Models.ExecutionList> ListExecutions(string functionId, string? search = null, int? limit = null, int? offset = null, OrderType orderType = OrderType.ASC)
        {
            var path = "/functions/{functionId}/executions"
                .Replace("{functionId}", functionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "search", search },
                { "limit", limit },
                { "offset", offset },
                { "orderType", orderType.ToString() }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.ExecutionList convert(Dictionary<string, object> it)
            {
                return Models.ExecutionList.From(map: it);
            }

            return _client.Call<Models.ExecutionList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.ExecutionList));
        }

        /// <summary>
        /// Create Execution
        /// <para>
        /// Trigger a function execution. The returned object will return you the
        /// current execution status. You can ping the `Get Execution` endpoint to get
        /// updates on the current execution status. Once this endpoint is called, your
        /// function execution process will start asynchronously.
        /// </para>
        /// </summary>
        public Task<Models.Execution> CreateExecution(string functionId, string? data = null)
        {
            var path = "/functions/{functionId}/executions"
                .Replace("{functionId}", functionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "data", data }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Execution convert(Dictionary<string, object> it)
            {
                return Models.Execution.From(map: it);
            }

            return _client.Call<Models.Execution>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.Execution));
        }

        /// <summary>
        /// Get Execution
        /// <para>
        /// Get a function execution log by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Execution> GetExecution(string functionId, string executionId)
        {
            var path = "/functions/{functionId}/executions/{executionId}"
                .Replace("{functionId}", functionId)
                .Replace("{executionId}", executionId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Execution convert(Dictionary<string, object> it)
            {
                return Models.Execution.From(map: it);
            }

            return _client.Call<Models.Execution>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.Execution));
        }

        /// <summary>
        /// Update Function Tag
        /// <para>
        /// Update the function code tag ID using the unique function ID. Use this
        /// endpoint to switch the code tag that should be executed by the execution
        /// endpoint.
        /// </para>
        /// </summary>
        public Task<Models.Function> UpdateTag(string functionId, string tag)
        {
            var path = "/functions/{functionId}/tag"
                .Replace("{functionId}", functionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "tag", tag }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Function convert(Dictionary<string, object> it)
            {
                return Models.Function.From(map: it);
            }

            return _client.Call<Models.Function>(
                method: "PATCH",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.Function));
        }

        /// <summary>
        /// List Tags
        /// <para>
        /// Get a list of all the project's code tags. You can use the query params to
        /// filter your results.
        /// </para>
        /// </summary>
        public Task<Models.TagList> ListTags(string functionId, string? search = null, int? limit = null, int? offset = null, OrderType orderType = OrderType.ASC)
        {
            var path = "/functions/{functionId}/tags"
                .Replace("{functionId}", functionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "search", search },
                { "limit", limit },
                { "offset", offset },
                { "orderType", orderType.ToString() }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.TagList convert(Dictionary<string, object> it)
            {
                return Models.TagList.From(map: it);
            }

            return _client.Call<Models.TagList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.TagList));
        }

        /// <summary>
        /// Create Tag
        /// <para>
        /// Create a new function code tag. Use this endpoint to upload a new version
        /// of your code function. To execute your newly uploaded code, you'll need to
        /// update the function's tag to use your new tag UID.
        /// 
        /// This endpoint accepts a tar.gz file compressed with your code. Make sure to
        /// include any dependencies your code has within the compressed file. You can
        /// learn more about code packaging in the [Appwrite Cloud Functions
        /// tutorial](/docs/functions).
        /// 
        /// Use the "command" param to set the entry point used to execute your code.
        /// </para>
        /// </summary>
        public Task<Models.Tag> CreateTag(string functionId, string command, FileInfo code)
        {
            var path = "/functions/{functionId}/tags"
                .Replace("{functionId}", functionId);

            var parameters = new Dictionary<string, object?>()
            {
                { "command", command },
                { "code", code }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "multipart/form-data" }
            };


            static Models.Tag convert(Dictionary<string, object> it)
            {
                return Models.Tag.From(map: it);
            }

            return _client.Call<Models.Tag>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.Tag));
        }

        /// <summary>
        /// Get Tag
        /// <para>
        /// Get a code tag by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Tag> GetTag(string functionId, string tagId)
        {
            var path = "/functions/{functionId}/tags/{tagId}"
                .Replace("{functionId}", functionId)
                .Replace("{tagId}", tagId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Tag convert(Dictionary<string, object> it)
            {
                return Models.Tag.From(map: it);
            }

            return _client.Call<Models.Tag>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.Tag));
        }

        /// <summary>
        /// Delete Tag
        /// <para>
        /// Delete a code tag by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> DeleteTag(string functionId, string tagId)
        {
            var path = "/functions/{functionId}/tags/{tagId}"
                .Replace("{functionId}", functionId)
                .Replace("{tagId}", tagId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "DELETE",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);
        }
    };
}