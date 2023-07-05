
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;

namespace Appwrite.Services
{
    public class Graphql : Service
    {
        public Graphql(Client client) : base(client)
        {
        }

        /// <summary>
        /// GraphQL Endpoint
        /// <para>
        /// Execute a GraphQL mutation.
        /// </para>
        /// </summary>
        public Task<object> Query(object query)
        {
            var path = "/graphql";

            var parameters = new Dictionary<string, object?>()
            {
                { "query", query }
            };

            var headers = new Dictionary<string, string>()
            {
                { "x-sdk-graphql", "true" },
                { "content-type", "application/json" }
            };



            static object Convert(Dictionary<string, object> it) =>
                it;


            return _client.Call<object>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// GraphQL Endpoint
        /// <para>
        /// Execute a GraphQL mutation.
        /// </para>
        /// </summary>
        public Task<object> Mutation(object query)
        {
            var path = "/graphql/mutation";

            var parameters = new Dictionary<string, object?>()
            {
                { "query", query }
            };

            var headers = new Dictionary<string, string>()
            {
                { "x-sdk-graphql", "true" },
                { "content-type", "application/json" }
            };



            static object Convert(Dictionary<string, object> it) =>
                it;


            return _client.Call<object>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

    }
}
