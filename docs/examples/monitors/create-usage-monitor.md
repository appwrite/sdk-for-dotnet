```csharp
using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndpoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Monitors monitors = new Monitors(client);

Appwrite.Models.Monitor result = await monitors.CreateUsageMonitor(
    monitorId: "<MONITOR_ID>",
    name: "<NAME>",
    rules: new List<string> {
        Query.GreaterThan("network.outbound", 5000000000)
    },
    window: 3600, // optional
    cooldown: 1800, // optional
    enabled: true, // optional
    notify: ["owner"], // optional
    severity: MonitorSeverity.Info, // optional
    escalationId: "<ESCALATION_ID>" // optional
);

```
