```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetSession(""); // The user session to authenticate with

Oauth2 oauth2 = new Oauth2(client);

Appwrite.Models.Oauth2Approve result = await oauth2.Approve(
    grant_id: "<GRANT_ID>",
    authorization_details: "<AUTHORIZATION_DETAILS>", // optional
    scope: "<SCOPE>" // optional
);

```
