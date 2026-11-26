using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Monitors : Service
    {
        public Monitors(Client client) : base(client)
        {
        }

        /// <para>
        /// Get a list of the project's monitors of every type. Use queries to filter
        /// by type, resource, severity or status, and `Query.search('search', term)`
        /// to search monitor IDs, names, metrics and resources.
        /// </para>
        /// </summary>
        public Task<Models.MonitorList> List(List<string>? queries = null, bool? total = null)
        {
            var apiPath = "/monitors";

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


            static Models.MonitorList Convert(Dictionary<string, object> it)
            {
                return Models.MonitorList.From(map: it);
            }

            return _client.Call<Models.MonitorList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a DNS monitor. It asks a resolver for a domain's records of one type
        /// on its own interval, and opens an alert when the resolver fails, or when
        /// its rules match the answers, by default when there is no such record. Each
        /// alert fires the `monitors.[monitorId].alerts.[alertId].create` event when
        /// it opens and `.update` when a check passes again, for project webhooks,
        /// functions and realtime, and notifies the organization's members by email
        /// and in the console.
        /// </para>
        /// </summary>
        public Task<Models.Monitor> CreateDnsMonitor(string monitorId, string name, string domain, Appwrite.Enums.MonitorRecord? record = null, string? resolver = null, List<string>? rules = null, long? interval = null, long? timeout = null, long? cooldown = null, bool? enabled = null, List<string>? notify = null, Appwrite.Enums.MonitorSeverity? severity = null, string? escalationId = null)
        {
            var apiPath = "/monitors/dns";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "monitorId", monitorId },
                { "name", name },
                { "domain", domain },
                { "record", record?.Value },
                { "resolver", resolver },
                { "rules", rules },
                { "interval", interval },
                { "timeout", timeout },
                { "cooldown", cooldown },
                { "enabled", enabled },
                { "notify", notify },
                { "severity", severity?.Value },
                { "escalationId", escalationId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Monitor Convert(Dictionary<string, object> it)
            {
                return Models.Monitor.From(map: it);
            }

            return _client.Call<Models.Monitor>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a DNS monitor by its unique ID. Only the parameters passed change;
        /// the monitor's state, its last check and its open alert are kept. Passing
        /// `rules` replaces all of them.
        /// </para>
        /// </summary>
        public Task<Models.Monitor> UpdateDnsMonitor(string monitorId, string? name = null, string? domain = null, Appwrite.Enums.MonitorRecord? record = null, string? resolver = null, List<string>? rules = null, long? interval = null, long? timeout = null, long? cooldown = null, bool? enabled = null, List<string>? notify = null, Appwrite.Enums.MonitorSeverity? severity = null, string? escalationId = null)
        {
            if (monitorId == "")
            {
                throw new AppwriteException("Missing required parameter: \"monitorId\"");
            }

            var apiPath = "/monitors/dns/{monitorId}"
                .Replace("{monitorId}", Client.EncodePath(monitorId));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "domain", domain },
                { "record", record?.Value },
                { "resolver", resolver },
                { "rules", rules },
                { "interval", interval },
                { "timeout", timeout },
                { "cooldown", cooldown },
                { "enabled", enabled },
                { "notify", notify },
                { "severity", severity?.Value },
                { "escalationId", escalationId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Monitor Convert(Dictionary<string, object> it)
            {
                return Models.Monitor.From(map: it);
            }

            return _client.Call<Models.Monitor>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create an HTTP monitor. It requests a URL on its own interval, following
        /// redirects, and opens an alert when the request fails or when its rules
        /// match the response, by default a status outside 2xx or the certificate of
        /// an HTTPS URL about to expire. The response body is discarded as it arrives.
        /// Each alert fires the `monitors.[monitorId].alerts.[alertId].create` event
        /// when it opens and `.update` when a check passes again, for project
        /// webhooks, functions and realtime, and notifies the organization's members
        /// by email and in the console.
        /// </para>
        /// </summary>
        public Task<Models.Monitor> CreateHttpMonitor(string monitorId, string name, string url, Appwrite.Enums.MonitorMethod? method = null, object? headers = null, string? body = null, List<string>? rules = null, long? interval = null, long? timeout = null, long? cooldown = null, bool? enabled = null, List<string>? notify = null, Appwrite.Enums.MonitorSeverity? severity = null, string? escalationId = null)
        {
            var apiPath = "/monitors/http";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "monitorId", monitorId },
                { "name", name },
                { "url", url },
                { "method", method?.Value },
                { "headers", headers },
                { "body", body },
                { "rules", rules },
                { "interval", interval },
                { "timeout", timeout },
                { "cooldown", cooldown },
                { "enabled", enabled },
                { "notify", notify },
                { "severity", severity?.Value },
                { "escalationId", escalationId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Monitor Convert(Dictionary<string, object> it)
            {
                return Models.Monitor.From(map: it);
            }

            return _client.Call<Models.Monitor>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an HTTP monitor by its unique ID. Only the parameters passed change;
        /// the monitor's state, its last check and its open alert are kept. Passing
        /// `rules` replaces all of them.
        /// </para>
        /// </summary>
        public Task<Models.Monitor> UpdateHttpMonitor(string monitorId, string? name = null, string? url = null, Appwrite.Enums.MonitorMethod? method = null, object? headers = null, string? body = null, List<string>? rules = null, long? interval = null, long? timeout = null, long? cooldown = null, bool? enabled = null, List<string>? notify = null, Appwrite.Enums.MonitorSeverity? severity = null, string? escalationId = null)
        {
            if (monitorId == "")
            {
                throw new AppwriteException("Missing required parameter: \"monitorId\"");
            }

            var apiPath = "/monitors/http/{monitorId}"
                .Replace("{monitorId}", Client.EncodePath(monitorId));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "url", url },
                { "method", method?.Value },
                { "headers", headers },
                { "body", body },
                { "rules", rules },
                { "interval", interval },
                { "timeout", timeout },
                { "cooldown", cooldown },
                { "enabled", enabled },
                { "notify", notify },
                { "severity", severity?.Value },
                { "escalationId", escalationId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Monitor Convert(Dictionary<string, object> it)
            {
                return Models.Monitor.From(map: it);
            }

            return _client.Call<Models.Monitor>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create an SMTP monitor. It reads a mail server's greeting, sends `EHLO`
        /// and, as its TLS mode asks, upgrades with `STARTTLS` or speaks TLS from the
        /// start, on its own interval. It opens an alert when the server cannot be
        /// reached, refuses the session or fails the TLS handshake, or when its rules
        /// match. It never authenticates or sends mail. Each alert fires the
        /// `monitors.[monitorId].alerts.[alertId].create` event when it opens and
        /// `.update` when a check passes again, for project webhooks, functions and
        /// realtime, and notifies the organization's members by email and in the
        /// console.
        /// </para>
        /// </summary>
        public Task<Models.Monitor> CreateSmtpMonitor(string monitorId, string name, string host, long port, Appwrite.Enums.MonitorTlsMode? tlsMode = null, List<string>? rules = null, long? interval = null, long? timeout = null, long? cooldown = null, bool? enabled = null, List<string>? notify = null, Appwrite.Enums.MonitorSeverity? severity = null, string? escalationId = null)
        {
            var apiPath = "/monitors/smtp";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "monitorId", monitorId },
                { "name", name },
                { "host", host },
                { "port", port },
                { "tlsMode", tlsMode?.Value },
                { "rules", rules },
                { "interval", interval },
                { "timeout", timeout },
                { "cooldown", cooldown },
                { "enabled", enabled },
                { "notify", notify },
                { "severity", severity?.Value },
                { "escalationId", escalationId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Monitor Convert(Dictionary<string, object> it)
            {
                return Models.Monitor.From(map: it);
            }

            return _client.Call<Models.Monitor>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an SMTP monitor by its unique ID. Only the parameters passed change;
        /// the monitor's state, its last check and its open alert are kept. Passing
        /// `rules` replaces all of them.
        /// </para>
        /// </summary>
        public Task<Models.Monitor> UpdateSmtpMonitor(string monitorId, string? name = null, string? host = null, long? port = null, Appwrite.Enums.MonitorTlsMode? tlsMode = null, List<string>? rules = null, long? interval = null, long? timeout = null, long? cooldown = null, bool? enabled = null, List<string>? notify = null, Appwrite.Enums.MonitorSeverity? severity = null, string? escalationId = null)
        {
            if (monitorId == "")
            {
                throw new AppwriteException("Missing required parameter: \"monitorId\"");
            }

            var apiPath = "/monitors/smtp/{monitorId}"
                .Replace("{monitorId}", Client.EncodePath(monitorId));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "host", host },
                { "port", port },
                { "tlsMode", tlsMode?.Value },
                { "rules", rules },
                { "interval", interval },
                { "timeout", timeout },
                { "cooldown", cooldown },
                { "enabled", enabled },
                { "notify", notify },
                { "severity", severity?.Value },
                { "escalationId", escalationId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Monitor Convert(Dictionary<string, object> it)
            {
                return Models.Monitor.From(map: it);
            }

            return _client.Call<Models.Monitor>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a TCP monitor. It opens a connection to a host and port on its own
        /// interval and closes it at once, and opens an alert when the connection
        /// cannot be made, or when its rules match. Each alert fires the
        /// `monitors.[monitorId].alerts.[alertId].create` event when it opens and
        /// `.update` when a check passes again, for project webhooks, functions and
        /// realtime, and notifies the organization's members by email and in the
        /// console.
        /// </para>
        /// </summary>
        public Task<Models.Monitor> CreateTcpMonitor(string monitorId, string name, string host, long port, List<string>? rules = null, long? interval = null, long? timeout = null, long? cooldown = null, bool? enabled = null, List<string>? notify = null, Appwrite.Enums.MonitorSeverity? severity = null, string? escalationId = null)
        {
            var apiPath = "/monitors/tcp";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "monitorId", monitorId },
                { "name", name },
                { "host", host },
                { "port", port },
                { "rules", rules },
                { "interval", interval },
                { "timeout", timeout },
                { "cooldown", cooldown },
                { "enabled", enabled },
                { "notify", notify },
                { "severity", severity?.Value },
                { "escalationId", escalationId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Monitor Convert(Dictionary<string, object> it)
            {
                return Models.Monitor.From(map: it);
            }

            return _client.Call<Models.Monitor>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a TCP monitor by its unique ID. Only the parameters passed change;
        /// the monitor's state, its last check and its open alert are kept. Passing
        /// `rules` replaces all of them.
        /// </para>
        /// </summary>
        public Task<Models.Monitor> UpdateTcpMonitor(string monitorId, string? name = null, string? host = null, long? port = null, List<string>? rules = null, long? interval = null, long? timeout = null, long? cooldown = null, bool? enabled = null, List<string>? notify = null, Appwrite.Enums.MonitorSeverity? severity = null, string? escalationId = null)
        {
            if (monitorId == "")
            {
                throw new AppwriteException("Missing required parameter: \"monitorId\"");
            }

            var apiPath = "/monitors/tcp/{monitorId}"
                .Replace("{monitorId}", Client.EncodePath(monitorId));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "host", host },
                { "port", port },
                { "rules", rules },
                { "interval", interval },
                { "timeout", timeout },
                { "cooldown", cooldown },
                { "enabled", enabled },
                { "notify", notify },
                { "severity", severity?.Value },
                { "escalationId", escalationId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Monitor Convert(Dictionary<string, object> it)
            {
                return Models.Monitor.From(map: it);
            }

            return _client.Call<Models.Monitor>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a usage monitor. It reads a usage metric of the project, or of one
        /// of its databases, buckets, functions or sites, on a schedule, and opens an
        /// alert when all its rules hold. Each alert fires the
        /// `monitors.[monitorId].alerts.[alertId].create` event when it opens and
        /// `.update` when usage recovers, for project webhooks, functions and
        /// realtime, and notifies the confirmed members of the `notify` roles by email
        /// and in the console, or the steps of the escalation set by `escalationId`.
        /// </para>
        /// </summary>
        public Task<Models.Monitor> CreateUsageMonitor(string monitorId, string name, List<string> rules, long? window = null, long? cooldown = null, bool? enabled = null, List<string>? notify = null, Appwrite.Enums.MonitorSeverity? severity = null, string? escalationId = null)
        {
            var apiPath = "/monitors/usage";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "monitorId", monitorId },
                { "name", name },
                { "rules", rules },
                { "window", window },
                { "cooldown", cooldown },
                { "enabled", enabled },
                { "notify", notify },
                { "severity", severity?.Value },
                { "escalationId", escalationId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Monitor Convert(Dictionary<string, object> it)
            {
                return Models.Monitor.From(map: it);
            }

            return _client.Call<Models.Monitor>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update a usage monitor by its unique ID. Only the parameters passed change;
        /// the monitor's state and its open alert are kept. Passing `rules` replaces
        /// all of them.
        /// </para>
        /// </summary>
        public Task<Models.Monitor> UpdateUsageMonitor(string monitorId, string? name = null, List<string>? rules = null, long? window = null, long? cooldown = null, bool? enabled = null, List<string>? notify = null, Appwrite.Enums.MonitorSeverity? severity = null, string? escalationId = null)
        {
            if (monitorId == "")
            {
                throw new AppwriteException("Missing required parameter: \"monitorId\"");
            }

            var apiPath = "/monitors/usage/{monitorId}"
                .Replace("{monitorId}", Client.EncodePath(monitorId));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "rules", rules },
                { "window", window },
                { "cooldown", cooldown },
                { "enabled", enabled },
                { "notify", notify },
                { "severity", severity?.Value },
                { "escalationId", escalationId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.Monitor Convert(Dictionary<string, object> it)
            {
                return Models.Monitor.From(map: it);
            }

            return _client.Call<Models.Monitor>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get a monitor by its unique ID, with its state as of its last evaluation.
        /// </para>
        /// </summary>
        public Task<Models.Monitor> Get(string monitorId)
        {
            if (monitorId == "")
            {
                throw new AppwriteException("Missing required parameter: \"monitorId\"");
            }

            var apiPath = "/monitors/{monitorId}"
                .Replace("{monitorId}", Client.EncodePath(monitorId));

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.Monitor Convert(Dictionary<string, object> it)
            {
                return Models.Monitor.From(map: it);
            }

            return _client.Call<Models.Monitor>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete a monitor by its unique ID. It stops being evaluated; an alert it is
        /// firing is resolved and kept with the rest of its alert history.
        /// </para>
        /// </summary>
        public Task<object> Delete(string monitorId)
        {
            if (monitorId == "")
            {
                throw new AppwriteException("Missing required parameter: \"monitorId\"");
            }

            var apiPath = "/monitors/{monitorId}"
                .Replace("{monitorId}", Client.EncodePath(monitorId));

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

    }
}
