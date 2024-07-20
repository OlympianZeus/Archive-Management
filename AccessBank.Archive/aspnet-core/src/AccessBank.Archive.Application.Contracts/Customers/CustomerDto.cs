using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace AccessBank.Archive.Customers
{
    public class CustomerDto: AuditedEntityDto<Guid>
    {
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string BranchName { get; set; }
        public int BranchCode { get; set; }
        public AccountType Type { get; set; }
        public AccountCategory Category { get; set; }
        public DateTime OnBoardDate { get; set; }
        public string AccountStatus { get; set; }
    }
}
