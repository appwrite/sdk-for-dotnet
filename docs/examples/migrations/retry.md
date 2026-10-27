```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndpoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Migrations migrations = new Migrations(client);

Appwrite.Models.Migration result = await migrations.Retry(
    migrationId: "<MIGRATION_ID>"
);

```
