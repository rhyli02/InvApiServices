using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvApiServices.Models.Context
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProductCode{ get; set; }
        [Required]
        public string ProductName { get; set; }
        public string Description { get; set; }
        [Required]
        public int SupplierId { get; set; }
        [Required]
        public string Unit { get; set; }// soldby
        public string Bundle { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        public decimal BundlePrice { get; set; }
        public Int32 Sold { get; set; }
        public Int32 InStock { get; set; }
        public Int32 SKU { get; set; }
        public Int32 Barcode { get; set; }
        [Required]
        public bool Status { get; set; }
        public string Photo { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime LastDateUpdated { get; set; }
        public string ClientAccount { get; set; }
    }
}
