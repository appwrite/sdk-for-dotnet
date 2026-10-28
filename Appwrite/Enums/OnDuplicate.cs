using System;

namespace Appwrite.Enums
{
    public class OnDuplicate : IEnum
    {
        public string Value { get; private set; }

        public OnDuplicate(string value)
        {
            Value = value;
        }

        public static OnDuplicate Fail => new OnDuplicate("fail");
        public static OnDuplicate Skip => new OnDuplicate("skip");
        public static OnDuplicate Overwrite => new OnDuplicate("overwrite");
    }
}
