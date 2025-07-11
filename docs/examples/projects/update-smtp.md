using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>"); // Your project ID

Projects projects = new Projects(client);

Project result = await projects.UpdateSmtp(
    projectId: "<PROJECT_ID>",
    enabled: false,
    senderName: "<SENDER_NAME>", // optional
    senderEmail: "email@example.com", // optional
    replyTo: "email@example.com", // optional
    host: "", // optional
    port: 0, // optional
    username: "<USERNAME>", // optional
    password: "<PASSWORD>", // optional
    secure: SMTPSecure.Tls // optional
);