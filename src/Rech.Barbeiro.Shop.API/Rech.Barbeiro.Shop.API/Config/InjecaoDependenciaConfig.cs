using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Rech.Barbeiro.Shop.Database.Base;
using System.Text;

namespace Rech.Barbeiro.Shop.API.Config
{
    public static class InjecaoDependenciaConfig
    {
        public static IServiceCollection AddInjecaoDepedencia(this IServiceCollection services)
        {

            return services;
        }

        public static IServiceCollection AddAutenticacao(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(config => {
                config.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                config.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(config => { 
                config.RequireHttpsMetadata = false;
                config.SaveToken = true;
                config.TokenValidationParameters = new TokenValidationParameters
                {
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.GetSection("JWT").GetValue<string>("Secret"))),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            return services;
        }

        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ContextoDatabase>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("Database"));
            });

            services.AddIdentity<IdentityUser, IdentityRole>(config =>
            {
                config.User.AllowedUserNameCharacters = "0123456789";
                config.Password.RequireNonAlphanumeric = true;
                config.Password.RequiredLength = 6;
                config.Password.RequireDigit = true;
            })
            .AddEntityFrameworkStores<ContextoDatabase>()
            .AddDefaultTokenProviders();

            return services;
        }
    }
}
