using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetSession(""); // The user session to authenticate with

Storage storage = new Storage(client);

FileList result = await storage.ListFiles(
    bucketId: "{$example}",
    queries: new List<string>(), // optional
    search: "{$example}" // optional
);