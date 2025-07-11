using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>"); // Your project ID

Proxy proxy = new Proxy(client);

ProxyRule result = await proxy.CreateRedirectRule(
    domain: "",
    url: "https://example.com",
    statusCode: .MovedPermanently301,
    resourceId: "<RESOURCE_ID>",
    resourceType: ProxyResourceType.Site
);