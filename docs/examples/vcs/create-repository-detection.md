using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>"); // Your project ID

Vcs vcs = new Vcs(client);

DetectionFramework result = await vcs.CreateRepositoryDetection(
    installationId: "<INSTALLATION_ID>",
    providerRepositoryId: "<PROVIDER_REPOSITORY_ID>",
    type: VCSDetectionType.Runtime,
    providerRootDirectory: "<PROVIDER_ROOT_DIRECTORY>" // optional
);