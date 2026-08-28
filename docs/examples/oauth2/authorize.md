```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetSession("") // The user session to authenticate with
    .SetProject("<YOUR_PROJECT_ID>"); // Your project ID

Oauth2 oauth2 = new Oauth2(client);

Oauth2Authorize result = await oauth2.Authorize(
    client_id: "<CLIENT_ID>", // optional
    redirect_uri: "https://example.com", // optional
    response_type: "", // optional
    scope: "<SCOPE>", // optional
    state: "<STATE>", // optional
    nonce: "<NONCE>", // optional
    code_challenge: "<CODE_CHALLENGE>", // optional
    code_challenge_method: "s256", // optional
    prompt: "<PROMPT>", // optional
    max_age: 0, // optional
    authorization_details: "<AUTHORIZATION_DETAILS>", // optional
    resource: "", // optional
    audience: "<AUDIENCE>", // optional
    request_uri: "<REQUEST_URI>" // optional
);

```
