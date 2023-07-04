
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

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
        public async Task<HttpResponseMessage> List(List<string> queries = null, string search = "") 
        {
            string path = "/users";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "queries", queries },
                { "search", search }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }

        /// <summary>
        /// Create User
        /// <para>
        /// Create a new user.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> Create(string userId, string email = "", string phone = "", string password = "", string name = "") 
        {
            string path = "/users";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "userId", userId },
                { "email", email },
                { "phone", phone },
                { "password", password },
                { "name", name }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Create User with Argon2 Password
        /// <para>
        /// Create a new user. Password provided must be hashed with the
        /// [Argon2](https://en.wikipedia.org/wiki/Argon2) algorithm. Use the [POST
        /// /users](/docs/server/users#usersCreate) endpoint to create users with a
        /// plain text password.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> CreateArgon2User(string userId, string email, string password, string name = "") 
        {
            string path = "/users/argon2";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "userId", userId },
                { "email", email },
                { "password", password },
                { "name", name }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Create User with Bcrypt Password
        /// <para>
        /// Create a new user. Password provided must be hashed with the
        /// [Bcrypt](https://en.wikipedia.org/wiki/Bcrypt) algorithm. Use the [POST
        /// /users](/docs/server/users#usersCreate) endpoint to create users with a
        /// plain text password.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> CreateBcryptUser(string userId, string email, string password, string name = "") 
        {
            string path = "/users/bcrypt";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "userId", userId },
                { "email", email },
                { "password", password },
                { "name", name }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Create User with MD5 Password
        /// <para>
        /// Create a new user. Password provided must be hashed with the
        /// [MD5](https://en.wikipedia.org/wiki/MD5) algorithm. Use the [POST
        /// /users](/docs/server/users#usersCreate) endpoint to create users with a
        /// plain text password.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> CreateMD5User(string userId, string email, string password, string name = "") 
        {
            string path = "/users/md5";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "userId", userId },
                { "email", email },
                { "password", password },
                { "name", name }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Create User with PHPass Password
        /// <para>
        /// Create a new user. Password provided must be hashed with the
        /// [PHPass](https://www.openwall.com/phpass/) algorithm. Use the [POST
        /// /users](/docs/server/users#usersCreate) endpoint to create users with a
        /// plain text password.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> CreatePHPassUser(string userId, string email, string password, string name = "") 
        {
            string path = "/users/phpass";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "userId", userId },
                { "email", email },
                { "password", password },
                { "name", name }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Create User with Scrypt Password
        /// <para>
        /// Create a new user. Password provided must be hashed with the
        /// [Scrypt](https://github.com/Tarsnap/scrypt) algorithm. Use the [POST
        /// /users](/docs/server/users#usersCreate) endpoint to create users with a
        /// plain text password.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> CreateScryptUser(string userId, string email, string password, string passwordSalt, int passwordCpu, int passwordMemory, int passwordParallel, int passwordLength, string name = "") 
        {
            string path = "/users/scrypt";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "userId", userId },
                { "email", email },
                { "password", password },
                { "passwordSalt", passwordSalt },
                { "passwordCpu", passwordCpu },
                { "passwordMemory", passwordMemory },
                { "passwordParallel", passwordParallel },
                { "passwordLength", passwordLength },
                { "name", name }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Create User with Scrypt Modified Password
        /// <para>
        /// Create a new user. Password provided must be hashed with the [Scrypt
        /// Modified](https://gist.github.com/Meldiron/eecf84a0225eccb5a378d45bb27462cc)
        /// algorithm. Use the [POST /users](/docs/server/users#usersCreate) endpoint
        /// to create users with a plain text password.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> CreateScryptModifiedUser(string userId, string email, string password, string passwordSalt, string passwordSaltSeparator, string passwordSignerKey, string name = "") 
        {
            string path = "/users/scrypt-modified";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "userId", userId },
                { "email", email },
                { "password", password },
                { "passwordSalt", passwordSalt },
                { "passwordSaltSeparator", passwordSaltSeparator },
                { "passwordSignerKey", passwordSignerKey },
                { "name", name }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Create User with SHA Password
        /// <para>
        /// Create a new user. Password provided must be hashed with the
        /// [SHA](https://en.wikipedia.org/wiki/Secure_Hash_Algorithm) algorithm. Use
        /// the [POST /users](/docs/server/users#usersCreate) endpoint to create users
        /// with a plain text password.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> CreateSHAUser(string userId, string email, string password, string passwordVersion = "", string name = "") 
        {
            string path = "/users/sha";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "userId", userId },
                { "email", email },
                { "password", password },
                { "passwordVersion", passwordVersion },
                { "name", name }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Get User
        /// <para>
        /// Get a user by its unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> Get(string userId) 
        {
            string path = "/users/{userId}".Replace("{userId}", userId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
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
        public async Task<HttpResponseMessage> Delete(string userId) 
        {
            string path = "/users/{userId}".Replace("{userId}", userId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("DELETE", path, headers, parameters);
        }

        /// <summary>
        /// Update Email
        /// <para>
        /// Update the user email by its unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> UpdateEmail(string userId, string email) 
        {
            string path = "/users/{userId}/email".Replace("{userId}", userId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "email", email }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }

        /// <summary>
        /// List User Logs
        /// <para>
        /// Get the user activity logs list by its unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> ListLogs(string userId, List<string> queries = null) 
        {
            string path = "/users/{userId}/logs".Replace("{userId}", userId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "queries", queries }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }

        /// <summary>
        /// List User Memberships
        /// <para>
        /// Get the user membership list by its unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> ListMemberships(string userId) 
        {
            string path = "/users/{userId}/memberships".Replace("{userId}", userId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }

        /// <summary>
        /// Update Name
        /// <para>
        /// Update the user name by its unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> UpdateName(string userId, string name) 
        {
            string path = "/users/{userId}/name".Replace("{userId}", userId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "name", name }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }

        /// <summary>
        /// Update Password
        /// <para>
        /// Update the user password by its unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> UpdatePassword(string userId, string password) 
        {
            string path = "/users/{userId}/password".Replace("{userId}", userId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "password", password }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }

        /// <summary>
        /// Update Phone
        /// <para>
        /// Update the user phone by its unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> UpdatePhone(string userId, string number) 
        {
            string path = "/users/{userId}/phone".Replace("{userId}", userId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "number", number }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }

        /// <summary>
        /// Get User Preferences
        /// <para>
        /// Get the user preferences by its unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> GetPrefs(string userId) 
        {
            string path = "/users/{userId}/prefs".Replace("{userId}", userId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }

        /// <summary>
        /// Update User Preferences
        /// <para>
        /// Update the user preferences by its unique ID. The object you pass is stored
        /// as is, and replaces any previous value. The maximum allowed prefs size is
        /// 64kB and throws error if exceeded.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> UpdatePrefs(string userId, object prefs) 
        {
            string path = "/users/{userId}/prefs".Replace("{userId}", userId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "prefs", prefs }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }

        /// <summary>
        /// List User Sessions
        /// <para>
        /// Get the user sessions list by its unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> ListSessions(string userId) 
        {
            string path = "/users/{userId}/sessions".Replace("{userId}", userId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }

        /// <summary>
        /// Delete User Sessions
        /// <para>
        /// Delete all user's sessions by using the user's unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> DeleteSessions(string userId) 
        {
            string path = "/users/{userId}/sessions".Replace("{userId}", userId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("DELETE", path, headers, parameters);
        }

        /// <summary>
        /// Delete User Session
        /// <para>
        /// Delete a user sessions by its unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> DeleteSession(string userId, string sessionId) 
        {
            string path = "/users/{userId}/sessions/{sessionId}".Replace("{userId}", userId).Replace("{sessionId}", sessionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("DELETE", path, headers, parameters);
        }

        /// <summary>
        /// Update User Status
        /// <para>
        /// Update the user status by its unique ID. Use this endpoint as an
        /// alternative to deleting a user if you want to keep user's ID reserved.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> UpdateStatus(string userId, bool status) 
        {
            string path = "/users/{userId}/status".Replace("{userId}", userId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "status", status }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }

        /// <summary>
        /// Update Email Verification
        /// <para>
        /// Update the user email verification status by its unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> UpdateEmailVerification(string userId, bool emailVerification) 
        {
            string path = "/users/{userId}/verification".Replace("{userId}", userId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "emailVerification", emailVerification }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }

        /// <summary>
        /// Update Phone Verification
        /// <para>
        /// Update the user phone verification status by its unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> UpdatePhoneVerification(string userId, bool phoneVerification) 
        {
            string path = "/users/{userId}/verification/phone".Replace("{userId}", userId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "phoneVerification", phoneVerification }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }
    };
}