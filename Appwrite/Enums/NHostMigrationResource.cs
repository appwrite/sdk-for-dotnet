using System;

namespace Appwrite.Enums
{
    public class NHostMigrationResource : IEnum
    {
        public string Value { get; private set; }

        public NHostMigrationResource(string value)
        {
            Value = value;
        }

        public static NHostMigrationResource User => new NHostMigrationResource("user");
        public static NHostMigrationResource Database => new NHostMigrationResource("database");
        public static NHostMigrationResource Table => new NHostMigrationResource("table");
        public static NHostMigrationResource Column => new NHostMigrationResource("column");
        public static NHostMigrationResource Index => new NHostMigrationResource("index");
        public static NHostMigrationResource Row => new NHostMigrationResource("row");
        public static NHostMigrationResource Document => new NHostMigrationResource("document");
        public static NHostMigrationResource Attribute => new NHostMigrationResource("attribute");
        public static NHostMigrationResource Collection => new NHostMigrationResource("collection");
        public static NHostMigrationResource Bucket => new NHostMigrationResource("bucket");
        public static NHostMigrationResource File => new NHostMigrationResource("file");
    }
}
