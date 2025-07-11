using Appwrite;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://<REGION>.cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>"); // Your project ID

Projects projects = new Projects(client);

Project result = await projects.Update(
    projectId: "<PROJECT_ID>",
    name: "<NAME>",
    description: "<DESCRIPTION>", // optional
    logo: "<LOGO>", // optional
    url: "https://example.com", // optional
    legalName: "<LEGAL_NAME>", // optional
    legalCountry: "<LEGAL_COUNTRY>", // optional
    legalState: "<LEGAL_STATE>", // optional
    legalCity: "<LEGAL_CITY>", // optional
    legalAddress: "<LEGAL_ADDRESS>", // optional
    legalTaxId: "<LEGAL_TAX_ID>" // optional
);