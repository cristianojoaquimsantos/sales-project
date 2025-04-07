namespace SalesDemo.Domain.Model;

public class SaleProducts (Guid saleId,
                           Guid sellerId,
                           Guid storeId,
                           Guid productId,
                           decimal salePrice,
                           decimal saleDiscount)
{
    public Guid SaleId { get; private set; } = saleId;
    public Guid SellerId { get; private set; } = sellerId;
    public Guid StoreId { get; private set; } = storeId;
    public Guid ProductId { get; private set; } = productId;
    public decimal SalePrice { get; private set; } = salePrice;
    public decimal SaleDiscount { get; private set; } = saleDiscount;
    
    public virtual Sale Sale { get; init; } = null!;
    public virtual Product Product { get; init; } = null!;

    public async Task<decimal> UpdateaTotalSale(Guid saleId,
        Guid sellerId,
        Guid storeId,
        Guid productId,
        decimal salePrice)
    {
        return await Task.FromResult(0);
    }
}