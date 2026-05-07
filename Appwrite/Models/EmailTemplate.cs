
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class EmailTemplate
    {
        [JsonPropertyName("templateId")]
        public string TemplateId { get; private set; }

        [JsonPropertyName("locale")]
        public string Locale { get; private set; }

        [JsonPropertyName("message")]
        public string Message { get; private set; }

        [JsonPropertyName("senderName")]
        public string SenderName { get; private set; }

        [JsonPropertyName("senderEmail")]
        public string SenderEmail { get; private set; }

        [JsonPropertyName("replyToEmail")]
        public string ReplyToEmail { get; private set; }

        [JsonPropertyName("replyToName")]
        public string ReplyToName { get; private set; }

        [JsonPropertyName("subject")]
        public string Subject { get; private set; }

        public EmailTemplate(
            string templateId,
            string locale,
            string message,
            string senderName,
            string senderEmail,
            string replyToEmail,
            string replyToName,
            string subject
        )
        {
            TemplateId = templateId;
            Locale = locale;
            Message = message;
            SenderName = senderName;
            SenderEmail = senderEmail;
            ReplyToEmail = replyToEmail;
            ReplyToName = replyToName;
            Subject = subject;
        }

        public static EmailTemplate From(Dictionary<string, object> map) => new EmailTemplate(
            templateId: map["templateId"].ToString(),
            locale: map["locale"].ToString(),
            message: map["message"].ToString(),
            senderName: map["senderName"].ToString(),
            senderEmail: map["senderEmail"].ToString(),
            replyToEmail: map["replyToEmail"].ToString(),
            replyToName: map["replyToName"].ToString(),
            subject: map["subject"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "templateId", TemplateId },
            { "locale", Locale },
            { "message", Message },
            { "senderName", SenderName },
            { "senderEmail", SenderEmail },
            { "replyToEmail", ReplyToEmail },
            { "replyToName", ReplyToName },
            { "subject", Subject }
        };
    }
}
