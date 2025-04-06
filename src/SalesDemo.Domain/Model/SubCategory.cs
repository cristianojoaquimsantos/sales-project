using SalesDemo.Domain.Core;

namespace SalesDemo.Domain.Model;

public class SubCategory(Guid categoryId,
                         string nameSubCategory,
                         string descriptionSubCategory): Entity
{
    public Guid CategoryId { get; private set; } = categoryId;
    public string NameSubCategory { get; private set; } = nameSubCategory;
    public string DescriptionSubCategory { get; private set; } = descriptionSubCategory;
    
    public virtual Category Category { get; init; } = null!;
    public virtual List<Product> Product { get; init; } = [];
}