
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class DeploymentList
    {
        [JsonPropertyName("total")]
        public long Total { get; private set; }

        [JsonPropertyName("deployments")]
        public List<Deployment> Deployments { get; private set; }

        public DeploymentList(
            long total,
            List<Deployment> deployments
        ) {
            Total = total;
            Deployments = deployments;
        }

        public static DeploymentList From(Dictionary<string, object> map) => new DeploymentList(
            total: Convert.ToInt64(map["total"]),
            deployments: map["deployments"] is JsonElement jsonArray2 ? jsonArray2.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Deployment.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["deployments"]).Select(it => Deployment.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "deployments", Deployments.Select(it => it.ToMap()) }
        };
    }
}
