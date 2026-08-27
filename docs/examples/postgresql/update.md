```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Postgresql postgresql = new Postgresql(client);

DedicatedDatabase result = await postgresql.Update(
    databaseId: "<DATABASE_ID>",
    name: "<NAME>", // optional
    status: "ready", // optional
    specification: "<SPECIFICATION>", // optional
    replicas: 0, // optional
    syncMode: "async", // optional
    networkIdleTimeoutSeconds: 60, // optional
    networkIPAllowlist: new List<string>(), // optional
    idleTimeoutMinutes: 5, // optional
    pitr: false, // optional
    pitrRetentionDays: 1, // optional
    storageAutoscaling: false, // optional
    storageAutoscalingThresholdPercent: 50, // optional
    storageAutoscalingMaxGb: 0, // optional
    metricsTraceSampleRate: 0, // optional
    metricsSlowQueryLogThresholdMs: 0, // optional
    sqlApiEnabled: false, // optional
    sqlApiAllowedStatements: new List<string>(), // optional
    sqlApiMaxRows: 1, // optional
    sqlApiMaxBytes: 1024, // optional
    sqlApiTimeoutSeconds: 1 // optional
);

```
