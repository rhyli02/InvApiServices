using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvApiServices.Models.Context
{
    public class Shipments
    {
        public int Id { get; set; }
        public string Shipment { get; set; }
        public bool Status { get; set; }
        public string ClientAccount { get; set; }
    }
}
