using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>"); // Your project ID

Users users = new Users(client);

Token result = await users.CreateToken(
    userId: "<USER_ID>",
    length: 4, // optional
    expire: 60 // optional
);