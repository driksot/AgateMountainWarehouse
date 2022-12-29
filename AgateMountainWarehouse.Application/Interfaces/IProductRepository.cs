using AgateMountainWarehouse.Application.RequestFeatures;
using AgateMountainWarehouse.Domain.Entities;

namespace AgateMountainWarehouse.Application.Interfaces;

public interface IProductRepository
{
    Task<PagedList<Product>> GetProducts(PagingParameters pagingParameters);
    Task<Product> GetProductById(Guid productId);
    Task CreateProduct(Product product);
    Task UpdateProduct(Product product, Product dbProduct);
    Task ArchiveProduct(Guid productId);
}
