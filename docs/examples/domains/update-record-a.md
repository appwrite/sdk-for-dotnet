```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Domains domains = new Domains(client);

Appwrite.Models.DnsRecord result = await domains.UpdateRecordA(
    domainId: "<DOMAIN_ID>",
    recordId: "<RECORD_ID>",
    name: "",
    value: "",
    ttl: 1,
    comment: "<COMMENT>" // optional
);

```
