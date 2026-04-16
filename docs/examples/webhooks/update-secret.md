```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Webhooks webhooks = new Webhooks(client);

Webhook result = await webhooks.UpdateSecret(
    webhookId: "<WEBHOOK_ID>",
    secret: "<SECRET>" // optional
);```
