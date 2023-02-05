
using Infrastructure.Context;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class ServiceInjection
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Context.AppContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("WarehouseContextConnection"),
                    b => b.MigrationsAssembly(typeof(Context.AppContext).Assembly.FullName)));


            services.AddScoped((Func<IServiceProvider, IAppContext>)(provider => provider.GetService<Context.AppContext>()));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            
        }
    }
}
