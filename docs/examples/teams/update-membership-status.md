using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetSession(""); // The user session to authenticate with

Teams teams = new Teams(client);

Membership result = await teams.UpdateMembershipStatus(
    teamId: "{$example}",
    membershipId: "{$example}",
    userId: "{$example}",
    secret: "{$example}"
);