using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Analytics : Service
    {
        public Analytics(Client client) : base(client)
        {
        }

        /// <para>
        /// List analytics properties for the current project.
        /// </para>
        /// </summary>
        public Task<Models.AnalyticsPropertyList> ListProperties(List<string>? queries = null, string? search = null, bool? total = null)
        {
            var apiPath = "/analytics/properties";

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


            static Models.AnalyticsPropertyList Convert(Dictionary<string, object> it)
            {
                return Models.AnalyticsPropertyList.From(map: it);
            }

            return _client.Call<Models.AnalyticsPropertyList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create a new analytics property to track a website or application.
        /// </para>
        /// </summary>
        public Task<Models.AnalyticsProperty> CreateProperty(string propertyId, string name, string? domain = null, bool? enabled = null, List<string>? allowedOrigins = null, bool? identifyUsers = null, Appwrite.Enums.AnalyticsPropertyType? type = null)
        {
            var apiPath = "/analytics/properties";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "propertyId", propertyId },
                { "name", name },
                { "domain", domain },
                { "enabled", enabled },
                { "allowedOrigins", allowedOrigins },
                { "identifyUsers", identifyUsers },
                { "type", type?.Value }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.AnalyticsProperty Convert(Dictionary<string, object> it)
            {
                return Models.AnalyticsProperty.From(map: it);
            }

            return _client.Call<Models.AnalyticsProperty>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get an analytics property by ID.
        /// </para>
        /// </summary>
        public Task<Models.AnalyticsProperty> GetProperty(string propertyId)
        {
            if (propertyId == "")
            {
                throw new AppwriteException("Missing required parameter: \"propertyId\"");
            }

            var apiPath = "/analytics/properties/{propertyId}"
                .Replace("{propertyId}", Client.EncodePath(propertyId));

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.AnalyticsProperty Convert(Dictionary<string, object> it)
            {
                return Models.AnalyticsProperty.From(map: it);
            }

            return _client.Call<Models.AnalyticsProperty>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an analytics property. Only the attributes you pass are changed;
        /// omitted attributes keep their current value.
        /// </para>
        /// </summary>
        public Task<Models.AnalyticsProperty> UpdateProperty(string propertyId, string? name = null, string? domain = null, bool? enabled = null, List<string>? allowedOrigins = null, bool? identifyUsers = null, Appwrite.Enums.AnalyticsPropertyType? type = null)
        {
            if (propertyId == "")
            {
                throw new AppwriteException("Missing required parameter: \"propertyId\"");
            }

            var apiPath = "/analytics/properties/{propertyId}"
                .Replace("{propertyId}", Client.EncodePath(propertyId));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "domain", domain },
                { "enabled", enabled },
                { "allowedOrigins", allowedOrigins },
                { "identifyUsers", identifyUsers },
                { "type", type?.Value }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.AnalyticsProperty Convert(Dictionary<string, object> it)
            {
                return Models.AnalyticsProperty.From(map: it);
            }

            return _client.Call<Models.AnalyticsProperty>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete an analytics property along with every event and session collected
        /// for it. This cannot be undone.
        /// </para>
        /// </summary>
        public Task<object> DeleteProperty(string propertyId)
        {
            if (propertyId == "")
            {
                throw new AppwriteException("Missing required parameter: \"propertyId\"");
            }

            var apiPath = "/analytics/properties/{propertyId}"
                .Replace("{propertyId}", Client.EncodePath(propertyId));

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
        /// List the annotations of an analytics property. Filter on `date` to fetch
        /// the annotations inside a chart's time range.
        /// </para>
        /// </summary>
        public Task<Models.AnalyticsAnnotationList> ListAnnotations(string propertyId, List<string>? queries = null, bool? total = null)
        {
            if (propertyId == "")
            {
                throw new AppwriteException("Missing required parameter: \"propertyId\"");
            }

            var apiPath = "/analytics/properties/{propertyId}/annotations"
                .Replace("{propertyId}", Client.EncodePath(propertyId));

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


            static Models.AnalyticsAnnotationList Convert(Dictionary<string, object> it)
            {
                return Models.AnalyticsAnnotationList.From(map: it);
            }

            return _client.Call<Models.AnalyticsAnnotationList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Create an annotation that marks a point in time on an analytics property's
        /// charts.
        /// </para>
        /// </summary>
        public Task<Models.AnalyticsAnnotation> CreateAnnotation(string propertyId, string annotationId, string date, string content)
        {
            if (propertyId == "")
            {
                throw new AppwriteException("Missing required parameter: \"propertyId\"");
            }

            var apiPath = "/analytics/properties/{propertyId}/annotations"
                .Replace("{propertyId}", Client.EncodePath(propertyId));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "annotationId", annotationId },
                { "date", date },
                { "content", content }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.AnalyticsAnnotation Convert(Dictionary<string, object> it)
            {
                return Models.AnalyticsAnnotation.From(map: it);
            }

            return _client.Call<Models.AnalyticsAnnotation>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Get an analytics annotation by ID.
        /// </para>
        /// </summary>
        public Task<Models.AnalyticsAnnotation> GetAnnotation(string propertyId, string annotationId)
        {
            if (propertyId == "")
            {
                throw new AppwriteException("Missing required parameter: \"propertyId\"");
            }

            if (annotationId == "")
            {
                throw new AppwriteException("Missing required parameter: \"annotationId\"");
            }

            var apiPath = "/analytics/properties/{propertyId}/annotations/{annotationId}"
                .Replace("{propertyId}", Client.EncodePath(propertyId))
                .Replace("{annotationId}", Client.EncodePath(annotationId));

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.AnalyticsAnnotation Convert(Dictionary<string, object> it)
            {
                return Models.AnalyticsAnnotation.From(map: it);
            }

            return _client.Call<Models.AnalyticsAnnotation>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Update an analytics annotation. Only the attributes you pass are changed;
        /// omitted attributes keep their current value.
        /// </para>
        /// </summary>
        public Task<Models.AnalyticsAnnotation> UpdateAnnotation(string propertyId, string annotationId, string? date = null, string? content = null)
        {
            if (propertyId == "")
            {
                throw new AppwriteException("Missing required parameter: \"propertyId\"");
            }

            if (annotationId == "")
            {
                throw new AppwriteException("Missing required parameter: \"annotationId\"");
            }

            var apiPath = "/analytics/properties/{propertyId}/annotations/{annotationId}"
                .Replace("{propertyId}", Client.EncodePath(propertyId))
                .Replace("{annotationId}", Client.EncodePath(annotationId));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "date", date },
                { "content", content }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };


            static Models.AnalyticsAnnotation Convert(Dictionary<string, object> it)
            {
                return Models.AnalyticsAnnotation.From(map: it);
            }

            return _client.Call<Models.AnalyticsAnnotation>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <para>
        /// Delete an analytics annotation.
        /// </para>
        /// </summary>
        public Task<object> DeleteAnnotation(string propertyId, string annotationId)
        {
            if (propertyId == "")
            {
                throw new AppwriteException("Missing required parameter: \"propertyId\"");
            }

            if (annotationId == "")
            {
                throw new AppwriteException("Missing required parameter: \"annotationId\"");
            }

            var apiPath = "/analytics/properties/{propertyId}/annotations/{annotationId}"
                .Replace("{propertyId}", Client.EncodePath(propertyId))
                .Replace("{annotationId}", Client.EncodePath(annotationId));

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
        /// Send a tracking event from a browser, native app, or server-side SDK.
        /// </para>
        /// </summary>
        public Task<object> CreateEvent(string propertyId, string name, string url, string? domain = null, string? referrer = null, long? screenWidth = null, string? sessionHash = null, long? scrollDepth = null, long? engagementTime = null, List<string>? props = null, string? userId = null, string? ip = null, string? userAgent = null, bool? interactive = null)
        {
            if (propertyId == "")
            {
                throw new AppwriteException("Missing required parameter: \"propertyId\"");
            }

            var apiPath = "/analytics/properties/{propertyId}/events"
                .Replace("{propertyId}", Client.EncodePath(propertyId));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "url", url },
                { "domain", domain },
                { "referrer", referrer },
                { "screenWidth", screenWidth },
                { "sessionHash", sessionHash },
                { "scrollDepth", scrollDepth },
                { "engagementTime", engagementTime },
                { "props", props },
                { "userId", userId },
                { "ip", ip },
                { "userAgent", userAgent },
                { "interactive", interactive }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "content-type", "application/json" },
                { "accept", "application/json" }
            };



            return _client.Call<object>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <para>
        /// Read analytics metrics (visitors, sessions, pageviews, events, bounceRate,
        /// …) for a property over a date range.
        /// 
        /// **Three response shapes**, chosen by `dimensions[]` and `interval`:
        /// - Neither: one row aggregating the whole window, with `value` and `date`
        /// null. Only this shape carries `visits`, `bounceRate`, `visitDuration`,
        /// `viewsPerVisit`, `scrollDepth` and `engagementTime`.
        /// - `dimensions[]`: one row per dimension value, ranked by visitors, with
        /// `value` set and `date` null.
        /// - `interval`: one row per time bucket in chronological order, with `date`
        /// set and `value` null.
        /// 
        /// `pageviews` is carried by the flat aggregate and by `interval`, but not by
        /// a breakdown.
        /// 
        /// `userId` and `users` cover identified traffic only: events sent with an API
        /// key's `userId`, or from a signed-in session on a property with
        /// `identifyUsers` on. A `userId` breakdown leaves out anonymous events;
        /// returned values are the project's user IDs.
        /// 
        /// Custom event props: `dimensions[]=props` ranks the prop keys seen in the
        /// window, and adding `propKey` ranks the values of that one key. `queries[]`
        /// filters on a prop's value with the `props.<key>` attribute, e.g.
        /// `equal("props.plan", ["pro"])`.
        /// 
        /// Combining `dimensions[]` with `interval` is not supported yet. `queries[]`
        /// filters the underlying events using standard Utopia query syntax.
        /// </para>
        /// </summary>
        public Task<Models.AnalyticsMetricList> ListMetrics(string propertyId, List<string>? queries = null, Appwrite.Enums.AnalyticsInterval? interval = null, List<Appwrite.Enums.AnalyticsDimension>? dimensions = null, string? propKey = null, string? dateRange = null, string? startAt = null, string? endAt = null, long? limit = null, bool? total = null)
        {
            if (propertyId == "")
            {
                throw new AppwriteException("Missing required parameter: \"propertyId\"");
            }

            var apiPath = "/analytics/properties/{propertyId}/metrics"
                .Replace("{propertyId}", Client.EncodePath(propertyId));

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "interval", interval?.Value },
                { "dimensions", dimensions?.Select(e => e.Value).ToList() },
                { "propKey", propKey },
                { "dateRange", dateRange },
                { "startAt", startAt },
                { "endAt", endAt },
                { "limit", limit },
                { "total", total }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "X-Appwrite-Project", _client.GetConfig("project") },
                { "accept", "application/json" }
            };


            static Models.AnalyticsMetricList Convert(Dictionary<string, object> it)
            {
                return Models.AnalyticsMetricList.From(map: it);
            }

            return _client.Call<Models.AnalyticsMetricList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

    }
}
