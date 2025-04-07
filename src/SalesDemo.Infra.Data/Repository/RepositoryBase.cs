using SalesDemo.Domain.Core;
using SalesDemo.Domain.Repository.Interface;

namespace SalesDemon.Infra.Data.Repository;

public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : Entity
{
}