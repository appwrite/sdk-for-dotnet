```csharp
using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Databases databases = new Databases(client);

Appwrite.Models.Index result = await databases.CreateIndex(
    databaseId: "<DATABASE_ID>",
    collectionId: "<COLLECTION_ID>",
    key: "<KEY>",
    type: DatabasesIndexType.Key,
    attributes: ["username"],
    orders: new List&lt;OrderBy&gt; { OrderBy.Asc }, // optional
    lengths: new List<long>() // optional
);

```
