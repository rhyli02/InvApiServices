using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvApiServices.Models.Context
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string SupplierName { get; set; }
        public string Description { get; set; }
        public string ContactPerson { get; set; }
        [Required]
        public string ContactDetails { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PaymentTerms { get; set; }
        public string PaymentMethod { get; set; }
        public string TIN { get; set; }
        [Required]
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
