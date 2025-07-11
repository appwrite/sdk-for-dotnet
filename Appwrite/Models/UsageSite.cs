
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class UsageSite
    {
        [JsonPropertyName("range")]
        public string Range { get; private set; }

        [JsonPropertyName("deploymentsTotal")]
        public long DeploymentsTotal { get; private set; }

        [JsonPropertyName("deploymentsStorageTotal")]
        public long DeploymentsStorageTotal { get; private set; }

        [JsonPropertyName("buildsTotal")]
        public long BuildsTotal { get; private set; }

        [JsonPropertyName("buildsSuccessTotal")]
        public long BuildsSuccessTotal { get; private set; }

        [JsonPropertyName("buildsFailedTotal")]
        public long BuildsFailedTotal { get; private set; }

        [JsonPropertyName("buildsStorageTotal")]
        public long BuildsStorageTotal { get; private set; }

        [JsonPropertyName("buildsTimeTotal")]
        public long BuildsTimeTotal { get; private set; }

        [JsonPropertyName("buildsTimeAverage")]
        public long BuildsTimeAverage { get; private set; }

        [JsonPropertyName("buildsMbSecondsTotal")]
        public long BuildsMbSecondsTotal { get; private set; }

        [JsonPropertyName("executionsTotal")]
        public long ExecutionsTotal { get; private set; }

        [JsonPropertyName("executionsTimeTotal")]
        public long ExecutionsTimeTotal { get; private set; }

        [JsonPropertyName("executionsMbSecondsTotal")]
        public long ExecutionsMbSecondsTotal { get; private set; }

        [JsonPropertyName("deployments")]
        public List<Metric> Deployments { get; private set; }

        [JsonPropertyName("deploymentsStorage")]
        public List<Metric> DeploymentsStorage { get; private set; }

        [JsonPropertyName("builds")]
        public List<Metric> Builds { get; private set; }

        [JsonPropertyName("buildsStorage")]
        public List<Metric> BuildsStorage { get; private set; }

        [JsonPropertyName("buildsTime")]
        public List<Metric> BuildsTime { get; private set; }

        [JsonPropertyName("buildsMbSeconds")]
        public List<Metric> BuildsMbSeconds { get; private set; }

        [JsonPropertyName("executions")]
        public List<Metric> Executions { get; private set; }

        [JsonPropertyName("executionsTime")]
        public List<Metric> ExecutionsTime { get; private set; }

        [JsonPropertyName("executionsMbSeconds")]
        public List<Metric> ExecutionsMbSeconds { get; private set; }

        [JsonPropertyName("buildsSuccess")]
        public List<Metric> BuildsSuccess { get; private set; }

        [JsonPropertyName("buildsFailed")]
        public List<Metric> BuildsFailed { get; private set; }

        [JsonPropertyName("requestsTotal")]
        public long RequestsTotal { get; private set; }

        [JsonPropertyName("requests")]
        public List<Metric> Requests { get; private set; }

        [JsonPropertyName("inboundTotal")]
        public long InboundTotal { get; private set; }

        [JsonPropertyName("inbound")]
        public List<Metric> Inbound { get; private set; }

        [JsonPropertyName("outboundTotal")]
        public long OutboundTotal { get; private set; }

        [JsonPropertyName("outbound")]
        public List<Metric> Outbound { get; private set; }

        public UsageSite(
            string range,
            long deploymentsTotal,
            long deploymentsStorageTotal,
            long buildsTotal,
            long buildsSuccessTotal,
            long buildsFailedTotal,
            long buildsStorageTotal,
            long buildsTimeTotal,
            long buildsTimeAverage,
            long buildsMbSecondsTotal,
            long executionsTotal,
            long executionsTimeTotal,
            long executionsMbSecondsTotal,
            List<Metric> deployments,
            List<Metric> deploymentsStorage,
            List<Metric> builds,
            List<Metric> buildsStorage,
            List<Metric> buildsTime,
            List<Metric> buildsMbSeconds,
            List<Metric> executions,
            List<Metric> executionsTime,
            List<Metric> executionsMbSeconds,
            List<Metric> buildsSuccess,
            List<Metric> buildsFailed,
            long requestsTotal,
            List<Metric> requests,
            long inboundTotal,
            List<Metric> inbound,
            long outboundTotal,
            List<Metric> outbound
        ) {
            Range = range;
            DeploymentsTotal = deploymentsTotal;
            DeploymentsStorageTotal = deploymentsStorageTotal;
            BuildsTotal = buildsTotal;
            BuildsSuccessTotal = buildsSuccessTotal;
            BuildsFailedTotal = buildsFailedTotal;
            BuildsStorageTotal = buildsStorageTotal;
            BuildsTimeTotal = buildsTimeTotal;
            BuildsTimeAverage = buildsTimeAverage;
            BuildsMbSecondsTotal = buildsMbSecondsTotal;
            ExecutionsTotal = executionsTotal;
            ExecutionsTimeTotal = executionsTimeTotal;
            ExecutionsMbSecondsTotal = executionsMbSecondsTotal;
            Deployments = deployments;
            DeploymentsStorage = deploymentsStorage;
            Builds = builds;
            BuildsStorage = buildsStorage;
            BuildsTime = buildsTime;
            BuildsMbSeconds = buildsMbSeconds;
            Executions = executions;
            ExecutionsTime = executionsTime;
            ExecutionsMbSeconds = executionsMbSeconds;
            BuildsSuccess = buildsSuccess;
            BuildsFailed = buildsFailed;
            RequestsTotal = requestsTotal;
            Requests = requests;
            InboundTotal = inboundTotal;
            Inbound = inbound;
            OutboundTotal = outboundTotal;
            Outbound = outbound;
        }

        public static UsageSite From(Dictionary<string, object> map) => new UsageSite(
            range: map["range"].ToString(),
            deploymentsTotal: Convert.ToInt64(map["deploymentsTotal"]),
            deploymentsStorageTotal: Convert.ToInt64(map["deploymentsStorageTotal"]),
            buildsTotal: Convert.ToInt64(map["buildsTotal"]),
            buildsSuccessTotal: Convert.ToInt64(map["buildsSuccessTotal"]),
            buildsFailedTotal: Convert.ToInt64(map["buildsFailedTotal"]),
            buildsStorageTotal: Convert.ToInt64(map["buildsStorageTotal"]),
            buildsTimeTotal: Convert.ToInt64(map["buildsTimeTotal"]),
            buildsTimeAverage: Convert.ToInt64(map["buildsTimeAverage"]),
            buildsMbSecondsTotal: Convert.ToInt64(map["buildsMbSecondsTotal"]),
            executionsTotal: Convert.ToInt64(map["executionsTotal"]),
            executionsTimeTotal: Convert.ToInt64(map["executionsTimeTotal"]),
            executionsMbSecondsTotal: Convert.ToInt64(map["executionsMbSecondsTotal"]),
            deployments: map["deployments"] is JsonElement jsonArray14 ? jsonArray14.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["deployments"]).Select(it => Metric.From(map: it)).ToList(),
            deploymentsStorage: map["deploymentsStorage"] is JsonElement jsonArray15 ? jsonArray15.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["deploymentsStorage"]).Select(it => Metric.From(map: it)).ToList(),
            builds: map["builds"] is JsonElement jsonArray16 ? jsonArray16.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["builds"]).Select(it => Metric.From(map: it)).ToList(),
            buildsStorage: map["buildsStorage"] is JsonElement jsonArray17 ? jsonArray17.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["buildsStorage"]).Select(it => Metric.From(map: it)).ToList(),
            buildsTime: map["buildsTime"] is JsonElement jsonArray18 ? jsonArray18.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["buildsTime"]).Select(it => Metric.From(map: it)).ToList(),
            buildsMbSeconds: map["buildsMbSeconds"] is JsonElement jsonArray19 ? jsonArray19.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["buildsMbSeconds"]).Select(it => Metric.From(map: it)).ToList(),
            executions: map["executions"] is JsonElement jsonArray20 ? jsonArray20.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["executions"]).Select(it => Metric.From(map: it)).ToList(),
            executionsTime: map["executionsTime"] is JsonElement jsonArray21 ? jsonArray21.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["executionsTime"]).Select(it => Metric.From(map: it)).ToList(),
            executionsMbSeconds: map["executionsMbSeconds"] is JsonElement jsonArray22 ? jsonArray22.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["executionsMbSeconds"]).Select(it => Metric.From(map: it)).ToList(),
            buildsSuccess: map["buildsSuccess"] is JsonElement jsonArray23 ? jsonArray23.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["buildsSuccess"]).Select(it => Metric.From(map: it)).ToList(),
            buildsFailed: map["buildsFailed"] is JsonElement jsonArray24 ? jsonArray24.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["buildsFailed"]).Select(it => Metric.From(map: it)).ToList(),
            requestsTotal: Convert.ToInt64(map["requestsTotal"]),
            requests: map["requests"] is JsonElement jsonArray26 ? jsonArray26.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["requests"]).Select(it => Metric.From(map: it)).ToList(),
            inboundTotal: Convert.ToInt64(map["inboundTotal"]),
            inbound: map["inbound"] is JsonElement jsonArray28 ? jsonArray28.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["inbound"]).Select(it => Metric.From(map: it)).ToList(),
            outboundTotal: Convert.ToInt64(map["outboundTotal"]),
            outbound: map["outbound"] is JsonElement jsonArray30 ? jsonArray30.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["outbound"]).Select(it => Metric.From(map: it)).ToList()
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "range", Range },
            { "deploymentsTotal", DeploymentsTotal },
            { "deploymentsStorageTotal", DeploymentsStorageTotal },
            { "buildsTotal", BuildsTotal },
            { "buildsSuccessTotal", BuildsSuccessTotal },
            { "buildsFailedTotal", BuildsFailedTotal },
            { "buildsStorageTotal", BuildsStorageTotal },
            { "buildsTimeTotal", BuildsTimeTotal },
            { "buildsTimeAverage", BuildsTimeAverage },
            { "buildsMbSecondsTotal", BuildsMbSecondsTotal },
            { "executionsTotal", ExecutionsTotal },
            { "executionsTimeTotal", ExecutionsTimeTotal },
            { "executionsMbSecondsTotal", ExecutionsMbSecondsTotal },
            { "deployments", Deployments.Select(it => it.ToMap()) },
            { "deploymentsStorage", DeploymentsStorage.Select(it => it.ToMap()) },
            { "builds", Builds.Select(it => it.ToMap()) },
            { "buildsStorage", BuildsStorage.Select(it => it.ToMap()) },
            { "buildsTime", BuildsTime.Select(it => it.ToMap()) },
            { "buildsMbSeconds", BuildsMbSeconds.Select(it => it.ToMap()) },
            { "executions", Executions.Select(it => it.ToMap()) },
            { "executionsTime", ExecutionsTime.Select(it => it.ToMap()) },
            { "executionsMbSeconds", ExecutionsMbSeconds.Select(it => it.ToMap()) },
            { "buildsSuccess", BuildsSuccess.Select(it => it.ToMap()) },
            { "buildsFailed", BuildsFailed.Select(it => it.ToMap()) },
            { "requestsTotal", RequestsTotal },
            { "requests", Requests.Select(it => it.ToMap()) },
            { "inboundTotal", InboundTotal },
            { "inbound", Inbound.Select(it => it.ToMap()) },
            { "outboundTotal", OutboundTotal },
            { "outbound", Outbound.Select(it => it.ToMap()) }
        };
    }
}
