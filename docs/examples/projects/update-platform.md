using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>"); // Your project ID

Projects projects = new Projects(client);

Platform result = await projects.UpdatePlatform(
    projectId: "<PROJECT_ID>",
    platformId: "<PLATFORM_ID>",
    name: "<NAME>",
    key: "<KEY>", // optional
    store: "<STORE>", // optional
    hostname: "" // optional
);