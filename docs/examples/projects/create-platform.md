using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>"); // Your project ID

Projects projects = new Projects(client);

Platform result = await projects.CreatePlatform(
    projectId: "<PROJECT_ID>",
    type: PlatformType.Web,
    name: "<NAME>",
    key: "<KEY>", // optional
    store: "<STORE>", // optional
    hostname: "" // optional
);