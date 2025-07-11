using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>"); // Your project ID

Migrations migrations = new Migrations(client);

Migration result = await migrations.CreateNHostMigration(
    resources: new List<string>(),
    subdomain: "<SUBDOMAIN>",
    region: "<REGION>",
    adminSecret: "<ADMIN_SECRET>",
    database: "<DATABASE>",
    username: "<USERNAME>",
    password: "<PASSWORD>",
    port: 0 // optional
);