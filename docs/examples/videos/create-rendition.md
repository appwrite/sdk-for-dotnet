```csharp
using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndpoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Videos videos = new Videos(client);

Appwrite.Models.VideoRendition result = await videos.CreateRendition(
    videoId: "<VIDEO_ID>",
    profileId: "<PROFILE_ID>",
    output: VideoOutput.Hls
);

```
