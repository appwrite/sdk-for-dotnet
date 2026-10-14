```csharp
using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetSession(""); // The user session to authenticate with

Account account = new Account(client);

Appwrite.Models.Session result = await account.CreateIdTokenSession(
    provider: IdTokenProvider.Apple,
    idToken: "<ID_TOKEN>",
    nonce: "<NONCE>", // optional
    accessToken: "<ACCESS_TOKEN>", // optional
    accessTokenExpiry: 0, // optional
    name: "<NAME>" // optional
);

```
