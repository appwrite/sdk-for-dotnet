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

Appwrite.Models.Monitor result = await monitors.UpdateHttpMonitor(
    monitorId: "<MONITOR_ID>",
    name: "<NAME>", // optional
    url: "https://api.example.com/health", // optional
    method: MonitorMethod.GET, // optional
    headers: new { Authorization = "Bearer <TOKEN>" }, // optional
    body: "<BODY>", // optional
    rules: new List<string> {
        Query.Or(new List<string> {
            Query.NotBetween("statusCode", 200, 299),
            Query.GreaterThan("latency", 2000)
        })
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
