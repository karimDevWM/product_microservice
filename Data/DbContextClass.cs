using Microsoft.EntityFrameworkCore;
using productMicroservice.Model;

namespace productMicroservice.Data
{
    public class DbContextClass : DbContext
    {
        //protected readonly IConfiguration Configuration;
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        {
        }
        
        public DbSet<Product> Products { get; set; }
    }
}
