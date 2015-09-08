using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.MODEL.Models
{
    public class BusinessSourceInfo
    {
        public int Id { get; set; }
        public string Branch { get; set; }
        public string Department { get; set; }

        public string ProposalStatus
        {
            get { return "Proposal"; }
        }


    }
}
