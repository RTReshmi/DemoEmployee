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
    }

}

