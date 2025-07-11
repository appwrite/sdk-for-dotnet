using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>"); // Your project ID

Sites sites = new Sites(client);

SiteList result = await sites.List(
    queries: new List<string>(), // optional
    search: "<SEARCH>" // optional
);