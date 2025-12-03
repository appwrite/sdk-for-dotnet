using System;

namespace Appwrite.Enums
{
    public class Theme : IEnum
    {
        public string Value { get; private set; }

        public Theme(string value)
        {
            Value = value;
        }

        public static Theme Light => new Theme("light");
        public static Theme Dark => new Theme("dark");
    }
}
