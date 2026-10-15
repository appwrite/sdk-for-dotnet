
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Appwrite.Enums;
using Appwrite.Extensions;

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
        )
        {
            Total = total;
            Deployments = deployments;
        }

        public static DeploymentList From(Dictionary<string, object> map) => new DeploymentList(
            total: Convert.ToInt64((map.ContainsKey("total") ? map["total"] : 0)),
            deployments: (map.ContainsKey("deployments") ? map["deployments"] : new List<object>()).ConvertToList<Dictionary<string, object>>().Select(it => Appwrite.Models.Deployment.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "deployments", Deployments?.Select(it => it.ToMap()).ToList() }
        };
    }
}
