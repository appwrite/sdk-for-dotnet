```csharp
using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Project project = new Project(client);

Project result = await project.UpdateSMTP(
    host: "", // optional
    port: 0, // optional
    username: "<USERNAME>", // optional
    password: "<PASSWORD>", // optional
    senderEmail: "email@example.com", // optional
    senderName: "<SENDER_NAME>", // optional
    replyToEmail: "email@example.com", // optional
    replyToName: "<REPLY_TO_NAME>", // optional
    secure: Secure.Tls, // optional
    enabled: false // optional
);```
