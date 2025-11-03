
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Users : Service
    {
        public Users(Client client) : base(client)
        {
        }

        /// <para>
        /// Get a list of all the project's users. You can use the query params to
        /// filter your results.
        /// </para>
        /// </summary>
        public Task<Models.UserList> List(List<string>? queries = null, string? search = null, bool? total = null)
        {
            var apiPath = "/users";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.UserList Convert(Dictionary<string, object> it) =>
                Models.UserList.From(map: it);

            return _client.Call<Models.UserList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new user.
        /// </para>
        /// </summary>
        public Task<Models.User> Create(string userId, string? email = null, string? phone = null, string? password = null, string? name = null)
        {
            var apiPath = "/users";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "email", email },
                { "phone", phone },
                { "password", password },
                { "name", name }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);

            return _client.Call<Models.User>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new user. Password provided must be hashed with the
        /// [Argon2](https://en.wikipedia.org/wiki/Argon2) algorithm. Use the [POST
        /// /users](https://appwrite.io/docs/server/users#usersCreate) endpoint to
        /// create users with a plain text password.
        /// </para>
        /// </summary>
        public Task<Models.User> CreateArgon2User(string userId, string email, string password, string? name = null)
        {
            var apiPath = "/users/argon2";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "email", email },
                { "password", password },
                { "name", name }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);

            return _client.Call<Models.User>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new user. Password provided must be hashed with the
        /// [Bcrypt](https://en.wikipedia.org/wiki/Bcrypt) algorithm. Use the [POST
        /// /users](https://appwrite.io/docs/server/users#usersCreate) endpoint to
        /// create users with a plain text password.
        /// </para>
        /// </summary>
        public Task<Models.User> CreateBcryptUser(string userId, string email, string password, string? name = null)
        {
            var apiPath = "/users/bcrypt";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "email", email },
                { "password", password },
                { "name", name }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);

            return _client.Call<Models.User>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get identities for all users.
        /// </para>
        /// </summary>
        public Task<Models.IdentityList> ListIdentities(List<string>? queries = null, string? search = null, bool? total = null)
        {
            var apiPath = "/users/identities";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.IdentityList Convert(Dictionary<string, object> it) =>
                Models.IdentityList.From(map: it);

            return _client.Call<Models.IdentityList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete an identity by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> DeleteIdentity(string identityId)
        {
            var apiPath = "/users/identities/{identityId}"
                .Replace("{identityId}", identityId);

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
        /// Create a new user. Password provided must be hashed with the
        /// [MD5](https://en.wikipedia.org/wiki/MD5) algorithm. Use the [POST
        /// /users](https://appwrite.io/docs/server/users#usersCreate) endpoint to
        /// create users with a plain text password.
        /// </para>
        /// </summary>
        public Task<Models.User> CreateMD5User(string userId, string email, string password, string? name = null)
        {
            var apiPath = "/users/md5";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "email", email },
                { "password", password },
                { "name", name }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);

            return _client.Call<Models.User>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new user. Password provided must be hashed with the
        /// [PHPass](https://www.openwall.com/phpass/) algorithm. Use the [POST
        /// /users](https://appwrite.io/docs/server/users#usersCreate) endpoint to
        /// create users with a plain text password.
        /// </para>
        /// </summary>
        public Task<Models.User> CreatePHPassUser(string userId, string email, string password, string? name = null)
        {
            var apiPath = "/users/phpass";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "email", email },
                { "password", password },
                { "name", name }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);

            return _client.Call<Models.User>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new user. Password provided must be hashed with the
        /// [Scrypt](https://github.com/Tarsnap/scrypt) algorithm. Use the [POST
        /// /users](https://appwrite.io/docs/server/users#usersCreate) endpoint to
        /// create users with a plain text password.
        /// </para>
        /// </summary>
        public Task<Models.User> CreateScryptUser(string userId, string email, string password, string passwordSalt, long passwordCpu, long passwordMemory, long passwordParallel, long passwordLength, string? name = null)
        {
            var apiPath = "/users/scrypt";

            var apiParameters = new Dictionary<string, object?>()
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

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);

            return _client.Call<Models.User>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new user. Password provided must be hashed with the [Scrypt
        /// Modified](https://gist.github.com/Meldiron/eecf84a0225eccb5a378d45bb27462cc)
        /// algorithm. Use the [POST
        /// /users](https://appwrite.io/docs/server/users#usersCreate) endpoint to
        /// create users with a plain text password.
        /// </para>
        /// </summary>
        public Task<Models.User> CreateScryptModifiedUser(string userId, string email, string password, string passwordSalt, string passwordSaltSeparator, string passwordSignerKey, string? name = null)
        {
            var apiPath = "/users/scrypt-modified";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "email", email },
                { "password", password },
                { "passwordSalt", passwordSalt },
                { "passwordSaltSeparator", passwordSaltSeparator },
                { "passwordSignerKey", passwordSignerKey },
                { "name", name }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);

            return _client.Call<Models.User>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new user. Password provided must be hashed with the
        /// [SHA](https://en.wikipedia.org/wiki/Secure_Hash_Algorithm) algorithm. Use
        /// the [POST /users](https://appwrite.io/docs/server/users#usersCreate)
        /// endpoint to create users with a plain text password.
        /// </para>
        /// </summary>
        public Task<Models.User> CreateSHAUser(string userId, string email, string password, Appwrite.Enums.PasswordHash? passwordVersion = null, string? name = null)
        {
            var apiPath = "/users/sha";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "email", email },
                { "password", password },
                { "passwordVersion", passwordVersion?.Value },
                { "name", name }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);

            return _client.Call<Models.User>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a user by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.User> Get(string userId)
        {
            var apiPath = "/users/{userId}"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);

            return _client.Call<Models.User>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a user by its unique ID, thereby releasing it's ID. Since ID is
        /// released and can be reused, all user-related resources like documents or
        /// storage files should be deleted before user deletion. If you want to keep
        /// ID reserved, use the
        /// [updateStatus](https://appwrite.io/docs/server/users#usersUpdateStatus)
        /// endpoint instead.
        /// </para>
        /// </summary>
        public Task<object> Delete(string userId)
        {
            var apiPath = "/users/{userId}"
                .Replace("{userId}", userId);

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
        /// Update the user email by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdateEmail(string userId, string email)
        {
            var apiPath = "/users/{userId}/email"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "email", email }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);

            return _client.Call<Models.User>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Use this endpoint to create a JSON Web Token for user by its unique ID. You
        /// can use the resulting JWT to authenticate on behalf of the user. The JWT
        /// secret will become invalid if the session it uses gets deleted.
        /// </para>
        /// </summary>
        public Task<Models.JWT> CreateJWT(string userId, string? sessionId = null, long? duration = null)
        {
            var apiPath = "/users/{userId}/jwts"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "sessionId", sessionId },
                { "duration", duration }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.JWT Convert(Dictionary<string, object> it) =>
                Models.JWT.From(map: it);

            return _client.Call<Models.JWT>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the user labels by its unique ID. 
        /// 
        /// Labels can be used to grant access to resources. While teams are a way for
        /// user's to share access to a resource, labels can be defined by the
        /// developer to grant access without an invitation. See the [Permissions
        /// docs](https://appwrite.io/docs/permissions) for more info.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdateLabels(string userId, List<string> labels)
        {
            var apiPath = "/users/{userId}/labels"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "labels", labels }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);

            return _client.Call<Models.User>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get the user activity logs list by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.LogList> ListLogs(string userId, List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/users/{userId}/logs"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.LogList Convert(Dictionary<string, object> it) =>
                Models.LogList.From(map: it);

            return _client.Call<Models.LogList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get the user membership list by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.MembershipList> ListMemberships(string userId, List<string>? queries = null, string? search = null, bool? total = null)
        {
            var apiPath = "/users/{userId}/memberships"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.MembershipList Convert(Dictionary<string, object> it) =>
                Models.MembershipList.From(map: it);

            return _client.Call<Models.MembershipList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Enable or disable MFA on a user account.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `Users.updateMFA` instead.")]
        public Task<Models.User> UpdateMfa(string userId, bool mfa)
        {
            var apiPath = "/users/{userId}/mfa"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "mfa", mfa }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);

            return _client.Call<Models.User>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Enable or disable MFA on a user account.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdateMFA(string userId, bool mfa)
        {
            var apiPath = "/users/{userId}/mfa"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "mfa", mfa }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);

            return _client.Call<Models.User>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete an authenticator app.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `Users.deleteMFAAuthenticator` instead.")]
        public Task<object> DeleteMfaAuthenticator(string userId, Appwrite.Enums.AuthenticatorType type)
        {
            var apiPath = "/users/{userId}/mfa/authenticators/{type}"
                .Replace("{userId}", userId)
                .Replace("{type}", type.Value);

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
        /// Delete an authenticator app.
        /// </para>
        /// </summary>
        public Task<object> DeleteMFAAuthenticator(string userId, Appwrite.Enums.AuthenticatorType type)
        {
            var apiPath = "/users/{userId}/mfa/authenticators/{type}"
                .Replace("{userId}", userId)
                .Replace("{type}", type.Value);

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
        /// List the factors available on the account to be used as a MFA challange.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `Users.listMFAFactors` instead.")]
        public Task<Models.MfaFactors> ListMfaFactors(string userId)
        {
            var apiPath = "/users/{userId}/mfa/factors"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.MfaFactors Convert(Dictionary<string, object> it) =>
                Models.MfaFactors.From(map: it);

            return _client.Call<Models.MfaFactors>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// List the factors available on the account to be used as a MFA challange.
        /// </para>
        /// </summary>
        public Task<Models.MfaFactors> ListMFAFactors(string userId)
        {
            var apiPath = "/users/{userId}/mfa/factors"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.MfaFactors Convert(Dictionary<string, object> it) =>
                Models.MfaFactors.From(map: it);

            return _client.Call<Models.MfaFactors>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get recovery codes that can be used as backup for MFA flow by User ID.
        /// Before getting codes, they must be generated using
        /// [createMfaRecoveryCodes](/docs/references/cloud/client-web/account#createMfaRecoveryCodes)
        /// method.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `Users.getMFARecoveryCodes` instead.")]
        public Task<Models.MfaRecoveryCodes> GetMfaRecoveryCodes(string userId)
        {
            var apiPath = "/users/{userId}/mfa/recovery-codes"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.MfaRecoveryCodes Convert(Dictionary<string, object> it) =>
                Models.MfaRecoveryCodes.From(map: it);

            return _client.Call<Models.MfaRecoveryCodes>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get recovery codes that can be used as backup for MFA flow by User ID.
        /// Before getting codes, they must be generated using
        /// [createMfaRecoveryCodes](/docs/references/cloud/client-web/account#createMfaRecoveryCodes)
        /// method.
        /// </para>
        /// </summary>
        public Task<Models.MfaRecoveryCodes> GetMFARecoveryCodes(string userId)
        {
            var apiPath = "/users/{userId}/mfa/recovery-codes"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.MfaRecoveryCodes Convert(Dictionary<string, object> it) =>
                Models.MfaRecoveryCodes.From(map: it);

            return _client.Call<Models.MfaRecoveryCodes>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Regenerate recovery codes that can be used as backup for MFA flow by User
        /// ID. Before regenerating codes, they must be first generated using
        /// [createMfaRecoveryCodes](/docs/references/cloud/client-web/account#createMfaRecoveryCodes)
        /// method.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `Users.updateMFARecoveryCodes` instead.")]
        public Task<Models.MfaRecoveryCodes> UpdateMfaRecoveryCodes(string userId)
        {
            var apiPath = "/users/{userId}/mfa/recovery-codes"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.MfaRecoveryCodes Convert(Dictionary<string, object> it) =>
                Models.MfaRecoveryCodes.From(map: it);

            return _client.Call<Models.MfaRecoveryCodes>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Regenerate recovery codes that can be used as backup for MFA flow by User
        /// ID. Before regenerating codes, they must be first generated using
        /// [createMfaRecoveryCodes](/docs/references/cloud/client-web/account#createMfaRecoveryCodes)
        /// method.
        /// </para>
        /// </summary>
        public Task<Models.MfaRecoveryCodes> UpdateMFARecoveryCodes(string userId)
        {
            var apiPath = "/users/{userId}/mfa/recovery-codes"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.MfaRecoveryCodes Convert(Dictionary<string, object> it) =>
                Models.MfaRecoveryCodes.From(map: it);

            return _client.Call<Models.MfaRecoveryCodes>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Generate recovery codes used as backup for MFA flow for User ID. Recovery
        /// codes can be used as a MFA verification type in
        /// [createMfaChallenge](/docs/references/cloud/client-web/account#createMfaChallenge)
        /// method by client SDK.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 1.8.0. Please use `Users.createMFARecoveryCodes` instead.")]
        public Task<Models.MfaRecoveryCodes> CreateMfaRecoveryCodes(string userId)
        {
            var apiPath = "/users/{userId}/mfa/recovery-codes"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.MfaRecoveryCodes Convert(Dictionary<string, object> it) =>
                Models.MfaRecoveryCodes.From(map: it);

            return _client.Call<Models.MfaRecoveryCodes>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Generate recovery codes used as backup for MFA flow for User ID. Recovery
        /// codes can be used as a MFA verification type in
        /// [createMfaChallenge](/docs/references/cloud/client-web/account#createMfaChallenge)
        /// method by client SDK.
        /// </para>
        /// </summary>
        public Task<Models.MfaRecoveryCodes> CreateMFARecoveryCodes(string userId)
        {
            var apiPath = "/users/{userId}/mfa/recovery-codes"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.MfaRecoveryCodes Convert(Dictionary<string, object> it) =>
                Models.MfaRecoveryCodes.From(map: it);

            return _client.Call<Models.MfaRecoveryCodes>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the user name by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdateName(string userId, string name)
        {
            var apiPath = "/users/{userId}/name"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);

            return _client.Call<Models.User>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the user password by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdatePassword(string userId, string password)
        {
            var apiPath = "/users/{userId}/password"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "password", password }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);

            return _client.Call<Models.User>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the user phone by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdatePhone(string userId, string number)
        {
            var apiPath = "/users/{userId}/phone"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "number", number }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);

            return _client.Call<Models.User>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get the user preferences by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Preferences> GetPrefs(string userId)
        {
            var apiPath = "/users/{userId}/prefs"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.Preferences Convert(Dictionary<string, object> it) =>
                Models.Preferences.From(map: it);

            return _client.Call<Models.Preferences>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the user preferences by its unique ID. The object you pass is stored
        /// as is, and replaces any previous value. The maximum allowed prefs size is
        /// 64kB and throws error if exceeded.
        /// </para>
        /// </summary>
        public Task<Models.Preferences> UpdatePrefs(string userId, object prefs)
        {
            var apiPath = "/users/{userId}/prefs"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "prefs", prefs }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Preferences Convert(Dictionary<string, object> it) =>
                Models.Preferences.From(map: it);

            return _client.Call<Models.Preferences>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get the user sessions list by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.SessionList> ListSessions(string userId, bool? total = null)
        {
            var apiPath = "/users/{userId}/sessions"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.SessionList Convert(Dictionary<string, object> it) =>
                Models.SessionList.From(map: it);

            return _client.Call<Models.SessionList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Creates a session for a user. Returns an immediately usable session object.
        /// 
        /// If you want to generate a token for a custom authentication flow, use the
        /// [POST
        /// /users/{userId}/tokens](https://appwrite.io/docs/server/users#createToken)
        /// endpoint.
        /// </para>
        /// </summary>
        public Task<Models.Session> CreateSession(string userId)
        {
            var apiPath = "/users/{userId}/sessions"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Session Convert(Dictionary<string, object> it) =>
                Models.Session.From(map: it);

            return _client.Call<Models.Session>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete all user's sessions by using the user's unique ID.
        /// </para>
        /// </summary>
        public Task<object> DeleteSessions(string userId)
        {
            var apiPath = "/users/{userId}/sessions"
                .Replace("{userId}", userId);

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
        /// Delete a user sessions by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> DeleteSession(string userId, string sessionId)
        {
            var apiPath = "/users/{userId}/sessions/{sessionId}"
                .Replace("{userId}", userId)
                .Replace("{sessionId}", sessionId);

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
        /// Update the user status by its unique ID. Use this endpoint as an
        /// alternative to deleting a user if you want to keep user's ID reserved.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdateStatus(string userId, bool status)
        {
            var apiPath = "/users/{userId}/status"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "status", status }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);

            return _client.Call<Models.User>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// List the messaging targets that are associated with a user.
        /// </para>
        /// </summary>
        public Task<Models.TargetList> ListTargets(string userId, List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/users/{userId}/targets"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.TargetList Convert(Dictionary<string, object> it) =>
                Models.TargetList.From(map: it);

            return _client.Call<Models.TargetList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a messaging target.
        /// </para>
        /// </summary>
        public Task<Models.Target> CreateTarget(string userId, string targetId, Appwrite.Enums.MessagingProviderType providerType, string identifier, string? providerId = null, string? name = null)
        {
            var apiPath = "/users/{userId}/targets"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "targetId", targetId },
                { "providerType", providerType?.Value },
                { "identifier", identifier },
                { "providerId", providerId },
                { "name", name }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Target Convert(Dictionary<string, object> it) =>
                Models.Target.From(map: it);

            return _client.Call<Models.Target>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a user's push notification target by ID.
        /// </para>
        /// </summary>
        public Task<Models.Target> GetTarget(string userId, string targetId)
        {
            var apiPath = "/users/{userId}/targets/{targetId}"
                .Replace("{userId}", userId)
                .Replace("{targetId}", targetId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
            };


            static Models.Target Convert(Dictionary<string, object> it) =>
                Models.Target.From(map: it);

            return _client.Call<Models.Target>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a messaging target.
        /// </para>
        /// </summary>
        public Task<Models.Target> UpdateTarget(string userId, string targetId, string? identifier = null, string? providerId = null, string? name = null)
        {
            var apiPath = "/users/{userId}/targets/{targetId}"
                .Replace("{userId}", userId)
                .Replace("{targetId}", targetId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "identifier", identifier },
                { "providerId", providerId },
                { "name", name }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Target Convert(Dictionary<string, object> it) =>
                Models.Target.From(map: it);

            return _client.Call<Models.Target>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a messaging target.
        /// </para>
        /// </summary>
        public Task<object> DeleteTarget(string userId, string targetId)
        {
            var apiPath = "/users/{userId}/targets/{targetId}"
                .Replace("{userId}", userId)
                .Replace("{targetId}", targetId);

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
        /// Returns a token with a secret key for creating a session. Use the user ID
        /// and secret and submit a request to the [PUT
        /// /account/sessions/token](https://appwrite.io/docs/references/cloud/client-web/account#createSession)
        /// endpoint to complete the login process.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.Token> CreateToken(string userId, long? length = null, long? expire = null)
        {
            var apiPath = "/users/{userId}/tokens"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "length", length },
                { "expire", expire }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Token Convert(Dictionary<string, object> it) =>
                Models.Token.From(map: it);

            return _client.Call<Models.Token>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the user email verification status by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdateEmailVerification(string userId, bool emailVerification)
        {
            var apiPath = "/users/{userId}/verification"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "emailVerification", emailVerification }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);

            return _client.Call<Models.User>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update the user phone verification status by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdatePhoneVerification(string userId, bool phoneVerification)
        {
            var apiPath = "/users/{userId}/verification/phone"
                .Replace("{userId}", userId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "phoneVerification", phoneVerification }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);

            return _client.Call<Models.User>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

    }
}
