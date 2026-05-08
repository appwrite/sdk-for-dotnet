```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Project project = new Project(client);

OAuth2Linkedin result = await project.UpdateOAuth2Linkedin(
    clientId: "<CLIENT_ID>", // optional
    primaryClientSecret: "<PRIMARY_CLIENT_SECRET>", // optional
    enabled: false // optional
);```
