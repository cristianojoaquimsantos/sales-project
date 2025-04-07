using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesDemo.Domain.Model;

namespace SalesDemon.Infra.Data.Mapping;

public class SaleProductsEntityMapping: IEntityTypeConfiguration<SaleProducts>
{
    public void Configure(EntityTypeBuilder<SaleProducts> builder)
    {
        builder.ToTable("SaleProducts");
        
        builder.HasKey(x => new { x.SaleId, x.ProductId })
            .HasName("PK_SaleProducts");
    }
}