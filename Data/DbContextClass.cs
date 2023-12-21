using Microsoft.EntityFrameworkCore;
using productMicroservice.Model;

namespace productMicroservice.Data
{
    public class DbContextClass : DbContext
    {
        //protected readonly IConfiguration Configuration;
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        {
            //Configuration = configuration;
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    //options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        //}
        public DbSet<Product> Products { get; set; }
    }
}
