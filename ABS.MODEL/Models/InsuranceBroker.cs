using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.MODEL.Models
{
    public class InsuranceBroker
    {
        public int Id { get; set; }
        public string BrokerId { get; set; }



        public string BrokerFlag { get; set; }
        public string AddedBy { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
