```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Oauth2 oauth2 = new Oauth2(client);

Appwrite.Models.Oauth2Introspection result = await oauth2.Introspect(
    token: "<TOKEN>",
    token_type_hint: "access_token", // optional
    client_id: "<CLIENT_ID>", // optional
    client_secret: "<CLIENT_SECRET>" // optional
);

```
