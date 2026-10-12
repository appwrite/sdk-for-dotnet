```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Waf waf = new Waf(client);

Appwrite.Models.WafRuleChallenge result = await waf.UpdateChallengeRule(
    ruleId: "<RULE_ID>",
    resourceType: "api", // optional
    resourceId: "<RESOURCE_ID>", // optional
    name: "<NAME>", // optional
    description: "<DESCRIPTION>", // optional
    challengeType: "compute", // optional
    priority: -100000, // optional
    enabled: false, // optional
    conditions: new List<string>(), // optional
    difficulty: 1, // optional
    ttl: 900 // optional
);

```
