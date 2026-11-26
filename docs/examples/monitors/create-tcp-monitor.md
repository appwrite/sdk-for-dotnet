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

Appwrite.Models.Monitor result = await monitors.CreateTcpMonitor(
    monitorId: "<MONITOR_ID>",
    name: "<NAME>",
    host: "db.example.com",
    port: 5432,
    rules: new List<string> {
        Query.GreaterThan("latency", 1000)
    }, // optional
    interval: 60, // optional
    timeout: 10, // optional
    cooldown: 300, // optional
    enabled: true, // optional
    notify: ["owner"], // optional
    severity: MonitorSeverity.Info, // optional
    escalationId: "<ESCALATION_ID>" // optional
);

```
