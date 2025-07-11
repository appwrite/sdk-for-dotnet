using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>"); // Your project ID

Proxy proxy = new Proxy(client);

ProxyRuleList result = await proxy.ListRules(
    queries: new List<string>(), // optional
    search: "<SEARCH>" // optional
);