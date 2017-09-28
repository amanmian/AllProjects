using System.Data.Entity;

namespace Authentication.Models
{

    public class Programcontext : DbContext
    {
        public Programcontext() : base("name=InfoContext")
        {

        }
        public DbSet<Program> Programs
        {
            get; set;
        }
    }
}
