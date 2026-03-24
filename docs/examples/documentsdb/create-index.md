```csharp
using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

DocumentsDB documentsDB = new DocumentsDB(client);

Index result = await documentsDB.CreateIndex(
    databaseId: "<DATABASE_ID>",
    collectionId: "<COLLECTION_ID>",
    key: "",
    type: DocumentsDBIndexType.Key,
    attributes: new List<string>(),
    orders: new List&lt;OrderBy&gt; { OrderBy.Asc }, // optional
    lengths: new List<long>() // optional
);```
