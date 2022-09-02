
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class ServiceInjection
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("WarehouseContextConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));


            services.AddScoped<IApplicationContext>(provider => provider.GetService<ApplicationContext>());
            
        }
    }
}
