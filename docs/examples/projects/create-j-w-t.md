using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>"); // Your project ID

Projects projects = new Projects(client);

JWT result = await projects.CreateJWT(
    projectId: "<PROJECT_ID>",
    scopes: new List<string>(),
    duration: 0 // optional
);