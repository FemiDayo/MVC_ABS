using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Entity;
using System.Data.Entity;
using ABS.MODEL;
using ABS.MODEL.Models;

namespace ABS.DAL
{
    public class AbsInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<AbsDbContext>
    {

        protected override void Seed(AbsDbContext context)
        {
            var custtomers = new List<Customer>
            {
                new Customer {Title = "Mr", FirstName = "Femi", OtherNames = "Adesanya", Dob = DateTime.Parse("1990-06-16")},
                new Customer {Title = "Mr", FirstName = "Azeez", OtherNames = "Adedayo", Dob = DateTime.Parse("2000-06-16")}

            };
            custtomers.ForEach(c => context.Customers.Add(c));
            context.SaveChanges();





        }


    }
}
