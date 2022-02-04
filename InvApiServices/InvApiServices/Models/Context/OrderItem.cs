using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvApiServices.Models.Context
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string OrderId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Qty { get; set; }
        public string OrderUnit { get; set; }
        public string Discount { get; set; }
        public decimal Amount { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public string CreatedBy { get; set; }
    }
}
