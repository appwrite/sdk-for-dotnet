```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Project project = new Project(client);

OAuth2Oidc result = await project.UpdateOAuth2Oidc(
    clientId: "<CLIENT_ID>", // optional
    clientSecret: "<CLIENT_SECRET>", // optional
    wellKnownURL: "https://example.com", // optional
    authorizationURL: "https://example.com", // optional
    tokenURL: "https://example.com", // optional
    userInfoURL: "https://example.com", // optional
    enabled: false // optional
);```
