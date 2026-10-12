using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Waf : Service
    {
        public Waf(Client client) : base(client)
        {
        }

        /// <para>
        /// List WAF rules for the current project.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.WafRuleList> ListRules(List<string>? queries = null, string? search = null, bool? total = null)
        {
            var apiPath = "/waf/rules";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.WafRuleList Convert(Dictionary<string, object> it)
            {
                return Models.WafRuleList.From(map: it);
            }

            return _client.Call<Models.WafRuleList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a bypass WAF rule. Conditions can match request attributes including
        /// `ip` (plain IPs or CIDR blocks like `10.0.0.0/8`), `method`, `path`,
        /// `host`, `country`, `continent`, `headers.<name>`, `query.<key>`,
        /// `queryKeys`, `userAgent`, `os`, `osVersion`, `browser`, and
        /// `browserVersion`. Conditions on `city` and `state` require the premium Geo
        /// DB addon.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.WafRuleBypass> CreateBypassRule(string ruleId, string resourceType, string name, string? resourceId = null, string? description = null, long? priority = null, bool? enabled = null, List<string>? conditions = null)
        {
            var apiPath = "/waf/rules/bypass";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "ruleId", ruleId },
                { "resourceType", resourceType },
                { "resourceId", resourceId },
                { "name", name },
                { "description", description },
                { "priority", priority },
                { "enabled", enabled },
                { "conditions", conditions }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.WafRuleBypass Convert(Dictionary<string, object> it)
            {
                return Models.WafRuleBypass.From(map: it);
            }

            return _client.Call<Models.WafRuleBypass>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a bypass WAF rule. Conditions can match request attributes including
        /// `ip` (plain IPs or CIDR blocks like `10.0.0.0/8`), `method`, `path`,
        /// `host`, `country`, `continent`, `headers.<name>`, `query.<key>`,
        /// `queryKeys`, `userAgent`, `os`, `osVersion`, `browser`, and
        /// `browserVersion`. Conditions on `city` and `state` require the premium Geo
        /// DB addon.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.WafRuleBypass> UpdateBypassRule(string ruleId, string? resourceType = null, string? resourceId = null, string? name = null, string? description = null, long? priority = null, bool? enabled = null, List<string>? conditions = null)
        {
            if (ruleId == "")
            {
                throw new AppwriteException("Missing required parameter: \"ruleId\"");
            }

            var apiPath = "/waf/rules/bypass/{ruleId}"
                .Replace("{ruleId}", ruleId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "resourceType", resourceType },
                { "resourceId", resourceId },
                { "name", name },
                { "description", description },
                { "priority", priority },
                { "enabled", enabled },
                { "conditions", conditions }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.WafRuleBypass Convert(Dictionary<string, object> it)
            {
                return Models.WafRuleBypass.From(map: it);
            }

            return _client.Call<Models.WafRuleBypass>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a challenge WAF rule. Use `difficulty` (1 easiest to 5 hardest) to
        /// tune the client-side proof-of-work cost, and `ttl` to control how long, in
        /// seconds, a visitor stays cleared after passing the challenge before being
        /// challenged again. Conditions can match request attributes including `ip`
        /// (plain IPs or CIDR blocks like `10.0.0.0/8`), `method`, `path`, `host`,
        /// `country`, `continent`, `headers.<name>`, `query.<key>`, `queryKeys`,
        /// `userAgent`, `os`, `osVersion`, `browser`, and `browserVersion`. Conditions
        /// on `city` and `state` require the premium Geo DB addon.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.WafRuleChallenge> CreateChallengeRule(string ruleId, string resourceType, string name, string? resourceId = null, string? description = null, string? challengeType = null, long? priority = null, bool? enabled = null, List<string>? conditions = null, long? difficulty = null, long? ttl = null)
        {
            var apiPath = "/waf/rules/challenge";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "ruleId", ruleId },
                { "resourceType", resourceType },
                { "resourceId", resourceId },
                { "name", name },
                { "description", description },
                { "challengeType", challengeType },
                { "priority", priority },
                { "enabled", enabled },
                { "conditions", conditions },
                { "difficulty", difficulty },
                { "ttl", ttl }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.WafRuleChallenge Convert(Dictionary<string, object> it)
            {
                return Models.WafRuleChallenge.From(map: it);
            }

            return _client.Call<Models.WafRuleChallenge>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a challenge WAF rule. Use `difficulty` (1 easiest to 5 hardest) to
        /// tune the client-side proof-of-work cost, and `ttl` to control how long, in
        /// seconds, a visitor stays cleared after passing the challenge before being
        /// challenged again. Conditions can match request attributes including `ip`
        /// (plain IPs or CIDR blocks like `10.0.0.0/8`), `method`, `path`, `host`,
        /// `country`, `continent`, `headers.<name>`, `query.<key>`, `queryKeys`,
        /// `userAgent`, `os`, `osVersion`, `browser`, and `browserVersion`. Conditions
        /// on `city` and `state` require the premium Geo DB addon.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.WafRuleChallenge> UpdateChallengeRule(string ruleId, string? resourceType = null, string? resourceId = null, string? name = null, string? description = null, string? challengeType = null, long? priority = null, bool? enabled = null, List<string>? conditions = null, long? difficulty = null, long? ttl = null)
        {
            if (ruleId == "")
            {
                throw new AppwriteException("Missing required parameter: \"ruleId\"");
            }

            var apiPath = "/waf/rules/challenge/{ruleId}"
                .Replace("{ruleId}", ruleId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "resourceType", resourceType },
                { "resourceId", resourceId },
                { "name", name },
                { "description", description },
                { "challengeType", challengeType },
                { "priority", priority },
                { "enabled", enabled },
                { "conditions", conditions },
                { "difficulty", difficulty },
                { "ttl", ttl }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.WafRuleChallenge Convert(Dictionary<string, object> it)
            {
                return Models.WafRuleChallenge.From(map: it);
            }

            return _client.Call<Models.WafRuleChallenge>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a deny WAF rule. Conditions can match request attributes including
        /// `ip` (plain IPs or CIDR blocks like `10.0.0.0/8`), `method`, `path`,
        /// `host`, `country`, `continent`, `headers.<name>`, `query.<key>`,
        /// `queryKeys`, `userAgent`, `os`, `osVersion`, `browser`, and
        /// `browserVersion`. Conditions on `city` and `state` require the premium Geo
        /// DB addon.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.WafRuleDeny> CreateDenyRule(string ruleId, string resourceType, string name, string? resourceId = null, string? description = null, long? priority = null, bool? enabled = null, List<string>? conditions = null)
        {
            var apiPath = "/waf/rules/deny";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "ruleId", ruleId },
                { "resourceType", resourceType },
                { "resourceId", resourceId },
                { "name", name },
                { "description", description },
                { "priority", priority },
                { "enabled", enabled },
                { "conditions", conditions }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.WafRuleDeny Convert(Dictionary<string, object> it)
            {
                return Models.WafRuleDeny.From(map: it);
            }

            return _client.Call<Models.WafRuleDeny>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a deny WAF rule. Conditions can match request attributes including
        /// `ip` (plain IPs or CIDR blocks like `10.0.0.0/8`), `method`, `path`,
        /// `host`, `country`, `continent`, `headers.<name>`, `query.<key>`,
        /// `queryKeys`, `userAgent`, `os`, `osVersion`, `browser`, and
        /// `browserVersion`. Conditions on `city` and `state` require the premium Geo
        /// DB addon.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.WafRuleDeny> UpdateDenyRule(string ruleId, string? resourceType = null, string? resourceId = null, string? name = null, string? description = null, long? priority = null, bool? enabled = null, List<string>? conditions = null)
        {
            if (ruleId == "")
            {
                throw new AppwriteException("Missing required parameter: \"ruleId\"");
            }

            var apiPath = "/waf/rules/deny/{ruleId}"
                .Replace("{ruleId}", ruleId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "resourceType", resourceType },
                { "resourceId", resourceId },
                { "name", name },
                { "description", description },
                { "priority", priority },
                { "enabled", enabled },
                { "conditions", conditions }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.WafRuleDeny Convert(Dictionary<string, object> it)
            {
                return Models.WafRuleDeny.From(map: it);
            }

            return _client.Call<Models.WafRuleDeny>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a rate limit WAF rule. Use `key` to choose the counter: `ip` limits
        /// per client IP, while `userId` limits per authenticated user (requests
        /// without an authenticated user skip `userId` rules). Conditions can match
        /// request attributes including `ip` (plain IPs or CIDR blocks like
        /// `10.0.0.0/8`), `method`, `path`, `host`, `country`, `continent`,
        /// `headers.<name>`, `query.<key>`, `queryKeys`, `userAgent`, `os`,
        /// `osVersion`, `browser`, and `browserVersion`. Conditions on `city` and
        /// `state` require the premium Geo DB addon.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.WafRuleRateLimit> CreateRateLimitRule(string ruleId, string resourceType, string name, long limit, long interval, string? resourceId = null, string? description = null, string? key = null, string? strategy = null, long? maxBucketSize = null, long? priority = null, bool? enabled = null, List<string>? conditions = null)
        {
            var apiPath = "/waf/rules/rate-limit";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "ruleId", ruleId },
                { "resourceType", resourceType },
                { "resourceId", resourceId },
                { "name", name },
                { "description", description },
                { "limit", limit },
                { "interval", interval },
                { "key", key },
                { "strategy", strategy },
                { "maxBucketSize", maxBucketSize },
                { "priority", priority },
                { "enabled", enabled },
                { "conditions", conditions }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.WafRuleRateLimit Convert(Dictionary<string, object> it)
            {
                return Models.WafRuleRateLimit.From(map: it);
            }

            return _client.Call<Models.WafRuleRateLimit>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a rate limit WAF rule. Use `key` to choose the counter: `ip` limits
        /// per client IP, while `userId` limits per authenticated user (requests
        /// without an authenticated user skip `userId` rules). Conditions can match
        /// request attributes including `ip` (plain IPs or CIDR blocks like
        /// `10.0.0.0/8`), `method`, `path`, `host`, `country`, `continent`,
        /// `headers.<name>`, `query.<key>`, `queryKeys`, `userAgent`, `os`,
        /// `osVersion`, `browser`, and `browserVersion`. Conditions on `city` and
        /// `state` require the premium Geo DB addon.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.WafRuleRateLimit> UpdateRateLimitRule(string ruleId, string? resourceType = null, string? resourceId = null, string? name = null, string? description = null, long? limit = null, long? interval = null, string? key = null, long? maxBucketSize = null, long? priority = null, bool? enabled = null, List<string>? conditions = null)
        {
            if (ruleId == "")
            {
                throw new AppwriteException("Missing required parameter: \"ruleId\"");
            }

            var apiPath = "/waf/rules/rate-limit/{ruleId}"
                .Replace("{ruleId}", ruleId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "resourceType", resourceType },
                { "resourceId", resourceId },
                { "name", name },
                { "description", description },
                { "limit", limit },
                { "interval", interval },
                { "key", key },
                { "maxBucketSize", maxBucketSize },
                { "priority", priority },
                { "enabled", enabled },
                { "conditions", conditions }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.WafRuleRateLimit Convert(Dictionary<string, object> it)
            {
                return Models.WafRuleRateLimit.From(map: it);
            }

            return _client.Call<Models.WafRuleRateLimit>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a redirect WAF rule. Conditions can match request attributes
        /// including `ip` (plain IPs or CIDR blocks like `10.0.0.0/8`), `method`,
        /// `path`, `host`, `country`, `continent`, `headers.<name>`, `query.<key>`,
        /// `queryKeys`, `userAgent`, `os`, `osVersion`, `browser`, and
        /// `browserVersion`. Conditions on `city` and `state` require the premium Geo
        /// DB addon.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.WafRuleRedirect> CreateRedirectRule(string ruleId, string resourceType, string name, string location, long statusCode, string? resourceId = null, string? description = null, long? priority = null, bool? enabled = null, List<string>? conditions = null)
        {
            var apiPath = "/waf/rules/redirect";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "ruleId", ruleId },
                { "resourceType", resourceType },
                { "resourceId", resourceId },
                { "name", name },
                { "description", description },
                { "location", location },
                { "statusCode", statusCode },
                { "priority", priority },
                { "enabled", enabled },
                { "conditions", conditions }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.WafRuleRedirect Convert(Dictionary<string, object> it)
            {
                return Models.WafRuleRedirect.From(map: it);
            }

            return _client.Call<Models.WafRuleRedirect>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a redirect WAF rule. Conditions can match request attributes
        /// including `ip` (plain IPs or CIDR blocks like `10.0.0.0/8`), `method`,
        /// `path`, `host`, `country`, `continent`, `headers.<name>`, `query.<key>`,
        /// `queryKeys`, `userAgent`, `os`, `osVersion`, `browser`, and
        /// `browserVersion`. Conditions on `city` and `state` require the premium Geo
        /// DB addon.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.WafRuleRedirect> UpdateRedirectRule(string ruleId, string? resourceType = null, string? resourceId = null, string? name = null, string? description = null, string? location = null, long? statusCode = null, long? priority = null, bool? enabled = null, List<string>? conditions = null)
        {
            if (ruleId == "")
            {
                throw new AppwriteException("Missing required parameter: \"ruleId\"");
            }

            var apiPath = "/waf/rules/redirect/{ruleId}"
                .Replace("{ruleId}", ruleId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "resourceType", resourceType },
                { "resourceId", resourceId },
                { "name", name },
                { "description", description },
                { "location", location },
                { "statusCode", statusCode },
                { "priority", priority },
                { "enabled", enabled },
                { "conditions", conditions }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.WafRuleRedirect Convert(Dictionary<string, object> it)
            {
                return Models.WafRuleRedirect.From(map: it);
            }

            return _client.Call<Models.WafRuleRedirect>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a WAF rule by its ID.
        /// 
        /// </para>
        /// </summary>
        public Task<object> GetRule(string ruleId)
        {
            if (ruleId == "")
            {
                throw new AppwriteException("Missing required parameter: \"ruleId\"");
            }

            var apiPath = "/waf/rules/{ruleId}"
                .Replace("{ruleId}", ruleId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static object Convert(Dictionary<string, object> it)
            {
                if (it.TryGetValue("action", out var actionValue1) && actionValue1?.ToString() == "bypass")
                {
                    return Appwrite.Models.WafRuleBypass.From(map: it);
                }
                if (it.TryGetValue("action", out var actionValue2) && actionValue2?.ToString() == "deny")
                {
                    return Appwrite.Models.WafRuleDeny.From(map: it);
                }
                if (it.TryGetValue("action", out var actionValue3) && actionValue3?.ToString() == "challenge")
                {
                    return Appwrite.Models.WafRuleChallenge.From(map: it);
                }
                if (it.TryGetValue("action", out var actionValue4) && actionValue4?.ToString() == "rateLimit")
                {
                    return Appwrite.Models.WafRuleRateLimit.From(map: it);
                }
                if (it.TryGetValue("action", out var actionValue5) && actionValue5?.ToString() == "redirect")
                {
                    return Appwrite.Models.WafRuleRedirect.From(map: it);
                }
                throw new System.Exception("Unable to match response to any expected response model");
            }

            return _client.Call<object>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a WAF rule.
        /// 
        /// </para>
        /// </summary>
        public Task<object> DeleteRule(string ruleId)
        {
            if (ruleId == "")
            {
                throw new AppwriteException("Missing required parameter: \"ruleId\"");
            }

            var apiPath = "/waf/rules/{ruleId}"
                .Replace("{ruleId}", ruleId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };



            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

    }
}
