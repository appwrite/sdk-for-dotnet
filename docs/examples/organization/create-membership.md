```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Organization organization = new Organization(client);

Membership result = await organization.CreateMembership(
    roles: new List<string>(),
    email: "email@example.com", // optional
    userId: "<USER_ID>", // optional
    phone: "+12065550100", // optional
    url: "https://example.com", // optional
    name: "<NAME>" // optional
);```
