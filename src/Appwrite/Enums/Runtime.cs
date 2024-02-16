using System;

namespace Appwrite.Enums
{
    public class Runtime : IEnum
    {
        public string Value { get; private set; }

        public Runtime(string value)
        {
            Value = value;
        }

        public static Runtime Node180 => new Runtime("node-18.0");
        public static Runtime Php80 => new Runtime("php-8.0");
        public static Runtime Ruby31 => new Runtime("ruby-3.1");
        public static Runtime Python39 => new Runtime("python-3.9");
    }
}
