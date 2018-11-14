using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using FurnitureApp.Models;

namespace FurnitureApp.DAL
{
    public class FurnitureAppContext: DbContext
    {

        public FurnitureAppContext(): base("Server=tcp:uncc.database.windows.net,1433;Initial Catalog=Moving_App;Persist Security Info=False;User ID={kparso12};Password={Sugarrush1};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<address> addresses { get; set; }
        public DbSet<itemsForSale> itemsForSales { get; set; }
        public DbSet<itemNeedRequests> itemNeedRequests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
