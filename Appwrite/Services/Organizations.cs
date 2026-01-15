
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Organizations : Service
    {
        public Organizations(Client client) : base(client)
        {
        }

        /// <para>
        /// Delete an organization.
        /// </para>
        /// </summary>
        public Task<object> Delete(string organizationId)
        {
            var apiPath = "/organizations/{organizationId}"
                .Replace("{organizationId}", organizationId);

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
        /// Get estimation for deleting an organization.
        /// </para>
        /// </summary>
        public Task<Models.EstimationDeleteOrganization> EstimationDeleteOrganization(string organizationId)
        {
            var apiPath = "/organizations/{organizationId}/estimations/delete-organization"
                .Replace("{organizationId}", organizationId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.EstimationDeleteOrganization Convert(Dictionary<string, object> it) =>
                Models.EstimationDeleteOrganization.From(map: it);

            return _client.Call<Models.EstimationDeleteOrganization>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

    }
}
