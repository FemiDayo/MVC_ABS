using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ABS.MODEL.Models
{
    public class AbsDbContext : DbContext
    {
        public AbsDbContext() : base("AbsDbContext")
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Proposal> Proposals { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
