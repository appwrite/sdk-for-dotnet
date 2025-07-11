
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Console : Service
    {
        public Console(Client client) : base(client)
        {
        }

        /// <para>
        /// Check if a resource ID is available.
        /// </para>
        /// </summary>
        public Task<object> GetResource(string xvalue, Appwrite.Enums.ConsoleResourceType type)
        {
            var apiPath = "/console/resources";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "value", xvalue },
                { "type", type }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };



            return _client.Call<object>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <para>
        /// Get all Environment Variables that are relevant for the console.
        /// </para>
        /// </summary>
        public Task<Models.ConsoleVariables> Variables()
        {
            var apiPath = "/console/variables";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.ConsoleVariables Convert(Dictionary<string, object> it) =>
                Models.ConsoleVariables.From(map: it);

            return _client.Call<Models.ConsoleVariables>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

    }
}
