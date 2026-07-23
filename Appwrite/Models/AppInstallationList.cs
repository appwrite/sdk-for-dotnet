
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

namespace Appwrite.Models
{
    public class AppInstallationList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("installations")]
        public List<AppInstallation> Installations { get; private set; }

        public AppInstallationList(
            long total,
            List<AppInstallation> installations
        )
        {
            Total = total;
            Installations = installations;
        }

        public static AppInstallationList From(Dictionary<string, object> map) => new AppInstallationList(
            total: Convert.ToInt64(map["total"]),
            installations: map["installations"].ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.AppInstallation.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "installations", Installations?.Select(it => it.ToMap()).ToList() }
        };
    }
}
