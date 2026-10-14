using System;

namespace Appwrite.Enums
{
    public class DomainRegistrationType : IEnum
    {
        public string Value { get; private set; }

        public DomainRegistrationType(string value)
        {
            Value = value;
        }

        public static DomainRegistrationType New => new DomainRegistrationType("new");
        public static DomainRegistrationType Transfer => new DomainRegistrationType("transfer");
        public static DomainRegistrationType Renewal => new DomainRegistrationType("renewal");
        public static DomainRegistrationType Trade => new DomainRegistrationType("trade");
    }
}
