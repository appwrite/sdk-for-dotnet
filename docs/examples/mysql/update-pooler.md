```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Mysql mysql = new Mysql(client);

DedicatedDatabasePooler result = await mysql.UpdatePooler(
    databaseId: "<DATABASE_ID>",
    mode: "transaction", // optional
    maxConnections: 10, // optional
    defaultPoolSize: 1, // optional
    readWriteSplitting: false, // optional
    poolerCpuRequest: "<POOLER_CPU_REQUEST>", // optional
    poolerCpuLimit: "<POOLER_CPU_LIMIT>", // optional
    poolerMemoryRequest: "<POOLER_MEMORY_REQUEST>", // optional
    poolerMemoryLimit: "<POOLER_MEMORY_LIMIT>" // optional
);

```
