using System;

namespace Appwrite.Enums
{
    public class FirebaseMigrationResource : IEnum
    {
        public string Value { get; private set; }

        public FirebaseMigrationResource(string value)
        {
            Value = value;
        }

        public static FirebaseMigrationResource User => new FirebaseMigrationResource("user");
        public static FirebaseMigrationResource Database => new FirebaseMigrationResource("database");
        public static FirebaseMigrationResource Table => new FirebaseMigrationResource("table");
        public static FirebaseMigrationResource Column => new FirebaseMigrationResource("column");
        public static FirebaseMigrationResource Row => new FirebaseMigrationResource("row");
        public static FirebaseMigrationResource Document => new FirebaseMigrationResource("document");
        public static FirebaseMigrationResource Attribute => new FirebaseMigrationResource("attribute");
        public static FirebaseMigrationResource Collection => new FirebaseMigrationResource("collection");
        public static FirebaseMigrationResource Bucket => new FirebaseMigrationResource("bucket");
        public static FirebaseMigrationResource File => new FirebaseMigrationResource("file");
    }
}
