
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;

namespace Appwrite.Services
{
    public class Project : Service
    {
        public Project(Client client) : base(client)
        {
        }

        /// <summary>
        /// List Variables
        /// <para>
        /// Get a list of all project variables. These variables will be accessible in
        /// all Appwrite Functions at runtime.
        /// </para>
        /// </summary>
        public Task<Models.VariableList> ListVariables()
        {
            var apiPath = "/project/variables";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.VariableList Convert(Dictionary<string, object> it) =>
                Models.VariableList.From(map: it);


            return _client.Call<Models.VariableList>(
                method: "GET",
                path: apiPath,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create Variable
        /// <para>
        /// Create a new project variable. This variable will be accessible in all
        /// Appwrite Functions at runtime.
        /// </para>
        /// </summary>
        public Task<Models.Variable> CreateVariable(string key, string xvalue)
        {
            var apiPath = "/project/variables";

            var parameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "value", xvalue }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Variable Convert(Dictionary<string, object> it) =>
                Models.Variable.From(map: it);


            return _client.Call<Models.Variable>(
                method: "POST",
                path: apiPath,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get Variable
        /// <para>
        /// Get a project variable by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Variable> GetVariable(string variableId)
        {
            var apiPath = "/project/variables/{variableId}"
                .Replace("{variableId}", variableId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Variable Convert(Dictionary<string, object> it) =>
                Models.Variable.From(map: it);


            return _client.Call<Models.Variable>(
                method: "GET",
                path: apiPath,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update Variable
        /// <para>
        /// Update project variable by its unique ID. This variable will be accessible
        /// in all Appwrite Functions at runtime.
        /// </para>
        /// </summary>
        public Task<Models.Variable> UpdateVariable(string variableId, string key, string? xvalue = null)
        {
            var apiPath = "/project/variables/{variableId}"
                .Replace("{variableId}", variableId);

            var parameters = new Dictionary<string, object?>()
            {
                { "key", key },
                { "value", xvalue }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Variable Convert(Dictionary<string, object> it) =>
                Models.Variable.From(map: it);


            return _client.Call<Models.Variable>(
                method: "PUT",
                path: apiPath,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Delete Variable
        /// <para>
        /// Delete a project variable by its unique ID. 
        /// </para>
        /// </summary>
        public Task<object> DeleteVariable(string variableId)
        {
            var apiPath = "/project/variables/{variableId}"
                .Replace("{variableId}", variableId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };





            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

    }
}
