
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Teams : Service
    {
        public Teams(Client client) : base(client)
        {
        }

        /// <summary>
        /// List teams
        /// <para>
        /// Get a list of all the teams in which the current user is a member. You can
        /// use the parameters to filter your results.
        /// </para>
        /// </summary>
        public Task<Models.TeamList> List(List<string>? queries = null, string? search = null)
        {
            var apiPath = "/teams";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.TeamList Convert(Dictionary<string, object> it) =>
                Models.TeamList.From(map: it);


            return _client.Call<Models.TeamList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create team
        /// <para>
        /// Create a new team. The user who creates the team will automatically be
        /// assigned as the owner of the team. Only the users with the owner role can
        /// invite new members, add new owners and delete or update the team.
        /// </para>
        /// </summary>
        public Task<Models.Team> Create(string teamId, string name, List<string>? roles = null)
        {
            var apiPath = "/teams";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "teamId", teamId },
                { "name", name },
                { "roles", roles }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Team Convert(Dictionary<string, object> it) =>
                Models.Team.From(map: it);


            return _client.Call<Models.Team>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get team
        /// <para>
        /// Get a team by its ID. All team members have read access for this resource.
        /// </para>
        /// </summary>
        public Task<Models.Team> Get(string teamId)
        {
            var apiPath = "/teams/{teamId}"
                .Replace("{teamId}", teamId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Team Convert(Dictionary<string, object> it) =>
                Models.Team.From(map: it);


            return _client.Call<Models.Team>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update name
        /// <para>
        /// Update the team's name by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Team> UpdateName(string teamId, string name)
        {
            var apiPath = "/teams/{teamId}"
                .Replace("{teamId}", teamId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Team Convert(Dictionary<string, object> it) =>
                Models.Team.From(map: it);


            return _client.Call<Models.Team>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Delete team
        /// <para>
        /// Delete a team using its ID. Only team members with the owner role can
        /// delete the team.
        /// </para>
        /// </summary>
        public Task<object> Delete(string teamId)
        {
            var apiPath = "/teams/{teamId}"
                .Replace("{teamId}", teamId);

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
        /// List team memberships
        /// <para>
        /// Use this endpoint to list a team's members using the team's ID. All team
        /// members have read access to this endpoint.
        /// </para>
        /// </summary>
        public Task<Models.MembershipList> ListMemberships(string teamId, List<string>? queries = null, string? search = null)
        {
            var apiPath = "/teams/{teamId}/memberships"
                .Replace("{teamId}", teamId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
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

        /// <summary>
        /// Create team membership
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
        /// Status](https://appwrite.io/docs/references/cloud/client-web/teams#updateMembershipStatus)
        /// endpoint to allow the user to accept the invitation to the team. 
        /// 
        /// Please note that to avoid a [Redirect
        /// Attack](https://github.com/OWASP/CheatSheetSeries/blob/master/cheatsheets/Unvalidated_Redirects_and_Forwards_Cheat_Sheet.md)
        /// Appwrite will accept the only redirect URLs under the domains you have
        /// added as a platform on the Appwrite Console.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.Membership> CreateMembership(string teamId, List<string> roles, string? email = null, string? userId = null, string? phone = null, string? url = null, string? name = null)
        {
            var apiPath = "/teams/{teamId}/memberships"
                .Replace("{teamId}", teamId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "email", email },
                { "userId", userId },
                { "phone", phone },
                { "roles", roles },
                { "url", url },
                { "name", name }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Membership Convert(Dictionary<string, object> it) =>
                Models.Membership.From(map: it);


            return _client.Call<Models.Membership>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get team membership
        /// <para>
        /// Get a team member by the membership unique id. All team members have read
        /// access for this resource.
        /// </para>
        /// </summary>
        public Task<Models.Membership> GetMembership(string teamId, string membershipId)
        {
            var apiPath = "/teams/{teamId}/memberships/{membershipId}"
                .Replace("{teamId}", teamId)
                .Replace("{membershipId}", membershipId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Membership Convert(Dictionary<string, object> it) =>
                Models.Membership.From(map: it);


            return _client.Call<Models.Membership>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update membership
        /// <para>
        /// Modify the roles of a team member. Only team members with the owner role
        /// have access to this endpoint. Learn more about [roles and
        /// permissions](https://appwrite.io/docs/permissions).
        /// 
        /// </para>
        /// </summary>
        public Task<Models.Membership> UpdateMembership(string teamId, string membershipId, List<string> roles)
        {
            var apiPath = "/teams/{teamId}/memberships/{membershipId}"
                .Replace("{teamId}", teamId)
                .Replace("{membershipId}", membershipId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "roles", roles }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Membership Convert(Dictionary<string, object> it) =>
                Models.Membership.From(map: it);


            return _client.Call<Models.Membership>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Delete team membership
        /// <para>
        /// This endpoint allows a user to leave a team or for a team owner to delete
        /// the membership of any other team member. You can also use this endpoint to
        /// delete a user membership even if it is not accepted.
        /// </para>
        /// </summary>
        public Task<object> DeleteMembership(string teamId, string membershipId)
        {
            var apiPath = "/teams/{teamId}/memberships/{membershipId}"
                .Replace("{teamId}", teamId)
                .Replace("{membershipId}", membershipId);

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
        /// Update team membership status
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
        public Task<Models.Membership> UpdateMembershipStatus(string teamId, string membershipId, string userId, string secret)
        {
            var apiPath = "/teams/{teamId}/memberships/{membershipId}/status"
                .Replace("{teamId}", teamId)
                .Replace("{membershipId}", membershipId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "secret", secret }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Membership Convert(Dictionary<string, object> it) =>
                Models.Membership.From(map: it);


            return _client.Call<Models.Membership>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get team preferences
        /// <para>
        /// Get the team's shared preferences by its unique ID. If a preference doesn't
        /// need to be shared by all team members, prefer storing them in [user
        /// preferences](https://appwrite.io/docs/references/cloud/client-web/account#getPrefs).
        /// </para>
        /// </summary>
        public Task<Models.Preferences> GetPrefs(string teamId)
        {
            var apiPath = "/teams/{teamId}/prefs"
                .Replace("{teamId}", teamId);

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
        /// Update the team's preferences by its unique ID. The object you pass is
        /// stored as is and replaces any previous value. The maximum allowed prefs
        /// size is 64kB and throws an error if exceeded.
        /// </para>
        /// </summary>
        public Task<Models.Preferences> UpdatePrefs(string teamId, object prefs)
        {
            var apiPath = "/teams/{teamId}/prefs"
                .Replace("{teamId}", teamId);

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
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

    }
}
