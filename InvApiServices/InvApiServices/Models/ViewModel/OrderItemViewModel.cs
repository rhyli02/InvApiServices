using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvApiServices.Models.ViewModel
{
    public class OrderItemViewModel
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public string OrderUnit { get; set; }
        public string Discount { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string CreatedBy { get; set; }
    }
}
