
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Appwrite
{
    public class Teams : Service
    {

        public Teams(Client client) : base(client) { }


    
        /// List Teams
            /*
         * Get a list of all the current user teams. You can use the query params to
     * filter your results. On admin mode, this endpoint will return a list of all
     * of the project's teams. [Learn more about different API
     * modes](/docs/admin).
        */
        public async Task<HttpResponseMessage> List(string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC) 
        {
            string path = "/teams";

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
    
        /// Create Team
            /*
         * Create a new team. The user who creates the team will automatically be
     * assigned as the owner of the team. The team owner can invite new members,
     * who will be able add new owners and update or delete the team from your
     * project.
        */
        public async Task<HttpResponseMessage> Create(string name, List<object> roles = null) 
        {
            string path = "/teams";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                    
                { "name", name },
                    
                { "roles", roles }
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }
    
        /// Get Team
            /*
         * Get a team by its unique ID. All team members have read access for this
     * resource.
        */
        public async Task<HttpResponseMessage> Get(string teamId) 
        {
            string path = "/teams/{teamId}".Replace("{teamId}", teamId);

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
    
        /// Update Team
            /*
         * Update a team by its unique ID. Only team owners have write access for this
     * resource.
        */
        public async Task<HttpResponseMessage> Update(string teamId, string name) 
        {
            string path = "/teams/{teamId}".Replace("{teamId}", teamId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                    
                { "name", name }
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("PUT", path, headers, parameters);
        }
    
        /// Delete Team
            /*
         * Delete a team by its unique ID. Only team owners have write access for this
     * resource.
        */
        public async Task<HttpResponseMessage> Delete(string teamId) 
        {
            string path = "/teams/{teamId}".Replace("{teamId}", teamId);

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
    
        /// Get Team Memberships
            /*
         * Get a team members by the team unique ID. All team members have read access
     * for this list of resources.
        */
        public async Task<HttpResponseMessage> GetMemberships(string teamId, string search = "", int? limit = 25, int? offset = 0, OrderType orderType = OrderType.ASC) 
        {
            string path = "/teams/{teamId}/memberships".Replace("{teamId}", teamId);

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
    
        /// Create Team Membership
            /*
         * Use this endpoint to invite a new member to join your team. An email with a
     * link to join the team will be sent to the new member email address if the
     * member doesn't exist in the project it will be created automatically.
     * 
     * Use the 'URL' parameter to redirect the user from the invitation email back
     * to your app. When the user is redirected, use the [Update Team Membership
     * Status](/docs/client/teams#teamsUpdateMembershipStatus) endpoint to allow
     * the user to accept the invitation to the team.
     * 
     * Please note that in order to avoid a [Redirect
     * Attacks](https://github.com/OWASP/CheatSheetSeries/blob/master/cheatsheets/Unvalidated_Redirects_and_Forwards_Cheat_Sheet.md)
     * the only valid redirect URL's are the once from domains you have set when
     * added your platforms in the console interface.
        */
        public async Task<HttpResponseMessage> CreateMembership(string teamId, string email, List<object> roles, string url, string name = "") 
        {
            string path = "/teams/{teamId}/memberships".Replace("{teamId}", teamId);

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                    
                { "email", email },
                    
                { "name", name },
                    
                { "roles", roles },
                    
                { "url", url }
            };

    //             
    
    
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                {"content-type", "application/json" }
            };

            return await _client.Call("POST", path, headers, parameters);
        }
    
        /// Delete Team Membership
            /*
         * This endpoint allows a user to leave a team or for a team owner to delete
     * the membership of any other team member. You can also use this endpoint to
     * delete a user membership even if it is not accepted.
        */
        public async Task<HttpResponseMessage> DeleteMembership(string teamId, string inviteId) 
        {
            string path = "/teams/{teamId}/memberships/{inviteId}".Replace("{teamId}", teamId).Replace("{inviteId}", inviteId);

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
        };
}