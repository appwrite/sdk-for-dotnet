```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Project project = new Project(client);

PlatformWindows result = await project.CreateWindowsPlatform(
    platformId: "<PLATFORM_ID>",
    name: "<NAME>",
    packageIdentifierName: "<PACKAGE_IDENTIFIER_NAME>"
);```
