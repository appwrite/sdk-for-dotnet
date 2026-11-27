```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndpoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Analytics analytics = new Analytics(client);

Appwrite.Models.AnalyticsAnnotation result = await analytics.UpdateAnnotation(
    propertyId: "<PROPERTY_ID>",
    annotationId: "<ANNOTATION_ID>",
    date: "2020-10-15T06:38:00.000+00:00", // optional
    content: "<CONTENT>" // optional
);

```
