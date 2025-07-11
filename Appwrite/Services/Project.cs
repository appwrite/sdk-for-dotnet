
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
        /// Get comprehensive usage statistics for your project. View metrics including
        /// network requests, bandwidth, storage, function executions, database usage,
        /// and user activity. Specify a time range with startDate and endDate, and
        /// optionally set the data granularity with period (1h or 1d). The response
        /// includes both total counts and detailed breakdowns by resource, along with
        /// historical data over the specified period.
        /// </para>
        /// </summary>
        public Task<Models.UsageProject> GetUsage(string startDate, string endDate, Appwrite.Enums.ProjectUsageRange? period = null)
        {
            var apiPath = "/project/usage";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "startDate", startDate },
                { "endDate", endDate },
                { "period", period }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.UsageProject Convert(Dictionary<string, object> it) =>
                Models.UsageProject.From(map: it);

            return _client.Call<Models.UsageProject>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a list of all project variables. These variables will be accessible in
        /// all Appwrite Functions at runtime.
        /// </para>
        /// </summary>
        public Task<Models.VariableList> ListVariables()
        {
            var apiPath = "/project/variables";

            var apiParameters = new Dictionary<string, object?>()
            {
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
        /// Create a new project variable. This variable will be accessible in all
        /// Appwrite Functions at runtime.
        /// </para>
        /// </summary>
        public Task<Models.Variable> CreateVariable(string key, string xvalue, bool? secret = null)
        {
            var apiPath = "/project/variables";

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
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a project variable by its unique ID.
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
        /// Update project variable by its unique ID. This variable will be accessible
        /// in all Appwrite Functions at runtime.
        /// </para>
        /// </summary>
        public Task<Models.Variable> UpdateVariable(string variableId, string key, string? xvalue = null, bool? secret = null)
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
        /// Delete a project variable by its unique ID. 
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
