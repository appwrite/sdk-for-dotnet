```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetSession(""); // The user session to authenticate with

VectorsDB vectorsDB = new VectorsDB(client);

Document result = await vectorsDB.CreateDocument(
    databaseId: "<DATABASE_ID>",
    collectionId: "<COLLECTION_ID>",
    documentId: "<DOCUMENT_ID>",
    data: new {
        embeddings = new[] { 0.12, -0.55, 0.88, 1.02 },
        metadata = { key = "value" }
    },
    permissions: new List<string> { Permission.Read(Role.Any()) } // optional
);```
