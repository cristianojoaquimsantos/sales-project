using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesDemo.Domain.Model;

namespace SalesDemon.Infra.Data.Mapping;

public class SellerEntityMapping: IEntityTypeConfiguration<Seller>
{
    public void Configure(EntityTypeBuilder<Seller> builder)
    {
        builder.ToTable("Seller");
        
        builder.HasKey(c => new {c.Id, c.StoreId})
            .HasName("PK_Seller");
        
        builder.Property(c => c.SellerName)
            .HasColumnName("SellerName")
            .HasColumnType("varchar(100)")
            .IsRequired();
        
        builder.HasOne(t => t.Store)
            .WithMany(s => s.Sellers)
            .HasForeignKey(t => t.StoreId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}