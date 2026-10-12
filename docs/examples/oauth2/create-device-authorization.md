```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetSession(""); // The user session to authenticate with

Oauth2 oauth2 = new Oauth2(client);

Appwrite.Models.Oauth2DeviceAuthorization result = await oauth2.CreateDeviceAuthorization(
    client_id: "<CLIENT_ID>", // optional
    scope: "<SCOPE>", // optional
    authorization_details: "<AUTHORIZATION_DETAILS>", // optional
    resource: new List<string>(), // optional
    audience: "<AUDIENCE>" // optional
);

```
