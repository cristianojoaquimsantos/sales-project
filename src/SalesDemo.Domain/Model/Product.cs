namespace SalesDemo.Domain.Model;

public class Product(Guid id,
                     Guid categoryId,
                     Guid subCategoryId,
                     string productName,
                     string description,
                     decimal unitPrice)
{
    public Guid CategoryId { get; private set; } = categoryId;
    public Guid SubCategoryId { get; private set; } = subCategoryId;
    public string ProductName { get; private set; } = productName;
    public string Description { get; private set; } = description;
    public decimal UnitPrice { get; set; } = unitPrice;
    
    public virtual SubCategory SubCategory { get; set; } = null!;
}