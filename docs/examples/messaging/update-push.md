using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Messaging messaging = new Messaging(client);

Message result = await messaging.UpdatePush(
    messageId: "{$example}",
    topics: new List<string>(), // optional
    users: new List<string>(), // optional
    targets: new List<string>(), // optional
    title: "{$example}", // optional
    body: "{$example}", // optional
    data: [object], // optional
    action: "{$example}", // optional
    image: "{$example}", // optional
    icon: "{$example}", // optional
    sound: "{$example}", // optional
    color: "{$example}", // optional
    tag: "{$example}", // optional
    badge: 0, // optional
    draft: false, // optional
    scheduledAt: "" // optional
);