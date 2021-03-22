
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Appwrite
{
    public class Account : Service
    {

        public Account(Client client) : base(client) { }


    
     /// Get Account
     ///
     /// Get currently logged in user data as JSON object.
     ///
        public async Task<HttpResponseMessage> Get() 
        {
            string path = "/account";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }
    
     /// Create Account
     ///
     /// Use this endpoint to allow a new user to register a new account in your
     /// project. After the user registration completes successfully, you can use
     /// the [/account/verfication](/docs/client/account#accountCreateVerification)
     /// route to start verifying the user email address. To allow the new user to
     /// login to their new account, you need to create a new [account
     /// session](/docs/client/account#accountCreateSession).
     ///
        public async Task<HttpResponseMessage> Create(string email, string password, string name = "") 
        {
            string path = "/account";

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
    
     /// Delete Account
     ///
     /// Delete a currently logged in user account. Behind the scene, the user
     /// record is not deleted but permanently blocked from any access. This is done
     /// to avoid deleted accounts being overtaken by new users with the same email
     /// address. Any user-related resources like documents or storage files should
     /// be deleted separately.
     ///
        public async Task<HttpResponseMessage> Delete() 
        {
            string path = "/account";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("DELETE", path, headers, parameters);
        }

     /// Update Account Email
     ///
     /// Update currently logged in user account email address. After changing user
     /// address, user confirmation status is being reset and a new confirmation
     /// mail is sent. For security measures, user password is required to complete
     /// this request.
     ///
        public async Task<HttpResponseMessage> UpdateEmail(string email, string password) 
        {
            string path = "/account/email";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {

                { "email", email },

                { "password", password }
            };
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }
    
     /// Get Account Logs
     ///
     /// Get currently logged in user list of latest security activity logs. Each
     /// log returns user IP address, location and date and time of log.
     ///
        public async Task<HttpResponseMessage> GetLogs() 
        {
            string path = "/account/logs";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }
    
     /// Update Account Name
     ///
     /// Update currently logged in user account name.
     ///
        public async Task<HttpResponseMessage> UpdateName(string name) 
        {
            string path = "/account/name";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                
                { "name", name }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }

     /// Update Account Password
     ///
     /// Update currently logged in user password. For validation, user is required
     /// to pass the password twice.
     ///
        public async Task<HttpResponseMessage> UpdatePassword(string password, string oldPassword) 
        {
            string path = "/account/password";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                
                { "password", password },

                { "oldPassword", oldPassword}
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }

     /// Get Account Preferences
     ///
     /// Get currently logged in user preferences as a key-value object.
     ///
        public async Task<HttpResponseMessage> GetPrefs() 
        {
            string path = "/account/prefs";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }
    
     /// Update Account Preferences
     ///
     /// Update currently logged in user account preferences. You can pass only the
     /// specific settings you wish to update.
     ///
        public async Task<HttpResponseMessage> UpdatePrefs(object prefs) 
        {
            string path = "/account/prefs";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                    
                { "prefs", prefs }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }
    
     /// Create Password Recovery
     ///
     /// Sends the user an email with a temporary secret key for password reset.
     /// When the user clicks the confirmation link he is redirected back to your
     /// app password reset URL with the secret key and email address values
     /// attached to the URL query string. Use the query string params to submit a
     /// request to the [PUT
     /// /account/recovery](/docs/client/account#accountUpdateRecovery) endpoint to
     /// complete the process.
     ///
        public async Task<HttpResponseMessage> CreateRecovery(string email, string url) 
        {
            string path = "/account/recovery";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                    
                { "email", email },

                { "url", url }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

     /// Complete Password Recovery
     ///
     /// Use this endpoint to complete the user account password reset. Both the
     /// **userId** and **secret** arguments will be passed as query parameters to
     /// the redirect URL you have provided when sending your request to the [POST
     /// /account/recovery](/docs/client/account#accountCreateRecovery) endpoint.
     /// 
     /// Please note that in order to avoid a [Redirect
     /// Attack](https://github.com/OWASP/CheatSheetSeries/blob/master/cheatsheets/Unvalidated_Redirects_and_Forwards_Cheat_Sheet.md)
     /// the only valid redirect URLs are the ones from domains you have set when
     /// adding your platforms in the console interface.
     ///
        public async Task<HttpResponseMessage> UpdateRecovery(string userId, string secret, string password, string passwordAgain) 
        {
            string path = "/account/recovery";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                    
                { "userId", userId },

                { "secret", secret },

                { "password", password },
                
                { "passwordAgain", passwordAgain }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("PUT", path, headers, parameters);
        }

     /// Get Account Sessions
     ///
     /// Get currently logged in user list of active sessions across different
     /// devices.
     ///
        public async Task<HttpResponseMessage> GetSessions() 
        {
            string path = "/account/sessions";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("GET", path, headers, parameters);
        }
    
     /// Create Account Session
     ///
     /// Allow the user to login into their account by providing a valid email and
     /// password combination. This route will create a new session for the user.
     ///
        public async Task<HttpResponseMessage> CreateSession(string email, string password) 
        {
            string path = "/account/sessions";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {

                { "email", email },
                { "password", password }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

     /// Delete All Account Sessions
     ///
     /// Delete all sessions from the user account and remove any sessions cookies
     /// from the end client.
     ///
        public async Task<HttpResponseMessage> DeleteSessions() 
        {
            string path = "/account/sessions";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("DELETE", path, headers, parameters);
        }
    
    /*         WORK IN PROGRESS
     /// Create Account Session with OAuth2
     ///
     /// Allow the user to login to their account using the OAuth2 provider of their
     /// choice. Each OAuth2 provider should be enabled from the Appwrite console
     /// first. Use the success and failure arguments to provide a redirect URL's
     /// back to your app when login is completed.
     ///
        public async Task<HttpResponseMessage> CreateOAuth2Session(string provider, string success = "https://appwrite.io/auth/oauth2/success", string failure = "https://appwrite.io/auth/oauth2/failure", List<object>[] scopes) 
        {
            string path = "/account/sessions/oauth2/{provider}".Replace("{provider}", provider);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {

                { "success", success },

                { "failure", failure },

                { "scopes", scopes },

                { "project", _client.GetConfig().get("project") }

            };


            List<object>[] query;

            foreach(var (key, value) in parameters) {
                if(param is List) {
                    foreach(var item in value) {
                        query.Add(Uri.EscapeDataString(key + "[]") + "=" + Uri.EscapeDataString(item));
                    }
                }
                else {
                    query.Add(Uri.EscapeDataString(key) + "=" + Uri.EscapeDataString(item));
                }
            }

            //Uri.Parse is deprecated. Here's a workaround.
            Uri endpoint = new Uri(_client.endpoint);
            Uri url = new UriBuilder() {
                Scheme = endpoint.Scheme,
                Port = endpoint.Port,
                Path = endpoint.Path + Path,
                Query = query.Join("&")
            };

            //This is a .NET application. No way it's running on a website.
            //if(kIsWeb)
            //
            //
            //

            //Confusing. I have to research OAuth some more.
 
            //Need a Cookie based OAuth system, not a Token based one.

            return.. 

        } */

     /// Delete Account Session
     ///
     /// Use this endpoint to log out the currently logged in user from all their
     /// account sessions across all of their different devices. When using the
     /// option id argument, only the session unique ID provider will be deleted.
     ///
        public async Task<HttpResponseMessage> DeleteSession(string sessionId) 
        {
            string path = "/account/sessions/{sessionId}".Replace("{sessionId}", sessionId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("DELETE", path, headers, parameters);
        }
    
     /// Create Email Verification
     ///
     /// Use this endpoint to send a verification message to your user email address
     /// to confirm they are the valid owners of that address. Both the **userId**
     /// and **secret** arguments will be passed as query parameters to the URL you
     /// have provided to be attached to the verification email. The provided URL
     /// should redirect the user back to your app and allow you to complete the
     /// verification process by verifying both the **userId** and **secret**
     /// parameters. Learn more about how to [complete the verification
     /// process](/docs/client/account#accountUpdateVerification). 
     /// 
     /// Please note that in order to avoid a [Redirect
     /// Attack](https://github.com/OWASP/CheatSheetSeries/blob/master/cheatsheets/Unvalidated_Redirects_and_Forwards_Cheat_Sheet.md),
     /// the only valid redirect URLs are the ones from domains you have set when
     /// adding your platforms in the console interface.
     /// 
     ///
        public async Task<HttpResponseMessage> CreateVerification(string url) 
        {
            string path = "/account/verification";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                    
                { "url", url }
            };
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

     /// Complete Email Verification
     ///
     /// Use this endpoint to complete the user email verification process. Use both
     /// the **userId** and **secret** parameters that were attached to your app URL
     /// to verify the user email ownership. If confirmed this route will return a
     /// 200 status code.
     ///
        public async Task<HttpResponseMessage> UpdateVerification(string userId, string secret) 
        {
            string path = "/account/verification";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                    
                { "userId", userId },
                { "secret", secret }
            };
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("PUT", path, headers, parameters);
        }

        };
}