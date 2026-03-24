```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetSession(""); // The user session to authenticate with

DocumentsDB documentsDB = new DocumentsDB(client);

Document result = await documentsDB.GetDocument(
    databaseId: "<DATABASE_ID>",
    collectionId: "<COLLECTION_ID>",
    documentId: "<DOCUMENT_ID>",
    queries: new List<string>(), // optional
    transactionId: "<TRANSACTION_ID>" // optional
);```
