namespace SalesDemo.Domain.Model;

public class SaleProducts (Guid saleId,
                           Guid productId,
                           decimal salePrice,
                           decimal saleDiscount)
{
    public Guid SaleId { get; private set; } = saleId;
    public Guid ProductId { get; private set; } = productId;
    public decimal SalePrice { get; private set; } = salePrice;
    public decimal SaleDiscount { get; private set; } = saleDiscount;
    
    public virtual Sale Sale { get; set; } = null!;
    public virtual Product Product { get; set; } = null!;
}