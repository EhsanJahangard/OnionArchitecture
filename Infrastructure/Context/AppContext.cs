
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Interfaces;
namespace Infrastructure.Context;

public class AppContext : DbContext, IAppContext
{

    public AppContext(DbContextOptions<AppContext> options) : base(options)
    {
    }
    public async Task<int> SaveChangesAsync()
    {
        return await base.SaveChangesAsync();
    }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductUnit> ProductUnits { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Remittance> Remittances { get; set; }
    public DbSet<Job> Jobs { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}

