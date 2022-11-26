using AgateMountainWarehouse.Application.Interfaces;
using AgateMountainWarehouse.Application.RequestFeatures;
using AgateMountainWarehouse.Domain.Entities;
using AgateMountainWarehouse.Infrastructure.RepositoryExtensions;
using Microsoft.EntityFrameworkCore;

namespace AgateMountainWarehouse.Infrastructure.Persistence;

public class ProductRepository : IProductRepository
{
    private readonly WarehouseDbContext _context;

    public ProductRepository(WarehouseDbContext context)
    {
        _context = context;
    }

    public async Task CreateProduct(Product product)
    {
        _context.Add(product);

        var newInventory = new Inventory
        {
            ProductId = product.Id,
            Product = product,
            QuantityOnHand = 0
        };

        _context.Inventories.Add(newInventory);

        await _context.SaveChangesAsync();
    }

    public async Task DeleteProduct(Product product)
    {
        _context.Remove(product);
        await _context.SaveChangesAsync();
    }

    public async Task<Product> GetProductById(Guid productId)
    {
        return await _context.Products.FirstOrDefaultAsync(p => p.Id.Equals(productId));
    }

    public async Task<PagedList<Product>> GetProducts(PagingParameters pagingParameters)
    {
        var products = await _context.Products
            .Search(pagingParameters.SearchTerm)
            .Sort(pagingParameters.OrderBy)
            .ToListAsync();

        return PagedList<Product>.ToPagedList(
            products, 
            pagingParameters.PageNumber, 
            pagingParameters.PageSize);
    }

    public async Task UpdateProduct(Product product, Product dbProduct)
    {
        dbProduct.Name = product.Name;
        dbProduct.Description = product.Description;
        dbProduct.Price = product.Price;
        dbProduct.ImageUrl = product.ImageUrl;

        await _context.SaveChangesAsync();
    }
}
