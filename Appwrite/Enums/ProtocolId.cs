using System;

namespace Appwrite.Enums
{
    public class ProtocolId : IEnum
    {
        public string Value { get; private set; }

        public ProtocolId(string value)
        {
            Value = value;
        }

        public static ProtocolId Rest => new ProtocolId("rest");
        public static ProtocolId Graphql => new ProtocolId("graphql");
        public static ProtocolId Websocket => new ProtocolId("websocket");
    }
}
