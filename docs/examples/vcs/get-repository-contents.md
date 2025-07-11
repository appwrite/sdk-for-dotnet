using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>"); // Your project ID

Vcs vcs = new Vcs(client);

VcsContentList result = await vcs.GetRepositoryContents(
    installationId: "<INSTALLATION_ID>",
    providerRepositoryId: "<PROVIDER_REPOSITORY_ID>",
    providerRootDirectory: "<PROVIDER_ROOT_DIRECTORY>", // optional
    providerReference: "<PROVIDER_REFERENCE>" // optional
);