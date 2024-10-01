using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Messaging messaging = new Messaging(client);

Provider result = await messaging.UpdateMailgunProvider(
    providerId: "{$example}",
    name: "{$example}", // optional
    apiKey: "{$example}", // optional
    domain: "{$example}", // optional
    isEuRegion: false, // optional
    enabled: false, // optional
    fromName: "{$example}", // optional
    fromEmail: "{$example}", // optional
    replyToName: "{$example}", // optional
    replyToEmail: "{$example}" // optional
);