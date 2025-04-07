using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesDemo.Domain.Model;

namespace SalesDemon.Infra.Data.Mapping;

public class ProductEntityMapping: IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Product");
        
        builder.HasKey(c => c.Id)
            .HasName("PK_Product");
        
        builder.Property(c => c.CategoryId)
            .HasColumnName("CategoryId")
            .IsRequired();
        
        builder.Property(c => c.SubCategoryId)
            .HasColumnName("SubCategoryId")
            .IsRequired();
        
        builder.Property(c => c.Description)
            .HasColumnName("Description")
            .HasColumnType("varchar(200)")
            .IsRequired(false);
        
        builder.Property(c => c.ProductName)
            .HasColumnName("ProductName")
            .HasColumnType("varchar(100)")
            .IsRequired();
        
        builder.Property(c => c.UnitPrice)
            .HasColumnName("UnitPrice")
            .HasColumnType("decimal(18,2)")
            .IsRequired()
            .HasDefaultValue(0);
        
        builder.HasOne(s => s.SubCategory)
            .WithMany(p => p.Product)
            .HasForeignKey(s => new { s.SubCategoryId, s.CategoryId })
            .OnDelete(DeleteBehavior.Restrict);
    }
}