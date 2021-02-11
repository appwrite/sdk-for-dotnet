
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Appwrite
{
    public class Users : Service
    {

        public Users(Client client) : base(client) { }


    
        /// List Users
            /*
         * Get a list of all the project's users. You can use the query params to
     * filter your results.
        */
        public async Task<HttpResponseMessage> List(string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC) 
        {
            string path = "/users";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                    
                { "search", search },
                    
                { "limit", limit },
                    
                { "offset", offset },
                    
                { "orderType", orderType.ToString() }
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }
    
        /// Create User
            /*
         * Create a new user.
        */
        public async Task<HttpResponseMessage> Create(string email, string password, string name = "") 
        {
            string path = "/users";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                    
                { "email", email },
                    
                { "password", password },
                    
                { "name", name }
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }
    
        /// Get User
            /*
         * Get a user by its unique ID.
        */
        public async Task<HttpResponseMessage> Get(string userId) 
        {
            string path = "/users/{userId}".Replace("{userId}", userId);

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
    
        /// Delete User
            /*
         * Delete a user by its unique ID.
        */
        public async Task<HttpResponseMessage> DeleteUser(string userId) 
        {
            string path = "/users/{userId}".Replace("{userId}", userId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("DELETE", path, headers, parameters);
        }
    
        /// Get User Logs
            /*
         * Get a user activity logs list by its unique ID.
        */
        public async Task<HttpResponseMessage> GetLogs(string userId) 
        {
            string path = "/users/{userId}/logs".Replace("{userId}", userId);

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
    
        /// Get User Preferences
            /*
         * Get the user preferences by its unique ID.
        */
        public async Task<HttpResponseMessage> GetPrefs(string userId) 
        {
            string path = "/users/{userId}/prefs".Replace("{userId}", userId);

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
    
        /// Update User Preferences
            /*
         * Update the user preferences by its unique ID. You can pass only the
     * specific settings you wish to update.
        */
        public async Task<HttpResponseMessage> UpdatePrefs(string userId, object prefs) 
        {
            string path = "/users/{userId}/prefs".Replace("{userId}", userId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                    
                { "prefs", prefs }
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }
    
        /// Get User Sessions
            /*
         * Get the user sessions list by its unique ID.
        */
        public async Task<HttpResponseMessage> GetSessions(string userId) 
        {
            string path = "/users/{userId}/sessions".Replace("{userId}", userId);

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
    
        /// Delete User Sessions
            /*
         * Delete all user's sessions by using the user's unique ID.
        */
        public async Task<HttpResponseMessage> DeleteSessions(string userId) 
        {
            string path = "/users/{userId}/sessions".Replace("{userId}", userId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("DELETE", path, headers, parameters);
        }
    
        /// Delete User Session
            /*
         * Delete a user sessions by its unique ID.
        */
        public async Task<HttpResponseMessage> DeleteSession(string userId, string sessionId) 
        {
            string path = "/users/{userId}/sessions/{sessionId}".Replace("{userId}", userId).Replace("{sessionId}", sessionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("DELETE", path, headers, parameters);
        }
    
        /// Update User Status
            /*
         * Update the user status by its unique ID.
        */
        public async Task<HttpResponseMessage> UpdateStatus(string userId, string status) 
        {
            string path = "/users/{userId}/status".Replace("{userId}", userId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                    
                { "status", status }
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }
        };
}