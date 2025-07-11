using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>"); // Your project ID

Migrations migrations = new Migrations(client);

Migration result = await migrations.CreateSupabaseMigration(
    resources: new List<string>(),
    endpoint: "https://example.com",
    apiKey: "<API_KEY>",
    databaseHost: "<DATABASE_HOST>",
    username: "<USERNAME>",
    password: "<PASSWORD>",
    port: 0 // optional
);