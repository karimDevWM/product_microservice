using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using productMicroservice.Data;

namespace productMicroservice.IoC.IoCApplication
{
    public static class IoCApplication
    {
        public static IServiceCollection ConfigureDBContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<DbContextClass>(options =>
                options.UseSqlServer(connectionString));


            return services;
        }
    }
}
