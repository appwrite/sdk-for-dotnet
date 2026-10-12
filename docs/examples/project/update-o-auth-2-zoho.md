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

Appwrite.Models.OAuth2Zoho result = await project.UpdateOAuth2Zoho(
    clientId: "<CLIENT_ID>", // optional
    clientSecret: "<CLIENT_SECRET>", // optional
    prompt: new List&lt;ProjectOAuth2ZohoPrompt&gt; { ProjectOAuth2ZohoPrompt.Consent }, // optional
    enabled: false // optional
);

```
