```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

TablesDB tablesDB = new TablesDB(client);

Appwrite.Models.RowList result = await tablesDB.UpsertRows(
    databaseId: "<DATABASE_ID>",
    tableId: "<TABLE_ID>",
    rows: [
	    {
	        "$id": "example1",
	        "username": "walter.obrien",
	        "email": "walter.obrien@example.com",
	        "fullName": "Walter O'Brien",
	        "age": 30,
	        "isAdmin": false
	    }
	],
    transactionId: "<TRANSACTION_ID>" // optional
);

```
