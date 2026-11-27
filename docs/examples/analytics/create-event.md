```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndpoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Analytics analytics = new Analytics(client);

object result = await analytics.CreateEvent(
    propertyId: "<PROPERTY_ID>",
    name: "<NAME>",
    url: "https://example.com",
    domain: "<DOMAIN>", // optional
    referrer: "<REFERRER>", // optional
    screenWidth: 0, // optional
    sessionHash: "<SESSION_HASH>", // optional
    scrollDepth: 0, // optional
    engagementTime: 0, // optional
    props: new List<string>(), // optional
    userId: "<USER_ID>", // optional
    ip: "<IP>", // optional
    userAgent: "<USER_AGENT>", // optional
    interactive: false // optional
);

```
