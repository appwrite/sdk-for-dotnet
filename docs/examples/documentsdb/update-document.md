```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetSession(""); // The user session to authenticate with

DocumentsDB documentsDB = new DocumentsDB(client);

Document result = await documentsDB.UpdateDocument(
    databaseId: "<DATABASE_ID>",
    collectionId: "<COLLECTION_ID>",
    documentId: "<DOCUMENT_ID>",
    data: [object], // optional
    permissions: new List<string> { Permission.Read(Role.Any()) }, // optional
    transactionId: "<TRANSACTION_ID>" // optional
);```
