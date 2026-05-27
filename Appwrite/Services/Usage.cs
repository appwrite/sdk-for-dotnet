using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Usage : Service
    {
        public Usage(Client client) : base(client)
        {
        }

        /// <para>
        /// Query usage event metrics from the usage database. Returns individual event
        /// rows with full metadata. Pass Query objects as JSON strings to filter,
        /// paginate, and order results. Supported query methods: equal,
        /// greaterThanEqual, lessThanEqual, orderAsc, orderDesc, limit, offset.
        /// Supported filter attributes: metric, path, method, status, resource,
        /// resourceId, country, userAgent, time (these match the underlying column
        /// names — note that the response surfaces `resource` as `resourceType` and
        /// `country` as `countryCode`). When no time filter is supplied the endpoint
        /// defaults to the last 7 days. Default `limit(100)` is applied if none is
        /// given; user-supplied limits are capped at 500. The `total` field is capped
        /// at 5000 to keep counts predictable — pass `total=false` to skip the count
        /// entirely.
        /// </para>
        /// </summary>
        public Task<Models.UsageEventList> ListEvents(List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/usage/events";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.UsageEventList Convert(Dictionary<string, object> it)
            {
                return Models.UsageEventList.From(map: it);
            }

            return _client.Call<Models.UsageEventList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Query usage gauge metrics (point-in-time resource snapshots) from the usage
        /// database. Returns individual gauge snapshots with metric, value, timestamp,
        /// resourceType, and resourceId. Pass Query objects as JSON strings to filter,
        /// paginate, and order results. Supported query methods: equal,
        /// greaterThanEqual, lessThanEqual, orderAsc, orderDesc, limit, offset.
        /// Supported filter attributes: metric, time. Use `orderDesc("time"),
        /// limit(1)` to fetch the most recent snapshot. When no time filter is
        /// supplied the endpoint defaults to the last 7 days. Default `limit(100)` is
        /// applied if none is given; user-supplied limits are capped at 500. The
        /// `total` field is capped at 5000 to keep counts predictable — pass
        /// `total=false` to skip the count entirely.
        /// </para>
        /// </summary>
        public Task<Models.UsageGaugeList> ListGauges(List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/usage/gauges";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.UsageGaugeList Convert(Dictionary<string, object> it)
            {
                return Models.UsageGaugeList.From(map: it);
            }

            return _client.Call<Models.UsageGaugeList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

    }
}
