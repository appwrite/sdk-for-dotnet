using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>"); // Your project ID

Vcs vcs = new Vcs(client);

 result = await vcs.UpdateExternalDeployments(
    installationId: "<INSTALLATION_ID>",
    repositoryId: "<REPOSITORY_ID>",
    providerPullRequestId: "<PROVIDER_PULL_REQUEST_ID>"
);