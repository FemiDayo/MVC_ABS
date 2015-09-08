using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.MODEL.Models
{
    class Communication
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }

        public DateTime DateAdded { get; set; }
        public  string  AddedBy { get; set; }
        public DateTime LastModified { get; set; }

    }
}
