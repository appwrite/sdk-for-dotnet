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

Appwrite.Models.OAuth2Okta result = await project.UpdateOAuth2Okta(
    clientId: "<CLIENT_ID>", // optional
    clientSecret: "<CLIENT_SECRET>", // optional
    domain: "example.com", // optional
    authorizationServerId: "<AUTHORIZATION_SERVER_ID>", // optional
    prompt: new List&lt;ProjectOAuth2OktaPrompt&gt; { ProjectOAuth2OktaPrompt.None }, // optional
    enabled: false // optional
);

```
