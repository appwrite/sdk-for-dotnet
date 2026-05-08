```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Project project = new Project(client);

OAuth2Dailymotion result = await project.UpdateOAuth2Dailymotion(
    apiKey: "<API_KEY>", // optional
    apiSecret: "<API_SECRET>", // optional
    enabled: false // optional
);```
