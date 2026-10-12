using System;

namespace Appwrite.Enums
{
    public class DomainTransferStatusEnum : IEnum
    {
        public string Value { get; private set; }

        public DomainTransferStatusEnum(string value)
        {
            Value = value;
        }

        public static DomainTransferStatusEnum Transferrable => new DomainTransferStatusEnum("transferrable");
        public static DomainTransferStatusEnum NotTransferrable => new DomainTransferStatusEnum("not_transferrable");
        public static DomainTransferStatusEnum PendingOwner => new DomainTransferStatusEnum("pending_owner");
        public static DomainTransferStatusEnum PendingAdmin => new DomainTransferStatusEnum("pending_admin");
        public static DomainTransferStatusEnum PendingRegistry => new DomainTransferStatusEnum("pending_registry");
        public static DomainTransferStatusEnum Completed => new DomainTransferStatusEnum("completed");
        public static DomainTransferStatusEnum Cancelled => new DomainTransferStatusEnum("cancelled");
        public static DomainTransferStatusEnum ServiceUnavailable => new DomainTransferStatusEnum("service_unavailable");
    }
}
