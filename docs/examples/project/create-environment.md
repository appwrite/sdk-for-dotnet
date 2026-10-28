```csharp
using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndpoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Project project = new Project(client);

Appwrite.Models.Project result = await project.CreateEnvironment(
    environmentId: "<ENVIRONMENT_ID>",
    name: "<NAME>",
    resources: new List<EnvironmentResource> { EnvironmentResource.Database, EnvironmentResource.Table, EnvironmentResource.Column, EnvironmentResource.Index, EnvironmentResource.Bucket, EnvironmentResource.Team, EnvironmentResource.Function, EnvironmentResource.EnvironmentVariable } // optional
);

```
