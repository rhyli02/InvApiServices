using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvApiServices.Models.Context
{
    public class ApprovalAssignment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ApprovalType { get; set; }
        [Required]
        public int ApprovalLevel { get; set; }
        [Required]
        public string ApproverId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Status { get; set; }
    }
}
