```csharp
using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndpoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetSession(""); // The user session to authenticate with

Videos videos = new Videos(client);

byte[] result = await videos.GetCaptionManifest(
    videoId: "<VIDEO_ID>",
    output: VideoOutput.Hls,
    captionId: "<CAPTION_ID>"
);

```
