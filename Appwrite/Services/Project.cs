
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
