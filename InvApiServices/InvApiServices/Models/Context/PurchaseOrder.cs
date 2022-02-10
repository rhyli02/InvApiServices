using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvApiServices.Models.Context
{
    public class PurchaseOrder
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string OrderId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int SupplierId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public string Terms { get; set; }
        public string Shipment { get; set; }
        public string Currency { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Vat { get; set; }
        [Required]
        public decimal GrandTotal { get; set; }
        [Required]
        public string Status { get; set; }
        public string Notes { get; set; }
        public string ClientAccount { get; set; }
    }
}
