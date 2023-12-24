using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using productMicroservice.Data;
using productMicroservice.Data.Repository;
using productMicroservice.Services.Interface;
using productMicroservice.Services;
using productMicroservice.Data.Repository.Interface;

namespace productMicroservice.IoC.IoCApplication
{
    public static class IoCApplication
    {
        public static IServiceCollection ConfigureInjectionDependencyRepository(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }

        public static IServiceCollection ConfigureInjectionDependencyService(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();

            return services;
        }

        public static IServiceCollection ConfigureDBContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<DbContextClass>(options =>
                options.UseSqlServer(connectionString));


            return services;
        }
    }
}
