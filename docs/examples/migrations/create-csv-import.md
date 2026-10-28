```csharp
using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndpoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Migrations migrations = new Migrations(client);

Appwrite.Models.Migration result = await migrations.CreateCSVImport(
    bucketId: "<BUCKET_ID>",
    fileId: "<FILE_ID>",
    databaseId: "<DATABASE_ID>",
    collectionId: "<COLLECTION_ID>",
    internalFile: false, // optional
    onDuplicate: OnDuplicate.Fail // optional
);

```
