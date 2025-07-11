using System;

namespace Appwrite.Enums
{
    public class Api : IEnum
    {
        public string Value { get; private set; }

        public Api(string value)
        {
            Value = value;
        }

        public static Api Rest => new Api("rest");
        public static Api Graphql => new Api("graphql");
        public static Api Realtime => new Api("realtime");
    }
}
