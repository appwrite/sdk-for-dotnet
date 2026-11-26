using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Alerts : Service
    {
        public Alerts(Client client) : base(client)
        {
        }

        /// <para>
        /// Get a list of the alerts the project's monitors raised, open and resolved.
        /// An alert is created when a monitor starts firing and resolved when it
        /// recovers. Use queries to filter by monitor, status, type or resource, order
        /// by `$createdAt` for the latest first, and `Query.search('search', term)` to
        /// search alert and monitor IDs, names and metrics.
        /// </para>
        /// </summary>
        public Task<Models.AlertList> List(List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/alerts";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.AlertList Convert(Dictionary<string, object> it)
            {
                return Models.AlertList.From(map: it);
            }

            return _client.Call<Models.AlertList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get an alert by its unique ID: the monitor that raised it, when it fired
        /// and resolved, and the readings while it fired.
        /// </para>
        /// </summary>
        public Task<Models.Alert> Get(string alertId)
        {
            if (alertId == "")
            {
                throw new AppwriteException("Missing required parameter: \"alertId\"");
            }

            var apiPath = "/alerts/{alertId}"
                .Replace("{alertId}", Client.EncodePath(alertId));

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.Alert Convert(Dictionary<string, object> it)
            {
                return Models.Alert.From(map: it);
            }

            return _client.Call<Models.Alert>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Acknowledge a firing alert, or undo that. Everyone who can read the alert
        /// sees who acknowledged it and when. The alert keeps firing until its monitor
        /// recovers; a resolved alert keeps its acknowledgement and cannot be changed.
        /// </para>
        /// </summary>
        public Task<Models.Alert> Update(string alertId, bool acknowledged)
        {
            if (alertId == "")
            {
                throw new AppwriteException("Missing required parameter: \"alertId\"");
            }

            var apiPath = "/alerts/{alertId}"
                .Replace("{alertId}", Client.EncodePath(alertId));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "acknowledged", acknowledged }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Alert Convert(Dictionary<string, object> it)
            {
                return Models.Alert.From(map: it);
            }

            return _client.Call<Models.Alert>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

    }
}
