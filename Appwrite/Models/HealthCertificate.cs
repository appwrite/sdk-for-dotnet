
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;

namespace Appwrite.Models
{
    public class HealthCertificate
    {
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("subjectSN")]
        public string SubjectSN { get; private set; }

        [JsonPropertyName("issuerOrganisation")]
        public string IssuerOrganisation { get; private set; }

        [JsonPropertyName("validFrom")]
        public string ValidFrom { get; private set; }

        [JsonPropertyName("validTo")]
        public string ValidTo { get; private set; }

        [JsonPropertyName("signatureTypeSN")]
        public string SignatureTypeSN { get; private set; }

        public HealthCertificate(
            string name,
            string subjectSN,
            string issuerOrganisation,
            string validFrom,
            string validTo,
            string signatureTypeSN
        ) {
            Name = name;
            SubjectSN = subjectSN;
            IssuerOrganisation = issuerOrganisation;
            ValidFrom = validFrom;
            ValidTo = validTo;
            SignatureTypeSN = signatureTypeSN;
        }

        public static HealthCertificate From(Dictionary<string, object> map) => new HealthCertificate(
            name: map["name"].ToString(),
            subjectSN: map["subjectSN"].ToString(),
            issuerOrganisation: map["issuerOrganisation"].ToString(),
            validFrom: map["validFrom"].ToString(),
            validTo: map["validTo"].ToString(),
            signatureTypeSN: map["signatureTypeSN"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "name", Name },
            { "subjectSN", SubjectSN },
            { "issuerOrganisation", IssuerOrganisation },
            { "validFrom", ValidFrom },
            { "validTo", ValidTo },
            { "signatureTypeSN", SignatureTypeSN }
        };
    }
}
