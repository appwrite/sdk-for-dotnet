```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndpoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetSession(""); // The user session to authenticate with

Videos videos = new Videos(client);

Appwrite.Models.Video result = await videos.Create(
    videoId: "<VIDEO_ID>",
    bucketId: "<BUCKET_ID>",
    fileId: "<FILE_ID>",
    name: "<NAME>", // optional
    permissions: new List<string> { Permission.Read(Role.Any()) } // optional
);

```
