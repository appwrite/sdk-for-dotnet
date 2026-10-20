using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Domains : Service
    {
        public Domains(Client client) : base(client)
        {
        }

        /// <para>
        /// List all domains registered for this project. This endpoint supports
        /// pagination.
        /// </para>
        /// </summary>
        public Task<Models.DomainsList> List(List<string>? queries = null, string? search = null, bool? total = null)
        {
            var apiPath = "/domains";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.DomainsList Convert(Dictionary<string, object> it)
            {
                return Models.DomainsList.From(map: it);
            }

            return _client.Call<Models.DomainsList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new domain. Before creating a domain, you need to ensure that your
        /// DNS provider is properly configured. After creating the domain, you can use
        /// the verification endpoint to check if the domain is ready to be used.
        /// </para>
        /// </summary>
        public Task<Models.XDomain> Create(string teamId, string domain)
        {
            var apiPath = "/domains";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "teamId", teamId },
                { "domain", domain }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.XDomain Convert(Dictionary<string, object> it)
            {
                return Models.XDomain.From(map: it);
            }

            return _client.Call<Models.XDomain>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get the registration price for a domain name.
        /// </para>
        /// </summary>
        [Obsolete("This API has been deprecated since 2.0.0. Please use `Domains.listPrices` instead.")]
        public Task<Models.DomainPrice> GetPrice(string domain, long? periodYears = null, Appwrite.Enums.DomainRegistrationType? registrationType = null)
        {
            var apiPath = "/domains/price";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "domain", domain },
                { "periodYears", periodYears },
                { "registrationType", registrationType?.Value }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.DomainPrice Convert(Dictionary<string, object> it)
            {
                return Models.DomainPrice.From(map: it);
            }

            return _client.Call<Models.DomainPrice>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Check availability and get the requested registration price for one or more
        /// domain names. Availability is resolved for all domains in a single
        /// registrar lookup. Unavailable domains have a null price for new
        /// registrations, but can still be priced for renewal, transfer, or trade.
        /// Every priced domain also carries its renewal price for the same period, so
        /// a separate renewal lookup is not needed. A domain whose price could not be
        /// resolved, for example because its TLD is not supported, is returned with a
        /// null price.
        /// </para>
        /// </summary>
        public Task<Models.DomainPricesList> ListPrices(List<string> domains, long? periodYears = null, Appwrite.Enums.DomainRegistrationType? registrationType = null)
        {
            var apiPath = "/domains/prices";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "domains", domains },
                { "periodYears", periodYears },
                { "registrationType", registrationType?.Value }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.DomainPricesList Convert(Dictionary<string, object> it)
            {
                return Models.DomainPricesList.From(map: it);
            }

            return _client.Call<Models.DomainPricesList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a domain by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.XDomain> Get(string domainId)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.XDomain Convert(Dictionary<string, object> it)
            {
                return Models.XDomain.From(map: it);
            }

            return _client.Call<Models.XDomain>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a domain by its unique ID. This endpoint can be used to delete a
        /// domain from your project.
        /// Once deleted, the domain will no longer be available for use and all
        /// associated resources will be removed.
        /// </para>
        /// </summary>
        public Task<object> Delete(string domainId)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };



            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <para>
        /// Update the registrar nameservers for the given domain. When nameservers are
        /// not provided,
        /// the domain will be updated to use Appwrite nameservers.
        /// </para>
        /// </summary>
        public Task<Models.XDomain> UpdateNameservers(string domainId, List<string>? nameservers = null)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/nameservers"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "nameservers", nameservers }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.XDomain Convert(Dictionary<string, object> it)
            {
                return Models.XDomain.From(map: it);
            }

            return _client.Call<Models.XDomain>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Verify which NS records are used and update the domain accordingly. This
        /// will check the domain's
        /// nameservers and update the domain's status based on whether the nameservers
        /// match the expected
        /// Appwrite nameservers.
        /// </para>
        /// </summary>
        public Task<Models.XDomain> VerifyNameservers(string domainId)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/nameservers/verification"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.XDomain Convert(Dictionary<string, object> it)
            {
                return Models.XDomain.From(map: it);
            }

            return _client.Call<Models.XDomain>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// List Google Workspace DNS records.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecordsList> GetPresetGoogleWorkspace(string domainId)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/presets/google-workspace"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.DnsRecordsList Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecordsList.From(map: it);
            }

            return _client.Call<Models.DnsRecordsList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Add Google Workspace DNS records to the domain. This will create the
        /// required MX records 
        /// for Google Workspace email hosting.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecordsList> CreatePresetGoogleWorkspace(string domainId)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/presets/google-workspace"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DnsRecordsList Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecordsList.From(map: it);
            }

            return _client.Call<Models.DnsRecordsList>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// List iCloud DNS records.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecordsList> GetPresetICloud(string domainId)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/presets/icloud"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.DnsRecordsList Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecordsList.From(map: it);
            }

            return _client.Call<Models.DnsRecordsList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Add iCloud DNS records to the domain. This will create the required MX and
        /// SPF records
        /// for using iCloud email services with your domain.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecordsList> CreatePresetICloud(string domainId)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/presets/icloud"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DnsRecordsList Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecordsList.From(map: it);
            }

            return _client.Call<Models.DnsRecordsList>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// List Mailgun DNS records.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecordsList> GetPresetMailgun(string domainId)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/presets/mailgun"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.DnsRecordsList Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecordsList.From(map: it);
            }

            return _client.Call<Models.DnsRecordsList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Add Mailgun DNS records to the domain. This endpoint will create the
        /// required DNS records 
        /// for Mailgun in the specified domain.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecordsList> CreatePresetMailgun(string domainId)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/presets/mailgun"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DnsRecordsList Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecordsList.From(map: it);
            }

            return _client.Call<Models.DnsRecordsList>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// List Outlook DNS records.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecordsList> GetPresetOutlook(string domainId)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/presets/outlook"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.DnsRecordsList Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecordsList.From(map: it);
            }

            return _client.Call<Models.DnsRecordsList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Add Outlook DNS records to the domain. This will create the required MX
        /// records
        /// for setting up Outlook email hosting for your domain.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecordsList> CreatePresetOutlook(string domainId)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/presets/outlook"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DnsRecordsList Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecordsList.From(map: it);
            }

            return _client.Call<Models.DnsRecordsList>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// List ProtonMail DNS records.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecordsList> GetPresetProtonMail(string domainId)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/presets/proton-mail"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.DnsRecordsList Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecordsList.From(map: it);
            }

            return _client.Call<Models.DnsRecordsList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Add ProtonMail DNS records to the domain. This will create the required MX
        /// records
        /// for using ProtonMail with your custom domain.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecordsList> CreatePresetProtonMail(string domainId)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/presets/proton-mail"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DnsRecordsList Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecordsList.From(map: it);
            }

            return _client.Call<Models.DnsRecordsList>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// List Zoho DNS records.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecordsList> GetPresetZoho(string domainId)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/presets/zoho"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.DnsRecordsList Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecordsList.From(map: it);
            }

            return _client.Call<Models.DnsRecordsList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Add Zoho Mail DNS records to the domain. This will create the required MX
        /// records
        /// for setting up Zoho Mail on your domain.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecordsList> CreatePresetZoho(string domainId)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/presets/zoho"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DnsRecordsList Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecordsList.From(map: it);
            }

            return _client.Call<Models.DnsRecordsList>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// List DNS records for a given domain. You can use this endpoint to list all
        /// the DNS records
        /// associated with your domain.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecordsList> ListRecords(string domainId, List<string>? queries = null, bool? total = null)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/records"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.DnsRecordsList Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecordsList.From(map: it);
            }

            return _client.Call<Models.DnsRecordsList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new A record for the given domain. A records are used to point a
        /// domain name 
        /// to an IPv4 address. The record value should be a valid IPv4 address.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecord> CreateRecordA(string domainId, string name, string @value, long ttl, string? comment = null)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/records/a"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "value", @value },
                { "ttl", ttl },
                { "comment", comment }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DnsRecord Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecord.From(map: it);
            }

            return _client.Call<Models.DnsRecord>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an existing A record for the given domain. This endpoint allows you
        /// to modify 
        /// the properties of an A record including its name (subdomain), IPv4 address,
        /// TTL, 
        /// and optional comment.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecord> UpdateRecordA(string domainId, string recordId, string name, string @value, long ttl, string? comment = null)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            if (recordId == "")
            {
                throw new AppwriteException("Missing required parameter: \"recordId\"");
            }

            var apiPath = "/domains/{domainId}/records/a/{recordId}"
                .Replace("{domainId}", domainId)
                .Replace("{recordId}", recordId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "value", @value },
                { "ttl", ttl },
                { "comment", comment }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DnsRecord Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecord.From(map: it);
            }

            return _client.Call<Models.DnsRecord>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new AAAA record for the given domain. This endpoint allows you to
        /// add a new IPv6 DNS record 
        /// to your domain. The record will be used to point a hostname to an IPv6
        /// address.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecord> CreateRecordAAAA(string domainId, string name, string @value, long ttl, string? comment = null)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/records/aaaa"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "value", @value },
                { "ttl", ttl },
                { "comment", comment }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DnsRecord Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecord.From(map: it);
            }

            return _client.Call<Models.DnsRecord>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an existing AAAA record for the given domain. This endpoint allows
        /// you to modify
        /// the properties of an existing AAAA record, including its name (subdomain),
        /// IPv6 address,
        /// TTL, and optional comment.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecord> UpdateRecordAAAA(string domainId, string recordId, string name, string @value, long ttl, string? comment = null)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            if (recordId == "")
            {
                throw new AppwriteException("Missing required parameter: \"recordId\"");
            }

            var apiPath = "/domains/{domainId}/records/aaaa/{recordId}"
                .Replace("{domainId}", domainId)
                .Replace("{recordId}", recordId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "value", @value },
                { "ttl", ttl },
                { "comment", comment }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DnsRecord Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecord.From(map: it);
            }

            return _client.Call<Models.DnsRecord>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new ALIAS record for the given domain. This record type can be
        /// used to point your domain 
        /// to another domain name that will serve as an alias. This is particularly
        /// useful when you want to 
        /// map your domain to a target domain that may change its IP address.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecord> CreateRecordAlias(string domainId, string name, string @value, long ttl, string? comment = null)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/records/alias"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "value", @value },
                { "ttl", ttl },
                { "comment", comment }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DnsRecord Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecord.From(map: it);
            }

            return _client.Call<Models.DnsRecord>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an existing ALIAS record for the specified domain. This endpoint
        /// allows you to modify
        /// the properties of an existing ALIAS record including its name, target
        /// domain, TTL, and comment.
        ///     
        /// The ALIAS record type is similar to a CNAME record but can be used at the
        /// zone apex (root domain).
        /// It provides a way to map one domain name to another.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecord> UpdateRecordAlias(string domainId, string recordId, string name, string @value, long ttl, string? comment = null)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            if (recordId == "")
            {
                throw new AppwriteException("Missing required parameter: \"recordId\"");
            }

            var apiPath = "/domains/{domainId}/records/alias/{recordId}"
                .Replace("{domainId}", domainId)
                .Replace("{recordId}", recordId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "value", @value },
                { "ttl", ttl },
                { "comment", comment }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DnsRecord Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecord.From(map: it);
            }

            return _client.Call<Models.DnsRecord>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new CAA record for the given domain. CAA records are used to
        /// specify which 
        /// Certificate Authorities (CAs) are allowed to issue SSL/TLS certificates for
        /// your domain.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecord> CreateRecordCAA(string domainId, string name, string @value, long ttl, string? comment = null)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/records/caa"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "value", @value },
                { "ttl", ttl },
                { "comment", comment }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DnsRecord Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecord.From(map: it);
            }

            return _client.Call<Models.DnsRecord>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an existing CAA record for the given domain. A CAA (Certification
        /// Authority Authorization) 
        /// record is used to specify which certificate authorities (CAs) are
        /// authorized to issue certificates 
        /// for a domain.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecord> UpdateRecordCAA(string domainId, string recordId, string name, string @value, long ttl, string? comment = null)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            if (recordId == "")
            {
                throw new AppwriteException("Missing required parameter: \"recordId\"");
            }

            var apiPath = "/domains/{domainId}/records/caa/{recordId}"
                .Replace("{domainId}", domainId)
                .Replace("{recordId}", recordId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "value", @value },
                { "ttl", ttl },
                { "comment", comment }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DnsRecord Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecord.From(map: it);
            }

            return _client.Call<Models.DnsRecord>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new CNAME record for the given domain.
        ///     
        /// A CNAME record maps a subdomain to another domain name, allowing you to
        /// create aliases 
        /// for your domain. For example, you can create a CNAME record to point
        /// 'blog.example.com' 
        /// to 'example.wordpress.com'.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecord> CreateRecordCNAME(string domainId, string name, string @value, long ttl, string? comment = null)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/records/cname"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "value", @value },
                { "ttl", ttl },
                { "comment", comment }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DnsRecord Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecord.From(map: it);
            }

            return _client.Call<Models.DnsRecord>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an existing CNAME record for the given domain.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecord> UpdateRecordCNAME(string domainId, string recordId, string name, string @value, long ttl, string? comment = null)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            if (recordId == "")
            {
                throw new AppwriteException("Missing required parameter: \"recordId\"");
            }

            var apiPath = "/domains/{domainId}/records/cname/{recordId}"
                .Replace("{domainId}", domainId)
                .Replace("{recordId}", recordId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "value", @value },
                { "ttl", ttl },
                { "comment", comment }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DnsRecord Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecord.From(map: it);
            }

            return _client.Call<Models.DnsRecord>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new HTTPS record for the given domain. This record is used to
        /// configure HTTPS 
        /// settings for your domain, enabling secure communication over SSL/TLS.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecord> CreateRecordHTTPS(string domainId, string name, string @value, long ttl, string? comment = null)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/records/https"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "value", @value },
                { "ttl", ttl },
                { "comment", comment }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DnsRecord Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecord.From(map: it);
            }

            return _client.Call<Models.DnsRecord>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an existing HTTPS record for the given domain. This endpoint allows
        /// you to modify 
        /// the properties of an HTTPS record associated with your domain, including
        /// the name (subdomain), 
        /// target value, TTL, and optional comment.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecord> UpdateRecordHTTPS(string domainId, string recordId, string name, string @value, long ttl, string? comment = null)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            if (recordId == "")
            {
                throw new AppwriteException("Missing required parameter: \"recordId\"");
            }

            var apiPath = "/domains/{domainId}/records/https/{recordId}"
                .Replace("{domainId}", domainId)
                .Replace("{recordId}", recordId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "value", @value },
                { "ttl", ttl },
                { "comment", comment }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DnsRecord Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecord.From(map: it);
            }

            return _client.Call<Models.DnsRecord>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new MX record for the given domain. MX records are used to define
        /// the mail servers responsible 
        /// for accepting email messages for the domain. Multiple MX records can be
        /// created with different priorities.
        /// The priority parameter determines the order in which mail servers are used,
        /// with lower values indicating 
        /// higher priority.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecord> CreateRecordMX(string domainId, string name, string @value, long ttl, long priority, string? comment = null)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/records/mx"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "value", @value },
                { "ttl", ttl },
                { "priority", priority },
                { "comment", comment }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DnsRecord Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecord.From(map: it);
            }

            return _client.Call<Models.DnsRecord>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an existing MX record for the given domain.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecord> UpdateRecordMX(string domainId, string recordId, string name, string @value, long ttl, long priority, string? comment = null)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            if (recordId == "")
            {
                throw new AppwriteException("Missing required parameter: \"recordId\"");
            }

            var apiPath = "/domains/{domainId}/records/mx/{recordId}"
                .Replace("{domainId}", domainId)
                .Replace("{recordId}", recordId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "value", @value },
                { "ttl", ttl },
                { "priority", priority },
                { "comment", comment }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DnsRecord Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecord.From(map: it);
            }

            return _client.Call<Models.DnsRecord>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new NS record for the given domain. NS records specify the
        /// nameservers that are used 
        /// to resolve the domain name to IP addresses. Each domain can have multiple
        /// NS records.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecord> CreateRecordNS(string domainId, string name, string @value, long ttl, string? comment = null)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/records/ns"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "value", @value },
                { "ttl", ttl },
                { "comment", comment }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DnsRecord Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecord.From(map: it);
            }

            return _client.Call<Models.DnsRecord>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an existing NS record for the given domain. This endpoint allows you
        /// to modify 
        /// the properties of an NS (nameserver) record associated with your domain.
        /// You can update 
        /// the record name (subdomain), target nameserver value, TTL, and add or
        /// modify comments 
        /// for better record management.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecord> UpdateRecordNS(string domainId, string recordId, string name, string @value, long ttl, string? comment = null)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            if (recordId == "")
            {
                throw new AppwriteException("Missing required parameter: \"recordId\"");
            }

            var apiPath = "/domains/{domainId}/records/ns/{recordId}"
                .Replace("{domainId}", domainId)
                .Replace("{recordId}", recordId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "value", @value },
                { "ttl", ttl },
                { "comment", comment }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DnsRecord Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecord.From(map: it);
            }

            return _client.Call<Models.DnsRecord>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new SRV record for the given domain. SRV records are used to
        /// define the location 
        /// of servers for specific services. For example, they can be used to specify
        /// which server 
        /// handles a specific service like SIP or XMPP for the domain.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecord> CreateRecordSRV(string domainId, string name, string @value, long ttl, long priority, long weight, long port, string? comment = null)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/records/srv"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "value", @value },
                { "ttl", ttl },
                { "priority", priority },
                { "weight", weight },
                { "port", port },
                { "comment", comment }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DnsRecord Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecord.From(map: it);
            }

            return _client.Call<Models.DnsRecord>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an existing SRV record for the given domain.
        ///     
        /// Required parameters:
        /// - domainId: Domain unique ID
        /// - recordId: DNS record unique ID
        /// - name: Record name (service name)
        /// - value: Target hostname for this SRV record
        /// - ttl: Time to live, in seconds
        /// - priority: Record priority
        /// - weight: Record weight
        /// - port: Port number for the service
        ///     
        /// Optional parameters:
        /// - comment: A comment for this record
        /// </para>
        /// </summary>
        public Task<Models.DnsRecord> UpdateRecordSRV(string domainId, string recordId, string name, string @value, long ttl, long priority, long weight, long port, string? comment = null)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            if (recordId == "")
            {
                throw new AppwriteException("Missing required parameter: \"recordId\"");
            }

            var apiPath = "/domains/{domainId}/records/srv/{recordId}"
                .Replace("{domainId}", domainId)
                .Replace("{recordId}", recordId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "value", @value },
                { "ttl", ttl },
                { "priority", priority },
                { "weight", weight },
                { "port", port },
                { "comment", comment }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DnsRecord Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecord.From(map: it);
            }

            return _client.Call<Models.DnsRecord>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new TXT record for the given domain. TXT records can be used 
        /// to provide additional information about your domain, such as domain 
        /// verification records, SPF records, or DKIM records.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecord> CreateRecordTXT(string domainId, string name, long ttl, string? @value = null, string? comment = null)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/records/txt"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "value", @value },
                { "ttl", ttl },
                { "comment", comment }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DnsRecord Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecord.From(map: it);
            }

            return _client.Call<Models.DnsRecord>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an existing TXT record for the given domain.
        ///     
        /// Update the TXT record details for a specific domain by providing the domain
        /// ID,
        /// record ID, and the new record configuration including name, value, TTL, and
        /// an optional comment.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecord> UpdateRecordTXT(string domainId, string recordId, string name, string @value, long ttl, string? comment = null)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            if (recordId == "")
            {
                throw new AppwriteException("Missing required parameter: \"recordId\"");
            }

            var apiPath = "/domains/{domainId}/records/txt/{recordId}"
                .Replace("{domainId}", domainId)
                .Replace("{recordId}", recordId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "value", @value },
                { "ttl", ttl },
                { "comment", comment }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.DnsRecord Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecord.From(map: it);
            }

            return _client.Call<Models.DnsRecord>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a single DNS record for a given domain by record ID.
        ///     
        /// This endpoint allows you to retrieve a specific DNS record associated with
        /// a domain
        /// using its unique identifier. The record contains information about the DNS
        /// configuration
        /// such as type, value, and TTL settings.
        /// </para>
        /// </summary>
        public Task<Models.DnsRecord> GetRecord(string domainId, string recordId)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            if (recordId == "")
            {
                throw new AppwriteException("Missing required parameter: \"recordId\"");
            }

            var apiPath = "/domains/{domainId}/records/{recordId}"
                .Replace("{domainId}", domainId)
                .Replace("{recordId}", recordId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.DnsRecord Convert(Dictionary<string, object> it)
            {
                return Models.DnsRecord.From(map: it);
            }

            return _client.Call<Models.DnsRecord>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a DNS record for the given domain. This endpoint allows you to
        /// delete an existing DNS record 
        /// from a specific domain.
        /// </para>
        /// </summary>
        public Task<object> DeleteRecord(string domainId, string recordId)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            if (recordId == "")
            {
                throw new AppwriteException("Missing required parameter: \"recordId\"");
            }

            var apiPath = "/domains/{domainId}/records/{recordId}"
                .Replace("{domainId}", domainId)
                .Replace("{recordId}", recordId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };



            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <para>
        /// Update the team ID for a specific domain. The caller must administer the
        /// current
        /// team and be an owner of the destination team.
        /// 
        /// Updating the team ID will transfer ownership and access control of the
        /// domain
        /// and all its DNS records to the new team.
        /// </para>
        /// </summary>
        public Task<Models.XDomain> UpdateTeam(string domainId, string teamId)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/team"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "teamId", teamId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.XDomain Convert(Dictionary<string, object> it)
            {
                return Models.XDomain.From(map: it);
            }

            return _client.Call<Models.XDomain>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Retrieve the current transfer status for a domain. Returns the status, an
        /// optional reason, and a timestamp of the last status change.
        /// </para>
        /// </summary>
        public Task<Models.DomainTransferStatus> GetTransferStatus(string domainId)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/transfers/status"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.DomainTransferStatus Convert(Dictionary<string, object> it)
            {
                return Models.DomainTransferStatus.From(map: it);
            }

            return _client.Call<Models.DomainTransferStatus>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Retrieve the DNS zone file for the given domain. This endpoint will return
        /// the DNS
        /// zone file in a standardized format that can be used to configure DNS
        /// servers.
        /// </para>
        /// </summary>
        public Task<string> GetZone(string domainId)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/zone"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "text/plain" }
            };



            return _client.Call<string>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <para>
        /// Update the DNS zone for the given domain using the provided zone file
        /// content.
        /// All parsed records are imported and then the main domain document is
        /// returned.
        /// </para>
        /// </summary>
        public Task<Models.XDomain> UpdateZone(string domainId, string content)
        {
            if (domainId == "")
            {
                throw new AppwriteException("Missing required parameter: \"domainId\"");
            }

            var apiPath = "/domains/{domainId}/zone"
                .Replace("{domainId}", domainId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "content", content }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.XDomain Convert(Dictionary<string, object> it)
            {
                return Models.XDomain.From(map: it);
            }

            return _client.Call<Models.XDomain>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

    }
}
