using SalesDemo.Domain.Core;

namespace SalesDemo.Domain.Model;

public class Seller(Guid storeId,
                    string sellerName): Entity
{

    public Guid StoreId { get; private set; } = storeId;
    public string SellerName { get; private set; } = sellerName;

    public virtual Store Store { get; init; } = null!;
    public virtual List<Sale>? Sale { get; init; } = [];
}