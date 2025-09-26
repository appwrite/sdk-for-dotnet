using System;

namespace Appwrite.Enums
{
    public class ExecutionTrigger : IEnum
    {
        public string Value { get; private set; }

        public ExecutionTrigger(string value)
        {
            Value = value;
        }

        public static ExecutionTrigger Http => new ExecutionTrigger("http");
        public static ExecutionTrigger Schedule => new ExecutionTrigger("schedule");
        public static ExecutionTrigger Event => new ExecutionTrigger("event");
    }
}
