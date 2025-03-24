using SalesDemo.Domain.Core;

namespace SalesDemo.Domain.Model;

public class Store(Guid storeId,
                   string storeName,
                   string address,
                   string district,
                   string city,
                   string zipCode): Entity
{
    public string StoreName { get; private set; } = storeName;
    public string Address { get; private set; } = address;
    public string District { get; private set; } = district;
    public string City { get; private set; } = city;
    public string ZipCode { get; private set; } = zipCode;
}