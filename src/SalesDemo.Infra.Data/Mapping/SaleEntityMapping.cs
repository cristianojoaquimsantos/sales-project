using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesDemo.Domain.Model;

namespace SalesDemon.Infra.Data.Mapping;

public class SaleEntityMapping: IEntityTypeConfiguration<Sale>
{
    public void Configure(EntityTypeBuilder<Sale> builder)
    {
        builder.ToTable("Sale");
        
        builder.HasKey(c => new {c.Id, c.StoreId, c.SellerId})
            .HasName("PK_Sale");
        
        builder.Property(c => c.DateSale)
            .HasColumnType("datetime")
            .IsRequired();
        
        builder.Property(c => c.TotalSale)
            .HasColumnType("decimal(18,2)")
            .IsRequired();
        
        builder.HasOne(s => s.Seller)
            .WithMany(p => p.Sale)
            .HasForeignKey(s => new {s.SellerId, s.StoreId})
            .OnDelete(DeleteBehavior.Restrict);
            
    }
}