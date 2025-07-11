using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>"); // Your project ID

Project project = new Project(client);

UsageProject result = await project.GetUsage(
    startDate: "",
    endDate: "",
    period: ProjectUsageRange.OneHour // optional
);