using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Messaging messaging = new Messaging(client);

Provider result = await messaging.UpdateTextmagicProvider(
    providerId: "{$example}",
    name: "{$example}", // optional
    enabled: false, // optional
    username: "{$example}", // optional
    apiKey: "{$example}", // optional
    from: "{$example}" // optional
);