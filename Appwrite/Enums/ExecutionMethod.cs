using System;

namespace Appwrite.Enums
{
    public class ExecutionMethod : IEnum
    {
        public string Value { get; private set; }

        public ExecutionMethod(string value)
        {
            Value = value;
        }

        public static ExecutionMethod GET => new ExecutionMethod("GET");
        public static ExecutionMethod POST => new ExecutionMethod("POST");
        public static ExecutionMethod PUT => new ExecutionMethod("PUT");
        public static ExecutionMethod PATCH => new ExecutionMethod("PATCH");
        public static ExecutionMethod DELETE => new ExecutionMethod("DELETE");
        public static ExecutionMethod OPTIONS => new ExecutionMethod("OPTIONS");
        public static ExecutionMethod HEAD => new ExecutionMethod("HEAD");
    }
}
