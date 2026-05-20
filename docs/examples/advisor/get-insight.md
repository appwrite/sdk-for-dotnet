```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Advisor advisor = new Advisor(client);

Insight result = await advisor.GetInsight(
    reportId: "<REPORT_ID>",
    insightId: "<INSIGHT_ID>"
);```
