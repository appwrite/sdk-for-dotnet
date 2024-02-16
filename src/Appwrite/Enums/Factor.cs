using System;

namespace Appwrite.Enums
{
    public class Factor : IEnum
    {
        public string Value { get; private set; }

        public Factor(string value)
        {
            Value = value;
        }

        public static Factor Totp => new Factor("totp");
        public static Factor Phone => new Factor("phone");
        public static Factor Email => new Factor("email");
    }
}
