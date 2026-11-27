```csharp
using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndpoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Analytics analytics = new Analytics(client);

Appwrite.Models.AnalyticsProperty result = await analytics.UpdateProperty(
    propertyId: "<PROPERTY_ID>",
    name: "<NAME>", // optional
    domain: "<DOMAIN>", // optional
    enabled: false, // optional
    allowedOrigins: new List<string>(), // optional
    identifyUsers: false, // optional
    type: AnalyticsPropertyType.Web // optional
);

```
