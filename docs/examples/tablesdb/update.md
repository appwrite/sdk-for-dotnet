```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndpoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

TablesDB tablesDB = new TablesDB(client);

Appwrite.Models.Database result = await tablesDB.Update(
    databaseId: "<DATABASE_ID>",
    name: "<NAME>", // optional
    enabled: false, // optional
    description: "<DESCRIPTION>", // optional
    specification: "serverless", // optional
    replicas: 0, // optional
    syncMode: "async" // optional
);

```
