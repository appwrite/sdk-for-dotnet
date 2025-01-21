
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Account : Service
    {
        public Account(Client client) : base(client)
        {
        }

        /// <summary>
        /// Get account
        /// <para>
        /// Get the currently logged in user.
        /// </para>
        /// </summary>
        public Task<Models.User> Get()
        {
            var apiPath = "/account";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
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

        /// <summary>
        /// Create account
        /// <para>
        /// Use this endpoint to allow a new user to register a new account in your
        /// project. After the user registration completes successfully, you can use
        /// the
        /// [/account/verfication](https://appwrite.io/docs/references/cloud/client-web/account#createVerification)
        /// route to start verifying the user email address. To allow the new user to
        /// login to their new account, you need to create a new [account
        /// session](https://appwrite.io/docs/references/cloud/client-web/account#createEmailSession).
        /// </para>
        /// </summary>
        public Task<Models.User> Create(string userId, string email, string password, string? name = null)
        {
            var apiPath = "/account";

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

        /// <summary>
        /// Update email
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
            var apiPath = "/account/email";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "email", email },
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

        /// <summary>
        /// List identities
        /// <para>
        /// Get the list of identities for the currently logged in user.
        /// </para>
        /// </summary>
        public Task<Models.IdentityList> ListIdentities(List<string>? queries = null)
        {
            var apiPath = "/account/identities";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
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

        /// <summary>
        /// Delete identity
        /// <para>
        /// Delete an identity by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> DeleteIdentity(string identityId)
        {
            var apiPath = "/account/identities/{identityId}"
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

        /// <summary>
        /// Create JWT
        /// <para>
        /// Use this endpoint to create a JSON Web Token. You can use the resulting JWT
        /// to authenticate on behalf of the current user when working with the
        /// Appwrite server-side API and SDKs. The JWT secret is valid for 15 minutes
        /// from its creation and will be invalid if the user will logout in that time
        /// frame.
        /// </para>
        /// </summary>
        public Task<Models.JWT> CreateJWT()
        {
            var apiPath = "/account/jwts";

            var apiParameters = new Dictionary<string, object?>()
            {
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

        /// <summary>
        /// List logs
        /// <para>
        /// Get the list of latest security activity logs for the currently logged in
        /// user. Each log returns user IP address, location and date and time of log.
        /// </para>
        /// </summary>
        public Task<Models.LogList> ListLogs(List<string>? queries = null)
        {
            var apiPath = "/account/logs";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
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

        /// <summary>
        /// Update MFA
        /// <para>
        /// Enable or disable MFA on an account.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdateMFA(bool mfa)
        {
            var apiPath = "/account/mfa";

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

        /// <summary>
        /// Create authenticator
        /// <para>
        /// Add an authenticator app to be used as an MFA factor. Verify the
        /// authenticator using the [verify
        /// authenticator](/docs/references/cloud/client-web/account#updateMfaAuthenticator)
        /// method.
        /// </para>
        /// </summary>
        public Task<Models.MfaType> CreateMfaAuthenticator(Appwrite.Enums.AuthenticatorType type)
        {
            var apiPath = "/account/mfa/authenticators/{type}"
                .Replace("{type}", type.Value);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.MfaType Convert(Dictionary<string, object> it) =>
                Models.MfaType.From(map: it);

            return _client.Call<Models.MfaType>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Verify authenticator
        /// <para>
        /// Verify an authenticator app after adding it using the [add
        /// authenticator](/docs/references/cloud/client-web/account#createMfaAuthenticator)
        /// method.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdateMfaAuthenticator(Appwrite.Enums.AuthenticatorType type, string otp)
        {
            var apiPath = "/account/mfa/authenticators/{type}"
                .Replace("{type}", type.Value);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "otp", otp }
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

        /// <summary>
        /// Delete authenticator
        /// <para>
        /// Delete an authenticator for a user by ID.
        /// </para>
        /// </summary>
        public Task<object> DeleteMfaAuthenticator(Appwrite.Enums.AuthenticatorType type)
        {
            var apiPath = "/account/mfa/authenticators/{type}"
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

        /// <summary>
        /// Create MFA challenge
        /// <para>
        /// Begin the process of MFA verification after sign-in. Finish the flow with
        /// [updateMfaChallenge](/docs/references/cloud/client-web/account#updateMfaChallenge)
        /// method.
        /// </para>
        /// </summary>
        public Task<Models.MfaChallenge> CreateMfaChallenge(Appwrite.Enums.AuthenticationFactor factor)
        {
            var apiPath = "/account/mfa/challenge";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "factor", factor }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.MfaChallenge Convert(Dictionary<string, object> it) =>
                Models.MfaChallenge.From(map: it);

            return _client.Call<Models.MfaChallenge>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create MFA challenge (confirmation)
        /// <para>
        /// Complete the MFA challenge by providing the one-time password. Finish the
        /// process of MFA verification by providing the one-time password. To begin
        /// the flow, use
        /// [createMfaChallenge](/docs/references/cloud/client-web/account#createMfaChallenge)
        /// method.
        /// </para>
        /// </summary>
        public Task<object> UpdateMfaChallenge(string challengeId, string otp)
        {
            var apiPath = "/account/mfa/challenge";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "challengeId", challengeId },
                { "otp", otp }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            return _client.Call<object>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <summary>
        /// List factors
        /// <para>
        /// List the factors available on the account to be used as a MFA challange.
        /// </para>
        /// </summary>
        public Task<Models.MfaFactors> ListMfaFactors()
        {
            var apiPath = "/account/mfa/factors";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
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

        /// <summary>
        /// Get MFA recovery codes
        /// <para>
        /// Get recovery codes that can be used as backup for MFA flow. Before getting
        /// codes, they must be generated using
        /// [createMfaRecoveryCodes](/docs/references/cloud/client-web/account#createMfaRecoveryCodes)
        /// method. An OTP challenge is required to read recovery codes.
        /// </para>
        /// </summary>
        public Task<Models.MfaRecoveryCodes> GetMfaRecoveryCodes()
        {
            var apiPath = "/account/mfa/recovery-codes";

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
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create MFA recovery codes
        /// <para>
        /// Generate recovery codes as backup for MFA flow. It's recommended to
        /// generate and show then immediately after user successfully adds their
        /// authehticator. Recovery codes can be used as a MFA verification type in
        /// [createMfaChallenge](/docs/references/cloud/client-web/account#createMfaChallenge)
        /// method.
        /// </para>
        /// </summary>
        public Task<Models.MfaRecoveryCodes> CreateMfaRecoveryCodes()
        {
            var apiPath = "/account/mfa/recovery-codes";

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
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Regenerate MFA recovery codes
        /// <para>
        /// Regenerate recovery codes that can be used as backup for MFA flow. Before
        /// regenerating codes, they must be first generated using
        /// [createMfaRecoveryCodes](/docs/references/cloud/client-web/account#createMfaRecoveryCodes)
        /// method. An OTP challenge is required to regenreate recovery codes.
        /// </para>
        /// </summary>
        public Task<Models.MfaRecoveryCodes> UpdateMfaRecoveryCodes()
        {
            var apiPath = "/account/mfa/recovery-codes";

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

        /// <summary>
        /// Update name
        /// <para>
        /// Update currently logged in user account name.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdateName(string name)
        {
            var apiPath = "/account/name";

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

        /// <summary>
        /// Update password
        /// <para>
        /// Update currently logged in user password. For validation, user is required
        /// to pass in the new password, and the old password. For users created with
        /// OAuth, Team Invites and Magic URL, oldPassword is optional.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdatePassword(string password, string? oldPassword = null)
        {
            var apiPath = "/account/password";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "password", password },
                { "oldPassword", oldPassword }
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

        /// <summary>
        /// Update phone
        /// <para>
        /// Update the currently logged in user's phone number. After updating the
        /// phone number, the phone verification status will be reset. A confirmation
        /// SMS is not sent automatically, however you can use the [POST
        /// /account/verification/phone](https://appwrite.io/docs/references/cloud/client-web/account#createPhoneVerification)
        /// endpoint to send a confirmation SMS.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdatePhone(string phone, string password)
        {
            var apiPath = "/account/phone";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "phone", phone },
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

        /// <summary>
        /// Get account preferences
        /// <para>
        /// Get the preferences as a key-value object for the currently logged in user.
        /// </para>
        /// </summary>
        public Task<Models.Preferences> GetPrefs()
        {
            var apiPath = "/account/prefs";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
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

        /// <summary>
        /// Update preferences
        /// <para>
        /// Update currently logged in user account preferences. The object you pass is
        /// stored as is, and replaces any previous value. The maximum allowed prefs
        /// size is 64kB and throws error if exceeded.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdatePrefs(object prefs)
        {
            var apiPath = "/account/prefs";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "prefs", prefs }
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

        /// <summary>
        /// Create password recovery
        /// <para>
        /// Sends the user an email with a temporary secret key for password reset.
        /// When the user clicks the confirmation link he is redirected back to your
        /// app password reset URL with the secret key and email address values
        /// attached to the URL query string. Use the query string params to submit a
        /// request to the [PUT
        /// /account/recovery](https://appwrite.io/docs/references/cloud/client-web/account#updateRecovery)
        /// endpoint to complete the process. The verification link sent to the user's
        /// email address is valid for 1 hour.
        /// </para>
        /// </summary>
        public Task<Models.Token> CreateRecovery(string email, string url)
        {
            var apiPath = "/account/recovery";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "email", email },
                { "url", url }
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

        /// <summary>
        /// Create password recovery (confirmation)
        /// <para>
        /// Use this endpoint to complete the user account password reset. Both the
        /// **userId** and **secret** arguments will be passed as query parameters to
        /// the redirect URL you have provided when sending your request to the [POST
        /// /account/recovery](https://appwrite.io/docs/references/cloud/client-web/account#createRecovery)
        /// endpoint.
        /// 
        /// Please note that in order to avoid a [Redirect
        /// Attack](https://github.com/OWASP/CheatSheetSeries/blob/master/cheatsheets/Unvalidated_Redirects_and_Forwards_Cheat_Sheet.md)
        /// the only valid redirect URLs are the ones from domains you have set when
        /// adding your platforms in the console interface.
        /// </para>
        /// </summary>
        public Task<Models.Token> UpdateRecovery(string userId, string secret, string password)
        {
            var apiPath = "/account/recovery";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "secret", secret },
                { "password", password }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Token Convert(Dictionary<string, object> it) =>
                Models.Token.From(map: it);

            return _client.Call<Models.Token>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// List sessions
        /// <para>
        /// Get the list of active sessions across different devices for the currently
        /// logged in user.
        /// </para>
        /// </summary>
        public Task<Models.SessionList> ListSessions()
        {
            var apiPath = "/account/sessions";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
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

        /// <summary>
        /// Delete sessions
        /// <para>
        /// Delete all sessions from the user account and remove any sessions cookies
        /// from the end client.
        /// </para>
        /// </summary>
        public Task<object> DeleteSessions()
        {
            var apiPath = "/account/sessions";

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

        /// <summary>
        /// Create anonymous session
        /// <para>
        /// Use this endpoint to allow a new user to register an anonymous account in
        /// your project. This route will also create a new session for the user. To
        /// allow the new user to convert an anonymous account to a normal account, you
        /// need to update its [email and
        /// password](https://appwrite.io/docs/references/cloud/client-web/account#updateEmail)
        /// or create an [OAuth2
        /// session](https://appwrite.io/docs/references/cloud/client-web/account#CreateOAuth2Session).
        /// </para>
        /// </summary>
        public Task<Models.Session> CreateAnonymousSession()
        {
            var apiPath = "/account/sessions/anonymous";

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

        /// <summary>
        /// Create email password session
        /// <para>
        /// Allow the user to login into their account by providing a valid email and
        /// password combination. This route will create a new session for the user.
        /// 
        /// A user is limited to 10 active sessions at a time by default. [Learn more
        /// about session
        /// limits](https://appwrite.io/docs/authentication-security#limits).
        /// </para>
        /// </summary>
        public Task<Models.Session> CreateEmailPasswordSession(string email, string password)
        {
            var apiPath = "/account/sessions/email";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "email", email },
                { "password", password }
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

        /// <summary>
        /// Update magic URL session
        /// <para>
        /// Use this endpoint to create a session from token. Provide the **userId**
        /// and **secret** parameters from the successful response of authentication
        /// flows initiated by token creation. For example, magic URL and phone login.
        /// </para>
        /// </summary>
        public Task<Models.Session> UpdateMagicURLSession(string userId, string secret)
        {
            var apiPath = "/account/sessions/magic-url";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "secret", secret }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Session Convert(Dictionary<string, object> it) =>
                Models.Session.From(map: it);

            return _client.Call<Models.Session>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update phone session
        /// <para>
        /// Use this endpoint to create a session from token. Provide the **userId**
        /// and **secret** parameters from the successful response of authentication
        /// flows initiated by token creation. For example, magic URL and phone login.
        /// </para>
        /// </summary>
        public Task<Models.Session> UpdatePhoneSession(string userId, string secret)
        {
            var apiPath = "/account/sessions/phone";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "secret", secret }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Session Convert(Dictionary<string, object> it) =>
                Models.Session.From(map: it);

            return _client.Call<Models.Session>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create session
        /// <para>
        /// Use this endpoint to create a session from token. Provide the **userId**
        /// and **secret** parameters from the successful response of authentication
        /// flows initiated by token creation. For example, magic URL and phone login.
        /// </para>
        /// </summary>
        public Task<Models.Session> CreateSession(string userId, string secret)
        {
            var apiPath = "/account/sessions/token";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "secret", secret }
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

        /// <summary>
        /// Get session
        /// <para>
        /// Use this endpoint to get a logged in user's session using a Session ID.
        /// Inputting 'current' will return the current session being used.
        /// </para>
        /// </summary>
        public Task<Models.Session> GetSession(string sessionId)
        {
            var apiPath = "/account/sessions/{sessionId}"
                .Replace("{sessionId}", sessionId);

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
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update session
        /// <para>
        /// Use this endpoint to extend a session's length. Extending a session is
        /// useful when session expiry is short. If the session was created using an
        /// OAuth provider, this endpoint refreshes the access token from the provider.
        /// </para>
        /// </summary>
        public Task<Models.Session> UpdateSession(string sessionId)
        {
            var apiPath = "/account/sessions/{sessionId}"
                .Replace("{sessionId}", sessionId);

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
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Delete session
        /// <para>
        /// Logout the user. Use 'current' as the session ID to logout on this device,
        /// use a session ID to logout on another device. If you're looking to logout
        /// the user on all devices, use [Delete
        /// Sessions](https://appwrite.io/docs/references/cloud/client-web/account#deleteSessions)
        /// instead.
        /// </para>
        /// </summary>
        public Task<object> DeleteSession(string sessionId)
        {
            var apiPath = "/account/sessions/{sessionId}"
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

        /// <summary>
        /// Update status
        /// <para>
        /// Block the currently logged in user account. Behind the scene, the user
        /// record is not deleted but permanently blocked from any access. To
        /// completely delete a user, use the Users API instead.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdateStatus()
        {
            var apiPath = "/account/status";

            var apiParameters = new Dictionary<string, object?>()
            {
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

        /// <summary>
        /// Create email token (OTP)
        /// <para>
        /// Sends the user an email with a secret key for creating a session. If the
        /// provided user ID has not be registered, a new user will be created. Use the
        /// returned user ID and secret and submit a request to the [POST
        /// /v1/account/sessions/token](https://appwrite.io/docs/references/cloud/client-web/account#createSession)
        /// endpoint to complete the login process. The secret sent to the user's email
        /// is valid for 15 minutes.
        /// 
        /// A user is limited to 10 active sessions at a time by default. [Learn more
        /// about session
        /// limits](https://appwrite.io/docs/authentication-security#limits).
        /// </para>
        /// </summary>
        public Task<Models.Token> CreateEmailToken(string userId, string email, bool? phrase = null)
        {
            var apiPath = "/account/tokens/email";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "email", email },
                { "phrase", phrase }
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

        /// <summary>
        /// Create magic URL token
        /// <para>
        /// Sends the user an email with a secret key for creating a session. If the
        /// provided user ID has not been registered, a new user will be created. When
        /// the user clicks the link in the email, the user is redirected back to the
        /// URL you provided with the secret key and userId values attached to the URL
        /// query string. Use the query string parameters to submit a request to the
        /// [POST
        /// /v1/account/sessions/token](https://appwrite.io/docs/references/cloud/client-web/account#createSession)
        /// endpoint to complete the login process. The link sent to the user's email
        /// address is valid for 1 hour.
        /// 
        /// A user is limited to 10 active sessions at a time by default. [Learn more
        /// about session
        /// limits](https://appwrite.io/docs/authentication-security#limits).
        /// 
        /// </para>
        /// </summary>
        public Task<Models.Token> CreateMagicURLToken(string userId, string email, string? url = null, bool? phrase = null)
        {
            var apiPath = "/account/tokens/magic-url";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "email", email },
                { "url", url },
                { "phrase", phrase }
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

        /// <summary>
        /// Create OAuth2 token
        /// <para>
        /// Allow the user to login to their account using the OAuth2 provider of their
        /// choice. Each OAuth2 provider should be enabled from the Appwrite console
        /// first. Use the success and failure arguments to provide a redirect URL's
        /// back to your app when login is completed. 
        /// 
        /// If authentication succeeds, `userId` and `secret` of a token will be
        /// appended to the success URL as query parameters. These can be used to
        /// create a new session using the [Create
        /// session](https://appwrite.io/docs/references/cloud/client-web/account#createSession)
        /// endpoint.
        /// 
        /// A user is limited to 10 active sessions at a time by default. [Learn more
        /// about session
        /// limits](https://appwrite.io/docs/authentication-security#limits).
        /// </para>
        /// </summary>
        public Task<String> CreateOAuth2Token(Appwrite.Enums.OAuthProvider provider, string? success = null, string? failure = null, List<string>? scopes = null)
        {
            var apiPath = "/account/tokens/oauth2/{provider}"
                .Replace("{provider}", provider.Value);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "success", success },
                { "failure", failure },
                { "scopes", scopes }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            return _client.Redirect(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <summary>
        /// Create phone token
        /// <para>
        /// Sends the user an SMS with a secret key for creating a session. If the
        /// provided user ID has not be registered, a new user will be created. Use the
        /// returned user ID and secret and submit a request to the [POST
        /// /v1/account/sessions/token](https://appwrite.io/docs/references/cloud/client-web/account#createSession)
        /// endpoint to complete the login process. The secret sent to the user's phone
        /// is valid for 15 minutes.
        /// 
        /// A user is limited to 10 active sessions at a time by default. [Learn more
        /// about session
        /// limits](https://appwrite.io/docs/authentication-security#limits).
        /// </para>
        /// </summary>
        public Task<Models.Token> CreatePhoneToken(string userId, string phone)
        {
            var apiPath = "/account/tokens/phone";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "phone", phone }
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

        /// <summary>
        /// Create email verification
        /// <para>
        /// Use this endpoint to send a verification message to your user email address
        /// to confirm they are the valid owners of that address. Both the **userId**
        /// and **secret** arguments will be passed as query parameters to the URL you
        /// have provided to be attached to the verification email. The provided URL
        /// should redirect the user back to your app and allow you to complete the
        /// verification process by verifying both the **userId** and **secret**
        /// parameters. Learn more about how to [complete the verification
        /// process](https://appwrite.io/docs/references/cloud/client-web/account#updateVerification).
        /// The verification link sent to the user's email address is valid for 7 days.
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
            var apiPath = "/account/verification";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "url", url }
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

        /// <summary>
        /// Create email verification (confirmation)
        /// <para>
        /// Use this endpoint to complete the user email verification process. Use both
        /// the **userId** and **secret** parameters that were attached to your app URL
        /// to verify the user email ownership. If confirmed this route will return a
        /// 200 status code.
        /// </para>
        /// </summary>
        public Task<Models.Token> UpdateVerification(string userId, string secret)
        {
            var apiPath = "/account/verification";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "secret", secret }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Token Convert(Dictionary<string, object> it) =>
                Models.Token.From(map: it);

            return _client.Call<Models.Token>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create phone verification
        /// <para>
        /// Use this endpoint to send a verification SMS to the currently logged in
        /// user. This endpoint is meant for use after updating a user's phone number
        /// using the
        /// [accountUpdatePhone](https://appwrite.io/docs/references/cloud/client-web/account#updatePhone)
        /// endpoint. Learn more about how to [complete the verification
        /// process](https://appwrite.io/docs/references/cloud/client-web/account#updatePhoneVerification).
        /// The verification code sent to the user's phone number is valid for 15
        /// minutes.
        /// </para>
        /// </summary>
        public Task<Models.Token> CreatePhoneVerification()
        {
            var apiPath = "/account/verification/phone";

            var apiParameters = new Dictionary<string, object?>()
            {
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

        /// <summary>
        /// Update phone verification (confirmation)
        /// <para>
        /// Use this endpoint to complete the user phone verification process. Use the
        /// **userId** and **secret** that were sent to your user's phone number to
        /// verify the user email ownership. If confirmed this route will return a 200
        /// status code.
        /// </para>
        /// </summary>
        public Task<Models.Token> UpdatePhoneVerification(string userId, string secret)
        {
            var apiPath = "/account/verification/phone";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "secret", secret }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Token Convert(Dictionary<string, object> it) =>
                Models.Token.From(map: it);

            return _client.Call<Models.Token>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

    }
}
