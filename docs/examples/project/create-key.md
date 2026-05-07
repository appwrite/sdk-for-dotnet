```csharp
using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Project project = new Project(client);

Key result = await project.CreateKey(
    keyId: "<KEY_ID>",
    name: "<NAME>",
    scopes: new List&lt;Scopes&gt; { Scopes.ProjectRead },
    expire: "2020-10-15T06:38:00.000+00:00" // optional
);```
