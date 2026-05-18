using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Presences : Service
    {
        public Presences(Client client) : base(client)
        {
        }

        /// <para>
        /// List presence logs. Expired entries are filtered out automatically.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.PresenceList> List(List<string>? queries = null, bool? total = null, long? ttl = null)
        {
            var apiPath = "/presences";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total },
                { "ttl", ttl }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.PresenceList Convert(Dictionary<string, object> it)
            {
                return Models.PresenceList.From(map: it);
            }

            return _client.Call<Models.PresenceList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a presence log by its unique ID. Entries whose `expiresAt` is in the
        /// past are treated as not found.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.Presence> Get(string presenceId)
        {
            var apiPath = "/presences/{presenceId}"
                .Replace("{presenceId}", presenceId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.Presence Convert(Dictionary<string, object> it)
            {
                return Models.Presence.From(map: it);
            }

            return _client.Call<Models.Presence>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create or update a presence log by its user ID.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.Presence> Upsert(string presenceId, string userId, string status, List<string>? permissions = null, string? expiresAt = null, object? metadata = null)
        {
            var apiPath = "/presences/{presenceId}"
                .Replace("{presenceId}", presenceId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "status", status },
                { "permissions", permissions },
                { "expiresAt", expiresAt },
                { "metadata", metadata }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Presence Convert(Dictionary<string, object> it)
            {
                return Models.Presence.From(map: it);
            }

            return _client.Call<Models.Presence>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a presence log by its unique ID. Using the patch method you can pass
        /// only specific fields that will get updated.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.Presence> UpdatePresence(string presenceId, string userId, string? status = null, string? expiresAt = null, object? metadata = null, List<string>? permissions = null, bool? purge = null)
        {
            var apiPath = "/presences/{presenceId}"
                .Replace("{presenceId}", presenceId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "status", status },
                { "expiresAt", expiresAt },
                { "metadata", metadata },
                { "permissions", permissions },
                { "purge", purge }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Presence Convert(Dictionary<string, object> it)
            {
                return Models.Presence.From(map: it);
            }

            return _client.Call<Models.Presence>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a presence log by its unique ID.
        /// 
        /// </para>
        /// </summary>
        public Task<object> Delete(string presenceId)
        {
            var apiPath = "/presences/{presenceId}"
                .Replace("{presenceId}", presenceId);

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
