
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Appwrite
{
    public class Health : Service
    {
        public Health(Client client) : base(client) { }

        /// <summary>
        /// Get HTTP
        /// <para>
        /// Check the Appwrite HTTP server is up and responsive.
        /// </para>
        /// </summary>
        public Task<object> Get()
        {
            var path = "/health";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);
        }

        /// <summary>
        /// Get Anti virus
        /// <para>
        /// Check the Appwrite Anti Virus server is up and connection is successful.
        /// </para>
        /// </summary>
        public Task<object> GetAntiVirus()
        {
            var path = "/health/anti-virus";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);
        }

        /// <summary>
        /// Get Cache
        /// <para>
        /// Check the Appwrite in-memory cache server is up and connection is
        /// successful.
        /// </para>
        /// </summary>
        public Task<object> GetCache()
        {
            var path = "/health/cache";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);
        }

        /// <summary>
        /// Get DB
        /// <para>
        /// Check the Appwrite database server is up and connection is successful.
        /// </para>
        /// </summary>
        public Task<object> GetDB()
        {
            var path = "/health/db";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);
        }

        /// <summary>
        /// Get Certificate Queue
        /// <para>
        /// Get the number of certificates that are waiting to be issued against
        /// [Letsencrypt](https://letsencrypt.org/) in the Appwrite internal queue
        /// server.
        /// </para>
        /// </summary>
        public Task<object> GetQueueCertificates()
        {
            var path = "/health/queue/certificates";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);
        }

        /// <summary>
        /// Get Functions Queue
        /// </summary>
        public Task<object> GetQueueFunctions()
        {
            var path = "/health/queue/functions";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);
        }

        /// <summary>
        /// Get Logs Queue
        /// <para>
        /// Get the number of logs that are waiting to be processed in the Appwrite
        /// internal queue server.
        /// </para>
        /// </summary>
        public Task<object> GetQueueLogs()
        {
            var path = "/health/queue/logs";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);
        }

        /// <summary>
        /// Get Tasks Queue
        /// <para>
        /// Get the number of tasks that are waiting to be processed in the Appwrite
        /// internal queue server.
        /// </para>
        /// </summary>
        public Task<object> GetQueueTasks()
        {
            var path = "/health/queue/tasks";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);
        }

        /// <summary>
        /// Get Usage Queue
        /// <para>
        /// Get the number of usage stats that are waiting to be processed in the
        /// Appwrite internal queue server.
        /// </para>
        /// </summary>
        public Task<object> GetQueueUsage()
        {
            var path = "/health/queue/usage";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);
        }

        /// <summary>
        /// Get Webhooks Queue
        /// <para>
        /// Get the number of webhooks that are waiting to be processed in the Appwrite
        /// internal queue server.
        /// </para>
        /// </summary>
        public Task<object> GetQueueWebhooks()
        {
            var path = "/health/queue/webhooks";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);
        }

        /// <summary>
        /// Get Local Storage
        /// <para>
        /// Check the Appwrite local storage device is up and connection is successful.
        /// </para>
        /// </summary>
        public Task<object> GetStorageLocal()
        {
            var path = "/health/storage/local";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);
        }

        /// <summary>
        /// Get Time
        /// <para>
        /// Check the Appwrite server time is synced with Google remote NTP server. We
        /// use this technology to smoothly handle leap seconds with no disruptive
        /// events. The [Network Time
        /// Protocol](https://en.wikipedia.org/wiki/Network_Time_Protocol) (NTP) is
        /// used by hundreds of millions of computers and devices to synchronize their
        /// clocks over the Internet. If your computer sets its own clock, it likely
        /// uses NTP.
        /// </para>
        /// </summary>
        public Task<object> GetTime()
        {
            var path = "/health/time";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);
        }
    };
}