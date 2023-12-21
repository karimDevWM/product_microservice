using Microsoft.EntityFrameworkCore;
using productMicroservice.Data;

namespace productMicroservice.IoC.IoCTest
{
    public static class IoCTest
    {
        public static IServiceCollection ConfigureDBContextTest(this IServiceCollection services)
        {
            services.AddDbContext<DbContextClass>(options =>
                options.UseInMemoryDatabase(databaseName: "TestApplication")
            );

            return services;
        }
    }
}
