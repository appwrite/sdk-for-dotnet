```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndpoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

TablesDB tablesDB = new TablesDB(client);

Appwrite.Models.DatabaseMigration result = await tablesDB.CreateMigration(
    databaseId: "<DATABASE_ID>",
    specification: "s-1vcpu-1gb",
    autoCutover: false // optional
);

```
