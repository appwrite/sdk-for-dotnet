using System;

namespace Appwrite.Enums
{
    public class DatabaseStatus : IEnum
    {
        public string Value { get; private set; }

        public DatabaseStatus(string value)
        {
            Value = value;
        }

        public static DatabaseStatus Provisioning => new DatabaseStatus("provisioning");
        public static DatabaseStatus Ready => new DatabaseStatus("ready");
        public static DatabaseStatus Inactive => new DatabaseStatus("inactive");
        public static DatabaseStatus Paused => new DatabaseStatus("paused");
        public static DatabaseStatus Failed => new DatabaseStatus("failed");
        public static DatabaseStatus Deleting => new DatabaseStatus("deleting");
        public static DatabaseStatus Deleted => new DatabaseStatus("deleted");
        public static DatabaseStatus Restoring => new DatabaseStatus("restoring");
        public static DatabaseStatus Scaling => new DatabaseStatus("scaling");
        public static DatabaseStatus Upgrading => new DatabaseStatus("upgrading");
        public static DatabaseStatus Migrating => new DatabaseStatus("migrating");
        public static DatabaseStatus Pausing => new DatabaseStatus("pausing");
        public static DatabaseStatus Resuming => new DatabaseStatus("resuming");
        public static DatabaseStatus FailingOver => new DatabaseStatus("failing-over");
    }
}
