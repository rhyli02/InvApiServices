using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvApiServices.Models.Context
{
    public class SalesMasterData
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string TransactionId { get; set; }

        public int CustomerId { get; set; }
        
        public decimal Tax { get; set; }
        public decimal Vat { get; set; }
        public decimal DiscountAmt { get; set; }
        public decimal TotalAmt { get; set; }
        [Required]
        public string PaymentMethod { get; set; }
        [Required]
        public string Status { get; set; }
        public string ApprovalStatus { get; set; }
        public int AgentId { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }

        public string Notes { get; set; }
    }
}
