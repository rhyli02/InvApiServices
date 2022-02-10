using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvApiServices.Models.Context
{
    public class ApprovalTransaction
    {
        [Key]
        public int Id { get; set; }
        public string OrderId { get; set; }
        public string ApproverId { get; set; }
        public DateTime ApprovalDate { get; set; }
        public DateTime TransactionDate { get; set; }
        public int ApprovalLevel { get; set; }
        public string Status { get; set; }
        public string ApprovalType { get; set; }
        public string ClientAccount { get; set; }
    }
}
