
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Appwrite
{
    public class Teams : Service
    {
        public Teams(Client client) : base(client) { }

        /// <summary>
        /// List Teams
        /// <para>
        /// Get a list of all the teams in which the current user is a member. You can
        /// use the parameters to filter your results.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> List(List<string> queries = null, string search = "") 
        {
            string path = "/teams";

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
        /// Create Team
        /// <para>
        /// Create a new team. The user who creates the team will automatically be
        /// assigned as the owner of the team. Only the users with the owner role can
        /// invite new members, add new owners and delete or update the team.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> Create(string teamId, string name, List<string> roles = null) 
        {
            string path = "/teams";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "teamId", teamId },
                { "name", name },
                { "roles", roles }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Get Team
        /// <para>
        /// Get a team by its ID. All team members have read access for this resource.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> Get(string teamId) 
        {
            string path = "/teams/{teamId}".Replace("{teamId}", teamId);

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
        /// Update the team's name by its unique ID.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> UpdateName(string teamId, string name) 
        {
            string path = "/teams/{teamId}".Replace("{teamId}", teamId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "name", name }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PUT", path, headers, parameters);
        }

        /// <summary>
        /// Delete Team
        /// <para>
        /// Delete a team using its ID. Only team members with the owner role can
        /// delete the team.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> Delete(string teamId) 
        {
            string path = "/teams/{teamId}".Replace("{teamId}", teamId);

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
        /// List Team Memberships
        /// <para>
        /// Use this endpoint to list a team's members using the team's ID. All team
        /// members have read access to this endpoint.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> ListMemberships(string teamId, List<string> queries = null, string search = "") 
        {
            string path = "/teams/{teamId}/memberships".Replace("{teamId}", teamId);

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
        /// Create Team Membership
        /// <para>
        /// Invite a new member to join your team. Provide an ID for existing users, or
        /// invite unregistered users using an email or phone number. If initiated from
        /// a Client SDK, Appwrite will send an email or sms with a link to join the
        /// team to the invited user, and an account will be created for them if one
        /// doesn't exist. If initiated from a Server SDK, the new member will be added
        /// automatically to the team.
        /// 
        /// You only need to provide one of a user ID, email, or phone number. Appwrite
        /// will prioritize accepting the user ID > email > phone number if you provide
        /// more than one of these parameters.
        /// 
        /// Use the `url` parameter to redirect the user from the invitation email to
        /// your app. After the user is redirected, use the [Update Team Membership
        /// Status](/docs/client/teams#teamsUpdateMembershipStatus) endpoint to allow
        /// the user to accept the invitation to the team. 
        /// 
        /// Please note that to avoid a [Redirect
        /// Attack](https://github.com/OWASP/CheatSheetSeries/blob/master/cheatsheets/Unvalidated_Redirects_and_Forwards_Cheat_Sheet.md)
        /// Appwrite will accept the only redirect URLs under the domains you have
        /// added as a platform on the Appwrite Console.
        /// 
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> CreateMembership(string teamId, List<string> roles, string url, string email = "", string userId = "", string phone = "", string name = "") 
        {
            string path = "/teams/{teamId}/memberships".Replace("{teamId}", teamId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "email", email },
                { "userId", userId },
                { "phone", phone },
                { "roles", roles },
                { "url", url },
                { "name", name }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }

        /// <summary>
        /// Get Team Membership
        /// <para>
        /// Get a team member by the membership unique id. All team members have read
        /// access for this resource.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> GetMembership(string teamId, string membershipId) 
        {
            string path = "/teams/{teamId}/memberships/{membershipId}".Replace("{teamId}", teamId).Replace("{membershipId}", membershipId);

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
        /// Update Membership Roles
        /// <para>
        /// Modify the roles of a team member. Only team members with the owner role
        /// have access to this endpoint. Learn more about [roles and
        /// permissions](/docs/permissions).
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> UpdateMembershipRoles(string teamId, string membershipId, List<string> roles) 
        {
            string path = "/teams/{teamId}/memberships/{membershipId}".Replace("{teamId}", teamId).Replace("{membershipId}", membershipId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "roles", roles }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }

        /// <summary>
        /// Delete Team Membership
        /// <para>
        /// This endpoint allows a user to leave a team or for a team owner to delete
        /// the membership of any other team member. You can also use this endpoint to
        /// delete a user membership even if it is not accepted.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> DeleteMembership(string teamId, string membershipId) 
        {
            string path = "/teams/{teamId}/memberships/{membershipId}".Replace("{teamId}", teamId).Replace("{membershipId}", membershipId);

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
        /// Update Team Membership Status
        /// <para>
        /// Use this endpoint to allow a user to accept an invitation to join a team
        /// after being redirected back to your app from the invitation email received
        /// by the user.
        /// 
        /// If the request is successful, a session for the user is automatically
        /// created.
        /// 
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> UpdateMembershipStatus(string teamId, string membershipId, string userId, string secret) 
        {
            string path = "/teams/{teamId}/memberships/{membershipId}/status".Replace("{teamId}", teamId).Replace("{membershipId}", membershipId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "userId", userId },
                { "secret", secret }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PATCH", path, headers, parameters);
        }

        /// <summary>
        /// Get Team Preferences
        /// <para>
        /// Get the team's shared preferences by its unique ID. If a preference doesn't
        /// need to be shared by all team members, prefer storing them in [user
        /// preferences](/docs/client/account#accountGetPrefs).
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> GetPrefs(string teamId) 
        {
            string path = "/teams/{teamId}/prefs".Replace("{teamId}", teamId);

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
        /// Update Preferences
        /// <para>
        /// Update the team's preferences by its unique ID. The object you pass is
        /// stored as is and replaces any previous value. The maximum allowed prefs
        /// size is 64kB and throws an error if exceeded.
        /// </para>
        /// </summary>
        public async Task<HttpResponseMessage> UpdatePrefs(string teamId, object prefs) 
        {
            string path = "/teams/{teamId}/prefs".Replace("{teamId}", teamId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "prefs", prefs }
            };

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };

            return await _client.Call("PUT", path, headers, parameters);
        }
    };
}