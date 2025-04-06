using SalesDemo.Domain.Core;

namespace SalesDemo.Domain.Model;

public class Category(string nameCategory,
                      string descriptionCategory) : Entity
{
    public string NameCategory { get; private set; } = nameCategory;
    public string DescriptionCategory { get; private set; } = descriptionCategory;

    public virtual List<SubCategory> SubCategory { get; init; } = [];
}