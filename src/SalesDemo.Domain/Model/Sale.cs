using SalesDemo.Domain.Core;

namespace SalesDemo.Domain.Model;

public class Sale(Guid sellerId,
                  Guid storeId): Entity
{
    public Guid SellerId { get; private set; } = sellerId;
    public Guid StoreId { get; private set; } = storeId;
    public DateTime DateSale { get; private set; } = DateTime.UtcNow;

    public virtual List<SaleProducts>? SaleProduct { get; set; } = null;
}