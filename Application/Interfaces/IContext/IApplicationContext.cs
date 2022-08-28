using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IContext;

public interface IApplicationContext
{
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductUnit> ProductUnits { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Remittance> Remittances { get; set; }
    public DbSet<Job> Jobs { get; set; }
    public Task<int> SaveChangesAsync();

}

