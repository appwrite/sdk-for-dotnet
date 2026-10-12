```csharp
using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Embeddings embeddings = new Embeddings(client);

Appwrite.Models.EmbeddingList result = await embeddings.CreateTextEmbeddings(
    texts: ["Appwrite helps developers build applications.", "Find documents with semantic search."],
    model: EmbeddingModel.NomicEmbedText // optional
);

```
