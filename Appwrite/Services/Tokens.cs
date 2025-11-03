
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Tokens : Service
    {
        public Tokens(Client client) : base(client)
        {
        }

        /// <para>
        /// List all the tokens created for a specific file or bucket. You can use the
        /// query params to filter your results.
        /// </para>
        /// </summary>
        public Task<Models.ResourceTokenList> List(string bucketId, string fileId, List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/tokens/buckets/{bucketId}/files/{fileId}"
                .Replace("{bucketId}", bucketId)
                .Replace("{fileId}", fileId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.ResourceTokenList Convert(Dictionary<string, object> it) =>
                Models.ResourceTokenList.From(map: it);

            return _client.Call<Models.ResourceTokenList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new token. A token is linked to a file. Token can be passed as a
        /// request URL search parameter.
        /// </para>
        /// </summary>
        public Task<Models.ResourceToken> CreateFileToken(string bucketId, string fileId, string? expire = null)
        {
            var apiPath = "/tokens/buckets/{bucketId}/files/{fileId}"
                .Replace("{bucketId}", bucketId)
                .Replace("{fileId}", fileId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "expire", expire }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.ResourceToken Convert(Dictionary<string, object> it) =>
                Models.ResourceToken.From(map: it);

            return _client.Call<Models.ResourceToken>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a token by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.ResourceToken> Get(string tokenId)
        {
            var apiPath = "/tokens/{tokenId}"
                .Replace("{tokenId}", tokenId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.ResourceToken Convert(Dictionary<string, object> it) =>
                Models.ResourceToken.From(map: it);

            return _client.Call<Models.ResourceToken>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a token by its unique ID. Use this endpoint to update a token's
        /// expiry date.
        /// </para>
        /// </summary>
        public Task<Models.ResourceToken> Update(string tokenId, string? expire = null)
        {
            var apiPath = "/tokens/{tokenId}"
                .Replace("{tokenId}", tokenId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "expire", expire }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.ResourceToken Convert(Dictionary<string, object> it) =>
                Models.ResourceToken.From(map: it);

            return _client.Call<Models.ResourceToken>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a token by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> Delete(string tokenId)
        {
            var apiPath = "/tokens/{tokenId}"
                .Replace("{tokenId}", tokenId);

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
