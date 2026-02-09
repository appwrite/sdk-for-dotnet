```csharp
using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Backups backups = new Backups(client);

BackupPolicy result = await backups.CreatePolicy(
    policyId: "<POLICY_ID>",
    services: new List&lt;BackupServices&gt; { BackupServices.Databases },
    retention: 1,
    schedule: "",
    name: "<NAME>", // optional
    resourceId: "<RESOURCE_ID>", // optional
    enabled: false // optional
);```
