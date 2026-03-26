using System;

namespace Appwrite.Enums
{
    public class BackupServices : IEnum
    {
        public string Value { get; private set; }

        public BackupServices(string value)
        {
            Value = value;
        }

        public static BackupServices Databases => new BackupServices("databases");
        public static BackupServices Tablesdb => new BackupServices("tablesdb");
        public static BackupServices Documentsdb => new BackupServices("documentsdb");
        public static BackupServices Vectorsdb => new BackupServices("vectorsdb");
        public static BackupServices Functions => new BackupServices("functions");
        public static BackupServices Storage => new BackupServices("storage");
    }
}
