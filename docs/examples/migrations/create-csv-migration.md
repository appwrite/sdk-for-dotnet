using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>"); // Your project ID

Migrations migrations = new Migrations(client);

Migration result = await migrations.CreateCsvMigration(
    bucketId: "<BUCKET_ID>",
    fileId: "<FILE_ID>",
    resourceId: "[ID1:ID2]"
);