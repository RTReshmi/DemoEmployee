using DemoEmployee.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoEmployee.db
{
    public class EmployeeDbContext  : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        
        public DbSet<Department> Departments { get; set; }
        public DbSet<Car> Cars{ get; set; }
        public DbSet<Engine>Engines  { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> customers { get; set; }

    }

}

