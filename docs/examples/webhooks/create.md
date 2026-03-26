```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Webhooks webhooks = new Webhooks(client);

Webhook result = await webhooks.Create(
    webhookId: "<WEBHOOK_ID>",
    url: "",
    name: "<NAME>",
    events: new List<string>(),
    enabled: false, // optional
    security: false, // optional
    httpUser: "<HTTP_USER>", // optional
    httpPass: "<HTTP_PASS>" // optional
);```
