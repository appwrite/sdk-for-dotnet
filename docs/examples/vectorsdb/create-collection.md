```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

VectorsDB vectorsDB = new VectorsDB(client);

Appwrite.Models.VectorsdbCollection result = await vectorsDB.CreateCollection(
    databaseId: "<DATABASE_ID>",
    collectionId: "<COLLECTION_ID>",
    name: "<NAME>",
    dimension: 4,
    permissions: new List<string> { Permission.Read(Role.Any()) }, // optional
    documentSecurity: false, // optional
    enabled: false // optional
);

```
