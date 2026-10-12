```csharp
using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Domains domains = new Domains(client);

Appwrite.Models.DomainPrice result = await domains.GetPrice(
    domain: "example.com",
    periodYears: 0, // optional
    registrationType: DomainRegistrationType.New // optional
);

```
