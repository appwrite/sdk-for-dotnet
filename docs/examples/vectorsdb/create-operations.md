```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

VectorsDB vectorsDB = new VectorsDB(client);

Transaction result = await vectorsDB.CreateOperations(
    transactionId: "<TRANSACTION_ID>",
    operations: [
	    {
	        "action": "create",
	        "databaseId": "<DATABASE_ID>",
	        "collectionId": "<COLLECTION_ID>",
	        "documentId": "<DOCUMENT_ID>",
	        "data": {
	            "name": "Walter O'Brien"
	        }
	    }
	] // optional
);```
