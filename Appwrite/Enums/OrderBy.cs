using System;

namespace Appwrite.Enums
{
    public class OrderBy : IEnum
    {
        public string Value { get; private set; }

        public OrderBy(string value)
        {
            Value = value;
        }

        public static OrderBy Asc => new OrderBy("asc");
        public static OrderBy Desc => new OrderBy("desc");
    }
}
