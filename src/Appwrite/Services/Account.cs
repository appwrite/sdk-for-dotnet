
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;

namespace Appwrite.Services
{
    public class Account : Service
    {
        public Account(Client client) : base(client)
        {
        }

        /// <summary>
        /// Get Account
        /// <para>
        /// Get currently logged in user data as JSON object.
        /// </para>
        /// </summary>
        public Task<Models.User> Get()
        {
            var path = "/account";

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
        /// Update Email
        /// <para>
        /// Update currently logged in user account email address. After changing user
        /// address, the user confirmation status will get reset. A new confirmation
        /// email is not sent automatically however you can use the send confirmation
        /// email endpoint again to send the confirmation email. For security measures,
        /// user password is required to complete this request.
        /// This endpoint can also be used to convert an anonymous account to a normal
        /// one, by passing an email address and a new password.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.User> UpdateEmail(string email, string password)
        {
            var path = "/account/email";

            var parameters = new Dictionary<string, object?>()
            {
                { "email", email },
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
        /// List Logs
        /// <para>
        /// Get currently logged in user list of latest security activity logs. Each
        /// log returns user IP address, location and date and time of log.
        /// </para>
        /// </summary>
        public Task<Models.LogList> ListLogs(List<string>? queries = null)
        {
            var path = "/account/logs";

            var parameters = new Dictionary<string, object?>()
            {
                { "queries", queries }
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
        /// Update Name
        /// <para>
        /// Update currently logged in user account name.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdateName(string name)
        {
            var path = "/account/name";

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
        /// Update currently logged in user password. For validation, user is required
        /// to pass in the new password, and the old password. For users created with
        /// OAuth, Team Invites and Magic URL, oldPassword is optional.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdatePassword(string password, string? oldPassword = null)
        {
            var path = "/account/password";

            var parameters = new Dictionary<string, object?>()
            {
                { "password", password },
                { "oldPassword", oldPassword }
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
        /// Update the currently logged in user's phone number. After updating the
        /// phone number, the phone verification status will be reset. A confirmation
        /// SMS is not sent automatically, however you can use the [POST
        /// /account/verification/phone](/docs/client/account#accountCreatePhoneVerification)
        /// endpoint to send a confirmation SMS.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdatePhone(string phone, string password)
        {
            var path = "/account/phone";

            var parameters = new Dictionary<string, object?>()
            {
                { "phone", phone },
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
        /// Get Account Preferences
        /// <para>
        /// Get currently logged in user preferences as a key-value object.
        /// </para>
        /// </summary>
        public Task<Models.Preferences> GetPrefs()
        {
            var path = "/account/prefs";

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
        /// Update Preferences
        /// <para>
        /// Update currently logged in user account preferences. The object you pass is
        /// stored as is, and replaces any previous value. The maximum allowed prefs
        /// size is 64kB and throws error if exceeded.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdatePrefs(object prefs)
        {
            var path = "/account/prefs";

            var parameters = new Dictionary<string, object?>()
            {
                { "prefs", prefs }
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
        /// Create Password Recovery
        /// <para>
        /// Sends the user an email with a temporary secret key for password reset.
        /// When the user clicks the confirmation link he is redirected back to your
        /// app password reset URL with the secret key and email address values
        /// attached to the URL query string. Use the query string params to submit a
        /// request to the [PUT
        /// /account/recovery](/docs/client/account#accountUpdateRecovery) endpoint to
        /// complete the process. The verification link sent to the user's email
        /// address is valid for 1 hour.
        /// </para>
        /// </summary>
        public Task<Models.Token> CreateRecovery(string email, string url)
        {
            var path = "/account/recovery";

            var parameters = new Dictionary<string, object?>()
            {
                { "email", email },
                { "url", url }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Token Convert(Dictionary<string, object> it) =>
                Models.Token.From(map: it);


            return _client.Call<Models.Token>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create Password Recovery (confirmation)
        /// <para>
        /// Use this endpoint to complete the user account password reset. Both the
        /// **userId** and **secret** arguments will be passed as query parameters to
        /// the redirect URL you have provided when sending your request to the [POST
        /// /account/recovery](/docs/client/account#accountCreateRecovery) endpoint.
        /// 
        /// Please note that in order to avoid a [Redirect
        /// Attack](https://github.com/OWASP/CheatSheetSeries/blob/master/cheatsheets/Unvalidated_Redirects_and_Forwards_Cheat_Sheet.md)
        /// the only valid redirect URLs are the ones from domains you have set when
        /// adding your platforms in the console interface.
        /// </para>
        /// </summary>
        public Task<Models.Token> UpdateRecovery(string userId, string secret, string password, string passwordAgain)
        {
            var path = "/account/recovery";

            var parameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "secret", secret },
                { "password", password },
                { "passwordAgain", passwordAgain }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Token Convert(Dictionary<string, object> it) =>
                Models.Token.From(map: it);


            return _client.Call<Models.Token>(
                method: "PUT",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// List Sessions
        /// <para>
        /// Get currently logged in user list of active sessions across different
        /// devices.
        /// </para>
        /// </summary>
        public Task<Models.SessionList> ListSessions()
        {
            var path = "/account/sessions";

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
        /// Delete Sessions
        /// <para>
        /// Delete all sessions from the user account and remove any sessions cookies
        /// from the end client.
        /// </para>
        /// </summary>
        public Task<object> DeleteSessions()
        {
            var path = "/account/sessions";

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
        /// Get Session
        /// <para>
        /// Use this endpoint to get a logged in user's session using a Session ID.
        /// Inputting 'current' will return the current session being used.
        /// </para>
        /// </summary>
        public Task<Models.Session> GetSession(string sessionId)
        {
            var path = "/account/sessions/{sessionId}"
                .Replace("{sessionId}", sessionId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Session Convert(Dictionary<string, object> it) =>
                Models.Session.From(map: it);


            return _client.Call<Models.Session>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update OAuth Session (Refresh Tokens)
        /// <para>
        /// Access tokens have limited lifespan and expire to mitigate security risks.
        /// If session was created using an OAuth provider, this route can be used to
        /// "refresh" the access token.
        /// </para>
        /// </summary>
        public Task<Models.Session> UpdateSession(string sessionId)
        {
            var path = "/account/sessions/{sessionId}"
                .Replace("{sessionId}", sessionId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Session Convert(Dictionary<string, object> it) =>
                Models.Session.From(map: it);


            return _client.Call<Models.Session>(
                method: "PATCH",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Delete Session
        /// <para>
        /// Use this endpoint to log out the currently logged in user from all their
        /// account sessions across all of their different devices. When using the
        /// Session ID argument, only the unique session ID provided is deleted.
        /// 
        /// </para>
        /// </summary>
        public Task<object> DeleteSession(string sessionId)
        {
            var path = "/account/sessions/{sessionId}"
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
        /// Update Status
        /// <para>
        /// Block the currently logged in user account. Behind the scene, the user
        /// record is not deleted but permanently blocked from any access. To
        /// completely delete a user, use the Users API instead.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdateStatus()
        {
            var path = "/account/status";

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
                method: "PATCH",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create Email Verification
        /// <para>
        /// Use this endpoint to send a verification message to your user email address
        /// to confirm they are the valid owners of that address. Both the **userId**
        /// and **secret** arguments will be passed as query parameters to the URL you
        /// have provided to be attached to the verification email. The provided URL
        /// should redirect the user back to your app and allow you to complete the
        /// verification process by verifying both the **userId** and **secret**
        /// parameters. Learn more about how to [complete the verification
        /// process](/docs/client/account#accountUpdateEmailVerification). The
        /// verification link sent to the user's email address is valid for 7 days.
        /// 
        /// Please note that in order to avoid a [Redirect
        /// Attack](https://github.com/OWASP/CheatSheetSeries/blob/master/cheatsheets/Unvalidated_Redirects_and_Forwards_Cheat_Sheet.md),
        /// the only valid redirect URLs are the ones from domains you have set when
        /// adding your platforms in the console interface.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.Token> CreateVerification(string url)
        {
            var path = "/account/verification";

            var parameters = new Dictionary<string, object?>()
            {
                { "url", url }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Token Convert(Dictionary<string, object> it) =>
                Models.Token.From(map: it);


            return _client.Call<Models.Token>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create Email Verification (confirmation)
        /// <para>
        /// Use this endpoint to complete the user email verification process. Use both
        /// the **userId** and **secret** parameters that were attached to your app URL
        /// to verify the user email ownership. If confirmed this route will return a
        /// 200 status code.
        /// </para>
        /// </summary>
        public Task<Models.Token> UpdateVerification(string userId, string secret)
        {
            var path = "/account/verification";

            var parameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "secret", secret }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Token Convert(Dictionary<string, object> it) =>
                Models.Token.From(map: it);


            return _client.Call<Models.Token>(
                method: "PUT",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create Phone Verification
        /// <para>
        /// Use this endpoint to send a verification SMS to the currently logged in
        /// user. This endpoint is meant for use after updating a user's phone number
        /// using the [accountUpdatePhone](/docs/client/account#accountUpdatePhone)
        /// endpoint. Learn more about how to [complete the verification
        /// process](/docs/client/account#accountUpdatePhoneVerification). The
        /// verification code sent to the user's phone number is valid for 15 minutes.
        /// </para>
        /// </summary>
        public Task<Models.Token> CreatePhoneVerification()
        {
            var path = "/account/verification/phone";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Token Convert(Dictionary<string, object> it) =>
                Models.Token.From(map: it);


            return _client.Call<Models.Token>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create Phone Verification (confirmation)
        /// <para>
        /// Use this endpoint to complete the user phone verification process. Use the
        /// **userId** and **secret** that were sent to your user's phone number to
        /// verify the user email ownership. If confirmed this route will return a 200
        /// status code.
        /// </para>
        /// </summary>
        public Task<Models.Token> UpdatePhoneVerification(string userId, string secret)
        {
            var path = "/account/verification/phone";

            var parameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "secret", secret }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Token Convert(Dictionary<string, object> it) =>
                Models.Token.From(map: it);


            return _client.Call<Models.Token>(
                method: "PUT",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

    }
}
