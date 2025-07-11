using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>"); // Your project ID

Sites sites = new Sites(client);

Site result = await sites.UpdateSiteDeployment(
    siteId: "<SITE_ID>",
    deploymentId: "<DEPLOYMENT_ID>"
);