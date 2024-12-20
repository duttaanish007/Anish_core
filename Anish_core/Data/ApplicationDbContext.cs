using Anish_core.Models;
using Microsoft.EntityFrameworkCore;

namespace Anish_core.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Catagory>Catagories { get; set; }
        public DbSet<Employee>Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catagory>().HasData(
                new Catagory { Catagory_Id = 1, Name = "Anish", DisplayOrder = 1 },
                new Catagory { Catagory_Id = 2, Name = "Uttara", DisplayOrder = 2 },
                new Catagory { Catagory_Id = 3, Name = "Mau", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Employee>().HasData(
                new Employee { Emp_Id = 1, Name = "Uttara", email = "uttara@gmail.com", phone = "8017723391", city = "Kolkata" },
                new Employee { Emp_Id = 2, Name = "Anish", email = "anish@gmail.com", phone = "8012458796", city = "Kolkata" },
                new Employee { Emp_Id = 3, Name = "Kau", email = "Kau@gmail.com", phone = "8045875985", city = "Kolkata" }
                );
        }
    }
}
