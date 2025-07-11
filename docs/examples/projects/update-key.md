using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>"); // Your project ID

Projects projects = new Projects(client);

Key result = await projects.UpdateKey(
    projectId: "<PROJECT_ID>",
    keyId: "<KEY_ID>",
    name: "<NAME>",
    scopes: new List<string>(),
    expire: "" // optional
);