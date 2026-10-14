```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndpoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetSession("") // The user session to authenticate with
    .SetProject("<YOUR_PROJECT_ID>"); // Your project ID

Oauth2 oauth2 = new Oauth2(client);

Oauth2DeviceAuthorization result = await oauth2.CreateDeviceAuthorization(
    clientId: "<CLIENT_ID>", // optional
    scope: "<SCOPE>", // optional
    authorizationDetails: "<AUTHORIZATION_DETAILS>", // optional
    resource: "", // optional
    audience: "<AUDIENCE>" // optional
);

```
