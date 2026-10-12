```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Waf waf = new Waf(client);

Appwrite.Models.WafRuleRateLimit result = await waf.CreateRateLimitRule(
    ruleId: "<RULE_ID>",
    resourceType: "api",
    name: "<NAME>",
    limit: 1,
    interval: 1,
    resourceId: "<RESOURCE_ID>", // optional
    description: "<DESCRIPTION>", // optional
    key: "ip", // optional
    strategy: "fixedWindow", // optional
    maxBucketSize: 1, // optional
    priority: -100000, // optional
    enabled: false, // optional
    conditions: new List<string>() // optional
);

```
