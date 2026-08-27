```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Mysql mysql = new Mysql(client);

DedicatedDatabase result = await mysql.CreateUpgrade(
    databaseId: "<DATABASE_ID>",
    targetVersion: "<TARGET_VERSION>"
);

```
