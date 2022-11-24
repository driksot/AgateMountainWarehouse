using AgateMountainWarehouse.Domain.Entities;

namespace AgateMountainWarehouse.Application.Interfaces;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetProducts();
}
