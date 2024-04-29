using Microsoft.EntityFrameworkCore;
using Rech.Barbeiro.Shop.Database.Base;

namespace Rech.Barbeiro.Shop.API.Config
{
    public static class InjecaoDependenciaConfig
    {
        public static IServiceCollection AddInjecaoDepedencia(this IServiceCollection services)
        {

            return services;
        }

        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ContextoDatabase>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("Database"));
            });

            return services;
        }
    }
}
