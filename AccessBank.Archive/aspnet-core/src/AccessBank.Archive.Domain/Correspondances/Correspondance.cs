using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace AccessBank.Archive.Correspondances
{
    public class Correspondance: AuditedAggregateRoot<Guid>
    {
        public string Sender {  get; set; }
        public Receptionist Cco { get; set; }
        public Receiver destinator { get; set; }
        public string BranchName { get; set; }
        public string Reference { get; set; }

        public Approver CorrespondanceApprover { get; set; }
        public Status CorrespondanceStatus { get; set; }
    }
}
