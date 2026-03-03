
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

        /// <para>
        /// Check the Appwrite in-memory cache servers are up and connection is
        /// successful.
        /// </para>
        /// </summary>
        public Task<Models.HealthStatusList> GetCache()
        {
            var apiPath = "/health/cache";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.HealthStatusList Convert(Dictionary<string, object> it) =>
                Models.HealthStatusList.From(map: it);

            return _client.Call<Models.HealthStatusList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

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

        /// <para>
        /// Check the Appwrite database servers are up and connection is successful.
        /// </para>
        /// </summary>
        public Task<Models.HealthStatusList> GetDB()
        {
            var apiPath = "/health/db";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.HealthStatusList Convert(Dictionary<string, object> it) =>
                Models.HealthStatusList.From(map: it);

            return _client.Call<Models.HealthStatusList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Check the Appwrite pub-sub servers are up and connection is successful.
        /// </para>
        /// </summary>
        public Task<Models.HealthStatusList> GetPubSub()
        {
            var apiPath = "/health/pubsub";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.HealthStatusList Convert(Dictionary<string, object> it) =>
                Models.HealthStatusList.From(map: it);

            return _client.Call<Models.HealthStatusList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get the number of audit logs that are waiting to be processed in the
        /// Appwrite internal queue server.
        /// </para>
        /// </summary>
        public Task<Models.HealthQueue> GetQueueAudits(long? threshold = null)
        {
            var apiPath = "/health/queue/audits";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "threshold", threshold }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
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

        /// <para>
        /// Get the number of metrics that are waiting to be processed in the Appwrite
        /// stats resources queue.
        /// </para>
        /// </summary>
        public Task<Models.HealthQueue> GetQueueStatsResources(long? threshold = null)
        {
            var apiPath = "/health/queue/stats-resources";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "threshold", threshold }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
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

        /// <para>
        /// Get the number of metrics that are waiting to be processed in the Appwrite
        /// internal queue server.
        /// </para>
        /// </summary>
        public Task<Models.HealthQueue> GetQueueUsage(long? threshold = null)
        {
            var apiPath = "/health/queue/stats-usage";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "threshold", threshold }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
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
