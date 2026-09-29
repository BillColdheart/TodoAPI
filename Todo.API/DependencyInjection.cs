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
            //Add DbContext
            services.AddDbContext<TodoAppDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            

            return services;
        }
    }
}
