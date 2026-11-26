```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndpoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Organization organization = new Organization(client);

Appwrite.Models.Escalation result = await organization.CreateEscalation(
    escalationId: "<ESCALATION_ID>",
    name: "<NAME>",
    steps: new List<object>
    {
        new Dictionary<string, object>
        {
            { "delay", 0 },
            { "roles", new List<object> { "owner" } }
        },
        new Dictionary<string, object>
        {
            { "delay", 900 },
            { "roles", new List<object> { "developer" } },
            { "userIds", new List<object> { "<USER_ID>" } }
        }
    },
    repeat: 1 // optional
);

```
