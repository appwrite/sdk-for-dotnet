
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Appwrite
{
    public class Graphql : Service
    {
        public Graphql(Client client) : base(client) { }

        /// <summary>
        /// GraphQL Endpoint
        /// <para>
        /// Execute a GraphQL mutation.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> Query(object query) 
        {
            string path = "/graphql";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "query", query }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "x-sdk-graphql", "true" },
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// GraphQL Endpoint
        /// <para>
        /// Execute a GraphQL mutation.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> Mutation(object query) 
        {
            string path = "/graphql/mutation";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "query", query }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "x-sdk-graphql", "true" },
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }
    };
}