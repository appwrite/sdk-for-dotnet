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

Appwrite.Models.Project result = await project.UpdateLDAP(
    enabled: false, // optional
    hosts: ["ldap.example.com"], // optional
    port: 636, // optional
    encryption: ProjectLDAPEncryption.None, // optional
    verification: false, // optional
    certificate: "<CERTIFICATE>", // optional
    timeout: 10, // optional
    baseDn: "ou=people,dc=example,dc=com", // optional
    bindDn: "cn=appwrite,ou=services,dc=example,dc=com", // optional
    bindPassword: "password", // optional
    userFilter: "(uid={username})", // optional
    requiredGroupDn: "cn=staff,ou=groups,dc=example,dc=com", // optional
    idAttribute: "entryUUID", // optional
    emailAttribute: "mail", // optional
    nameAttribute: "cn", // optional
    phoneAttribute: "mobile" // optional
);

```
