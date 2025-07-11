using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>"); // Your project ID

Vcs vcs = new Vcs(client);

ProviderRepositoryFrameworkList result = await vcs.ListRepositories(
    installationId: "<INSTALLATION_ID>",
    type: VCSDetectionType.Runtime,
    search: "<SEARCH>" // optional
);