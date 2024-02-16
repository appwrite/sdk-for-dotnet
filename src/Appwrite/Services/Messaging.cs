
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Messaging : Service
    {
        public Messaging(Client client) : base(client)
        {
        }

        /// <summary>
        /// List messages
        /// </summary>
        public Task<Models.MessageList> ListMessages(List<string>? queries = null, string? search = null)
        {
            var apiPath = "/messaging/messages";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.MessageList Convert(Dictionary<string, object> it) =>
                Models.MessageList.From(map: it);


            return _client.Call<Models.MessageList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create an email.
        /// </summary>
        public Task<Models.Message> CreateEmail(string messageId, string subject, string content, List<string>? topics = null, List<string>? users = null, List<string>? targets = null, List<string>? cc = null, List<string>? bcc = null, MessageStatus? status = null, bool? html = null, string? scheduledAt = null)
        {
            var apiPath = "/messaging/messages/email";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "messageId", messageId },
                { "subject", subject },
                { "content", content },
                { "topics", topics },
                { "users", users },
                { "targets", targets },
                { "cc", cc },
                { "bcc", bcc },
                { "status", status },
                { "html", html },
                { "scheduledAt", scheduledAt }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Message Convert(Dictionary<string, object> it) =>
                Models.Message.From(map: it);


            return _client.Call<Models.Message>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update an email.
        /// </summary>
        public Task<Models.Message> UpdateEmail(string messageId, List<string>? topics = null, List<string>? users = null, List<string>? targets = null, string? subject = null, string? content = null, MessageStatus? status = null, bool? html = null, List<string>? cc = null, List<string>? bcc = null, string? scheduledAt = null)
        {
            var apiPath = "/messaging/messages/email/{messageId}"
                .Replace("{messageId}", messageId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "topics", topics },
                { "users", users },
                { "targets", targets },
                { "subject", subject },
                { "content", content },
                { "status", status },
                { "html", html },
                { "cc", cc },
                { "bcc", bcc },
                { "scheduledAt", scheduledAt }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Message Convert(Dictionary<string, object> it) =>
                Models.Message.From(map: it);


            return _client.Call<Models.Message>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create a push notification.
        /// </summary>
        public Task<Models.Message> CreatePush(string messageId, string title, string body, List<string>? topics = null, List<string>? users = null, List<string>? targets = null, object? data = null, string? action = null, string? icon = null, string? sound = null, string? color = null, string? tag = null, string? badge = null, MessageStatus? status = null, string? scheduledAt = null)
        {
            var apiPath = "/messaging/messages/push";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "messageId", messageId },
                { "title", title },
                { "body", body },
                { "topics", topics },
                { "users", users },
                { "targets", targets },
                { "data", data },
                { "action", action },
                { "icon", icon },
                { "sound", sound },
                { "color", color },
                { "tag", tag },
                { "badge", badge },
                { "status", status },
                { "scheduledAt", scheduledAt }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Message Convert(Dictionary<string, object> it) =>
                Models.Message.From(map: it);


            return _client.Call<Models.Message>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update a push notification.
        /// </summary>
        public Task<Models.Message> UpdatePush(string messageId, List<string>? topics = null, List<string>? users = null, List<string>? targets = null, string? title = null, string? body = null, object? data = null, string? action = null, string? icon = null, string? sound = null, string? color = null, string? tag = null, long? badge = null, MessageStatus? status = null, string? scheduledAt = null)
        {
            var apiPath = "/messaging/messages/push/{messageId}"
                .Replace("{messageId}", messageId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "topics", topics },
                { "users", users },
                { "targets", targets },
                { "title", title },
                { "body", body },
                { "data", data },
                { "action", action },
                { "icon", icon },
                { "sound", sound },
                { "color", color },
                { "tag", tag },
                { "badge", badge },
                { "status", status },
                { "scheduledAt", scheduledAt }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Message Convert(Dictionary<string, object> it) =>
                Models.Message.From(map: it);


            return _client.Call<Models.Message>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create an SMS.
        /// </summary>
        public Task<Models.Message> CreateSMS(string messageId, string content, List<string>? topics = null, List<string>? users = null, List<string>? targets = null, MessageStatus? status = null, string? scheduledAt = null)
        {
            var apiPath = "/messaging/messages/sms";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "messageId", messageId },
                { "content", content },
                { "topics", topics },
                { "users", users },
                { "targets", targets },
                { "status", status },
                { "scheduledAt", scheduledAt }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Message Convert(Dictionary<string, object> it) =>
                Models.Message.From(map: it);


            return _client.Call<Models.Message>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update an SMS.
        /// </summary>
        public Task<Models.Message> UpdateSMS(string messageId, List<string>? topics = null, List<string>? users = null, List<string>? targets = null, string? content = null, MessageStatus? status = null, string? scheduledAt = null)
        {
            var apiPath = "/messaging/messages/sms/{messageId}"
                .Replace("{messageId}", messageId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "topics", topics },
                { "users", users },
                { "targets", targets },
                { "content", content },
                { "status", status },
                { "scheduledAt", scheduledAt }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Message Convert(Dictionary<string, object> it) =>
                Models.Message.From(map: it);


            return _client.Call<Models.Message>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get a message
        /// </summary>
        public Task<Models.Message> GetMessage(string messageId)
        {
            var apiPath = "/messaging/messages/{messageId}"
                .Replace("{messageId}", messageId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Message Convert(Dictionary<string, object> it) =>
                Models.Message.From(map: it);


            return _client.Call<Models.Message>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Delete a message
        /// </summary>
        public Task<object> Delete(string messageId)
        {
            var apiPath = "/messaging/messages/{messageId}"
                .Replace("{messageId}", messageId);

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
        /// List message logs
        /// </summary>
        public Task<Models.LogList> ListMessageLogs(string messageId, List<string>? queries = null)
        {
            var apiPath = "/messaging/messages/{messageId}/logs"
                .Replace("{messageId}", messageId);

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
        /// List message targets
        /// <para>
        /// List the targets associated with a message as set via the targets
        /// attribute.
        /// </para>
        /// </summary>
        public Task<Models.TargetList> ListTargets(string messageId, List<string>? queries = null)
        {
            var apiPath = "/messaging/messages/{messageId}/targets"
                .Replace("{messageId}", messageId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.TargetList Convert(Dictionary<string, object> it) =>
                Models.TargetList.From(map: it);


            return _client.Call<Models.TargetList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// List providers
        /// </summary>
        public Task<Models.ProviderList> ListProviders(List<string>? queries = null, string? search = null)
        {
            var apiPath = "/messaging/providers";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.ProviderList Convert(Dictionary<string, object> it) =>
                Models.ProviderList.From(map: it);


            return _client.Call<Models.ProviderList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create APNS provider
        /// </summary>
        public Task<Models.Provider> CreateAPNSProvider(string providerId, string name, string? authKey = null, string? authKeyId = null, string? teamId = null, string? bundleId = null, bool? enabled = null)
        {
            var apiPath = "/messaging/providers/apns";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "providerId", providerId },
                { "name", name },
                { "authKey", authKey },
                { "authKeyId", authKeyId },
                { "teamId", teamId },
                { "bundleId", bundleId },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Provider Convert(Dictionary<string, object> it) =>
                Models.Provider.From(map: it);


            return _client.Call<Models.Provider>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update APNS provider
        /// </summary>
        public Task<Models.Provider> UpdateAPNSProvider(string providerId, string? name = null, bool? enabled = null, string? authKey = null, string? authKeyId = null, string? teamId = null, string? bundleId = null)
        {
            var apiPath = "/messaging/providers/apns/{providerId}"
                .Replace("{providerId}", providerId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "enabled", enabled },
                { "authKey", authKey },
                { "authKeyId", authKeyId },
                { "teamId", teamId },
                { "bundleId", bundleId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Provider Convert(Dictionary<string, object> it) =>
                Models.Provider.From(map: it);


            return _client.Call<Models.Provider>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create FCM provider
        /// </summary>
        public Task<Models.Provider> CreateFCMProvider(string providerId, string name, object? serviceAccountJSON = null, bool? enabled = null)
        {
            var apiPath = "/messaging/providers/fcm";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "providerId", providerId },
                { "name", name },
                { "serviceAccountJSON", serviceAccountJSON },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Provider Convert(Dictionary<string, object> it) =>
                Models.Provider.From(map: it);


            return _client.Call<Models.Provider>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update FCM provider
        /// </summary>
        public Task<Models.Provider> UpdateFCMProvider(string providerId, string? name = null, bool? enabled = null, object? serviceAccountJSON = null)
        {
            var apiPath = "/messaging/providers/fcm/{providerId}"
                .Replace("{providerId}", providerId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "enabled", enabled },
                { "serviceAccountJSON", serviceAccountJSON }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Provider Convert(Dictionary<string, object> it) =>
                Models.Provider.From(map: it);


            return _client.Call<Models.Provider>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create Mailgun provider
        /// </summary>
        public Task<Models.Provider> CreateMailgunProvider(string providerId, string name, string? apiKey = null, string? domain = null, bool? isEuRegion = null, string? fromName = null, string? fromEmail = null, string? replyToName = null, string? replyToEmail = null, bool? enabled = null)
        {
            var apiPath = "/messaging/providers/mailgun";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "providerId", providerId },
                { "name", name },
                { "apiKey", apiKey },
                { "domain", domain },
                { "isEuRegion", isEuRegion },
                { "fromName", fromName },
                { "fromEmail", fromEmail },
                { "replyToName", replyToName },
                { "replyToEmail", replyToEmail },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Provider Convert(Dictionary<string, object> it) =>
                Models.Provider.From(map: it);


            return _client.Call<Models.Provider>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update Mailgun provider
        /// </summary>
        public Task<Models.Provider> UpdateMailgunProvider(string providerId, string? name = null, string? apiKey = null, string? domain = null, bool? isEuRegion = null, bool? enabled = null, string? fromName = null, string? fromEmail = null, string? replyToName = null, string? replyToEmail = null)
        {
            var apiPath = "/messaging/providers/mailgun/{providerId}"
                .Replace("{providerId}", providerId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "apiKey", apiKey },
                { "domain", domain },
                { "isEuRegion", isEuRegion },
                { "enabled", enabled },
                { "fromName", fromName },
                { "fromEmail", fromEmail },
                { "replyToName", replyToName },
                { "replyToEmail", replyToEmail }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Provider Convert(Dictionary<string, object> it) =>
                Models.Provider.From(map: it);


            return _client.Call<Models.Provider>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create Msg91 provider
        /// </summary>
        public Task<Models.Provider> CreateMsg91Provider(string providerId, string name, string? xfrom = null, string? senderId = null, string? authKey = null, bool? enabled = null)
        {
            var apiPath = "/messaging/providers/msg91";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "providerId", providerId },
                { "name", name },
                { "from", xfrom },
                { "senderId", senderId },
                { "authKey", authKey },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Provider Convert(Dictionary<string, object> it) =>
                Models.Provider.From(map: it);


            return _client.Call<Models.Provider>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update Msg91 provider
        /// </summary>
        public Task<Models.Provider> UpdateMsg91Provider(string providerId, string? name = null, bool? enabled = null, string? senderId = null, string? authKey = null, string? xfrom = null)
        {
            var apiPath = "/messaging/providers/msg91/{providerId}"
                .Replace("{providerId}", providerId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "enabled", enabled },
                { "senderId", senderId },
                { "authKey", authKey },
                { "from", xfrom }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Provider Convert(Dictionary<string, object> it) =>
                Models.Provider.From(map: it);


            return _client.Call<Models.Provider>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create Sendgrid provider
        /// </summary>
        public Task<Models.Provider> CreateSendgridProvider(string providerId, string name, string? apiKey = null, string? fromName = null, string? fromEmail = null, string? replyToName = null, string? replyToEmail = null, bool? enabled = null)
        {
            var apiPath = "/messaging/providers/sendgrid";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "providerId", providerId },
                { "name", name },
                { "apiKey", apiKey },
                { "fromName", fromName },
                { "fromEmail", fromEmail },
                { "replyToName", replyToName },
                { "replyToEmail", replyToEmail },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Provider Convert(Dictionary<string, object> it) =>
                Models.Provider.From(map: it);


            return _client.Call<Models.Provider>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update Sendgrid provider
        /// </summary>
        public Task<Models.Provider> UpdateSendgridProvider(string providerId, string? name = null, bool? enabled = null, string? apiKey = null, string? fromName = null, string? fromEmail = null, string? replyToName = null, string? replyToEmail = null)
        {
            var apiPath = "/messaging/providers/sendgrid/{providerId}"
                .Replace("{providerId}", providerId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "enabled", enabled },
                { "apiKey", apiKey },
                { "fromName", fromName },
                { "fromEmail", fromEmail },
                { "replyToName", replyToName },
                { "replyToEmail", replyToEmail }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Provider Convert(Dictionary<string, object> it) =>
                Models.Provider.From(map: it);


            return _client.Call<Models.Provider>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create SMTP provider
        /// </summary>
        public Task<Models.Provider> CreateSMTPProvider(string providerId, string name, string host, long? port = null, string? username = null, string? password = null, SMTPEncryption? encryption = null, bool? autoTLS = null, string? mailer = null, string? fromName = null, string? fromEmail = null, string? replyToName = null, string? replyToEmail = null, bool? enabled = null)
        {
            var apiPath = "/messaging/providers/smtp";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "providerId", providerId },
                { "name", name },
                { "host", host },
                { "port", port },
                { "username", username },
                { "password", password },
                { "encryption", encryption },
                { "autoTLS", autoTLS },
                { "mailer", mailer },
                { "fromName", fromName },
                { "fromEmail", fromEmail },
                { "replyToName", replyToName },
                { "replyToEmail", replyToEmail },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Provider Convert(Dictionary<string, object> it) =>
                Models.Provider.From(map: it);


            return _client.Call<Models.Provider>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update SMTP provider
        /// </summary>
        public Task<Models.Provider> UpdateSMTPProvider(string providerId, string? name = null, string? host = null, long? port = null, string? username = null, string? password = null, SMTPEncryption? encryption = null, bool? autoTLS = null, string? mailer = null, string? fromName = null, string? fromEmail = null, string? replyToName = null, string? replyToEmail = null, bool? enabled = null)
        {
            var apiPath = "/messaging/providers/smtp/{providerId}"
                .Replace("{providerId}", providerId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "host", host },
                { "port", port },
                { "username", username },
                { "password", password },
                { "encryption", encryption },
                { "autoTLS", autoTLS },
                { "mailer", mailer },
                { "fromName", fromName },
                { "fromEmail", fromEmail },
                { "replyToName", replyToName },
                { "replyToEmail", replyToEmail },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Provider Convert(Dictionary<string, object> it) =>
                Models.Provider.From(map: it);


            return _client.Call<Models.Provider>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create Telesign provider
        /// </summary>
        public Task<Models.Provider> CreateTelesignProvider(string providerId, string name, string? xfrom = null, string? customerId = null, string? apiKey = null, bool? enabled = null)
        {
            var apiPath = "/messaging/providers/telesign";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "providerId", providerId },
                { "name", name },
                { "from", xfrom },
                { "customerId", customerId },
                { "apiKey", apiKey },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Provider Convert(Dictionary<string, object> it) =>
                Models.Provider.From(map: it);


            return _client.Call<Models.Provider>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update Telesign provider
        /// </summary>
        public Task<Models.Provider> UpdateTelesignProvider(string providerId, string? name = null, bool? enabled = null, string? customerId = null, string? apiKey = null, string? xfrom = null)
        {
            var apiPath = "/messaging/providers/telesign/{providerId}"
                .Replace("{providerId}", providerId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "enabled", enabled },
                { "customerId", customerId },
                { "apiKey", apiKey },
                { "from", xfrom }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Provider Convert(Dictionary<string, object> it) =>
                Models.Provider.From(map: it);


            return _client.Call<Models.Provider>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create Textmagic provider
        /// </summary>
        public Task<Models.Provider> CreateTextmagicProvider(string providerId, string name, string? xfrom = null, string? username = null, string? apiKey = null, bool? enabled = null)
        {
            var apiPath = "/messaging/providers/textmagic";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "providerId", providerId },
                { "name", name },
                { "from", xfrom },
                { "username", username },
                { "apiKey", apiKey },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Provider Convert(Dictionary<string, object> it) =>
                Models.Provider.From(map: it);


            return _client.Call<Models.Provider>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update Textmagic provider
        /// </summary>
        public Task<Models.Provider> UpdateTextmagicProvider(string providerId, string? name = null, bool? enabled = null, string? username = null, string? apiKey = null, string? xfrom = null)
        {
            var apiPath = "/messaging/providers/textmagic/{providerId}"
                .Replace("{providerId}", providerId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "enabled", enabled },
                { "username", username },
                { "apiKey", apiKey },
                { "from", xfrom }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Provider Convert(Dictionary<string, object> it) =>
                Models.Provider.From(map: it);


            return _client.Call<Models.Provider>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create Twilio provider
        /// </summary>
        public Task<Models.Provider> CreateTwilioProvider(string providerId, string name, string? xfrom = null, string? accountSid = null, string? authToken = null, bool? enabled = null)
        {
            var apiPath = "/messaging/providers/twilio";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "providerId", providerId },
                { "name", name },
                { "from", xfrom },
                { "accountSid", accountSid },
                { "authToken", authToken },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Provider Convert(Dictionary<string, object> it) =>
                Models.Provider.From(map: it);


            return _client.Call<Models.Provider>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update Twilio provider
        /// </summary>
        public Task<Models.Provider> UpdateTwilioProvider(string providerId, string? name = null, bool? enabled = null, string? accountSid = null, string? authToken = null, string? xfrom = null)
        {
            var apiPath = "/messaging/providers/twilio/{providerId}"
                .Replace("{providerId}", providerId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "enabled", enabled },
                { "accountSid", accountSid },
                { "authToken", authToken },
                { "from", xfrom }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Provider Convert(Dictionary<string, object> it) =>
                Models.Provider.From(map: it);


            return _client.Call<Models.Provider>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create Vonage provider
        /// </summary>
        public Task<Models.Provider> CreateVonageProvider(string providerId, string name, string? xfrom = null, string? apiKey = null, string? apiSecret = null, bool? enabled = null)
        {
            var apiPath = "/messaging/providers/vonage";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "providerId", providerId },
                { "name", name },
                { "from", xfrom },
                { "apiKey", apiKey },
                { "apiSecret", apiSecret },
                { "enabled", enabled }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Provider Convert(Dictionary<string, object> it) =>
                Models.Provider.From(map: it);


            return _client.Call<Models.Provider>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update Vonage provider
        /// </summary>
        public Task<Models.Provider> UpdateVonageProvider(string providerId, string? name = null, bool? enabled = null, string? apiKey = null, string? apiSecret = null, string? xfrom = null)
        {
            var apiPath = "/messaging/providers/vonage/{providerId}"
                .Replace("{providerId}", providerId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "enabled", enabled },
                { "apiKey", apiKey },
                { "apiSecret", apiSecret },
                { "from", xfrom }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Provider Convert(Dictionary<string, object> it) =>
                Models.Provider.From(map: it);


            return _client.Call<Models.Provider>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get provider
        /// </summary>
        public Task<Models.Provider> GetProvider(string providerId)
        {
            var apiPath = "/messaging/providers/{providerId}"
                .Replace("{providerId}", providerId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Provider Convert(Dictionary<string, object> it) =>
                Models.Provider.From(map: it);


            return _client.Call<Models.Provider>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Delete provider
        /// </summary>
        public Task<object> DeleteProvider(string providerId)
        {
            var apiPath = "/messaging/providers/{providerId}"
                .Replace("{providerId}", providerId);

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
        /// List provider logs
        /// </summary>
        public Task<Models.LogList> ListProviderLogs(string providerId, List<string>? queries = null)
        {
            var apiPath = "/messaging/providers/{providerId}/logs"
                .Replace("{providerId}", providerId);

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
        /// List subscriber logs
        /// </summary>
        public Task<Models.LogList> ListSubscriberLogs(string subscriberId, List<string>? queries = null)
        {
            var apiPath = "/messaging/subscribers/{subscriberId}/logs"
                .Replace("{subscriberId}", subscriberId);

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
        /// List topics.
        /// </summary>
        public Task<Models.TopicList> ListTopics(List<string>? queries = null, string? search = null)
        {
            var apiPath = "/messaging/topics";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.TopicList Convert(Dictionary<string, object> it) =>
                Models.TopicList.From(map: it);


            return _client.Call<Models.TopicList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create a topic.
        /// </summary>
        public Task<Models.Topic> CreateTopic(string topicId, string name, List<string>? subscribe = null)
        {
            var apiPath = "/messaging/topics";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "topicId", topicId },
                { "name", name },
                { "subscribe", subscribe }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Topic Convert(Dictionary<string, object> it) =>
                Models.Topic.From(map: it);


            return _client.Call<Models.Topic>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get a topic.
        /// </summary>
        public Task<Models.Topic> GetTopic(string topicId)
        {
            var apiPath = "/messaging/topics/{topicId}"
                .Replace("{topicId}", topicId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Topic Convert(Dictionary<string, object> it) =>
                Models.Topic.From(map: it);


            return _client.Call<Models.Topic>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update a topic.
        /// </summary>
        public Task<Models.Topic> UpdateTopic(string topicId, string? name = null)
        {
            var apiPath = "/messaging/topics/{topicId}"
                .Replace("{topicId}", topicId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Topic Convert(Dictionary<string, object> it) =>
                Models.Topic.From(map: it);


            return _client.Call<Models.Topic>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Delete a topic.
        /// </summary>
        public Task<object> DeleteTopic(string topicId)
        {
            var apiPath = "/messaging/topics/{topicId}"
                .Replace("{topicId}", topicId);

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
        /// List topic logs
        /// </summary>
        public Task<Models.LogList> ListTopicLogs(string topicId, List<string>? queries = null)
        {
            var apiPath = "/messaging/topics/{topicId}/logs"
                .Replace("{topicId}", topicId);

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
        /// List subscribers.
        /// </summary>
        public Task<Models.SubscriberList> ListSubscribers(string topicId, List<string>? queries = null, string? search = null)
        {
            var apiPath = "/messaging/topics/{topicId}/subscribers"
                .Replace("{topicId}", topicId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries },
                { "search", search }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.SubscriberList Convert(Dictionary<string, object> it) =>
                Models.SubscriberList.From(map: it);


            return _client.Call<Models.SubscriberList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create a subscriber.
        /// </summary>
        public Task<Models.Subscriber> CreateSubscriber(string topicId, string subscriberId, string targetId)
        {
            var apiPath = "/messaging/topics/{topicId}/subscribers"
                .Replace("{topicId}", topicId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "subscriberId", subscriberId },
                { "targetId", targetId }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Subscriber Convert(Dictionary<string, object> it) =>
                Models.Subscriber.From(map: it);


            return _client.Call<Models.Subscriber>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get a subscriber.
        /// </summary>
        public Task<Models.Subscriber> GetSubscriber(string topicId, string subscriberId)
        {
            var apiPath = "/messaging/topics/{topicId}/subscribers/{subscriberId}"
                .Replace("{topicId}", topicId)
                .Replace("{subscriberId}", subscriberId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Subscriber Convert(Dictionary<string, object> it) =>
                Models.Subscriber.From(map: it);


            return _client.Call<Models.Subscriber>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Delete a subscriber.
        /// </summary>
        public Task<object> DeleteSubscriber(string topicId, string subscriberId)
        {
            var apiPath = "/messaging/topics/{topicId}/subscribers/{subscriberId}"
                .Replace("{topicId}", topicId)
                .Replace("{subscriberId}", subscriberId);

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

    }
}
