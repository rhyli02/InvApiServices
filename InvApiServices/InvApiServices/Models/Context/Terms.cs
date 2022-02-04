using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvApiServices.Models.Context
{
    public class Terms
    {
        public int Id { get; set; }
        public string Term { get; set; }
        public bool Status { get; set; }
    }
}
