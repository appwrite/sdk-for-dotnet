```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetSession(""); // The user session to authenticate with

Teams teams = new Teams(client);

AppInstallationList result = await teams.ListInstallations(
    teamId: "<TEAM_ID>",
    queries: new List<string>(), // optional
    total: false // optional
);

```
