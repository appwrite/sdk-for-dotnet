```csharp
using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndpoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Project project = new Project(client);

Appwrite.Models.VideoProfile result = await project.CreateVideoProfile(
    profileId: "<PROFILE_ID>",
    name: "<NAME>",
    videoBitRate: 32000,
    audioBitRate: 32000,
    width: 16,
    height: 16,
    codec: VideoCodecId.H264 // optional
);

```
