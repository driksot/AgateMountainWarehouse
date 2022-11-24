using AgateMountainWarehouse.Application.Interfaces;
using AgateMountainWarehouse.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgateMountainWarehouse.Infrastructure.Persistence;

public class ProductRepository : IProductRepository
{
    private readonly WarehouseDbContext _context;

    public ProductRepository(WarehouseDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Product>> GetProducts()
    {
        return await _context.Products.ToListAsync();
    }
}
