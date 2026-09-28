using Microsoft.EntityFrameworkCore;
using Todo.Infrastructure.Persistance.Entities;

namespace Todo.API
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddInfrastructer(
            this IServiceCollection services, IConfiguration configuration)
        {

            var connectionString = configuration.GetConnectionString("DatabaseConnection");

            services.AddDbContext<TodoAppDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            //Add DbContext

            return services;
        }
    }
}
