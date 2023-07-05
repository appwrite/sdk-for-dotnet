
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class DeploymentList
    {
        [JsonProperty("total")]
        public long Total { get; private set; }

        [JsonProperty("deployments")]
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
            deployments: ((JArray)map["deployments"]).ToObject<List<Dictionary<string, object>>>().Select(it => Deployment.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "total", Total },
            { "deployments", Deployments.Select(it => it.ToMap()) }
        };
    }
}