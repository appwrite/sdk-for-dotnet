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

Appwrite.Models.OAuth2Microsoft result = await project.UpdateOAuth2Microsoft(
    applicationId: "<APPLICATION_ID>", // optional
    applicationSecret: "<APPLICATION_SECRET>", // optional
    tenant: "<TENANT>", // optional
    prompt: new List&lt;ProjectOAuth2MicrosoftPrompt&gt; { ProjectOAuth2MicrosoftPrompt.None }, // optional
    enabled: false // optional
);

```
