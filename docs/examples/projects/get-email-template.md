using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>"); // Your project ID

Projects projects = new Projects(client);

EmailTemplate result = await projects.GetEmailTemplate(
    projectId: "<PROJECT_ID>",
    type: EmailTemplateType.Verification,
    locale: EmailTemplateLocale.Af
);