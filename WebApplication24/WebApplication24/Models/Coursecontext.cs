
using System.Data.Entity;


namespace WebApplication24.Models
{
    public class Coursecontext:DbContext
    {
        public Coursecontext() : base("name = MyConnectionString") { 
            }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .Property(c => c.description)
                .HasMaxLength(255);


            /*one to many*/
            modelBuilder.Entity<Author>()
                .HasKey(i => i.AuthorId)
               .HasMany(a => a.Courses);


            modelBuilder.Entity<Author>()
             .HasMany(Z => Z.Student)
             .WithOptional(d => d.Author);
            
            /*many to many*/

            modelBuilder.Entity<Student>()
                .HasKey(a => a.Id)
                .HasMany(b => b.Course);

            modelBuilder.Entity<Course>()
               .HasRequired(c => c.Author);



            modelBuilder.Entity<Course>()
               
                .HasMany(c => c.Student)
                .WithMany(t => t.Course)
                .Map(m => m.ToTable("StudentCourse")
                .MapLeftKey("courseId")
                .MapRightKey("Id"));


            /*one to one*/

            modelBuilder.Entity<Profile>()
                .HasKey(i=>i.firstname)
                .HasRequired(z => z.student)
                .WithRequiredPrincipal(x => x.Profile);

            modelBuilder.Entity<Student>()
                .HasRequired(v => v.Profile)
                .WithRequiredDependent(o => o.student);
                
         
            

            base.OnModelCreating(modelBuilder);
        }
    }
}
