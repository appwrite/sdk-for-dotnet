```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndpoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Users users = new Users(client);

Appwrite.Models.User result = await users.CreatePHPassUser(
    userId: "<USER_ID>",
    email: "email@example.com",
    password: "$P$BrOEFP1YR5W1yHpvvGuoeVUDPmw9ra/",
    name: "<NAME>" // optional
);

```
