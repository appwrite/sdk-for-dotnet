```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Mysql mysql = new Mysql(client);

DedicatedDatabaseRestoration result = await mysql.CreateRestoration(
    databaseId: "<DATABASE_ID>",
    type: "backup", // optional
    backupId: "<BACKUP_ID>", // optional
    targetDatabaseId: "<TARGET_DATABASE_ID>", // optional
    targetTime: "2020-10-15T06:38:00.000+00:00" // optional
);

```
