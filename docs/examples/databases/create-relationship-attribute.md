using Appwrite;
using Appwrite.Enums;
using Appwrite.Models;
using Appwrite.Services;

Client client = new Client()
    .SetEndPoint("https://cloud.appwrite.io/v1") // Your API Endpoint
    .SetProject("<YOUR_PROJECT_ID>") // Your project ID
    .SetKey("<YOUR_API_KEY>"); // Your secret API key

Databases databases = new Databases(client);

AttributeRelationship result = await databases.CreateRelationshipAttribute(
    databaseId: "{$example}",
    collectionId: "{$example}",
    relatedCollectionId: "{$example}",
    type: RelationshipType.OneToOne,
    twoWay: false, // optional
    key: "", // optional
    twoWayKey: "", // optional
    onDelete: RelationMutate.Cascade // optional
);