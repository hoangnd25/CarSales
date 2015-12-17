using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using CarSales.Models;

namespace CarSales.DAL
{
    public class CarContext : DbContext
    {
        public CarContext() : base("CarContext")
        {
            Database.SetInitializer<CarContext>(new CarInitializer());
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Enquiry> Enquiries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}