using Microsoft.EntityFrameworkCore;
using SalesDemo.Domain.Model;
using SalesDemon.Infra.Data.Mapping;

namespace SalesDemon.Infra.Data.Context;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Store> Store { get; set; } = null!;
    public DbSet<Product> Product { get; set; } = null!;
    public DbSet<Category> Category { get; set; } = null!;
    public DbSet<SubCategory> SubCategory { get; set; } = null!;
    public DbSet<Seller> Seller { get; set; } = null!;
    public DbSet<Sale> Sale { get; set; } = null!;
    public DbSet<SaleProducts> SaleProducts { get; set; } = null!;
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new StoreEntityMapping());
        modelBuilder.ApplyConfiguration(new SellerEntityMapping());
        modelBuilder.ApplyConfiguration(new CategoryEntityMapping());
        modelBuilder.ApplyConfiguration(new SubCategoryEntityMapping());
        modelBuilder.ApplyConfiguration(new ProductEntityMapping());
        modelBuilder.ApplyConfiguration(new SaleEntityMapping());
        modelBuilder.ApplyConfiguration(new SaleProductsEntityMapping());
        
        base.OnModelCreating(modelBuilder);
    }
}