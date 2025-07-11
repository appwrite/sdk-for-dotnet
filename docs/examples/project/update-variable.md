using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>"); // Your project ID

Project project = new Project(client);

Variable result = await project.UpdateVariable(
    variableId: "<VARIABLE_ID>",
    key: "<KEY>",
    value: "<VALUE>", // optional
    secret: false // optional
);