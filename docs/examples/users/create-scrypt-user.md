```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Users users = new Users(client);

User result = await users.CreateScryptUser(
    userId: "<USER_ID>",
    email: "email@example.com",
    password: "password",
    passwordSalt: "<PASSWORD_SALT>",
    passwordCpu: 8,
    passwordMemory: 65536,
    passwordParallel: 1,
    passwordLength: 64,
    name: "<NAME>" // optional
);

```
