using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Databases databases = new Databases(client);

Index result = await databases.CreateIndex(
    databaseId: "{$example}",
    collectionId: "{$example}",
    key: "",
    type: IndexType.Key,
    attributes: new List<string>(),
    orders: new List<string>() // optional
);