
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class ConsoleVariables
    {
        [JsonPropertyName("_APP_DOMAIN_TARGET_CNAME")]
        public string APPDOMAINTARGETCNAME { get; private set; }

        [JsonPropertyName("_APP_DOMAIN_TARGET_A")]
        public string APPDOMAINTARGETA { get; private set; }

        [JsonPropertyName("_APP_DOMAIN_TARGET_AAAA")]
        public string APPDOMAINTARGETAAAA { get; private set; }

        [JsonPropertyName("_APP_STORAGE_LIMIT")]
        public long APPSTORAGELIMIT { get; private set; }

        [JsonPropertyName("_APP_COMPUTE_SIZE_LIMIT")]
        public long APPCOMPUTESIZELIMIT { get; private set; }

        [JsonPropertyName("_APP_USAGE_STATS")]
        public string APPUSAGESTATS { get; private set; }

        [JsonPropertyName("_APP_VCS_ENABLED")]
        public bool APPVCSENABLED { get; private set; }

        [JsonPropertyName("_APP_DOMAIN_ENABLED")]
        public bool APPDOMAINENABLED { get; private set; }

        [JsonPropertyName("_APP_ASSISTANT_ENABLED")]
        public bool APPASSISTANTENABLED { get; private set; }

        [JsonPropertyName("_APP_DOMAIN_SITES")]
        public string APPDOMAINSITES { get; private set; }

        [JsonPropertyName("_APP_DOMAIN_FUNCTIONS")]
        public string APPDOMAINFUNCTIONS { get; private set; }

        [JsonPropertyName("_APP_OPTIONS_FORCE_HTTPS")]
        public string APPOPTIONSFORCEHTTPS { get; private set; }

        [JsonPropertyName("_APP_DOMAINS_NAMESERVERS")]
        public string APPDOMAINSNAMESERVERS { get; private set; }

        public ConsoleVariables(
            string aPPDOMAINTARGETCNAME,
            string aPPDOMAINTARGETA,
            string aPPDOMAINTARGETAAAA,
            long aPPSTORAGELIMIT,
            long aPPCOMPUTESIZELIMIT,
            string aPPUSAGESTATS,
            bool aPPVCSENABLED,
            bool aPPDOMAINENABLED,
            bool aPPASSISTANTENABLED,
            string aPPDOMAINSITES,
            string aPPDOMAINFUNCTIONS,
            string aPPOPTIONSFORCEHTTPS,
            string aPPDOMAINSNAMESERVERS
        ) {
            APPDOMAINTARGETCNAME = aPPDOMAINTARGETCNAME;
            APPDOMAINTARGETA = aPPDOMAINTARGETA;
            APPDOMAINTARGETAAAA = aPPDOMAINTARGETAAAA;
            APPSTORAGELIMIT = aPPSTORAGELIMIT;
            APPCOMPUTESIZELIMIT = aPPCOMPUTESIZELIMIT;
            APPUSAGESTATS = aPPUSAGESTATS;
            APPVCSENABLED = aPPVCSENABLED;
            APPDOMAINENABLED = aPPDOMAINENABLED;
            APPASSISTANTENABLED = aPPASSISTANTENABLED;
            APPDOMAINSITES = aPPDOMAINSITES;
            APPDOMAINFUNCTIONS = aPPDOMAINFUNCTIONS;
            APPOPTIONSFORCEHTTPS = aPPOPTIONSFORCEHTTPS;
            APPDOMAINSNAMESERVERS = aPPDOMAINSNAMESERVERS;
        }

        public static ConsoleVariables From(Dictionary<string, object> map) => new ConsoleVariables(
            aPPDOMAINTARGETCNAME: map["_APP_DOMAIN_TARGET_CNAME"].ToString(),
            aPPDOMAINTARGETA: map["_APP_DOMAIN_TARGET_A"].ToString(),
            aPPDOMAINTARGETAAAA: map["_APP_DOMAIN_TARGET_AAAA"].ToString(),
            aPPSTORAGELIMIT: Convert.ToInt64(map["_APP_STORAGE_LIMIT"]),
            aPPCOMPUTESIZELIMIT: Convert.ToInt64(map["_APP_COMPUTE_SIZE_LIMIT"]),
            aPPUSAGESTATS: map["_APP_USAGE_STATS"].ToString(),
            aPPVCSENABLED: (bool)map["_APP_VCS_ENABLED"],
            aPPDOMAINENABLED: (bool)map["_APP_DOMAIN_ENABLED"],
            aPPASSISTANTENABLED: (bool)map["_APP_ASSISTANT_ENABLED"],
            aPPDOMAINSITES: map["_APP_DOMAIN_SITES"].ToString(),
            aPPDOMAINFUNCTIONS: map["_APP_DOMAIN_FUNCTIONS"].ToString(),
            aPPOPTIONSFORCEHTTPS: map["_APP_OPTIONS_FORCE_HTTPS"].ToString(),
            aPPDOMAINSNAMESERVERS: map["_APP_DOMAINS_NAMESERVERS"].ToString()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "_APP_DOMAIN_TARGET_CNAME", APPDOMAINTARGETCNAME },
            { "_APP_DOMAIN_TARGET_A", APPDOMAINTARGETA },
            { "_APP_DOMAIN_TARGET_AAAA", APPDOMAINTARGETAAAA },
            { "_APP_STORAGE_LIMIT", APPSTORAGELIMIT },
            { "_APP_COMPUTE_SIZE_LIMIT", APPCOMPUTESIZELIMIT },
            { "_APP_USAGE_STATS", APPUSAGESTATS },
            { "_APP_VCS_ENABLED", APPVCSENABLED },
            { "_APP_DOMAIN_ENABLED", APPDOMAINENABLED },
            { "_APP_ASSISTANT_ENABLED", APPASSISTANTENABLED },
            { "_APP_DOMAIN_SITES", APPDOMAINSITES },
            { "_APP_DOMAIN_FUNCTIONS", APPDOMAINFUNCTIONS },
            { "_APP_OPTIONS_FORCE_HTTPS", APPOPTIONSFORCEHTTPS },
            { "_APP_DOMAINS_NAMESERVERS", APPDOMAINSNAMESERVERS }
        };
    }
}
