```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Postgresql postgresql = new Postgresql(client);

DedicatedDatabase result = await postgresql.CreateBranch(
    databaseId: "<DATABASE_ID>",
    branchId: "<BRANCH_ID>", // optional
    ttl: 300 // optional
);

```
