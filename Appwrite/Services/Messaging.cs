
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
        /// <para>
        /// Get a list of all messages from the current Appwrite project.
        /// </para>
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
        /// Create email
        /// <para>
        /// Create a new email message.
        /// </para>
        /// </summary>
        public Task<Models.Message> CreateEmail(string messageId, string subject, string content, List<string>? topics = null, List<string>? users = null, List<string>? targets = null, List<string>? cc = null, List<string>? bcc = null, List<string>? attachments = null, bool? draft = null, bool? html = null, string? scheduledAt = null)
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
                { "attachments", attachments },
                { "draft", draft },
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
        /// Update email
        /// <para>
        /// Update an email message by its unique ID.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.Message> UpdateEmail(string messageId, List<string>? topics = null, List<string>? users = null, List<string>? targets = null, string? subject = null, string? content = null, bool? draft = null, bool? html = null, List<string>? cc = null, List<string>? bcc = null, string? scheduledAt = null, List<string>? attachments = null)
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
                { "draft", draft },
                { "html", html },
                { "cc", cc },
                { "bcc", bcc },
                { "scheduledAt", scheduledAt },
                { "attachments", attachments }
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
        /// Create push notification
        /// <para>
        /// Create a new push notification.
        /// </para>
        /// </summary>
        public Task<Models.Message> CreatePush(string messageId, string? title = null, string? body = null, List<string>? topics = null, List<string>? users = null, List<string>? targets = null, object? data = null, string? action = null, string? image = null, string? icon = null, string? sound = null, string? color = null, string? tag = null, long? badge = null, bool? draft = null, string? scheduledAt = null, bool? contentAvailable = null, bool? critical = null, Appwrite.Enums.MessagePriority? priority = null)
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
                { "image", image },
                { "icon", icon },
                { "sound", sound },
                { "color", color },
                { "tag", tag },
                { "badge", badge },
                { "draft", draft },
                { "scheduledAt", scheduledAt },
                { "contentAvailable", contentAvailable },
                { "critical", critical },
                { "priority", priority }
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
        /// Update push notification
        /// <para>
        /// Update a push notification by its unique ID.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.Message> UpdatePush(string messageId, List<string>? topics = null, List<string>? users = null, List<string>? targets = null, string? title = null, string? body = null, object? data = null, string? action = null, string? image = null, string? icon = null, string? sound = null, string? color = null, string? tag = null, long? badge = null, bool? draft = null, string? scheduledAt = null, bool? contentAvailable = null, bool? critical = null, Appwrite.Enums.MessagePriority? priority = null)
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
                { "image", image },
                { "icon", icon },
                { "sound", sound },
                { "color", color },
                { "tag", tag },
                { "badge", badge },
                { "draft", draft },
                { "scheduledAt", scheduledAt },
                { "contentAvailable", contentAvailable },
                { "critical", critical },
                { "priority", priority }
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
        /// Create SMS
        /// <para>
        /// Create a new SMS message.
        /// </para>
        /// </summary>
        public Task<Models.Message> CreateSms(string messageId, string content, List<string>? topics = null, List<string>? users = null, List<string>? targets = null, bool? draft = null, string? scheduledAt = null)
        {
            var apiPath = "/messaging/messages/sms";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "messageId", messageId },
                { "content", content },
                { "topics", topics },
                { "users", users },
                { "targets", targets },
                { "draft", draft },
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
        /// Update SMS
        /// <para>
        /// Update an SMS message by its unique ID.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.Message> UpdateSms(string messageId, List<string>? topics = null, List<string>? users = null, List<string>? targets = null, string? content = null, bool? draft = null, string? scheduledAt = null)
        {
            var apiPath = "/messaging/messages/sms/{messageId}"
                .Replace("{messageId}", messageId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "topics", topics },
                { "users", users },
                { "targets", targets },
                { "content", content },
                { "draft", draft },
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
        /// Get message
        /// <para>
        /// Get a message by its unique ID.
        /// 
        /// </para>
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
        /// Delete message
        /// <para>
        /// Delete a message. If the message is not a draft or scheduled, but has been
        /// sent, this will not recall the message.
        /// </para>
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
        /// <para>
        /// Get the message activity logs listed by its unique ID.
        /// </para>
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
        /// Get a list of the targets associated with a message.
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
        /// <para>
        /// Get a list of all providers from the current Appwrite project.
        /// </para>
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
        /// <para>
        /// Create a new Apple Push Notification service provider.
        /// </para>
        /// </summary>
        public Task<Models.Provider> CreateApnsProvider(string providerId, string name, string? authKey = null, string? authKeyId = null, string? teamId = null, string? bundleId = null, bool? sandbox = null, bool? enabled = null)
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
                { "sandbox", sandbox },
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
        /// <para>
        /// Update a Apple Push Notification service provider by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Provider> UpdateApnsProvider(string providerId, string? name = null, bool? enabled = null, string? authKey = null, string? authKeyId = null, string? teamId = null, string? bundleId = null, bool? sandbox = null)
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
                { "bundleId", bundleId },
                { "sandbox", sandbox }
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
        /// <para>
        /// Create a new Firebase Cloud Messaging provider.
        /// </para>
        /// </summary>
        public Task<Models.Provider> CreateFcmProvider(string providerId, string name, object? serviceAccountJSON = null, bool? enabled = null)
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
        /// <para>
        /// Update a Firebase Cloud Messaging provider by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Provider> UpdateFcmProvider(string providerId, string? name = null, bool? enabled = null, object? serviceAccountJSON = null)
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
        /// <para>
        /// Create a new Mailgun provider.
        /// </para>
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
        /// <para>
        /// Update a Mailgun provider by its unique ID.
        /// </para>
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
        /// <para>
        /// Create a new MSG91 provider.
        /// </para>
        /// </summary>
        public Task<Models.Provider> CreateMsg91Provider(string providerId, string name, string? templateId = null, string? senderId = null, string? authKey = null, bool? enabled = null)
        {
            var apiPath = "/messaging/providers/msg91";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "providerId", providerId },
                { "name", name },
                { "templateId", templateId },
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
        /// <para>
        /// Update a MSG91 provider by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Provider> UpdateMsg91Provider(string providerId, string? name = null, bool? enabled = null, string? templateId = null, string? senderId = null, string? authKey = null)
        {
            var apiPath = "/messaging/providers/msg91/{providerId}"
                .Replace("{providerId}", providerId);

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name },
                { "enabled", enabled },
                { "templateId", templateId },
                { "senderId", senderId },
                { "authKey", authKey }
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
        /// <para>
        /// Create a new Sendgrid provider.
        /// </para>
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
        /// <para>
        /// Update a Sendgrid provider by its unique ID.
        /// </para>
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
        /// <para>
        /// Create a new SMTP provider.
        /// </para>
        /// </summary>
        public Task<Models.Provider> CreateSmtpProvider(string providerId, string name, string host, long? port = null, string? username = null, string? password = null, Appwrite.Enums.SmtpEncryption? encryption = null, bool? autoTLS = null, string? mailer = null, string? fromName = null, string? fromEmail = null, string? replyToName = null, string? replyToEmail = null, bool? enabled = null)
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
        /// <para>
        /// Update a SMTP provider by its unique ID.
        /// </para>
        /// </summary>
        public Task<Models.Provider> UpdateSmtpProvider(string providerId, string? name = null, string? host = null, long? port = null, string? username = null, string? password = null, Appwrite.Enums.SmtpEncryption? encryption = null, bool? autoTLS = null, string? mailer = null, string? fromName = null, string? fromEmail = null, string? replyToName = null, string? replyToEmail = null, bool? enabled = null)
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
        /// <para>
        /// Create a new Telesign provider.
        /// </para>
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
        /// <para>
        /// Update a Telesign provider by its unique ID.
        /// </para>
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
        /// <para>
        /// Create a new Textmagic provider.
        /// </para>
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
        /// <para>
        /// Update a Textmagic provider by its unique ID.
        /// </para>
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
        /// <para>
        /// Create a new Twilio provider.
        /// </para>
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
        /// <para>
        /// Update a Twilio provider by its unique ID.
        /// </para>
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
        /// <para>
        /// Create a new Vonage provider.
        /// </para>
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
        /// <para>
        /// Update a Vonage provider by its unique ID.
        /// </para>
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
        /// <para>
        /// Get a provider by its unique ID.
        /// 
        /// </para>
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
        /// <para>
        /// Delete a provider by its unique ID.
        /// </para>
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
        /// <para>
        /// Get the provider activity logs listed by its unique ID.
        /// </para>
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
        /// <para>
        /// Get the subscriber activity logs listed by its unique ID.
        /// </para>
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
        /// List topics
        /// <para>
        /// Get a list of all topics from the current Appwrite project.
        /// </para>
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
        /// Create topic
        /// <para>
        /// Create a new topic.
        /// </para>
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
        /// Get topic
        /// <para>
        /// Get a topic by its unique ID.
        /// 
        /// </para>
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
        /// Update topic
        /// <para>
        /// Update a topic by its unique ID.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.Topic> UpdateTopic(string topicId, string? name = null, List<string>? subscribe = null)
        {
            var apiPath = "/messaging/topics/{topicId}"
                .Replace("{topicId}", topicId);

            var apiParameters = new Dictionary<string, object?>()
            {
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
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Delete topic
        /// <para>
        /// Delete a topic by its unique ID.
        /// </para>
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
        /// <para>
        /// Get the topic activity logs listed by its unique ID.
        /// </para>
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
        /// List subscribers
        /// <para>
        /// Get a list of all subscribers from the current Appwrite project.
        /// </para>
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
        /// Create subscriber
        /// <para>
        /// Create a new subscriber.
        /// </para>
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
        /// Get subscriber
        /// <para>
        /// Get a subscriber by its unique ID.
        /// 
        /// </para>
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
        /// Delete subscriber
        /// <para>
        /// Delete a subscriber by its unique ID.
        /// </para>
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
