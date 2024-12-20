using AnishCoreRazor.Models;
using Microsoft.EntityFrameworkCore;

namespace AnishCoreRazor.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options) 
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
