using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesDemo.Domain.Model;

namespace SalesDemon.Infra.Data.Mapping;

public class SubCategoryEntityMapping: IEntityTypeConfiguration<SubCategory>
{
    public void Configure(EntityTypeBuilder<SubCategory> builder)
    {
        builder.ToTable("SubCategory");
        
        builder.HasKey(c => new { c.Id, c.CategoryId})
            .HasName("PK_SubCategory");
        
        builder.Property(c => c.NameSubCategory)
            .HasColumnName("NameSubCategory")
            .HasColumnType("varchar(100)")
            .IsRequired();
        
        builder.Property(c => c.DescriptionSubCategory)
            .HasColumnName("DescriptionSubCategory")
            .HasColumnType("varchar(200)")
            .IsRequired(false);
        
        builder.HasOne(c => c.Category)
            .WithMany(s => s.SubCategory)
            .HasForeignKey(c => c.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}