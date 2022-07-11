
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Appwrite.Models;

namespace Appwrite
{
    public class Users : Service
    {

        public Users(Client client) : base(client) { }

        /// <summary>
        /// List Users
        /// <para>
        /// Get a list of all the project's users. You can use the query params to
        /// filter your results.
        /// </para>
        /// </summary>
        public Task<Models.UserList> List(string? search = null, long? limit = null, long? offset = null, string? cursor = null, string? cursorDirection = null, OrderType orderType = OrderType.ASC)
        {
            var path = "/users";

            var parameters = new Dictionary<string, object?>()
            {
                { "search", search },
                { "limit", limit },
                { "offset", offset },
                { "cursor", cursor },
                { "cursorDirection", cursorDirection },
                { "orderType", orderType.ToString() }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.UserList Convert(Dictionary<string, object> it) =>
                Models.UserList.From(map: it);


            return _client.Call<Models.UserList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Create User
        /// <para>
        /// Create a new user.
        /// </para>
        /// </summary>
        public Task<Models.User> Create(string userId, string email, string password, string? name = null)
        {
            var path = "/users";

            var parameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "email", email },
                { "password", password },
                { "name", name }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Get User
        /// <para>
        /// Get a user by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.User> Get(string userId)
        {
            var path = "/users/{userId}"
                .Replace("{userId}", userId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Delete User
        /// <para>
        /// Delete a user by its unique ID, thereby releasing it's ID. Since ID is
        /// released and can be reused, all user-related resources like documents or
        /// storage files should be deleted before user deletion. If you want to keep
        /// ID reserved, use the [updateStatus](/docs/server/users#usersUpdateStatus)
        /// endpoint instead.
        /// </para>
        /// </summary>
        public Task<object> Delete(string userId)
        {
            var path = "/users/{userId}"
                .Replace("{userId}", userId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };




            return _client.Call<object>(
                method: "DELETE",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);
        }

        /// <summary>
        /// Update Email
        /// <para>
        /// Update the user email by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdateEmail(string userId, string email)
        {
            var path = "/users/{userId}/email"
                .Replace("{userId}", userId);

            var parameters = new Dictionary<string, object?>()
            {
                { "email", email }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "PATCH",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Get User Logs
        /// <para>
        /// Get the user activity logs list by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.LogList> GetLogs(string userId, long? limit = null, long? offset = null)
        {
            var path = "/users/{userId}/logs"
                .Replace("{userId}", userId);

            var parameters = new Dictionary<string, object?>()
            {
                { "limit", limit },
                { "offset", offset }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.LogList Convert(Dictionary<string, object> it) =>
                Models.LogList.From(map: it);


            return _client.Call<Models.LogList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Get User Memberships
        /// <para>
        /// Get the user membership list by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.MembershipList> GetMemberships(string userId)
        {
            var path = "/users/{userId}/memberships"
                .Replace("{userId}", userId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.MembershipList Convert(Dictionary<string, object> it) =>
                Models.MembershipList.From(map: it);


            return _client.Call<Models.MembershipList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Update Name
        /// <para>
        /// Update the user name by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdateName(string userId, string name)
        {
            var path = "/users/{userId}/name"
                .Replace("{userId}", userId);

            var parameters = new Dictionary<string, object?>()
            {
                { "name", name }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "PATCH",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Update Password
        /// <para>
        /// Update the user password by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdatePassword(string userId, string password)
        {
            var path = "/users/{userId}/password"
                .Replace("{userId}", userId);

            var parameters = new Dictionary<string, object?>()
            {
                { "password", password }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "PATCH",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Update Phone
        /// <para>
        /// Update the user phone by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdatePhone(string userId, string number)
        {
            var path = "/users/{userId}/phone"
                .Replace("{userId}", userId);

            var parameters = new Dictionary<string, object?>()
            {
                { "number", number }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "PATCH",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Get User Preferences
        /// <para>
        /// Get the user preferences by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Preferences> GetPrefs(string userId)
        {
            var path = "/users/{userId}/prefs"
                .Replace("{userId}", userId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Preferences Convert(Dictionary<string, object> it) =>
                Models.Preferences.From(map: it);


            return _client.Call<Models.Preferences>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Update User Preferences
        /// <para>
        /// Update the user preferences by its unique ID. The object you pass is stored
        /// as is, and replaces any previous value. The maximum allowed prefs size is
        /// 64kB and throws error if exceeded.
        /// </para>
        /// </summary>
        public Task<Models.Preferences> UpdatePrefs(string userId, object prefs)
        {
            var path = "/users/{userId}/prefs"
                .Replace("{userId}", userId);

            var parameters = new Dictionary<string, object?>()
            {
                { "prefs", prefs }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Preferences Convert(Dictionary<string, object> it) =>
                Models.Preferences.From(map: it);


            return _client.Call<Models.Preferences>(
                method: "PATCH",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Get User Sessions
        /// <para>
        /// Get the user sessions list by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.SessionList> GetSessions(string userId)
        {
            var path = "/users/{userId}/sessions"
                .Replace("{userId}", userId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.SessionList Convert(Dictionary<string, object> it) =>
                Models.SessionList.From(map: it);


            return _client.Call<Models.SessionList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Delete User Sessions
        /// <para>
        /// Delete all user's sessions by using the user's unique ID.
        /// </para>
        /// </summary>
        public Task<object> DeleteSessions(string userId)
        {
            var path = "/users/{userId}/sessions"
                .Replace("{userId}", userId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };




            return _client.Call<object>(
                method: "DELETE",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);
        }

        /// <summary>
        /// Delete User Session
        /// <para>
        /// Delete a user sessions by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> DeleteSession(string userId, string sessionId)
        {
            var path = "/users/{userId}/sessions/{sessionId}"
                .Replace("{userId}", userId)
                .Replace("{sessionId}", sessionId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };




            return _client.Call<object>(
                method: "DELETE",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);
        }

        /// <summary>
        /// Update User Status
        /// <para>
        /// Update the user status by its unique ID. Use this endpoint as an
        /// alternative to deleting a user if you want to keep user's ID reserved.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdateStatus(string userId, bool status)
        {
            var path = "/users/{userId}/status"
                .Replace("{userId}", userId);

            var parameters = new Dictionary<string, object?>()
            {
                { "status", status }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "PATCH",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Update Email Verification
        /// <para>
        /// Update the user email verification status by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdateEmailVerification(string userId, bool emailVerification)
        {
            var path = "/users/{userId}/verification"
                .Replace("{userId}", userId);

            var parameters = new Dictionary<string, object?>()
            {
                { "emailVerification", emailVerification }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "PATCH",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }

        /// <summary>
        /// Update Phone Verification
        /// <para>
        /// Update the user phone verification status by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdatePhoneVerification(string userId, bool phoneVerification)
        {
            var path = "/users/{userId}/verification/phone"
                .Replace("{userId}", userId);

            var parameters = new Dictionary<string, object?>()
            {
                { "phoneVerification", phoneVerification }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "PATCH",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);
        }
    }
}