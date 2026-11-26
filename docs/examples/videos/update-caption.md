```csharp
using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndpoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetSession(""); // The user session to authenticate with

Videos videos = new Videos(client);

Appwrite.Models.VideoCaption result = await videos.UpdateCaption(
    videoId: "<VIDEO_ID>",
    captionId: "<CAPTION_ID>",
    bucketId: "<BUCKET_ID>", // optional
    fileId: "<FILE_ID>", // optional
    name: "<NAME>", // optional
    language: "aar", // optional
    @default: false // optional
);

```
