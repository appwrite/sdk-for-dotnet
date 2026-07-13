```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Project project = new Project(client);

Project result = await project.UpdateOAuth2Server(
    enabled: false,
    authorizationUrl: "https://example.com",
    scopes: new List<string>(), // optional
    authorizationDetailsTypes: new List<string>(), // optional
    accessTokenDuration: 60, // optional
    refreshTokenDuration: 60, // optional
    publicAccessTokenDuration: 60, // optional
    publicRefreshTokenDuration: 60, // optional
    confidentialPkce: false, // optional
    verificationUrl: "https://example.com", // optional
    userCodeLength: 6, // optional
    userCodeFormat: "numeric", // optional
    deviceCodeDuration: 60, // optional
    defaultScopes: new List<string>() // optional
);```
