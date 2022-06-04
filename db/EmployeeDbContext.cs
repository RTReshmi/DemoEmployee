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
        public DbSet<Order> Order { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Photo> Photo { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Book_Author> Book_Author { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var car = modelBuilder.Entity<Car>();
            car.HasKey(x=>x.Id); //pk
            car.ToTable("speehiveCar");
            car.Property(x => x.Name)
                .HasMaxLength(20)
                .IsRequired();
            car.Property(x => x.Colour)
                .IsRequired();

            car.HasOne(x=>x.engine)
                .WithOne(x=>x.Car)
                .HasForeignKey<Car>(x=>x.EngineId);//fk



            //one to one
            var teacher=modelBuilder.Entity<Teacher>(); 
            teacher.HasKey(x=>x.Id);
            teacher.HasOne(x=>x.department)
                .WithOne(x=>x.teacher)
                .HasForeignKey<Teacher>(x=>x.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);


            //one to many
            var order=modelBuilder.Entity<Order>();
            order.HasKey(x=>x.Id);
            order.HasOne(x => x.Customer)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.Cascade); 
            

            var photo=modelBuilder.Entity<Photo>(); 
            photo.HasKey(x=>x.Id);
            photo.HasOne(x => x.Customer)
                .WithMany(x => x.Photos)
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);






            
            



            base.OnModelCreating(modelBuilder);
        }
    }

}

