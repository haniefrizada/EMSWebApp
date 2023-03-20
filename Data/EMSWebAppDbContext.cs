using EMSWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EMSWebApp.Data
{
    public class EMSWebAppDbContext : DbContext
    {
        public EMSWebAppDbContext(DbContextOptions<EMSWebAppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
