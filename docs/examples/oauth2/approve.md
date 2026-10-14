```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndpoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetSession(""); // The user session to authenticate with

Oauth2 oauth2 = new Oauth2(client);

Appwrite.Models.Oauth2Approve result = await oauth2.Approve(
    grantId: "<GRANT_ID>",
    authorizationDetails: "<AUTHORIZATION_DETAILS>", // optional
    scope: "<SCOPE>" // optional
);

```
