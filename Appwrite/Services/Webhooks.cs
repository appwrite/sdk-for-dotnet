
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Webhooks : Service
    {
        public Webhooks(Client client) : base(client)
        {
        }

        /// <para>
        /// Get a list of all webhooks belonging to the project. You can use the query
        /// params to filter your results.
        /// </para>
        /// </summary>
        public Task<Models.WebhookList> List(List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/webhooks";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.WebhookList Convert(Dictionary<string, object> it) =>
                Models.WebhookList.From(map: it);

            return _client.Call<Models.WebhookList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new webhook. Use this endpoint to configure a URL that will
        /// receive events from Appwrite when specific events occur.
        /// </para>
        /// </summary>
        public Task<Models.Webhook> Create(string webhookId, string url, string name, List<string> events, bool? enabled = null, bool? security = null, string? httpUser = null, string? httpPass = null)
        {
            var apiPath = "/webhooks";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "webhookId", webhookId },
                { "url", url },
                { "name", name },
                { "events", events },
                { "enabled", enabled },
                { "security", security },
                { "httpUser", httpUser },
                { "httpPass", httpPass }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Webhook Convert(Dictionary<string, object> it) =>
                Models.Webhook.From(map: it);

            return _client.Call<Models.Webhook>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a webhook by its unique ID. This endpoint returns details about a
        /// specific webhook configured for a project. 
        /// </para>
        /// </summary>
        public Task<Models.Webhook> Get(string webhookId)
        {
            var apiPath = "/webhooks/{webhookId}"
                .Replace("{webhookId}", webhookId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.Webhook Convert(Dictionary<string, object> it) =>
                Models.Webhook.From(map: it);

            return _client.Call<Models.Webhook>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a webhook by its unique ID. Use this endpoint to update the URL,
        /// events, or status of an existing webhook.
        /// </para>
        /// </summary>
        public Task<Models.Webhook> Update(string webhookId, string name, string url, List<string> events, bool? enabled = null, bool? security = null, string? httpUser = null, string? httpPass = null)
        {
            var apiPath = "/webhooks/{webhookId}"
                .Replace("{webhookId}", webhookId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "url", url },
                { "events", events },
                { "enabled", enabled },
                { "security", security },
                { "httpUser", httpUser },
                { "httpPass", httpPass }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Webhook Convert(Dictionary<string, object> it) =>
                Models.Webhook.From(map: it);

            return _client.Call<Models.Webhook>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a webhook by its unique ID. Once deleted, the webhook will no longer
        /// receive project events. 
        /// </para>
        /// </summary>
        public Task<object> Delete(string webhookId)
        {
            var apiPath = "/webhooks/{webhookId}"
                .Replace("{webhookId}", webhookId);

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
        /// Update the webhook signature key. This endpoint can be used to regenerate
        /// the signature key used to sign and validate payload deliveries for a
        /// specific webhook.
        /// </para>
        /// </summary>
        public Task<Models.Webhook> UpdateSignature(string webhookId)
        {
            var apiPath = "/webhooks/{webhookId}/signature"
                .Replace("{webhookId}", webhookId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Webhook Convert(Dictionary<string, object> it) =>
                Models.Webhook.From(map: it);

            return _client.Call<Models.Webhook>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

    }
}
