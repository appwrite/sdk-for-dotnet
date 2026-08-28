```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetSession("") // The user session to authenticate with
    .SetProject("<YOUR_PROJECT_ID>"); // Your project ID

Oauth2 oauth2 = new Oauth2(client);

Oauth2Token result = await oauth2.CreateToken(
    grant_type: "<GRANT_TYPE>",
    code: "<CODE>", // optional
    refresh_token: "<REFRESH_TOKEN>", // optional
    device_code: "<DEVICE_CODE>", // optional
    client_id: "<CLIENT_ID>", // optional
    client_secret: "<CLIENT_SECRET>", // optional
    code_verifier: "<CODE_VERIFIER>", // optional
    redirect_uri: "https://example.com", // optional
    resource: "", // optional
    audience: "<AUDIENCE>" // optional
);

```
