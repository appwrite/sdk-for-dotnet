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

Appwrite.Models.OAuth2Auth0 result = await project.UpdateOAuth2Auth0(
    clientId: "<CLIENT_ID>", // optional
    clientSecret: "<CLIENT_SECRET>", // optional
    endpoint: "<ENDPOINT>", // optional
    prompt: new List&lt;ProjectOAuth2Auth0Prompt&gt; { ProjectOAuth2Auth0Prompt.None }, // optional
    enabled: false // optional
);

```
