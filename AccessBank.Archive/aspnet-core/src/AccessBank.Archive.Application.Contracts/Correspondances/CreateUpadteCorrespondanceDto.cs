using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessBank.Archive.Correspondances
{
    public class CreateUpadteCorrespondanceDto
    {
        [Required]
        [StringLength(128)]
        public string Sender { get; set; } = string.Empty;
        [Required]
        public Receptionist Cco { get; set; } = Receptionist.Undefined;
        [Required]
        public Receiver destinator { get; set; } = Receiver.Undefined;
        [Required]
        public string BranchName { get; set; } = string.Empty ;
        [Required]
        public string Reference { get; set; } = string.Empty;
        [Required]
        public Approver CorrespondanceApprover { get; set; } = Approver.Undefined;  
        [Required]
        public Status CorrespondanceStatus { get; set; } = Status.Undefined;
    }
}
