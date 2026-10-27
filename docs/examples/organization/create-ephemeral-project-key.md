```csharp
using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndpoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Organization organization = new Organization(client);

Appwrite.Models.EphemeralKey result = await organization.CreateEphemeralProjectKey(
    projectId: "<PROJECT_ID>",
    scopes: new List<ProjectKeyScopes> { ProjectKeyScopes.UsersRead },
    duration: 600
);

```
