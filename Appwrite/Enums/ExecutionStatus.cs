using System;

namespace Appwrite.Enums
{
    public class ExecutionStatus : IEnum
    {
        public string Value { get; private set; }

        public ExecutionStatus(string value)
        {
            Value = value;
        }

        public static ExecutionStatus Waiting => new ExecutionStatus("waiting");
        public static ExecutionStatus Processing => new ExecutionStatus("processing");
        public static ExecutionStatus Completed => new ExecutionStatus("completed");
        public static ExecutionStatus Failed => new ExecutionStatus("failed");
        public static ExecutionStatus Scheduled => new ExecutionStatus("scheduled");
    }
}
