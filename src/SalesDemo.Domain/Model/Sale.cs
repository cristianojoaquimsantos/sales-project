using SalesDemo.Domain.Core;

namespace SalesDemo.Domain.Model;

public class Sale(Guid sellerId,
                  Guid storeId,
                  decimal totalSale): Entity
{
    public Guid SellerId { get; private set; } = sellerId;
    public Guid StoreId { get; private set; } = storeId;
    public DateTime DateSale { get; private set; } = DateTime.UtcNow;
    public decimal TotalSale { get; private set; } = totalSale;

    public virtual List<SaleProducts>? SaleProduct { get; init; } = null;
    
    public virtual Seller Seller { get; set; } = null!;
    
}