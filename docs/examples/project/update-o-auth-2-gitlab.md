```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Project project = new Project(client);

OAuth2Gitlab result = await project.UpdateOAuth2Gitlab(
    applicationId: "<APPLICATION_ID>", // optional
    secret: "<SECRET>", // optional
    endpoint: "https://example.com", // optional
    enabled: false // optional
);```
