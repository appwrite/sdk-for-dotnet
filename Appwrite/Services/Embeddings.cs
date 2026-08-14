using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Embeddings : Service
    {
        public Embeddings(Client client) : base(client)
        {
        }

        /// <para>
        /// Generate vector embeddings for an array of text using the selected
        /// embedding model. Use the returned vectors to power semantic search and
        /// similarity queries against your vector collections.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.EmbeddingList> CreateTextEmbeddings(List<string> texts, Appwrite.Enums.EmbeddingModel? model = null)
        {
            var apiPath = "/embeddings/text";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "texts", texts },
                { "model", model?.Value }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.EmbeddingList Convert(Dictionary<string, object> it)
            {
                return Models.EmbeddingList.From(map: it);
            }

            return _client.Call<Models.EmbeddingList>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

    }
}
