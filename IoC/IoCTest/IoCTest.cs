using Microsoft.EntityFrameworkCore;
using productMicroservice.Data;
using productMicroservice.Data.Repository;
using productMicroservice.Data.Repository.Interface;
using productMicroservice.Services;
using productMicroservice.Services.Interface;

namespace productMicroservice.IoC.IoCTest
{
    public static class IoCTest
    {
        public static IServiceCollection ConfigureInjectionDependencyRepositoryTest(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }

        public static IServiceCollection ConfigureInjectionDependencyServiceTest(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();

            return services;
        }

        public static IServiceCollection ConfigureDBContextTest(this IServiceCollection services)
        {
            services.AddDbContext<DbContextClass>(options =>
                options.UseInMemoryDatabase(databaseName: "TestApplication")
            );

            return services;
        }
    }
}
