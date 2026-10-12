
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class XDomain
    {
        [JsonPropertyName("$id")]
        public string Id { get; private set; }

        [JsonPropertyName("$createdAt")]
        public string CreatedAt { get; private set; }

        [JsonPropertyName("$updatedAt")]
        public string UpdatedAt { get; private set; }

        [JsonPropertyName("domain")]
        public string Domain { get; private set; }

        [JsonPropertyName("registrar")]
        public string Registrar { get; private set; }

        [JsonPropertyName("nameservers")]
        public string Nameservers { get; private set; }

        [JsonPropertyName("expire")]
        public string Expire { get; private set; }

        [JsonPropertyName("renewal")]
        public string Renewal { get; private set; }

        [JsonPropertyName("autoRenewal")]
        public bool AutoRenewal { get; private set; }

        [JsonPropertyName("renewalPrice")]
        public long RenewalPrice { get; private set; }

        [JsonPropertyName("transferStatus")]
        public Appwrite.Enums.DomainTransferStatusEnum? TransferStatus { get; private set; }

        [JsonPropertyName("teamId")]
        public string TeamId { get; private set; }

        [JsonPropertyName("dnsRecords")]
        public List<DnsRecord> DnsRecords { get; private set; }

        public XDomain(
            string id,
            string createdAt,
            string updatedAt,
            string domain,
            string registrar,
            string nameservers,
            string expire,
            string renewal,
            bool autoRenewal,
            long renewalPrice,
            Appwrite.Enums.DomainTransferStatusEnum? transferStatus,
            string teamId,
            List<DnsRecord> dnsRecords
        )
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Domain = domain;
            Registrar = registrar;
            Nameservers = nameservers;
            Expire = expire;
            Renewal = renewal;
            AutoRenewal = autoRenewal;
            RenewalPrice = renewalPrice;
            TransferStatus = transferStatus;
            TeamId = teamId;
            DnsRecords = dnsRecords;
        }

        public static XDomain From(Dictionary<string, object> map) => new XDomain(
            id: (map.ContainsKey("$id") ? map["$id"] : "").ToString(),
            createdAt: (map.ContainsKey("$createdAt") ? map["$createdAt"] : "").ToString(),
            updatedAt: (map.ContainsKey("$updatedAt") ? map["$updatedAt"] : "").ToString(),
            domain: (map.ContainsKey("domain") ? map["domain"] : "").ToString(),
            registrar: (map.ContainsKey("registrar") ? map["registrar"] : "").ToString(),
            nameservers: (map.ContainsKey("nameservers") ? map["nameservers"] : "").ToString(),
            expire: (map.ContainsKey("expire") ? map["expire"] : "").ToString(),
            renewal: (map.ContainsKey("renewal") ? map["renewal"] : "").ToString(),
            autoRenewal: (bool)(map.ContainsKey("autoRenewal") ? map["autoRenewal"] : false),
            renewalPrice: Convert.ToInt64((map.ContainsKey("renewalPrice") ? map["renewalPrice"] : 0)),
            transferStatus: map.TryGetValue("transferStatus", out var enumRaw11)
                            ? enumRaw11 == null
                                ? null
                                : new Appwrite.Enums.DomainTransferStatusEnum(enumRaw11.ToString()!)
                            : null,
            teamId: (map.ContainsKey("teamId") ? map["teamId"] : "").ToString(),
            dnsRecords: map["dnsRecords"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.DnsRecord.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "$id", Id },
            { "$createdAt", CreatedAt },
            { "$updatedAt", UpdatedAt },
            { "domain", Domain },
            { "registrar", Registrar },
            { "nameservers", Nameservers },
            { "expire", Expire },
            { "renewal", Renewal },
            { "autoRenewal", AutoRenewal },
            { "renewalPrice", RenewalPrice },
            { "transferStatus", TransferStatus?.Value },
            { "teamId", TeamId },
            { "dnsRecords", DnsRecords?.Select(it => it.ToMap()).ToList() }
        };
    }
}
