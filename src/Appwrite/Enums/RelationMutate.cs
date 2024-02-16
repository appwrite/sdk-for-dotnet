using System;

namespace Appwrite.Enums
{
    public class RelationMutate : IEnum
    {
        public string Value { get; private set; }

        public RelationMutate(string value)
        {
            Value = value;
        }

        public static RelationMutate Cascade => new RelationMutate("cascade");
        public static RelationMutate Restrict => new RelationMutate("restrict");
        public static RelationMutate SetNull => new RelationMutate("setNull");
    }
}
