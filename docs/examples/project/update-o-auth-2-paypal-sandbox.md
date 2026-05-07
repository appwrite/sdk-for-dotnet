```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Project project = new Project(client);

OAuth2Paypal result = await project.UpdateOAuth2PaypalSandbox(
    clientId: "<CLIENT_ID>", // optional
    secretKey: "<SECRET_KEY>", // optional
    enabled: false // optional
);```
