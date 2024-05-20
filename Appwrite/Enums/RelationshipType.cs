using System;

namespace Appwrite.Enums
{
    public class RelationshipType : IEnum
    {
        public string Value { get; private set; }

        public RelationshipType(string value)
        {
            Value = value;
        }

        public static RelationshipType OneToOne => new RelationshipType("oneToOne");
        public static RelationshipType ManyToOne => new RelationshipType("manyToOne");
        public static RelationshipType ManyToMany => new RelationshipType("manyToMany");
        public static RelationshipType OneToMany => new RelationshipType("oneToMany");
    }
}
