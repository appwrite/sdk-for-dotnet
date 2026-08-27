```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetSession(""); // The user session to authenticate with

Apps apps = new Apps(client);

App result = await apps.Update(
    appId: "<APP_ID>",
    name: "<NAME>",
    description: "<DESCRIPTION>", // optional
    clientUri: "https://example.com", // optional
    logoUri: "https://example.com", // optional
    privacyPolicyUrl: "https://example.com", // optional
    termsUrl: "https://example.com", // optional
    contacts: new List<string>(), // optional
    tagline: "<TAGLINE>", // optional
    tags: new List<string>(), // optional
    images: new List<string>(), // optional
    supportUrl: "https://example.com", // optional
    dataDeletionUrl: "https://example.com", // optional
    enabled: false, // optional
    redirectUris: new List<string>(), // optional
    postLogoutRedirectUris: new List<string>(), // optional
    type: "public", // optional
    deviceFlow: false, // optional
    installationScopes: new List<string>(), // optional
    installationRedirectUrl: "https://example.com" // optional
);

```
