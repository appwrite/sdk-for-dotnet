using System;

namespace Appwrite.Enums
{
    public class Roles : IEnum
    {
        public string Value { get; private set; }

        public Roles(string value)
        {
            Value = value;
        }

        public static Roles Admin => new Roles("admin");
        public static Roles Developer => new Roles("developer");
        public static Roles Owner => new Roles("owner");
    }
}
