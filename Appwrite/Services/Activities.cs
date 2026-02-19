
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Activities : Service
    {
        public Activities(Client client) : base(client)
        {
        }

        /// <para>
        /// List all events for selected filters.
        /// </para>
        /// </summary>
        public Task<Models.ActivityEventList> ListEvents(string? queries = null)
        {
            var apiPath = "/activities/events";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.ActivityEventList Convert(Dictionary<string, object> it) =>
                Models.ActivityEventList.From(map: it);

            return _client.Call<Models.ActivityEventList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get event by ID.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.ActivityEvent> GetEvent(string eventId)
        {
            var apiPath = "/activities/events/{eventId}"
                .Replace("{eventId}", eventId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.ActivityEvent Convert(Dictionary<string, object> it) =>
                Models.ActivityEvent.From(map: it);

            return _client.Call<Models.ActivityEvent>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

    }
}
