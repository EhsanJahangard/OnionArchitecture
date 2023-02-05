using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ServiceInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            
            //services.AddScoped<Interfaces.IListProductById, Features.ProductFeatures.Queries.ListProductById>();
            //services.AddScoped<IApplicationContext>(provider => provider.GetService<ApplicationContext>());
            //services.AddScoped<Infrastructure.Context.IApplicationContext>(provider => provider.GetService<Infrastructure.Context.ApplicationContext>());
            //services.AddDbContext<IApplicationContext>(Assembly.GetExecutingAssembly());
        }
    }
}
