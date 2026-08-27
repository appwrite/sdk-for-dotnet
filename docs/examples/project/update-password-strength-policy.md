```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Project project = new Project(client);

PolicyPasswordStrength result = await project.UpdatePasswordStrengthPolicy(
    min: 8, // optional
    uppercase: false, // optional
    lowercase: false, // optional
    number: false, // optional
    symbols: false // optional
);

```
