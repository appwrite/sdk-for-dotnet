using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>"); // Your project ID

Account account = new Account(client);

User result = await account.Create(
    userId: "{$example}",
    email: "{$example}",
    password: "",
    name: "{$example}" // optional
);