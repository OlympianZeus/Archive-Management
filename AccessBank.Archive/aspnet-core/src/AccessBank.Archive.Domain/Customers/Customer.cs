using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace AccessBank.Archive.Customers
{
    public class Customer: AuditedAggregateRoot<Guid>
    {
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string BranchName { get; set; }
        public int BranchCode { get; set; }
        public AccountType Type { get; set; }
        public AccountCategory Category { get; set; }
        public DateOnly OnBoardDate { get; set; }
        public string AccountStatus { get; set; }
    }
}
