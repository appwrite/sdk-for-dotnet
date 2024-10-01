using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Functions functions = new Functions(client);

Function result = await functions.Update(
    functionId: "{$example}",
    name: "{$example}",
    runtime: .Node145, // optional
    execute: ["any"], // optional
    events: new List<string>(), // optional
    schedule: "", // optional
    timeout: 1, // optional
    enabled: false, // optional
    logging: false, // optional
    entrypoint: "{$example}", // optional
    commands: "{$example}", // optional
    scopes: new List<string>(), // optional
    installationId: "{$example}", // optional
    providerRepositoryId: "{$example}", // optional
    providerBranch: "{$example}", // optional
    providerSilentMode: false, // optional
    providerRootDirectory: "{$example}", // optional
    specification: "" // optional
);