
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Proxy : Service
    {
        public Proxy(Client client) : base(client)
        {
        }

        /// <para>
        /// Get a list of all the proxy rules. You can use the query params to filter
        /// your results.
        /// </para>
        /// </summary>
        public Task<Models.ProxyRuleList> ListRules(List<string>? queries = null, string? search = null)
        {
            var apiPath = "/proxy/rules";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.ProxyRuleList Convert(Dictionary<string, object> it) =>
                Models.ProxyRuleList.From(map: it);

            return _client.Call<Models.ProxyRuleList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new proxy rule for serving Appwrite's API on custom domain.
        /// </para>
        /// </summary>
        public Task<Models.ProxyRule> CreateAPIRule(string domain)
        {
            var apiPath = "/proxy/rules/api";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "domain", domain }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.ProxyRule Convert(Dictionary<string, object> it) =>
                Models.ProxyRule.From(map: it);

            return _client.Call<Models.ProxyRule>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new proxy rule for executing Appwrite Function on custom domain.
        /// </para>
        /// </summary>
        public Task<Models.ProxyRule> CreateFunctionRule(string domain, string functionId, string? branch = null)
        {
            var apiPath = "/proxy/rules/function";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "domain", domain },
                { "functionId", functionId },
                { "branch", branch }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.ProxyRule Convert(Dictionary<string, object> it) =>
                Models.ProxyRule.From(map: it);

            return _client.Call<Models.ProxyRule>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new proxy rule for to redirect from custom domain to another
        /// domain.
        /// </para>
        /// </summary>
        public Task<Models.ProxyRule> CreateRedirectRule(string domain, string url, Appwrite.Enums.StatusCode statusCode, string resourceId, Appwrite.Enums.ProxyResourceType resourceType)
        {
            var apiPath = "/proxy/rules/redirect";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "domain", domain },
                { "url", url },
                { "statusCode", statusCode },
                { "resourceId", resourceId },
                { "resourceType", resourceType }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.ProxyRule Convert(Dictionary<string, object> it) =>
                Models.ProxyRule.From(map: it);

            return _client.Call<Models.ProxyRule>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new proxy rule for serving Appwrite Site on custom domain.
        /// </para>
        /// </summary>
        public Task<Models.ProxyRule> CreateSiteRule(string domain, string siteId, string? branch = null)
        {
            var apiPath = "/proxy/rules/site";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "domain", domain },
                { "siteId", siteId },
                { "branch", branch }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.ProxyRule Convert(Dictionary<string, object> it) =>
                Models.ProxyRule.From(map: it);

            return _client.Call<Models.ProxyRule>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a proxy rule by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.ProxyRule> GetRule(string ruleId)
        {
            var apiPath = "/proxy/rules/{ruleId}"
                .Replace("{ruleId}", ruleId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.ProxyRule Convert(Dictionary<string, object> it) =>
                Models.ProxyRule.From(map: it);

            return _client.Call<Models.ProxyRule>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a proxy rule by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> DeleteRule(string ruleId)
        {
            var apiPath = "/proxy/rules/{ruleId}"
                .Replace("{ruleId}", ruleId);

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
        /// Retry getting verification process of a proxy rule. This endpoint triggers
        /// domain verification by checking DNS records (CNAME) against the configured
        /// target domain. If verification is successful, a TLS certificate will be
        /// automatically provisioned for the domain.
        /// </para>
        /// </summary>
        public Task<Models.ProxyRule> UpdateRuleVerification(string ruleId)
        {
            var apiPath = "/proxy/rules/{ruleId}/verification"
                .Replace("{ruleId}", ruleId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.ProxyRule Convert(Dictionary<string, object> it) =>
                Models.ProxyRule.From(map: it);

            return _client.Call<Models.ProxyRule>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

    }
}
