```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetSession(""); // The user session to authenticate with

Teams teams = new Teams(client);

Appwrite.Models.Preferences result = await teams.GetPrefs(
    teamId: "<TEAM_ID>"
);

```
