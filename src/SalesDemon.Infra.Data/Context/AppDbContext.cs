using Microsoft.EntityFrameworkCore;
using SalesDemo.Domain.Model;
using SalesDemon.Infra.Data.Mapping;

namespace SalesDemon.Infra.Data.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Store> Store { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<SubCategory> SubCategory { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new StoreEntityMapping());
        base.OnModelCreating(modelBuilder);
    }
}