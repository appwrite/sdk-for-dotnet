
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Appwrite.Models
{
    public class UsageProject
    {
        [JsonPropertyName("executionsTotal")]
        public long ExecutionsTotal { get; private set; }

        [JsonPropertyName("documentsTotal")]
        public long DocumentsTotal { get; private set; }

        [JsonPropertyName("databasesTotal")]
        public long DatabasesTotal { get; private set; }

        [JsonPropertyName("databasesStorageTotal")]
        public long DatabasesStorageTotal { get; private set; }

        [JsonPropertyName("usersTotal")]
        public long UsersTotal { get; private set; }

        [JsonPropertyName("filesStorageTotal")]
        public long FilesStorageTotal { get; private set; }

        [JsonPropertyName("functionsStorageTotal")]
        public long FunctionsStorageTotal { get; private set; }

        [JsonPropertyName("buildsStorageTotal")]
        public long BuildsStorageTotal { get; private set; }

        [JsonPropertyName("deploymentsStorageTotal")]
        public long DeploymentsStorageTotal { get; private set; }

        [JsonPropertyName("bucketsTotal")]
        public long BucketsTotal { get; private set; }

        [JsonPropertyName("executionsMbSecondsTotal")]
        public long ExecutionsMbSecondsTotal { get; private set; }

        [JsonPropertyName("buildsMbSecondsTotal")]
        public long BuildsMbSecondsTotal { get; private set; }

        [JsonPropertyName("databasesReadsTotal")]
        public long DatabasesReadsTotal { get; private set; }

        [JsonPropertyName("databasesWritesTotal")]
        public long DatabasesWritesTotal { get; private set; }

        [JsonPropertyName("requests")]
        public List<Metric> Requests { get; private set; }

        [JsonPropertyName("network")]
        public List<Metric> Network { get; private set; }

        [JsonPropertyName("users")]
        public List<Metric> Users { get; private set; }

        [JsonPropertyName("executions")]
        public List<Metric> Executions { get; private set; }

        [JsonPropertyName("executionsBreakdown")]
        public List<MetricBreakdown> ExecutionsBreakdown { get; private set; }

        [JsonPropertyName("bucketsBreakdown")]
        public List<MetricBreakdown> BucketsBreakdown { get; private set; }

        [JsonPropertyName("databasesStorageBreakdown")]
        public List<MetricBreakdown> DatabasesStorageBreakdown { get; private set; }

        [JsonPropertyName("executionsMbSecondsBreakdown")]
        public List<MetricBreakdown> ExecutionsMbSecondsBreakdown { get; private set; }

        [JsonPropertyName("buildsMbSecondsBreakdown")]
        public List<MetricBreakdown> BuildsMbSecondsBreakdown { get; private set; }

        [JsonPropertyName("functionsStorageBreakdown")]
        public List<MetricBreakdown> FunctionsStorageBreakdown { get; private set; }

        [JsonPropertyName("authPhoneTotal")]
        public long AuthPhoneTotal { get; private set; }

        [JsonPropertyName("authPhoneEstimate")]
        public double AuthPhoneEstimate { get; private set; }

        [JsonPropertyName("authPhoneCountryBreakdown")]
        public List<MetricBreakdown> AuthPhoneCountryBreakdown { get; private set; }

        [JsonPropertyName("databasesReads")]
        public List<Metric> DatabasesReads { get; private set; }

        [JsonPropertyName("databasesWrites")]
        public List<Metric> DatabasesWrites { get; private set; }

        [JsonPropertyName("imageTransformations")]
        public List<Metric> ImageTransformations { get; private set; }

        [JsonPropertyName("imageTransformationsTotal")]
        public long ImageTransformationsTotal { get; private set; }

        public UsageProject(
            long executionsTotal,
            long documentsTotal,
            long databasesTotal,
            long databasesStorageTotal,
            long usersTotal,
            long filesStorageTotal,
            long functionsStorageTotal,
            long buildsStorageTotal,
            long deploymentsStorageTotal,
            long bucketsTotal,
            long executionsMbSecondsTotal,
            long buildsMbSecondsTotal,
            long databasesReadsTotal,
            long databasesWritesTotal,
            List<Metric> requests,
            List<Metric> network,
            List<Metric> users,
            List<Metric> executions,
            List<MetricBreakdown> executionsBreakdown,
            List<MetricBreakdown> bucketsBreakdown,
            List<MetricBreakdown> databasesStorageBreakdown,
            List<MetricBreakdown> executionsMbSecondsBreakdown,
            List<MetricBreakdown> buildsMbSecondsBreakdown,
            List<MetricBreakdown> functionsStorageBreakdown,
            long authPhoneTotal,
            double authPhoneEstimate,
            List<MetricBreakdown> authPhoneCountryBreakdown,
            List<Metric> databasesReads,
            List<Metric> databasesWrites,
            List<Metric> imageTransformations,
            long imageTransformationsTotal
        ) {
            ExecutionsTotal = executionsTotal;
            DocumentsTotal = documentsTotal;
            DatabasesTotal = databasesTotal;
            DatabasesStorageTotal = databasesStorageTotal;
            UsersTotal = usersTotal;
            FilesStorageTotal = filesStorageTotal;
            FunctionsStorageTotal = functionsStorageTotal;
            BuildsStorageTotal = buildsStorageTotal;
            DeploymentsStorageTotal = deploymentsStorageTotal;
            BucketsTotal = bucketsTotal;
            ExecutionsMbSecondsTotal = executionsMbSecondsTotal;
            BuildsMbSecondsTotal = buildsMbSecondsTotal;
            DatabasesReadsTotal = databasesReadsTotal;
            DatabasesWritesTotal = databasesWritesTotal;
            Requests = requests;
            Network = network;
            Users = users;
            Executions = executions;
            ExecutionsBreakdown = executionsBreakdown;
            BucketsBreakdown = bucketsBreakdown;
            DatabasesStorageBreakdown = databasesStorageBreakdown;
            ExecutionsMbSecondsBreakdown = executionsMbSecondsBreakdown;
            BuildsMbSecondsBreakdown = buildsMbSecondsBreakdown;
            FunctionsStorageBreakdown = functionsStorageBreakdown;
            AuthPhoneTotal = authPhoneTotal;
            AuthPhoneEstimate = authPhoneEstimate;
            AuthPhoneCountryBreakdown = authPhoneCountryBreakdown;
            DatabasesReads = databasesReads;
            DatabasesWrites = databasesWrites;
            ImageTransformations = imageTransformations;
            ImageTransformationsTotal = imageTransformationsTotal;
        }

        public static UsageProject From(Dictionary<string, object> map) => new UsageProject(
            executionsTotal: Convert.ToInt64(map["executionsTotal"]),
            documentsTotal: Convert.ToInt64(map["documentsTotal"]),
            databasesTotal: Convert.ToInt64(map["databasesTotal"]),
            databasesStorageTotal: Convert.ToInt64(map["databasesStorageTotal"]),
            usersTotal: Convert.ToInt64(map["usersTotal"]),
            filesStorageTotal: Convert.ToInt64(map["filesStorageTotal"]),
            functionsStorageTotal: Convert.ToInt64(map["functionsStorageTotal"]),
            buildsStorageTotal: Convert.ToInt64(map["buildsStorageTotal"]),
            deploymentsStorageTotal: Convert.ToInt64(map["deploymentsStorageTotal"]),
            bucketsTotal: Convert.ToInt64(map["bucketsTotal"]),
            executionsMbSecondsTotal: Convert.ToInt64(map["executionsMbSecondsTotal"]),
            buildsMbSecondsTotal: Convert.ToInt64(map["buildsMbSecondsTotal"]),
            databasesReadsTotal: Convert.ToInt64(map["databasesReadsTotal"]),
            databasesWritesTotal: Convert.ToInt64(map["databasesWritesTotal"]),
            requests: map["requests"] is JsonElement jsonArray15 ? jsonArray15.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["requests"]).Select(it => Metric.From(map: it)).ToList(),
            network: map["network"] is JsonElement jsonArray16 ? jsonArray16.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["network"]).Select(it => Metric.From(map: it)).ToList(),
            users: map["users"] is JsonElement jsonArray17 ? jsonArray17.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["users"]).Select(it => Metric.From(map: it)).ToList(),
            executions: map["executions"] is JsonElement jsonArray18 ? jsonArray18.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["executions"]).Select(it => Metric.From(map: it)).ToList(),
            executionsBreakdown: map["executionsBreakdown"] is JsonElement jsonArray19 ? jsonArray19.Deserialize<List<Dictionary<string, object>>>()!.Select(it => MetricBreakdown.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["executionsBreakdown"]).Select(it => MetricBreakdown.From(map: it)).ToList(),
            bucketsBreakdown: map["bucketsBreakdown"] is JsonElement jsonArray20 ? jsonArray20.Deserialize<List<Dictionary<string, object>>>()!.Select(it => MetricBreakdown.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["bucketsBreakdown"]).Select(it => MetricBreakdown.From(map: it)).ToList(),
            databasesStorageBreakdown: map["databasesStorageBreakdown"] is JsonElement jsonArray21 ? jsonArray21.Deserialize<List<Dictionary<string, object>>>()!.Select(it => MetricBreakdown.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["databasesStorageBreakdown"]).Select(it => MetricBreakdown.From(map: it)).ToList(),
            executionsMbSecondsBreakdown: map["executionsMbSecondsBreakdown"] is JsonElement jsonArray22 ? jsonArray22.Deserialize<List<Dictionary<string, object>>>()!.Select(it => MetricBreakdown.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["executionsMbSecondsBreakdown"]).Select(it => MetricBreakdown.From(map: it)).ToList(),
            buildsMbSecondsBreakdown: map["buildsMbSecondsBreakdown"] is JsonElement jsonArray23 ? jsonArray23.Deserialize<List<Dictionary<string, object>>>()!.Select(it => MetricBreakdown.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["buildsMbSecondsBreakdown"]).Select(it => MetricBreakdown.From(map: it)).ToList(),
            functionsStorageBreakdown: map["functionsStorageBreakdown"] is JsonElement jsonArray24 ? jsonArray24.Deserialize<List<Dictionary<string, object>>>()!.Select(it => MetricBreakdown.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["functionsStorageBreakdown"]).Select(it => MetricBreakdown.From(map: it)).ToList(),
            authPhoneTotal: Convert.ToInt64(map["authPhoneTotal"]),
            authPhoneEstimate: Convert.ToDouble(map["authPhoneEstimate"]),
            authPhoneCountryBreakdown: map["authPhoneCountryBreakdown"] is JsonElement jsonArray27 ? jsonArray27.Deserialize<List<Dictionary<string, object>>>()!.Select(it => MetricBreakdown.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["authPhoneCountryBreakdown"]).Select(it => MetricBreakdown.From(map: it)).ToList(),
            databasesReads: map["databasesReads"] is JsonElement jsonArray28 ? jsonArray28.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["databasesReads"]).Select(it => Metric.From(map: it)).ToList(),
            databasesWrites: map["databasesWrites"] is JsonElement jsonArray29 ? jsonArray29.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["databasesWrites"]).Select(it => Metric.From(map: it)).ToList(),
            imageTransformations: map["imageTransformations"] is JsonElement jsonArray30 ? jsonArray30.Deserialize<List<Dictionary<string, object>>>()!.Select(it => Metric.From(map: it)).ToList() : ((IEnumerable<Dictionary<string, object>>)map["imageTransformations"]).Select(it => Metric.From(map: it)).ToList(),
            imageTransformationsTotal: Convert.ToInt64(map["imageTransformationsTotal"])
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "executionsTotal", ExecutionsTotal },
            { "documentsTotal", DocumentsTotal },
            { "databasesTotal", DatabasesTotal },
            { "databasesStorageTotal", DatabasesStorageTotal },
            { "usersTotal", UsersTotal },
            { "filesStorageTotal", FilesStorageTotal },
            { "functionsStorageTotal", FunctionsStorageTotal },
            { "buildsStorageTotal", BuildsStorageTotal },
            { "deploymentsStorageTotal", DeploymentsStorageTotal },
            { "bucketsTotal", BucketsTotal },
            { "executionsMbSecondsTotal", ExecutionsMbSecondsTotal },
            { "buildsMbSecondsTotal", BuildsMbSecondsTotal },
            { "databasesReadsTotal", DatabasesReadsTotal },
            { "databasesWritesTotal", DatabasesWritesTotal },
            { "requests", Requests.Select(it => it.ToMap()) },
            { "network", Network.Select(it => it.ToMap()) },
            { "users", Users.Select(it => it.ToMap()) },
            { "executions", Executions.Select(it => it.ToMap()) },
            { "executionsBreakdown", ExecutionsBreakdown.Select(it => it.ToMap()) },
            { "bucketsBreakdown", BucketsBreakdown.Select(it => it.ToMap()) },
            { "databasesStorageBreakdown", DatabasesStorageBreakdown.Select(it => it.ToMap()) },
            { "executionsMbSecondsBreakdown", ExecutionsMbSecondsBreakdown.Select(it => it.ToMap()) },
            { "buildsMbSecondsBreakdown", BuildsMbSecondsBreakdown.Select(it => it.ToMap()) },
            { "functionsStorageBreakdown", FunctionsStorageBreakdown.Select(it => it.ToMap()) },
            { "authPhoneTotal", AuthPhoneTotal },
            { "authPhoneEstimate", AuthPhoneEstimate },
            { "authPhoneCountryBreakdown", AuthPhoneCountryBreakdown.Select(it => it.ToMap()) },
            { "databasesReads", DatabasesReads.Select(it => it.ToMap()) },
            { "databasesWrites", DatabasesWrites.Select(it => it.ToMap()) },
            { "imageTransformations", ImageTransformations.Select(it => it.ToMap()) },
            { "imageTransformationsTotal", ImageTransformationsTotal }
        };
    }
}
