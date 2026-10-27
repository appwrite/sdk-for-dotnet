using System;

namespace Appwrite.Enums
{
    public class SupabaseMigrationResource : IEnum
    {
        public string Value { get; private set; }

        public SupabaseMigrationResource(string value)
        {
            Value = value;
        }

        public static SupabaseMigrationResource User => new SupabaseMigrationResource("user");
        public static SupabaseMigrationResource Database => new SupabaseMigrationResource("database");
        public static SupabaseMigrationResource Table => new SupabaseMigrationResource("table");
        public static SupabaseMigrationResource Column => new SupabaseMigrationResource("column");
        public static SupabaseMigrationResource Index => new SupabaseMigrationResource("index");
        public static SupabaseMigrationResource Row => new SupabaseMigrationResource("row");
        public static SupabaseMigrationResource Document => new SupabaseMigrationResource("document");
        public static SupabaseMigrationResource Attribute => new SupabaseMigrationResource("attribute");
        public static SupabaseMigrationResource Collection => new SupabaseMigrationResource("collection");
        public static SupabaseMigrationResource Bucket => new SupabaseMigrationResource("bucket");
        public static SupabaseMigrationResource File => new SupabaseMigrationResource("file");
    }
}
