using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvApiServices.Models.Context
{
    public class GoodReceipt
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string OrderId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int SupplierId { get; set; }
        public string OrderUnit { get; set; }
        public int OrderQty { get; set; }
        public int OrderConvertion { get; set; }
        public int ActualReceived { get; set; }
        public DateTime DateReceived { get; set; }
        public string Notes { get; set; }
        public string EmployeeId { get; set; }
        [Required]
        public string Status { get; set; }
        public decimal Amount { get; set; }
    }
}
