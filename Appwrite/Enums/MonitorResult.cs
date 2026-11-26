using System;

namespace Appwrite.Enums
{
    public class MonitorResult : IEnum
    {
        public string Value { get; private set; }

        public MonitorResult(string value)
        {
            Value = value;
        }

        public static MonitorResult Ok => new MonitorResult("ok");
        public static MonitorResult DnsFailed => new MonitorResult("dns_failed");
        public static MonitorResult ConnectRefused => new MonitorResult("connect_refused");
        public static MonitorResult ConnectTimeout => new MonitorResult("connect_timeout");
        public static MonitorResult ConnectFailed => new MonitorResult("connect_failed");
        public static MonitorResult TlsFailed => new MonitorResult("tls_failed");
        public static MonitorResult TlsExpiring => new MonitorResult("tls_expiring");
        public static MonitorResult StatusMismatch => new MonitorResult("status_mismatch");
        public static MonitorResult AnswerMismatch => new MonitorResult("answer_mismatch");
        public static MonitorResult SmtpRejected => new MonitorResult("smtp_rejected");
        public static MonitorResult TargetDenied => new MonitorResult("target_denied");
        public static MonitorResult Timeout => new MonitorResult("timeout");
        public static MonitorResult RuleMatched => new MonitorResult("rule_matched");
    }
}
