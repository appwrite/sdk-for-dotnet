```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndpoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetSession(""); // The user session to authenticate with

Oauth2 oauth2 = new Oauth2(client);

Appwrite.Models.Oauth2Token result = await oauth2.CreateToken(
    grantType: "<GRANT_TYPE>",
    code: "<CODE>", // optional
    refreshToken: "<REFRESH_TOKEN>", // optional
    deviceCode: "<DEVICE_CODE>", // optional
    clientId: "<CLIENT_ID>", // optional
    clientSecret: "<CLIENT_SECRET>", // optional
    codeVerifier: "<CODE_VERIFIER>", // optional
    redirectUri: "https://example.com", // optional
    resource: new List<string>(), // optional
    audience: "<AUDIENCE>" // optional
);

```
