```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetSession(""); // The user session to authenticate with

Teams teams = new Teams(client);

AppInstallation result = await teams.CreateInstallation(
    teamId: "<TEAM_ID>",
    appId: "<APP_ID>",
    authorizationDetails: "<AUTHORIZATION_DETAILS>" // optional
);```
