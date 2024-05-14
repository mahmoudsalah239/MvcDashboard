using Microsoft.EntityFrameworkCore;
using TranningCenter.Models;

namespace TranningCenter.DataAccessLayer
{
    public class Context : DbContext
    {
        public Context() { }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Traniee> Traniees { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<CrsResualt> CrsResualts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=TrainningCenter2024;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        }





    }
}
