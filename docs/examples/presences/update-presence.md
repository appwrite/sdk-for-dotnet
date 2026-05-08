```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Presences presences = new Presences(client);

Presence result = await presences.UpdatePresence(
    presenceId: "<PRESENCE_ID>",
    userId: "<USER_ID>",
    status: "<STATUS>", // optional
    expiresAt: "2020-10-15T06:38:00.000+00:00", // optional
    metadata: [object], // optional
    permissions: new List<string> { Permission.Read(Role.Any()) }, // optional
    purge: false // optional
);```
