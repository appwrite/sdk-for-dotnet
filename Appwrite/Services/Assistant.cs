
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Assistant : Service
    {
        public Assistant(Client client) : base(client)
        {
        }

        /// <para>
        /// Send a prompt to the AI assistant and receive a response. This endpoint
        /// allows you to interact with Appwrite's AI assistant by sending questions or
        /// prompts and receiving helpful responses in real-time through a server-sent
        /// events stream. 
        /// </para>
        /// </summary>
        public Task<object> Chat(string prompt)
        {
            var apiPath = "/console/assistant";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "prompt", prompt }
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

    }
}
