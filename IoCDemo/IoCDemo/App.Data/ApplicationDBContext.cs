using App.Data.EntityModels;
using System.Data.Entity;
namespace App.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<LineItem> LineItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ContactDetail> ContactDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public ApplicationDBContext() : base("name=DIDemoContext")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);       
        }
        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}
