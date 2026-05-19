using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Advisor : Service
    {
        public Advisor(Client client) : base(client)
        {
        }

        /// <para>
        /// Get a list of all the project's analyzer reports. You can use the query
        /// params to filter your results.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.ReportList> ListReports(List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/reports";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.ReportList Convert(Dictionary<string, object> it)
            {
                return Models.ReportList.From(map: it);
            }

            return _client.Call<Models.ReportList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get an analyzer report by its unique ID. The response includes the report's
        /// metadata and the nested insights it produced.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.Report> GetReport(string reportId)
        {
            var apiPath = "/reports/{reportId}"
                .Replace("{reportId}", reportId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.Report Convert(Dictionary<string, object> it)
            {
                return Models.Report.From(map: it);
            }

            return _client.Call<Models.Report>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete an analyzer report by its unique ID. Nested insights and CTA
        /// metadata are removed asynchronously by the deletes worker.
        /// 
        /// </para>
        /// </summary>
        public Task<object> DeleteReport(string reportId)
        {
            var apiPath = "/reports/{reportId}"
                .Replace("{reportId}", reportId);

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

        /// <para>
        /// List the insights produced under a single analyzer report. You can use the
        /// query params to filter your results further.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.InsightList> ListInsights(string reportId, List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/reports/{reportId}/insights"
                .Replace("{reportId}", reportId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.InsightList Convert(Dictionary<string, object> it)
            {
                return Models.InsightList.From(map: it);
            }

            return _client.Call<Models.InsightList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get an insight by its unique ID, scoped to its parent report.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.Insight> GetInsight(string reportId, string insightId)
        {
            var apiPath = "/reports/{reportId}/insights/{insightId}"
                .Replace("{reportId}", reportId)
                .Replace("{insightId}", insightId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.Insight Convert(Dictionary<string, object> it)
            {
                return Models.Insight.From(map: it);
            }

            return _client.Call<Models.Insight>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

    }
}
