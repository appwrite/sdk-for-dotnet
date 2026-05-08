```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Project project = new Project(client);

OAuth2Apple result = await project.UpdateOAuth2Apple(
    serviceId: "<SERVICE_ID>", // optional
    keyId: "<KEY_ID>", // optional
    teamId: "<TEAM_ID>", // optional
    p8File: "<P8_FILE>", // optional
    enabled: false // optional
);```
