using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Functions functions = new Functions(client);

Deployment result = await functions.CreateDeployment(
    functionId: "{$example}",
    code: Payload.FromFile("/path/to/file.png"),
    activate: false,
    entrypoint: "{$example}", // optional
    commands: "{$example}" // optional
);