
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;

namespace Appwrite.Services
{
    public class Proxy : Service
    {
        public Proxy(Client client) : base(client)
        {
        }

        /// <summary>
        /// List Rules
        /// <para>
        /// Get a list of all the proxy rules. You can use the query params to filter
        /// your results.
        /// </para>
        /// </summary>
        public Task<Models.ProxyRuleList> ListRules(List<string>? queries = null, string? search = null)
        {
            var apiPath = "/proxy/rules";

            var parameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.ProxyRuleList Convert(Dictionary<string, object> it) =>
                Models.ProxyRuleList.From(map: it);


            return _client.Call<Models.ProxyRuleList>(
                method: "GET",
                path: apiPath,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create Rule
        /// <para>
        /// Create a new proxy rule.
        /// </para>
        /// </summary>
        public Task<Models.ProxyRule> CreateRule(string domain, string resourceType, string? resourceId = null)
        {
            var apiPath = "/proxy/rules";

            var parameters = new Dictionary<string, object?>()
            {
                { "domain", domain },
                { "resourceType", resourceType },
                { "resourceId", resourceId }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.ProxyRule Convert(Dictionary<string, object> it) =>
                Models.ProxyRule.From(map: it);


            return _client.Call<Models.ProxyRule>(
                method: "POST",
                path: apiPath,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get Rule
        /// <para>
        /// Get a proxy rule by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.ProxyRule> GetRule(string ruleId)
        {
            var apiPath = "/proxy/rules/{ruleId}"
                .Replace("{ruleId}", ruleId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.ProxyRule Convert(Dictionary<string, object> it) =>
                Models.ProxyRule.From(map: it);


            return _client.Call<Models.ProxyRule>(
                method: "GET",
                path: apiPath,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Delete Rule
        /// <para>
        /// Delete a proxy rule by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> DeleteRule(string ruleId)
        {
            var apiPath = "/proxy/rules/{ruleId}"
                .Replace("{ruleId}", ruleId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };





            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <summary>
        /// Update Rule Verification Status
        /// </summary>
        public Task<Models.ProxyRule> UpdateRuleVerification(string ruleId)
        {
            var apiPath = "/proxy/rules/{ruleId}/verification"
                .Replace("{ruleId}", ruleId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.ProxyRule Convert(Dictionary<string, object> it) =>
                Models.ProxyRule.From(map: it);


            return _client.Call<Models.ProxyRule>(
                method: "PATCH",
                path: apiPath,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

    }
}
