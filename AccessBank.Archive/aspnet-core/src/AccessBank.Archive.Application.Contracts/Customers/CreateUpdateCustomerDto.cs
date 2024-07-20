using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AccessBank.Archive.Customers
{
    public class CreateUpdateCustomerDto
    {
        //This DTO class is used to get a Customer information from the user interface while creating(Inserting) or updating the book.

        [Required]
        [StringLength(128)]
        public string AccountName { get; set; }
        [Required]
        public string AccountNumber { get; set; }
        [Required]
        public string BranchName { get; set; }
        [Required]
        public int BranchCode { get; set; }
        [Required]
        public AccountType Type { get; set; }
        [Required]
        public AccountCategory Category { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime OnBoardDate { get; set; }
        [Required]
        public string AccountStatus { get; set; }
    }
}
