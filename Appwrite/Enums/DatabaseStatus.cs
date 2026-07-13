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
        public static DatabaseStatus Failed => new DatabaseStatus("failed");
    }
}
