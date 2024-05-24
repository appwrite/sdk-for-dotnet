
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

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
            var apiPath = "/health";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.HealthStatus Convert(Dictionary<string, object> it) =>
                Models.HealthStatus.From(map: it);

            return _client.Call<Models.HealthStatus>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get antivirus
        /// <para>
        /// Check the Appwrite Antivirus server is up and connection is successful.
        /// </para>
        /// </summary>
        public Task<Models.HealthAntivirus> GetAntivirus()
        {
            var apiPath = "/health/anti-virus";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.HealthAntivirus Convert(Dictionary<string, object> it) =>
                Models.HealthAntivirus.From(map: it);

            return _client.Call<Models.HealthAntivirus>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get cache
        /// <para>
        /// Check the Appwrite in-memory cache servers are up and connection is
        /// successful.
        /// </para>
        /// </summary>
        public Task<Models.HealthStatus> GetCache()
        {
            var apiPath = "/health/cache";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.HealthStatus Convert(Dictionary<string, object> it) =>
                Models.HealthStatus.From(map: it);

            return _client.Call<Models.HealthStatus>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get the SSL certificate for a domain
        /// <para>
        /// Get the SSL certificate for a domain
        /// </para>
        /// </summary>
        public Task<Models.HealthCertificate> GetCertificate(string? domain = null)
        {
            var apiPath = "/health/certificate";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "domain", domain }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.HealthCertificate Convert(Dictionary<string, object> it) =>
                Models.HealthCertificate.From(map: it);

            return _client.Call<Models.HealthCertificate>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get DB
        /// <para>
        /// Check the Appwrite database servers are up and connection is successful.
        /// </para>
        /// </summary>
        public Task<Models.HealthStatus> GetDB()
        {
            var apiPath = "/health/db";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.HealthStatus Convert(Dictionary<string, object> it) =>
                Models.HealthStatus.From(map: it);

            return _client.Call<Models.HealthStatus>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get pubsub
        /// <para>
        /// Check the Appwrite pub-sub servers are up and connection is successful.
        /// </para>
        /// </summary>
        public Task<Models.HealthStatus> GetPubSub()
        {
            var apiPath = "/health/pubsub";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.HealthStatus Convert(Dictionary<string, object> it) =>
                Models.HealthStatus.From(map: it);

            return _client.Call<Models.HealthStatus>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get queue
        /// <para>
        /// Check the Appwrite queue messaging servers are up and connection is
        /// successful.
        /// </para>
        /// </summary>
        public Task<Models.HealthStatus> GetQueue()
        {
            var apiPath = "/health/queue";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.HealthStatus Convert(Dictionary<string, object> it) =>
                Models.HealthStatus.From(map: it);

            return _client.Call<Models.HealthStatus>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get builds queue
        /// <para>
        /// Get the number of builds that are waiting to be processed in the Appwrite
        /// internal queue server.
        /// </para>
        /// </summary>
        public Task<Models.HealthQueue> GetQueueBuilds(long? threshold = null)
        {
            var apiPath = "/health/queue/builds";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "threshold", threshold }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.HealthQueue Convert(Dictionary<string, object> it) =>
                Models.HealthQueue.From(map: it);

            return _client.Call<Models.HealthQueue>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get certificates queue
        /// <para>
        /// Get the number of certificates that are waiting to be issued against
        /// [Letsencrypt](https://letsencrypt.org/) in the Appwrite internal queue
        /// server.
        /// </para>
        /// </summary>
        public Task<Models.HealthQueue> GetQueueCertificates(long? threshold = null)
        {
            var apiPath = "/health/queue/certificates";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "threshold", threshold }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.HealthQueue Convert(Dictionary<string, object> it) =>
                Models.HealthQueue.From(map: it);

            return _client.Call<Models.HealthQueue>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get databases queue
        /// <para>
        /// Get the number of database changes that are waiting to be processed in the
        /// Appwrite internal queue server.
        /// </para>
        /// </summary>
        public Task<Models.HealthQueue> GetQueueDatabases(string? name = null, long? threshold = null)
        {
            var apiPath = "/health/queue/databases";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "threshold", threshold }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.HealthQueue Convert(Dictionary<string, object> it) =>
                Models.HealthQueue.From(map: it);

            return _client.Call<Models.HealthQueue>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get deletes queue
        /// <para>
        /// Get the number of background destructive changes that are waiting to be
        /// processed in the Appwrite internal queue server.
        /// </para>
        /// </summary>
        public Task<Models.HealthQueue> GetQueueDeletes(long? threshold = null)
        {
            var apiPath = "/health/queue/deletes";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "threshold", threshold }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.HealthQueue Convert(Dictionary<string, object> it) =>
                Models.HealthQueue.From(map: it);

            return _client.Call<Models.HealthQueue>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get number of failed queue jobs
        /// <para>
        /// Returns the amount of failed jobs in a given queue.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.HealthQueue> GetFailedJobs(Appwrite.Enums.Name name, long? threshold = null)
        {
            var apiPath = "/health/queue/failed/{name}"
                .Replace("{name}", name.Value);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "threshold", threshold }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.HealthQueue Convert(Dictionary<string, object> it) =>
                Models.HealthQueue.From(map: it);

            return _client.Call<Models.HealthQueue>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get functions queue
        /// <para>
        /// Get the number of function executions that are waiting to be processed in
        /// the Appwrite internal queue server.
        /// </para>
        /// </summary>
        public Task<Models.HealthQueue> GetQueueFunctions(long? threshold = null)
        {
            var apiPath = "/health/queue/functions";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "threshold", threshold }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.HealthQueue Convert(Dictionary<string, object> it) =>
                Models.HealthQueue.From(map: it);

            return _client.Call<Models.HealthQueue>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get logs queue
        /// <para>
        /// Get the number of logs that are waiting to be processed in the Appwrite
        /// internal queue server.
        /// </para>
        /// </summary>
        public Task<Models.HealthQueue> GetQueueLogs(long? threshold = null)
        {
            var apiPath = "/health/queue/logs";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "threshold", threshold }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.HealthQueue Convert(Dictionary<string, object> it) =>
                Models.HealthQueue.From(map: it);

            return _client.Call<Models.HealthQueue>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get mails queue
        /// <para>
        /// Get the number of mails that are waiting to be processed in the Appwrite
        /// internal queue server.
        /// </para>
        /// </summary>
        public Task<Models.HealthQueue> GetQueueMails(long? threshold = null)
        {
            var apiPath = "/health/queue/mails";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "threshold", threshold }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.HealthQueue Convert(Dictionary<string, object> it) =>
                Models.HealthQueue.From(map: it);

            return _client.Call<Models.HealthQueue>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get messaging queue
        /// <para>
        /// Get the number of messages that are waiting to be processed in the Appwrite
        /// internal queue server.
        /// </para>
        /// </summary>
        public Task<Models.HealthQueue> GetQueueMessaging(long? threshold = null)
        {
            var apiPath = "/health/queue/messaging";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "threshold", threshold }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.HealthQueue Convert(Dictionary<string, object> it) =>
                Models.HealthQueue.From(map: it);

            return _client.Call<Models.HealthQueue>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get migrations queue
        /// <para>
        /// Get the number of migrations that are waiting to be processed in the
        /// Appwrite internal queue server.
        /// </para>
        /// </summary>
        public Task<Models.HealthQueue> GetQueueMigrations(long? threshold = null)
        {
            var apiPath = "/health/queue/migrations";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "threshold", threshold }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.HealthQueue Convert(Dictionary<string, object> it) =>
                Models.HealthQueue.From(map: it);

            return _client.Call<Models.HealthQueue>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get usage queue
        /// <para>
        /// Get the number of metrics that are waiting to be processed in the Appwrite
        /// internal queue server.
        /// </para>
        /// </summary>
        public Task<Models.HealthQueue> GetQueueUsage(long? threshold = null)
        {
            var apiPath = "/health/queue/usage";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "threshold", threshold }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.HealthQueue Convert(Dictionary<string, object> it) =>
                Models.HealthQueue.From(map: it);

            return _client.Call<Models.HealthQueue>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get usage dump queue
        /// <para>
        /// Get the number of projects containing metrics that are waiting to be
        /// processed in the Appwrite internal queue server.
        /// </para>
        /// </summary>
        public Task<Models.HealthQueue> GetQueueUsageDump(long? threshold = null)
        {
            var apiPath = "/health/queue/usage-dump";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "threshold", threshold }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.HealthQueue Convert(Dictionary<string, object> it) =>
                Models.HealthQueue.From(map: it);

            return _client.Call<Models.HealthQueue>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get webhooks queue
        /// <para>
        /// Get the number of webhooks that are waiting to be processed in the Appwrite
        /// internal queue server.
        /// </para>
        /// </summary>
        public Task<Models.HealthQueue> GetQueueWebhooks(long? threshold = null)
        {
            var apiPath = "/health/queue/webhooks";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "threshold", threshold }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.HealthQueue Convert(Dictionary<string, object> it) =>
                Models.HealthQueue.From(map: it);

            return _client.Call<Models.HealthQueue>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get storage
        /// <para>
        /// Check the Appwrite storage device is up and connection is successful.
        /// </para>
        /// </summary>
        public Task<Models.HealthStatus> GetStorage()
        {
            var apiPath = "/health/storage";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.HealthStatus Convert(Dictionary<string, object> it) =>
                Models.HealthStatus.From(map: it);

            return _client.Call<Models.HealthStatus>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get local storage
        /// <para>
        /// Check the Appwrite local storage device is up and connection is successful.
        /// </para>
        /// </summary>
        public Task<Models.HealthStatus> GetStorageLocal()
        {
            var apiPath = "/health/storage/local";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.HealthStatus Convert(Dictionary<string, object> it) =>
                Models.HealthStatus.From(map: it);

            return _client.Call<Models.HealthStatus>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get time
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
            var apiPath = "/health/time";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.HealthTime Convert(Dictionary<string, object> it) =>
                Models.HealthTime.From(map: it);

            return _client.Call<Models.HealthTime>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

    }
}
