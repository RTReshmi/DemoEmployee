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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            var teacher= modelBuilder.Entity<Teacher>();
            var department= modelBuilder.Entity<Department>();

            teacher.HasKey(x => x.Id);
            

            department.HasKey(x => x.Id);
            department.HasOne(t => t.Teacher)
                       .WithOne(dep => dep.department)
                       .HasForeignKey<Order>(fk => fk.UserId)
                       .OnDelete(DeleteBehavior.Cascade);

            var order= modelBuilder.Entity<Order>();
            order.HasKey(x => x.Id);
            order.HasOne(user=>user.User)
                  .WithMany(u => u.Orders)
                  .HasForeignKey(fk => fk.UserId);

        }
    }


}

