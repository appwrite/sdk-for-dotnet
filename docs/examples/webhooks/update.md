```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Webhooks webhooks = new Webhooks(client);

Webhook result = await webhooks.Update(
    webhookId: "<WEBHOOK_ID>",
    name: "<NAME>",
    url: "",
    events: new List<string>(),
    enabled: false, // optional
    tls: false, // optional
    authUsername: "<AUTH_USERNAME>", // optional
    authPassword: "<AUTH_PASSWORD>" // optional
);```
