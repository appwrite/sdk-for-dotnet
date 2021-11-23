
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        /// Get a list of all the current user teams. You can use the query params to
        /// filter your results. On admin mode, this endpoint will return a list of all
        /// of the project's teams. [Learn more about different API
        /// modes](/docs/admin).
        /// </para>
        /// </summary>
        public Task<Models.TeamList> List(string? search = null, int? limit = null, int? offset = null, OrderType orderType = OrderType.ASC)
        {
            var path = "/teams";

            var parameters = new Dictionary<string, object?>()
            {
                { "search", search },
                { "limit", limit },
                { "offset", offset },
                { "orderType", orderType.ToString() }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.TeamList convert(Dictionary<string, object> it)
            {
                return Models.TeamList.From(map: it);
            }

            return _client.Call<Models.TeamList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.TeamList));
        }

        /// <summary>
        /// Create Team
        /// <para>
        /// Create a new team. The user who creates the team will automatically be
        /// assigned as the owner of the team. The team owner can invite new members,
        /// who will be able add new owners and update or delete the team from your
        /// project.
        /// </para>
        /// </summary>
        public Task<Models.Team> Create(string name, List<object>? roles = null)
        {
            var path = "/teams";

            var parameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "roles", roles }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Team convert(Dictionary<string, object> it)
            {
                return Models.Team.From(map: it);
            }

            return _client.Call<Models.Team>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.Team));
        }

        /// <summary>
        /// Get Team
        /// <para>
        /// Get a team by its unique ID. All team members have read access for this
        /// resource.
        /// </para>
        /// </summary>
        public Task<Models.Team> Get(string teamId)
        {
            var path = "/teams/{teamId}"
                .Replace("{teamId}", teamId);

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Team convert(Dictionary<string, object> it)
            {
                return Models.Team.From(map: it);
            }

            return _client.Call<Models.Team>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.Team));
        }

        /// <summary>
        /// Update Team
        /// <para>
        /// Update a team by its unique ID. Only team owners have write access for this
        /// resource.
        /// </para>
        /// </summary>
        public Task<Models.Team> Update(string teamId, string name)
        {
            var path = "/teams/{teamId}"
                .Replace("{teamId}", teamId);

            var parameters = new Dictionary<string, object?>()
            {
                { "name", name }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Team convert(Dictionary<string, object> it)
            {
                return Models.Team.From(map: it);
            }

            return _client.Call<Models.Team>(
                method: "PUT",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.Team));
        }

        /// <summary>
        /// Delete Team
        /// <para>
        /// Delete a team by its unique ID. Only team owners have write access for this
        /// resource.
        /// </para>
        /// </summary>
        public Task<object> Delete(string teamId)
        {
            var path = "/teams/{teamId}"
                .Replace("{teamId}", teamId);

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
        /// Get Team Memberships
        /// <para>
        /// Get a team members by the team unique ID. All team members have read access
        /// for this list of resources.
        /// </para>
        /// </summary>
        public Task<Models.MembershipList> GetMemberships(string teamId, string? search = null, int? limit = null, int? offset = null, OrderType orderType = OrderType.ASC)
        {
            var path = "/teams/{teamId}/memberships"
                .Replace("{teamId}", teamId);

            var parameters = new Dictionary<string, object?>()
            {
                { "search", search },
                { "limit", limit },
                { "offset", offset },
                { "orderType", orderType.ToString() }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.MembershipList convert(Dictionary<string, object> it)
            {
                return Models.MembershipList.From(map: it);
            }

            return _client.Call<Models.MembershipList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.MembershipList));
        }

        /// <summary>
        /// Create Team Membership
        /// <para>
        /// Use this endpoint to invite a new member to join your team. If initiated
        /// from Client SDK, an email with a link to join the team will be sent to the
        /// new member's email address if the member doesn't exist in the project it
        /// will be created automatically. If initiated from server side SDKs, new
        /// member will automatically be added to the team.
        /// 
        /// Use the 'URL' parameter to redirect the user from the invitation email back
        /// to your app. When the user is redirected, use the [Update Team Membership
        /// Status](/docs/client/teams#teamsUpdateMembershipStatus) endpoint to allow
        /// the user to accept the invitation to the team.  While calling from side
        /// SDKs the redirect url can be empty string.
        /// 
        /// Please note that in order to avoid a [Redirect
        /// Attacks](https://github.com/OWASP/CheatSheetSeries/blob/master/cheatsheets/Unvalidated_Redirects_and_Forwards_Cheat_Sheet.md)
        /// the only valid redirect URL's are the once from domains you have set when
        /// added your platforms in the console interface.
        /// </para>
        /// </summary>
        public Task<Models.Membership> CreateMembership(string teamId, string email, List<object> roles, string url, string? name = null)
        {
            var path = "/teams/{teamId}/memberships"
                .Replace("{teamId}", teamId);

            var parameters = new Dictionary<string, object?>()
            {
                { "email", email },
                { "roles", roles },
                { "url", url },
                { "name", name }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Membership convert(Dictionary<string, object> it)
            {
                return Models.Membership.From(map: it);
            }

            return _client.Call<Models.Membership>(
                method: "POST",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.Membership));
        }

        /// <summary>
        /// Update Membership Roles
        /// </summary>
        public Task<Models.Membership> UpdateMembershipRoles(string teamId, string membershipId, List<object> roles)
        {
            var path = "/teams/{teamId}/memberships/{membershipId}"
                .Replace("{teamId}", teamId)
                .Replace("{membershipId}", membershipId);

            var parameters = new Dictionary<string, object?>()
            {
                { "roles", roles }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Membership convert(Dictionary<string, object> it)
            {
                return Models.Membership.From(map: it);
            }

            return _client.Call<Models.Membership>(
                method: "PATCH",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.Membership));
        }

        /// <summary>
        /// Delete Team Membership
        /// <para>
        /// This endpoint allows a user to leave a team or for a team owner to delete
        /// the membership of any other team member. You can also use this endpoint to
        /// delete a user membership even if it is not accepted.
        /// </para>
        /// </summary>
        public Task<object> DeleteMembership(string teamId, string membershipId)
        {
            var path = "/teams/{teamId}/memberships/{membershipId}"
                .Replace("{teamId}", teamId)
                .Replace("{membershipId}", membershipId);

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
        /// Update Team Membership Status
        /// <para>
        /// Use this endpoint to allow a user to accept an invitation to join a team
        /// after being redirected back to your app from the invitation email recieved
        /// by the user.
        /// </para>
        /// </summary>
        public Task<Models.Membership> UpdateMembershipStatus(string teamId, string membershipId, string userId, string secret)
        {
            var path = "/teams/{teamId}/memberships/{membershipId}/status"
                .Replace("{teamId}", teamId)
                .Replace("{membershipId}", membershipId);

            var parameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "secret", secret }
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Membership convert(Dictionary<string, object> it)
            {
                return Models.Membership.From(map: it);
            }

            return _client.Call<Models.Membership>(
                method: "PATCH",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.Membership));
        }
    };
}