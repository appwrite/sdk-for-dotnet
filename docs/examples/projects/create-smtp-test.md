using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>"); // Your project ID

Projects projects = new Projects(client);

 result = await projects.CreateSmtpTest(
    projectId: "<PROJECT_ID>",
    emails: new List<string>(),
    senderName: "<SENDER_NAME>",
    senderEmail: "email@example.com",
    host: "",
    replyTo: "email@example.com", // optional
    port: 0, // optional
    username: "<USERNAME>", // optional
    password: "<PASSWORD>", // optional
    secure: SMTPSecure.Tls // optional
);