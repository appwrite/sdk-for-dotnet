using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Databases databases = new Databases(client);

AttributeString result = await databases.UpdateStringAttribute(
    databaseId: "{$example}",
    collectionId: "{$example}",
    key: "",
    required: false,
    default: "{$example}",
    size: 0, // optional
    newKey: "" // optional
);