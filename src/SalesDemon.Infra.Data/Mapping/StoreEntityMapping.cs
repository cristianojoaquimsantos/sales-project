using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesDemo.Domain.Model;

namespace SalesDemon.Infra.Data.Mapping;

public class StoreEntityMapping: IEntityTypeConfiguration<Store>
{
    public void Configure(EntityTypeBuilder<Store> builder)
    {
        builder.ToTable("Store");
        
        builder.HasKey(x => x.Id)
            .HasName("PK_Store");
        
        builder.Property(x => x.StoreName)
            .HasColumnName("StoreName")
            .HasColumnType("varchar(100)")
            .IsRequired();
        
        builder.Property(x => x.Address)
            .HasColumnName("Address")
            .HasColumnType("varchar(100)")
            .IsRequired();
        
        builder.Property(x => x.District)   
            .HasColumnName("District")
            .HasColumnType("varchar(50)")
            .IsRequired();
        
        builder.Property(x => x.City)
            .HasColumnName("City")
            .HasColumnType("varchar(50)")
            .IsRequired();
        
        builder.Property(x => x.ZipCode)
            .HasColumnName("ZipCode")
            .HasColumnType("varchar(50)")
            .IsRequired();
    }
}