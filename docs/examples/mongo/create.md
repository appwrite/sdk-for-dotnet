```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Mongo mongo = new Mongo(client);

DedicatedDatabase result = await mongo.Create(
    databaseId: "<DATABASE_ID>",
    name: "<NAME>",
    version: "17", // optional
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
    storageAutoscalingMaxGb: 0 // optional
);

```
