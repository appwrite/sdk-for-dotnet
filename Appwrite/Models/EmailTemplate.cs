
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class EmailTemplate
    {
        [JsonPropertyName("type")]
        public string Type { get; private set; }

        [JsonPropertyName("locale")]
        public string Locale { get; private set; }

        [JsonPropertyName("message")]
        public string Message { get; private set; }

        [JsonPropertyName("senderName")]
        public string SenderName { get; private set; }

        [JsonPropertyName("senderEmail")]
        public string SenderEmail { get; private set; }

        [JsonPropertyName("replyTo")]
        public string ReplyTo { get; private set; }

        [JsonPropertyName("subject")]
        public string Subject { get; private set; }

        public EmailTemplate(
            string type,
            string locale,
            string message,
            string senderName,
            string senderEmail,
            string replyTo,
            string subject
        ) {
            Type = type;
            Locale = locale;
            Message = message;
            SenderName = senderName;
            SenderEmail = senderEmail;
            ReplyTo = replyTo;
            Subject = subject;
        }

        public static EmailTemplate From(Dictionary<string, object> map) => new EmailTemplate(
            type: map["type"].ToString(),
            locale: map["locale"].ToString(),
            message: map["message"].ToString(),
            senderName: map["senderName"].ToString(),
            senderEmail: map["senderEmail"].ToString(),
            replyTo: map["replyTo"].ToString(),
            subject: map["subject"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "type", Type },
            { "locale", Locale },
            { "message", Message },
            { "senderName", SenderName },
            { "senderEmail", SenderEmail },
            { "replyTo", ReplyTo },
            { "subject", Subject }
        };
    }
}
