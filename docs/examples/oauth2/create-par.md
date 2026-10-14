```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndpoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetSession("") // The user session to authenticate with
    .SetProject("<YOUR_PROJECT_ID>"); // Your project ID

Oauth2 oauth2 = new Oauth2(client);

Oauth2PAR result = await oauth2.CreatePAR(
    clientId: "<CLIENT_ID>",
    redirectUri: "https://example.com",
    responseType: "code",
    scope: "<SCOPE>", // optional
    state: "<STATE>", // optional
    nonce: "<NONCE>", // optional
    codeChallenge: "<CODE_CHALLENGE>", // optional
    codeChallengeMethod: "s256", // optional
    prompt: "<PROMPT>", // optional
    maxAge: 0, // optional
    authorizationDetails: "<AUTHORIZATION_DETAILS>", // optional
    resource: "", // optional
    audience: "<AUDIENCE>" // optional
);

```
