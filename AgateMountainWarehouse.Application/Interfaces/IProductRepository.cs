using AgateMountainWarehouse.Application.RequestFeatures;
using AgateMountainWarehouse.Domain.Entities;

namespace AgateMountainWarehouse.Application.Interfaces;

public interface IProductRepository
{
    Task<PagedList<Product>> GetProducts(PagingParameters pagingParameters);
}
