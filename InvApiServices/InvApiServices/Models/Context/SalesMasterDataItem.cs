using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvApiServices.Models.Context
{
    public class SalesMasterDataItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TransactionId { get; set; }
        public int CustomerId { get; set; }
        [Required]
        public int ProductId { get; set; }
        public Int32 SKU { get; set; }
        [Required]
        public string Unit { get; set; }
        public string Bundle { get; set; }
        [Required]
        public int Qty { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public decimal Total { get; set; }
        public string Discount { get; set; }
    }

}
