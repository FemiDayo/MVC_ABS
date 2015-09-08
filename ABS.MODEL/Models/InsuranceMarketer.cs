using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.MODEL.Models
{
    public class InsuranceMarketer
    {
        public int Id { get; set; }
        public string MarketerId { get; set; }





        public string MarketerFlag { get; set; }
        public string AddedBy { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }

    }
}
