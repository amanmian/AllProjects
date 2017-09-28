using Assignment4.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Repository
{
    public class Employeecontext : DbContext
    {


        public Employeecontext() : base("name=MyConnectionString")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<State> StateList { get; set; }
        public DbSet<City> CityList { get; set; }
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
