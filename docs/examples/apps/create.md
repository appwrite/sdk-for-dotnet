```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetSession(""); // The user session to authenticate with

Apps apps = new Apps(client);

App result = await apps.Create(
    appId: "<APP_ID>",
    name: "<NAME>",
    redirectUris: new List<string>(),
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
    postLogoutRedirectUris: new List<string>(), // optional
    enabled: false, // optional
    type: "public", // optional
    deviceFlow: false, // optional
    teamId: "<TEAM_ID>" // optional
);```
