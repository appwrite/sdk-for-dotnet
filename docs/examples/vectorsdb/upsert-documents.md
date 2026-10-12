```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

VectorsDB vectorsDB = new VectorsDB(client);

Appwrite.Models.DocumentList result = await vectorsDB.UpsertDocuments(
    databaseId: "<DATABASE_ID>",
    collectionId: "<COLLECTION_ID>",
    documents: [
	    {
	        "$id": "example1",
	        "embeddings": [
	            0.12,
	            -0.55,
	            0.88,
	            1.02
	        ],
	        "metadata": {
	            "name": "First document"
	        }
	    }
	],
    transactionId: "<TRANSACTION_ID>" // optional
);

```
