using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Databases databases = new Databases(client);

AttributeEnum result = await databases.CreateEnumAttribute(
    databaseId: "{$example}",
    collectionId: "{$example}",
    key: "",
    elements: new List<string>(),
    required: false,
    default: "{$example}", // optional
    array: false // optional
);