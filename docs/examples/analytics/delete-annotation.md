```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndpoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Analytics analytics = new Analytics(client);

await analytics.DeleteAnnotation(
    propertyId: "<PROPERTY_ID>",
    annotationId: "<ANNOTATION_ID>"
);

```
