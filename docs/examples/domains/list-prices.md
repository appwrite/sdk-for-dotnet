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

Appwrite.Models.DomainPricesList result = await domains.ListPrices(
    domains: new List<string>(),
    periodYears: 0, // optional
    registrationType: DomainRegistrationType.New // optional
);

```
