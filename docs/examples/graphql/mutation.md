```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Graphql graphql = new Graphql(client);

Appwrite.Models.Any result = await graphql.Mutation(
    query: new { query = "mutation { accountUpdateName(name: "Walter") { name } }" }
);

```
