```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Mysql mysql = new Mysql(client);

DedicatedDatabaseBackupStorage result = await mysql.UpdateBackupStorage(
    databaseId: "<DATABASE_ID>",
    provider: "s3",
    bucket: "<BUCKET>",
    accessKey: "<ACCESS_KEY>",
    secretKey: "<SECRET_KEY>",
    region: "<REGION>", // optional
    prefix: "<PREFIX>", // optional
    endpoint: "<ENDPOINT>" // optional
);

```
