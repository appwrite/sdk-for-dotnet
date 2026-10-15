
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class DnsRecordsList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("dnsRecords")]
        public List<DnsRecord> DnsRecords { get; private set; }

        public DnsRecordsList(
            long total,
            List<DnsRecord> dnsRecords
        )
        {
            Total = total;
            DnsRecords = dnsRecords;
        }

        public static DnsRecordsList From(Dictionary<string, object> map) => new DnsRecordsList(
            total: Convert.ToInt64((map.ContainsKey("total") ? map["total"] : 0)),
            dnsRecords: (map.ContainsKey("dnsRecords") ? map["dnsRecords"] : new List<object>()).ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.DnsRecord.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "dnsRecords", DnsRecords?.Select(it => it.ToMap()).ToList() }
        };
    }
}
