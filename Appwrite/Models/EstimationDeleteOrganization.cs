
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class EstimationDeleteOrganization
    {
        [JsonPropertyName("unpaidInvoices")]
        public List<Invoice> UnpaidInvoices { get; private set; }

        public EstimationDeleteOrganization(
            List<Invoice> unpaidInvoices
        ) {
            UnpaidInvoices = unpaidInvoices;
        }

        public static EstimationDeleteOrganization From(Dictionary<string, object> map) => new EstimationDeleteOrganization(
            unpaidInvoices: map["unpaidInvoices"].ConvertToList<Dictionary<string, object>>().Select(it => Invoice.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "unpaidInvoices", UnpaidInvoices.Select(it => it.ToMap()) }
        };
    }
}
