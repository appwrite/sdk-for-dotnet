```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Postgresql postgresql = new Postgresql(client);

DedicatedDatabaseExecution result = await postgresql.CreateExecution(
    databaseId: "<DATABASE_ID>",
    sql: "<SQL>",
    bindings: [object], // optional
    timeoutSeconds: 1 // optional
);

```
