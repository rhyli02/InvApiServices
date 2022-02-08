using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvApiServices.Models.ViewModel
{
    public class POViewModel
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public DateTime Date { get; set; }
        public string Terms { get; set; }
        public string Shipment { get; set; }
        public string Currency { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Vat { get; set; }
        public decimal GrandTotal { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public IEnumerable<OrderItemViewModel> OrderItems { get; set; }
    }
}
