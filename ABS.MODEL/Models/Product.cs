using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.MODEL.Models
{
    class Product
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }



        public string ProductFlag { get; set; }
        public DateTime DateAdded { get; set; }
        public string AddedBy { get; set; }
        public DateTime LastModified { get; set; }

    }
}
