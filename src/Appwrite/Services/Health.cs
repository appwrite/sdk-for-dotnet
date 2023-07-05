
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;

namespace Appwrite.Services
{
    public class Health : Service
    {
        public Health(Client client) : base(client)
        {
        }

        /// <summary>
        /// Get HTTP
        /// <para>
        /// Check the Appwrite HTTP server is up and responsive.
        /// </para>
        /// </summary>
        public Task<Models.HealthStatus> Get()
        {
            var path = "/health";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.HealthStatus Convert(Dictionary<string, object> it) =>
                Models.HealthStatus.From(map: it);


            return _client.Call<Models.HealthStatus>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get Antivirus
        /// <para>
        /// Check the Appwrite Antivirus server is up and connection is successful.
        /// </para>
        /// </summary>
        public Task<Models.HealthAntivirus> GetAntivirus()
        {
            var path = "/health/anti-virus";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.HealthAntivirus Convert(Dictionary<string, object> it) =>
                Models.HealthAntivirus.From(map: it);


            return _client.Call<Models.HealthAntivirus>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get Cache
        /// <para>
        /// Check the Appwrite in-memory cache server is up and connection is
        /// successful.
        /// </para>
        /// </summary>
        public Task<Models.HealthStatus> GetCache()
        {
            var path = "/health/cache";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.HealthStatus Convert(Dictionary<string, object> it) =>
                Models.HealthStatus.From(map: it);


            return _client.Call<Models.HealthStatus>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get DB
        /// <para>
        /// Check the Appwrite database server is up and connection is successful.
        /// </para>
        /// </summary>
        public Task<Models.HealthStatus> GetDB()
        {
            var path = "/health/db";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.HealthStatus Convert(Dictionary<string, object> it) =>
                Models.HealthStatus.From(map: it);


            return _client.Call<Models.HealthStatus>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get Certificates Queue
        /// <para>
        /// Get the number of certificates that are waiting to be issued against
        /// [Letsencrypt](https://letsencrypt.org/) in the Appwrite internal queue
        /// server.
        /// </para>
        /// </summary>
        public Task<Models.HealthQueue> GetQueueCertificates()
        {
            var path = "/health/queue/certificates";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.HealthQueue Convert(Dictionary<string, object> it) =>
                Models.HealthQueue.From(map: it);


            return _client.Call<Models.HealthQueue>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get Functions Queue
        /// </summary>
        public Task<Models.HealthQueue> GetQueueFunctions()
        {
            var path = "/health/queue/functions";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.HealthQueue Convert(Dictionary<string, object> it) =>
                Models.HealthQueue.From(map: it);


            return _client.Call<Models.HealthQueue>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get Logs Queue
        /// <para>
        /// Get the number of logs that are waiting to be processed in the Appwrite
        /// internal queue server.
        /// </para>
        /// </summary>
        public Task<Models.HealthQueue> GetQueueLogs()
        {
            var path = "/health/queue/logs";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.HealthQueue Convert(Dictionary<string, object> it) =>
                Models.HealthQueue.From(map: it);


            return _client.Call<Models.HealthQueue>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get Webhooks Queue
        /// <para>
        /// Get the number of webhooks that are waiting to be processed in the Appwrite
        /// internal queue server.
        /// </para>
        /// </summary>
        public Task<Models.HealthQueue> GetQueueWebhooks()
        {
            var path = "/health/queue/webhooks";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.HealthQueue Convert(Dictionary<string, object> it) =>
                Models.HealthQueue.From(map: it);


            return _client.Call<Models.HealthQueue>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get Local Storage
        /// <para>
        /// Check the Appwrite local storage device is up and connection is successful.
        /// </para>
        /// </summary>
        public Task<Models.HealthStatus> GetStorageLocal()
        {
            var path = "/health/storage/local";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.HealthStatus Convert(Dictionary<string, object> it) =>
                Models.HealthStatus.From(map: it);


            return _client.Call<Models.HealthStatus>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

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
        public Task<Models.HealthTime> GetTime()
        {
            var path = "/health/time";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.HealthTime Convert(Dictionary<string, object> it) =>
                Models.HealthTime.From(map: it);


            return _client.Call<Models.HealthTime>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

    }
}
