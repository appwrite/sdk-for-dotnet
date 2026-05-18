using System;

namespace Appwrite.Enums
{
    public class ProjectProtocolId : IEnum
    {
        public string Value { get; private set; }

        public ProjectProtocolId(string value)
        {
            Value = value;
        }

        public static ProjectProtocolId Rest => new ProjectProtocolId("rest");
        public static ProjectProtocolId Graphql => new ProjectProtocolId("graphql");
        public static ProjectProtocolId Websocket => new ProjectProtocolId("websocket");
    }
}
