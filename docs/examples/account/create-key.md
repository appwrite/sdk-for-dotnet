```csharp
using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetSession(""); // The user session to authenticate with

Account account = new Account(client);

Key result = await account.CreateKey(
    name: "<NAME>",
    scopes: new List&lt;Scopes&gt; { Scopes.Account },
    expire: "" // optional
);```
