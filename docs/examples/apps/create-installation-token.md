```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetSession(""); // The user session to authenticate with

Apps apps = new Apps(client);

Oauth2Token result = await apps.CreateInstallationToken(
    appId: "<APP_ID>",
    installationId: "<INSTALLATION_ID>"
);

```
