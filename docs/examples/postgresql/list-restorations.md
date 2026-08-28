```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Postgresql postgresql = new Postgresql(client);

DedicatedDatabaseRestorationList result = await postgresql.ListRestorations(
    databaseId: "<DATABASE_ID>",
    status: "pending", // optional
    type: "backup", // optional
    limit: 1, // optional
    offset: 0 // optional
);

```
