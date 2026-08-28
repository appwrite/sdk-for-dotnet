using System;

namespace Appwrite.Enums
{
    public class ExecutionResourceType : IEnum
    {
        public string Value { get; private set; }

        public ExecutionResourceType(string value)
        {
            Value = value;
        }

        public static ExecutionResourceType Functions => new ExecutionResourceType("functions");
        public static ExecutionResourceType Sites => new ExecutionResourceType("sites");
    }
}
