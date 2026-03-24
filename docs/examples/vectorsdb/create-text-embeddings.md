```csharp
using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

VectorsDB vectorsDB = new VectorsDB(client);

EmbeddingList result = await vectorsDB.CreateTextEmbeddings(
    texts: new List<string>(),
    model: Model.Embeddinggemma // optional
);```
