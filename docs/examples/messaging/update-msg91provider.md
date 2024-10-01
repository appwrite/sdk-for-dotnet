using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Messaging messaging = new Messaging(client);

Provider result = await messaging.UpdateMsg91Provider(
    providerId: "{$example}",
    name: "{$example}", // optional
    enabled: false, // optional
    templateId: "{$example}", // optional
    senderId: "{$example}", // optional
    authKey: "{$example}" // optional
);