using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesDemo.Domain.Model;

namespace SalesDemon.Infra.Data.Mapping;

public class CategoryEntityMapping: IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Category");
        
        builder.HasKey(c => c.Id)
            .HasName("PK_Category");
        
        builder.Property(c => c.NameCategory)
            .HasColumnName("NameCategory")
            .HasColumnType("varchar(100)")
            .IsRequired();
    }
}