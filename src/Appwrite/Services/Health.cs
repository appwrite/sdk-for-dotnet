
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Appwrite
{
    public class Health : Service
    {

        public Health(Client client) : base(client) { }


    
        /// Get HTTP
            /*
         * Check the Appwrite HTTP server is up and responsive.
        */
        public async Task<HttpResponseMessage> Get() 
        {
            string path = "/health";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }
    
        /// Get Anti virus
            /*
         * Check the Appwrite Anti Virus server is up and connection is successful.
        */
        public async Task<HttpResponseMessage> GetAntiVirus() 
        {
            string path = "/health/anti-virus";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }
    
        /// Get Cache
            /*
         * Check the Appwrite in-memory cache server is up and connection is
     * successful.
        */
        public async Task<HttpResponseMessage> GetCache() 
        {
            string path = "/health/cache";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }
    
        /// Get DB
            /*
         * Check the Appwrite database server is up and connection is successful.
        */
        public async Task<HttpResponseMessage> GetDB() 
        {
            string path = "/health/db";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }
    
        /// Get Certificate Queue
            /*
         * Get the number of certificates that are waiting to be issued against
     * [Letsencrypt](https://letsencrypt.org/) in the Appwrite internal queue
     * server.
        */
        public async Task<HttpResponseMessage> GetQueueCertificates() 
        {
            string path = "/health/queue/certificates";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }
    
        /// Get Functions Queue
        public async Task<HttpResponseMessage> GetQueueFunctions() 
        {
            string path = "/health/queue/functions";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }
    
        /// Get Logs Queue
            /*
         * Get the number of logs that are waiting to be processed in the Appwrite
     * internal queue server.
        */
        public async Task<HttpResponseMessage> GetQueueLogs() 
        {
            string path = "/health/queue/logs";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }
    
        /// Get Tasks Queue
            /*
         * Get the number of tasks that are waiting to be processed in the Appwrite
     * internal queue server.
        */
        public async Task<HttpResponseMessage> GetQueueTasks() 
        {
            string path = "/health/queue/tasks";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }
    
        /// Get Usage Queue
            /*
         * Get the number of usage stats that are waiting to be processed in the
     * Appwrite internal queue server.
        */
        public async Task<HttpResponseMessage> GetQueueUsage() 
        {
            string path = "/health/queue/usage";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }
    
        /// Get Webhooks Queue
            /*
         * Get the number of webhooks that are waiting to be processed in the Appwrite
     * internal queue server.
        */
        public async Task<HttpResponseMessage> GetQueueWebhooks() 
        {
            string path = "/health/queue/webhooks";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }
    
        /// Get Local Storage
            /*
         * Check the Appwrite local storage device is up and connection is successful.
        */
        public async Task<HttpResponseMessage> GetStorageLocal() 
        {
            string path = "/health/storage/local";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }
    
        /// Get Time
            /*
         * Check the Appwrite server time is synced with Google remote NTP server. We
     * use this technology to smoothly handle leap seconds with no disruptive
     * events. The [Network Time
     * Protocol](https://en.wikipedia.org/wiki/Network_Time_Protocol) (NTP) is
     * used by hundreds of millions of computers and devices to synchronize their
     * clocks over the Internet. If your computer sets its own clock, it likely
     * uses NTP.
        */
        public async Task<HttpResponseMessage> GetTime() 
        {
            string path = "/health/time";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }
        };
}